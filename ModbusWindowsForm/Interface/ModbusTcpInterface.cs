using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Osre.Modbus.Interface
{
   /// <summary>
   /// ModbusTcpInterface is a Modbus TCP implemention of the <see cref="IModbusInterface"/> interface 
   /// to be used with <see cref="ModbusMaster"/> or <see cref="ModbusDevice"/>.
   /// </summary>
   public class ModbusTcpInterface : IModbusInterface, IDisposable
   {
      private Socket _Socket;
      private bool _OwnsSocket;
      private ushort _NextTransactionId;

      /// <summary>
      /// Creates a new Modbus TCP interface using an existing and fully initialized <see cref="System.Net.Sockets.Socket"/>.
      /// This interface can be used with <see cref="ModbusMaster"/> or <see cref="ModbusDevice"/>.
      /// </summary>
      /// <param name="socket">Fully initialized <see cref="Socket"/>.</param>
      /// <param name="maxDataLength">Maximum allowed length of function code specific data.</param>
      /// <param name="ownsSocket">true if the interface owns the <see cref="Socket"/> and should close it when disposed; else false.</param>
      public ModbusTcpInterface(Socket socket, short maxDataLength = 252, bool ownsSocket = false)
      {
         _Socket = socket;
         _OwnsSocket = ownsSocket;
         MaxDataLength = maxDataLength;
         MaxTelegramLength = (short)(maxDataLength + 8);
      }

      /// <summary>
      /// Creates a new Modbus TCP interface. This will connect to a TCP server listening to the given port.
      /// This interface can be used with <see cref="ModbusMaster"/>.
      /// </summary>
      /// <param name="host">Host name or ip address of the Modbus TCP device.</param>
      /// <param name="port">Port to which the devuice is listening. The Modbus TCP default port is 502.</param>
      /// <param name="maxDataLength">Maximum allowed length of function code specific data.</param>
      public ModbusTcpInterface(string host, int port = 502, short maxDataLength = 252)
      {
         IPAddress ip;
         try
         {
            ip = IPAddress.Parse(host);
         }
         catch
         {
            ip = Dns.GetHostEntry(host).AddressList[0];
         }
         _Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
         try
         {
            _Socket.Connect(new IPEndPoint(ip, port));
            _OwnsSocket = true;
         }
         catch
         {
            _Socket = null;
            _OwnsSocket = false;
            throw;
         }
         MaxDataLength = maxDataLength;
         MaxTelegramLength = (short)(maxDataLength + 8);
      }

      /// <summary>
      /// Creates a new Modbus TCP listener. This will start a TCP server listening to the given port.
      /// </summary>
      /// <param name="device">Device to add the listeners to.</param>
      /// <param name="port">Port to listen. The Modbus TCP default port is 502.</param>
      /// <param name="maxConnections">Maximum number of allowed connections. The default is 5.</param>
      /// <param name="maxDataLength">Maximum allowed length of function code specific data.</param>
      /// <returns>Returns a new <see cref="ModbusTcpListener"/>.</returns>
      /// <remarks>
      /// For every incomming connection a new <see cref="ModbusTcpInterface"/> is created and added to the <see cref="ModbusDevice"/>.
      /// </remarks>
      public static ModbusTcpListener StartDeviceListener(ModbusDevice device, int port = 502, int maxConnections = 5, short maxDataLength = 252)
      {
         return new ModbusTcpListener(device, port, maxConnections, maxDataLength);
      }

      /// <summary>
      /// Gets the maximum function code specific data length (not including address, function code, ...) of e telegram.
      /// </summary>
      public short MaxDataLength { get; private set; }

      /// <summary>
      /// Gets the maximum length of a Modbus telegram.
      /// </summary>
      public short MaxTelegramLength { get; private set; }

      /// <summary>
      /// Creates a new telegram for a modbus request or response.
      /// All data except the function code specific user data is written into the given buffer.
      /// </summary>
      /// <param name="addr">Device address. 0 = Breadcast, 1..247 are valid device addresses.</param>
      /// <param name="fkt">Function code. <see cref="ModbusFunctionCode"/></param>
      /// <param name="dataLength">Number of bytes for function code sspecific user data.</param>
      /// <param name="buffer">Buffer to write data into. The buffer must be at least MaxTelegramLength - MaxDataLength + dataLength bytes long.</param>
      /// <param name="telegramLength">Returns the total length of the telegram in bytes.</param>
      /// <param name="dataPos">Returns the offset of the function code specific user data in buffer.</param>
      /// <param name="isResponse">true if this is a response telegram; false if this is a request telegram.</param>
      /// <param name="telegramContext">
      /// If isResponse == false, this parameter returns the interface implementation specific data which must be passed to the ParseTelegram method of the received response.
      /// If isResponse == true, this parameter must be called with the telegramContext parameter returned by ParseTelegram of the request telegram.</param>
      public void CreateTelegram(byte addr, byte fkt, short dataLength, byte[] buffer, out short telegramLength, out short dataPos,
                                 bool isResponse, ref object telegramContext)
      {
         telegramLength = (short)(8 + dataLength);

         if (isResponse)
         {
            // in a response we insert the given telegramContext as transaction id
            if (telegramContext is ushort)
            {
               ModbusUtils.InsertUShort(buffer, 0, (ushort)telegramContext);
            }
            else
            {
               ModbusUtils.InsertUShort(buffer, 0, 0);
            }
         }
         else
         {
            // insert new transaction id into request
            telegramContext = _NextTransactionId;
            if (_NextTransactionId == 0xffff)
            {
               ModbusUtils.InsertUShort(buffer, 0, 0xffff);
               _NextTransactionId = 0;
            }
            else
            {
               ModbusUtils.InsertUShort(buffer, 0, _NextTransactionId++);
            }
         }
         ModbusUtils.InsertUShort(buffer, 2, 0);
         ModbusUtils.InsertUShort(buffer, 4, (ushort)(telegramLength - 6));
         buffer[6] = addr;
         buffer[7] = fkt;
         dataPos = 8;
      }

      public void PrepareWrite()
      { }

      public void PrepareRead()
      { }

      /// <summary>
      /// Sends the given telegram.
      /// If necessary additional information like a checksum can be inserted here.
      /// </summary>
      /// <param name="buffer">Buffer containing the data.</param>
      /// <param name="telegramLength">Length of the telegram in bytes.</param>
      public void SendTelegram(byte[] buffer, short telegramLength)
      {
         if (_Socket == null)
         {
            throw new ObjectDisposedException("ModbusTcp interface");
         }
         _Socket.Send(buffer, 0, telegramLength, SocketFlags.None);
      }

      /// <summary>
      /// Waits and receives a telegram.
      /// </summary>
      /// <param name="buffer">Buffer to write data into.</param>
      /// <param name="desiredDataLength">Desired length of the function code specific data in bytes. -1 if length is unknown.</param>
      /// <param name="timeout">Timeout in milliseconds to wait for the telegram.</param>
      /// <param name="telegramLength">Returns the total length of the telegram in bytes.</param>
      /// <returns>Returns true if the telegram was received successfully; false on timeout.</returns>
      public bool ReceiveTelegram(byte[] buffer, short desiredDataLength, int timeout, out short telegramLength)
      {
         if (_Socket == null)
         {
            throw new ObjectDisposedException("ModbusTcp interface");
         }
         if (!_Socket.Poll(timeout * 1000, SelectMode.SelectRead) || _Socket.Available == 0)
         {
            telegramLength = 0;
            return false;
         }
         // get the 1st 6 bytes, which includes the remaining length
         int pos = 0;
         while (pos < 6)
         {
            pos += _Socket.Receive(buffer, pos, 6 - pos, SocketFlags.None);
         }
         telegramLength = (short)(ModbusUtils.ExtractUShort(buffer, 4) + 6);

         // receive remaining data
         while (pos < telegramLength)
         {
            pos += _Socket.Receive(buffer, pos, telegramLength - pos, SocketFlags.None);
         }
         return true;
      }

      /// <summary>
      /// Parses a telegram received by ReceiveTelegram.
      /// </summary>
      /// <param name="buffer">Buffer containing the data.</param>
      /// <param name="telegramLength">Total length of the telegram in bytes.</param>
      /// <param name="isResponse">true if the telegram is a response telegram; false if the telegram is a request telegram.</param>
      /// <param name="telegramContext">
      /// If isResponse == true: pass the telegramContext returned by CreateTelegram from the request.
      /// If isResponse == false: returns the telegramContext from the received request. It must pe passed to the CreateTelegram method for the response.
      /// </param>
      /// <param name="address">Returns the device address.</param>
      /// <param name="fkt">Returns the function code.</param>
      /// <param name="dataPos">Returns the offset in buffer of the function code specific data.</param>
      /// <param name="dataLength">Returns the length of the function code specific data.</param>
      /// <returns>Returns true if this is the matching response according to the telegramContext; else false. If isResponse == false this method should return always true.</returns>
      public bool ParseTelegram(byte[] buffer, short telegramLength, bool isResponse, ref object telegramContext, out byte address,
                                out byte fkt, out short dataPos, out short dataLength)
      {
         if (telegramLength < 8)
         {
            throw new ModbusException(ModbusErrorCode.ResponseTooShort);
         }
         if (isResponse)
         {
            if (telegramContext is ushort)
            {
               ushort transactionId = ModbusUtils.ExtractUShort(buffer, 0);
               if (transactionId != (ushort)telegramContext)
               {
                  // telegram does not match
                  address = 0;
                  fkt = 0;
                  dataPos = 0;
                  dataLength = 0;
                  return false;
               }
            }
         }
         else
         {
            telegramContext = ModbusUtils.ExtractUShort(buffer, 0);
         }
         address = buffer[6];
         fkt = buffer[7];
         dataPos = 8;
         dataLength = (short)(telegramLength - 8);
         return true;
      }

      /// <summary>
      /// Gets if there is currently data available on the interface.
      /// </summary>
      public bool IsDataAvailable
      {
         get
         {
            try
            {
               return _Socket != null && _Socket.Available > 0;
            }
            catch
            {
               return false;
            }
         }
      }

      /// <summary>
      /// Removes all data from the input interface.
      /// </summary>
      public void ClearInputBuffer()
      {
         byte[] buffer = new byte[1024];
         while (_Socket.Available > 0)
         {
            _Socket.Receive(buffer, Math.Min(1024, _Socket.Available), SocketFlags.None);
         }
      }

      /// <summary>
      /// Gets if the connection is ok
      /// </summary>
      public bool IsConnectionOk
      {
#if NETMF
         get
         {
            if (_Socket != null)
            {
               try
               {
                  bool error = _Socket.Poll(0, SelectMode.SelectError);
                  bool read = _Socket.Poll(0, SelectMode.SelectRead);
                  return !error &&
                     (!read || _Socket.Available > 0);
               }
               catch
               {
                  // ignored
               }
            }
            return false;
         }
#else
         get { return _Socket != null && _Socket.Connected; }
#endif
      }

      /// <summary>
      /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
      /// </summary>
      /// <filterpriority>2</filterpriority>
      public void Dispose()
      {
         if (_OwnsSocket)
         {
            try
            {
               _Socket.Close();
            }
            // ReSharper disable EmptyGeneralCatchClause
            catch { }
            // ReSharper restore EmptyGeneralCatchClause
            _Socket = null;
            _OwnsSocket = false;
         }
      }
   }

   /// <summary>
   /// Listener for Mdbus TCP devices
   /// </summary>
   public class ModbusTcpListener : IDisposable
   {
      private readonly ModbusDevice _device;
      private readonly short _maxDataLength;
      private readonly Socket _listenSocket;
      private Thread _listenThread;

      /// <summary>
      /// Creates a new Modbus TCP listener. This will start a TCP server listening to the given port.
      /// </summary>
      /// <param name="device">Device to add the listeners to.</param>
      /// <param name="port">Port to listen. The Modbus TCP default port is 502.</param>
      /// <param name="maxConnections">Maximum number of allowed connections. The default is 5.</param>
      /// <param name="maxDataLength">Maximum allowed length of function code specific data.</param>
      /// <remarks>
      /// For every incomming connection a new <see cref="ModbusTcpInterface"/> is created and added to the <see cref="ModbusDevice"/>.
      /// </remarks>
      public ModbusTcpListener(ModbusDevice device, int port, int maxConnections, short maxDataLength)
      {
         _device = device;
         _maxDataLength = maxDataLength;
         _listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
         _listenSocket.Bind(new IPEndPoint(IPAddress.Any, port));
         _listenSocket.Listen(1);
         _listenThread = new Thread(ListenProc);
         _listenThread.Start();
      }

      private void ListenProc()
      {
         while (_listenThread != null)
         {
            try
            {
               var socket = _listenSocket.Accept();
               var intf = new ModbusTcpInterface(socket, _maxDataLength, true);
               _device.AddInterface(intf);
            }
            catch { }
         }
      }

      /// <summary>
      /// Disposes the listener and releases all resources
      /// </summary>
      public void Dispose()
      {
         var thread = _listenThread;
         _listenThread = null;

         if (_listenSocket != null)
         {
            try
            {
               _listenSocket.Close();
            }
            catch { }
         }
         if (thread != null)
         {
            thread.Join(5000);
         }
      }
   }
}
