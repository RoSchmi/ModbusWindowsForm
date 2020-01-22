// Copyright RoSchmi March 2017, Jan 2020 License Apache 2.0
// This Windows Forms Application was made to test the functions
// of Reinhard Ostermeiers ModbusRtu libraries
// -https://www.ghielectronics.com/community/codeshare/entry/865
// -https://www.ghielectronics.com/community/codeshare/entry/880
// The code was hammered together "quick and dirty" and is redundant
// and probably full of bugs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

using Osre.Modbus.Interface;
using Osre.Modbus;

namespace ModbusWindowsForm
{
    public partial class Form1 : Form, IModbusInterface
    {

        //********   Presets to be set by User   ************//
        const string slaveAddressPreset = "01";
        const string serialPortPreset = "COM9";
        const int serialPortBaudratePreset = 2400;
        const Parity serialPortParityPreset = Parity.None;
        const StopBits serialPortStopbitsPreset = StopBits.One;
        //********   End of Presets to be set by User   *****//


        ModbusRtuInterface myModbusRtuInterface;
        //ModbusMaster myModbusMaster;
        RoSchmiModbusMaster myModbusMaster;
        private static SerialPort _comPort;

        private readonly byte[] _Buffer = new byte[6] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        private byte clientAddress = 0;
        private byte[] RegWriteValue = new byte[2] { 0x00, 0x00 };
        private byte[] coilAddress = new byte[2] { 0x00, 0x00 };
        private byte[] coilAddressRead = new byte[2] { 0x00, 0x00 };
        private byte[] HoldingRegsAddress = new byte[2] { 0x00, 0x00 };
        private byte[] InputRegsAddress = new byte[2] { 0x00, 0x00 };
        private byte[] RegisterWriteAddress = new byte[2] { 0x00, 0x00 };
        private byte[] HoldingRegsWriteAddress = new byte[2] { 0x00, 0x00 };

        private ushort[] HoldingRegsWriteValues = new ushort[4] { 0x00, 0x00 , 0x00, 0x00};

        public Form1()
        {
            InitializeComponent();
        }

        #region Form1 Load
        private void Form1_Load(object sender, EventArgs e)
        {
            //_comPort = new SerialPort("COM1", 9600, Parity.Even, 8, StopBits.One);

            _comPort = new SerialPort(serialPortPreset, serialPortBaudratePreset, serialPortParityPreset, 8, serialPortStopbitsPreset);
            _comPort.Open();
            _comPort.DiscardInBuffer();

            myModbusRtuInterface = new ModbusRtuInterface(_comPort);
            //myModbusMaster = new ModbusMaster(myModbusRtuInterface);
            myModbusMaster = new RoSchmiModbusMaster(myModbusRtuInterface);

            //myModbusMaster.NewSerialDataRecieved += new EventHandler<ReceivedDataEventArgs>(_spManager_NewSerialDataRecieved);
            myModbusMaster.NewSerialDataRecieved += myModbusMaster_NewSerialDataRecieved;

            textBoxComPort.Text = serialPortPreset;
            textBoxAddress.Text = slaveAddressPreset;
            textBoxCoilAddress.Text = "0000";
            textBoxCoilAddressRead.Text = "0000";
            textBoxHoldingRegsRead.Text = "0000";
            textBoxInputRegsRead.Text = "0000";
            textBoxRegWriteValue.Text = "0000";
            textBoxRegisterAddress.Text = "0000";
            textBoxHoldingRegsWrite.Text = "0000";
            textBoxRegValue_00.Text = "0000";
            textBoxRegValue_01.Text = "0000";
            textBoxRegValue_02.Text = "0000";
            textBoxRegValue_03.Text = "0000";
        }
        #endregion

        #region Event - New serial Data received

        void myModbusMaster_NewSerialDataRecieved(object sender, ReceivedDataEventArgs e)
        {
            if (this.InvokeRequired)
            {

                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<ReceivedDataEventArgs>(myModbusMaster_NewSerialDataRecieved), new object[] { sender, e });
                return;
            }
            string theString = e.Data;
            if (theString.Length > 70)
            {
                theString = theString.Substring(0, 70);
            }
            theString += "\r\n";
            int maxTextLength = 1000; // maximum text length in text box
            if (tbData.TextLength > maxTextLength)
                tbData.Text = tbData.Text.Remove(0, tbData.TextLength - maxTextLength);

            tbData.AppendText(theString);
            tbData.ScrollToCaret();
        }

        #endregion

        #region  Write Error Message String
        void writeErrorMessage(string text)
        {
            int maxTextLength = 1000; // maximum text length in text box
            if (tbData.TextLength > maxTextLength)
                tbData.Text = tbData.Text.Remove(0, tbData.TextLength - maxTextLength);

            tbData.AppendText(text);
            tbData.ScrollToCaret();
        }
        #endregion

        #region Send to Coil
        private void buttonSendCoil_Click(object sender, EventArgs e)
        {
            try
            {
                myModbusMaster.WriteSingleCoil(clientAddress, (ushort)((coilAddress[0] << 8 )+ coilAddress[1]), radioButtonOff.Checked == false);
                groupBox1.BackColor = Color.LightGreen;
            }
            catch (Exception ex)
            {
                writeErrorMessage(ex.Message);
            }
        }
        #endregion

        #region Read Coil
        private void buttonReadCoils_Click(object sender, EventArgs e)
        {
            byte[] theCoilResult;
            try
            {
                theCoilResult = myModbusMaster.ReadCoils(clientAddress, (ushort)((coilAddressRead[0] << 8) + coilAddressRead[1]), (ushort)numericUpDownCoilCount.Value);
                textBoxReadResult.Text = HexEncoding.ToString(theCoilResult, 0, theCoilResult.Length);
            }
            catch (Exception ex)
            {
                writeErrorMessage(ex.Message);
            }
        }
        #endregion

        /*
        private void buttonReadOneHoldingRegister_Click(object sender, EventArgs e)
        {

        }
        */
   

        private void buttonRoundTest_Click(object sender, EventArgs e)
        {
            float floatTestValue = 0;
                if ( !string.IsNullOrEmpty(textBoxFloatTestInput.Text))
                {
                    
                    try
                    {
                        floatTestValue = float.Parse(textBoxFloatTestInput.Text);
                    }
                    catch 
                    {
                        MessageBox.Show("No valid float value");
                    }
                }
            float result = reform_uint16_2_float32(floatTestValue);  

            textBoxFloatTestResult.Text = result.ToString("n6");
        }


        #region Read Input Register
        private void buttonReadInputRegister_Click(object sender, EventArgs e)
        {

            // Function Code 04
            textBoxReadInputRegisters.Text = "";
            textBoxReadInputRegisters_1.Text = "";
            ushort[] theInputRegisterResult;
            StringBuilder theStringBuilder = new StringBuilder("");
            try
            {
                theInputRegisterResult = myModbusMaster.ReadInputRegisters(clientAddress, (ushort)((InputRegsAddress[0] << 8) + InputRegsAddress[1]), (ushort)numericUpDownRegsCount2.Value);

                for (int i = 0; i < theInputRegisterResult.Length; i++)
                {
                    theStringBuilder.Append(theInputRegisterResult[i].ToString("X4"));
                    theStringBuilder.Append(" ");
                }
                textBoxReadInputRegisters.Text = theStringBuilder.ToString();
               
                float result = reform_uint16_2_float32(theInputRegisterResult[0], theInputRegisterResult[1]);

                textBoxReadInputRegisters_1.Text = result.ToString("n3");
            }
            catch (Exception ex)
            {
                writeErrorMessage(ex.Message);
            }
        }
        #endregion

        #region Read Holding Registers
        private void buttonReadHoldingRegisters_Click(object sender, EventArgs e)
        {

            // Function Code 03

            ushort[] theHoldingRegisterResult;
            StringBuilder theStringBuilder = new StringBuilder("");
            try
            {
                theHoldingRegisterResult = myModbusMaster.ReadHoldingRegisters(clientAddress, (ushort)((HoldingRegsAddress[0] << 8) + HoldingRegsAddress[1]), (ushort)numericUpDownRegsCount.Value);

                for (int i = 0; i < theHoldingRegisterResult.Length; i++)
                {
                    theStringBuilder.Append(theHoldingRegisterResult[i].ToString("X4"));
                    theStringBuilder.Append(" ");
                }
                textBoxReadHoldingRegisters.Text = theStringBuilder.ToString();
            }
            catch (Exception ex)
            {
                writeErrorMessage(ex.Message);
            }
        }
        #endregion

        #region Write Holding Registers
        private void buttonWriteHoldingRegisters_Click(object sender, EventArgs e)
        {
            try
            {
                //theHoldingRegisterResult = myModbusMaster.ReadHoldingRegisters(clientAddress, (ushort)((HoldingRegsAddress[0] << 8) + HoldingRegsAddress[1]), (ushort)numericUpDownRegsCount.Value);
                //myModbusMaster.WriteMultipleRegisters(clientAddress, (ushort)((HoldingRegsAddress[0] << 8) + HoldingRegsAddress[1]), (ushort)numericUpDownRegsCount.Value);
                ushort[] sendArray = new ushort[(int)numericUpDownWriteRegsCount.Value];
                Array.Copy(HoldingRegsWriteValues, 0, sendArray, 0, sendArray.Length);

                myModbusMaster.WriteMultipleRegisters(clientAddress, (ushort)((HoldingRegsAddress[0] << 8) + HoldingRegsAddress[1]), sendArray);
            }
            catch (Exception ex)
            {
                writeErrorMessage(ex.Message);
            }

        }
        #endregion

        #region Write Single Register
        private void buttonWriteSingleRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Function 06 Write Singel Register
                myModbusMaster.WriteSingleRegister(clientAddress, (ushort)(RegisterWriteAddress[0] + RegisterWriteAddress[1]), (ushort)((RegWriteValue[0]<<8) + RegWriteValue[1]));
            }
            catch (Exception ex)
            {
                writeErrorMessage(ex.Message);
            }
        }
        #endregion

        #region Not realized functions

        // Function 02 Read dicrete Inputs
        //var theSingleRegisterResult = myModbusMaster.ReadDiscreteInputs(clientAddress,0x0000, 2);

        // Function 04 Read Input Registers
        //var theSingleRegisterResult = myModbusMaster.ReadInputRegisters(clientAddress, 0x0000, 1);

        #endregion

        #region not needed implements
        public short MaxDataLength
        {
            get
            {
                return MaxDataLength;
            }
        }
        public short MaxTelegramLength
        {
            get
            {
                return MaxTelegramLength;
            }
        }
        public void CreateTelegram(byte addr, byte fkt, short dataLength, byte[] buffer, out short telegramLength, out short dataPos, bool isResponse, ref object telegramContext)
        {
            //RoSchmi
            dataPos = 1;
            telegramLength = 1;
        }

        public void PrepareWrite() { }

        public void PrepareRead() { }


        public void SendTelegram(byte[] buffer, short telegramLength) { }

        public bool ReceiveTelegram(byte[] buffer, short desiredDataLength, int timeout, out short telegramLength)
        {
            telegramLength = 1;
            return true;
        }


        public bool ParseTelegram(byte[] buffer, short telegramLength, bool isResponse, ref object telegramContext, out byte address, out byte fkt,
                        out short dataPos, out short dataLength)
        {
            address = 0x00;
            fkt = 0x00;
            dataPos = 1;
            dataLength = 1;
            return true;

        }
        public bool IsDataAvailable
        {
            get
            {
                return IsDataAvailable;
            }
        }

        public void ClearInputBuffer() { }

        public bool IsConnectionOk
        {

            get
            {
                //bool IsOK {get;}
                return true;
                //return IsConnectionOk;

            }
        }
        #endregion


        /*
        /// <summary>
        /// Sends a modbus telegram over the interface and waits for a response
        /// </summary>
        /// <param name="deviceAddress">Modbus device address.</param>
        /// <param name="fc">Function code.</param>
        /// <param name="timeout">Timeout in Milli seconds.</param>
        /// <param name="telegramLength">Total length of the telegram in bytes</param>
        /// <param name="desiredDataLength">Length of the desired telegram data (without fc, cs, ...) of the response in bytes. -1 for unknown.</param>
        /// <param name="telegramContext">Interface specific context of the telegram</param>
        /// <param name="dataPos">Index of the response data in the buffer.</param>
        /// <returns></returns>
        protected virtual short SendReceive(byte deviceAddress, ModbusFunctionCode fc, int timeout, short telegramLength, short desiredDataLength,
                                            object telegramContext, ref short dataPos)
        {
            // lock (_SyncObject)
            // {
            try
            {
                myModbusRtuInterface.SendTelegram(_Buffer, telegramLength);
                myModbusRtuInterface.PrepareRead();

                if (deviceAddress == ModbusConst.BroadcastAddress)
                {
                    return 0;
                }

                byte responseDeviceAddress;
                byte responseFc = 0;
                short dataLength = 0;

                while (timeout > 0)
                {
                    var ts = DateTime.Now.Ticks;
                    if (!myModbusRtuInterface.ReceiveTelegram(_Buffer, desiredDataLength, timeout, out telegramLength))
                    {
                        throw new ModbusException(ModbusErrorCode.Timeout);
                    }
                    timeout -= (int)((DateTime.Now.Ticks - ts) / 10000);

                    // if this is not the response we are waiting for wait again until time runs out
                    if (myModbusRtuInterface.ParseTelegram(_Buffer, telegramLength, true, ref telegramContext,
                       out responseDeviceAddress,
                       out responseFc,
                       out dataPos, out dataLength)
                        && responseDeviceAddress == deviceAddress
                        && (responseFc & 0x7f) == (byte)fc)
                    {
                        break;
                    }
                    if (timeout <= 0)
                    {
                        throw new ModbusException(ModbusErrorCode.Timeout);
                    }
                }
                if ((responseFc & 0x80) != 0)
                {
                    // error response
                    throw new ModbusException((ModbusErrorCode)_Buffer[dataPos]);
                }
                return dataLength;
            }
            finally
            {
                myModbusRtuInterface.PrepareWrite();
            }
            // }
        }
        */


        // Overloaded so that floats can be passed as parameters and should return the same value
        // as a test
        private float reform_uint16_2_float32(float pTestFloat)
        {


            // For tests: to test with different valus
            // float floatTestValue = (float)0.075;

            float result = 0;
            
            UInt16 u2 = 0;
            byte[] arr = new byte[4];

            arr = BitConverter.GetBytes(pTestFloat);
            Byte data0 = arr[3];    //High Register (u1) High Byte         
            Byte data1 = arr[2];
            Byte data2 = arr[1];    //Low Register (u2) High Byte             
            Byte data3 = arr[0];

            UInt16 u1 = 0;

            UInt16 Reg_u1_high = (UInt16)(((UInt16)data0) << 8);
            UInt16 Reg_u1_low = (UInt16)((UInt16)data1);
            u1 = (UInt16)(Reg_u1_high | Reg_u1_low);

            UInt16 Reg_u2_high = (UInt16)(((UInt16)data2) << 8);
            UInt16 Reg_u2_low = (UInt16)((UInt16)data3);
            u2 = (UInt16)(Reg_u2_high | Reg_u2_low);

            result = reform_uint16_2_float32(u1, u2);
            return result;
        }
        
        private float reform_uint16_2_float32(UInt16  pU1, UInt16 pU2)
        {
            float result = 0;
            UInt16 u1 = pU1;
            UInt16 u2 = pU2;
                      
            // This is an example for value: 240.50
            //u1 = 0x4370;
            //u2 = 0x8000;

            
            
            // sign 0 is positive, 1 is negativ        
            bool sign = ((uint)u1 & 0x8000) == 0;
            
            UInt16 expon = 0;
            Int32 finalExponent = 0;
            

            UInt16 maskedExponent = (UInt16)(u1 & 0x7F80);           
            expon = (UInt16)(maskedExponent >> 7);
            finalExponent = (Int32)expon - 127;

            if (finalExponent > 19)
            {
                throw new ArgumentOutOfRangeException("Exception: Value was to large");
            }
            


            // This is the ugly way in C
            /*
            if (finalExponent >= -8)     // function returns not valid results for finalExponent < -8
            {
                uint mantissaLow = u2;
                uint mantissaHigh = (((uint)u1 & 0x007F) & 0xFF7F);  // set higher 8 bits to zero, set the following bit to one
                uint mantissaHighShifted = mantissaHigh << 16;       // shift 16 bits left so that the lower part can be added
                uint mantissa = (mantissaHighShifted + mantissaLow) | 0x800000;   // add higher 16 bits and lower 16 bits, set highest bit to one



                uint preDecPoint = (uint)mantissa >> (23 - finalExponent);
                int indexFirstPastPointDigit = 23 - finalExponent - 1;
                uint maskBit = (uint)Math.Pow(2, indexFirstPastPointDigit);
                double pastDecPoint = 0;
                for (int i = 0; i <= (int)indexFirstPastPointDigit; i++)
                {
                    if ((mantissa & maskBit) != 0)
                    {
                        pastDecPoint += 1.0 / (Math.Pow(2, i + 1));
                    }
                    maskBit = maskBit >> 1;
                }
                result = (float)(preDecPoint + pastDecPoint);
                if (sign != true)
                {
                    result = result * -1;
                }
                return result;
            }
            else
            {
                result = 0;
                return result;
            }
            */

            // This is the easy way in C#
         
            UInt32 u_32 = (UInt32)(u1 * 65536) + u2;
            result = BitConverter.ToSingle(BitConverter.GetBytes((int)u_32), 0);
            return result;
        }


        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAddress.Text.Length > 2)
            {
                textBoxAddress.Text = textBoxAddress.Text.Substring(0, 2);
            }
            if (textBoxAddress.Text.Length == 2)
            {
                int discarded = 0;
                byte[] result = new byte[1];

                result = HexEncoding.GetBytes(textBoxAddress.Text, out discarded);
                try
                {
                    clientAddress = result[0];
                    textBox2.Text = clientAddress.ToString();
                }
                catch
                {
                    AsyncMessageBox asyncMSGBOX = new AsyncMessageBox("No valid Hex value");
                    asyncMSGBOX.Show();
                    textBoxAddress.Text = "";
                    textBox2.Text = "";
                    clientAddress = 0x00;
                }

            }
        }
        private void textBoxCoilAddress_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCoilAddress.Text.Length > 4)
            {
                textBoxCoilAddress.Text = textBoxCoilAddress.Text.Substring(0, 4);
            }
            if (textBoxCoilAddress.Text.Length == 4)
            {
                int discarded = 0;
                byte[] result = new byte[2];

                result = HexEncoding.GetBytes(textBoxCoilAddress.Text, out discarded);
                try
                {
                    coilAddress = result;
                    textBoxCoilDecAddress.Text = ((int)coilAddress[0] * 256 + (int)coilAddress[1]).ToString();
                }
                catch
                {
                    AsyncMessageBox asyncMSGBOX = new AsyncMessageBox("No valid Hex value");
                    asyncMSGBOX.Show();
                    textBoxCoilAddress.Text = "";
                    textBoxCoilDecAddress.Text = "";
                    coilAddress[0] = 0x00;
                    coilAddress[1] = 0x00;
                }

            }
        }


        private void textBoxCoilAddressRead_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCoilAddressRead.Text.Length > 4)
            {
                textBoxCoilAddressRead.Text = textBoxCoilAddressRead.Text.Substring(0, 4);
            }
            if (textBoxCoilAddressRead.Text.Length == 4)
            {
                int discarded = 0;
                byte[] result = new byte[2];

                result = HexEncoding.GetBytes(textBoxCoilAddressRead.Text, out discarded);
                try
                {
                    coilAddressRead = result;
                    textBoxCoilDecAddressRead.Text = ((int)coilAddressRead[0] * 256 + (int)coilAddressRead[1]).ToString();
                }
                catch
                {
                    AsyncMessageBox asyncMSGBOX = new AsyncMessageBox("No valid Hex value");
                    asyncMSGBOX.Show();
                    textBoxCoilAddressRead.Text = "";
                    textBoxCoilDecAddressRead.Text = "";
                    coilAddressRead[0] = 0x00;
                    coilAddressRead[1] = 0x00;
                }

            }
        }

        private void radioButtonOff_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.LightGray;
        }

        private void textBoxInputRegsRead_TextChanged(object sender, EventArgs e)
        {
            if (textBoxInputRegsRead.Text.Length > 4)
            {
                textBoxInputRegsRead.Text = textBoxInputRegsRead.Text.Substring(0, 4);
            }
            if (textBoxInputRegsRead.Text.Length == 4)
            {
                int discarded = 0;
                byte[] result = new byte[2];

                result = HexEncoding.GetBytes(textBoxInputRegsRead.Text, out discarded);
                try
                {
                    InputRegsAddress = result;
                    textBoxInputRegsDecAddressRead.Text = ((int)InputRegsAddress[0] * 256 + (int)InputRegsAddress[1]).ToString();
                    
                }
                catch
                {
                    AsyncMessageBox asyncMSGBOX = new AsyncMessageBox("No valid Hex value");
                    asyncMSGBOX.Show();
                    textBoxInputRegsRead.Text = "";
                    textBoxInputRegsDecAddressRead.Text = "";
                    InputRegsAddress[0] = 0x00;
                    InputRegsAddress[1] = 0x00;
                }

            }
        }



        private void textBoxHoldingRegsRead_TextChanged(object sender, EventArgs e)
        {
            if (textBoxHoldingRegsRead.Text.Length > 4)
            {
                textBoxHoldingRegsRead.Text = textBoxHoldingRegsRead.Text.Substring(0, 4);
            }
            if (textBoxHoldingRegsRead.Text.Length == 4)
            {
                int discarded = 0;
                byte[] result = new byte[2];

                result = HexEncoding.GetBytes(textBoxHoldingRegsRead.Text, out discarded);
                try
                {
                    HoldingRegsAddress = result;
                    textBoxHoldingRegsDecAddressRead.Text = ((int)HoldingRegsAddress[0] * 256 + (int)HoldingRegsAddress[1]).ToString();
                }
                catch
                {
                    AsyncMessageBox asyncMSGBOX = new AsyncMessageBox("No valid Hex value");
                    asyncMSGBOX.Show();
                    textBoxHoldingRegsRead.Text = "";
                    textBoxHoldingRegsDecAddressRead.Text = "";
                    HoldingRegsAddress[0] = 0x00;
                    HoldingRegsAddress[1] = 0x00;
                }

            }
        }

        private void textBoxRegWriteValue_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRegWriteValue.Text.Length > 4)
            {
                textBoxRegWriteValue.Text = textBoxRegWriteValue.Text.Substring(0, 4);
            }
            if (textBoxRegWriteValue.Text.Length == 4)
            {
                int discarded = 0;
                byte[] result = new byte[2];

                result = HexEncoding.GetBytes(textBoxRegWriteValue.Text, out discarded);
                try
                {
                    RegWriteValue = result;
                }
                catch
                {
                    AsyncMessageBox asyncMSGBOX = new AsyncMessageBox("No valid Hex value");
                    asyncMSGBOX.Show();
                    textBoxRegWriteValue.Text = "0000";
                    RegWriteValue[0] = 0x00;
                    RegWriteValue[1] = 0x00;

                }

            }
        }

        private void textBoxRegisterAddress_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRegisterAddress.Text.Length > 4)
            {
                textBoxRegisterAddress.Text = textBoxRegisterAddress.Text.Substring(0, 4);
            }
            if (textBoxRegisterAddress.Text.Length == 4)
            {
                int discarded = 0;
                byte[] result = new byte[2];

                result = HexEncoding.GetBytes(textBoxRegisterAddress.Text, out discarded);
                try
                {
                    RegisterWriteAddress = result;
                    textBoxRegisterDecAddress.Text = ((int)RegisterWriteAddress[0] * 256 + (int)RegisterWriteAddress[1]).ToString();
                }
                catch
                {
                    AsyncMessageBox asyncMSGBOX = new AsyncMessageBox("No valid Hex value");
                    asyncMSGBOX.Show();
                    textBoxRegisterAddress.Text = "";
                    textBoxHoldingRegsDecAddressRead.Text = "";
                    HoldingRegsAddress[0] = 0x00;
                    HoldingRegsAddress[1] = 0x00;
                }
            }
        }

        private void textBoxHoldingRegsWrite_TextChanged(object sender, EventArgs e)
        {
            if (textBoxHoldingRegsWrite.Text.Length > 4)
            {
                textBoxHoldingRegsWrite.Text = textBoxHoldingRegsWrite.Text.Substring(0, 4);
            }
            if (textBoxHoldingRegsWrite.Text.Length == 4)
            {
                int discarded = 0;
                byte[] result = new byte[2];

                result = HexEncoding.GetBytes(textBoxHoldingRegsWrite.Text, out discarded);
                try
                {
                    HoldingRegsWriteAddress = result;
                    textBoxHoldingRegsDecWrite.Text = (((int)HoldingRegsWriteAddress[0] << 8) + (int)HoldingRegsWriteAddress[1]).ToString();
                }
                catch
                {
                    AsyncMessageBox asyncMSGBOX = new AsyncMessageBox("No valid Hex value");
                    asyncMSGBOX.Show();
                    textBoxHoldingRegsWrite.Text = "";
                    textBoxHoldingRegsDecWrite.Text = "";
                    HoldingRegsWriteAddress[0] = 0x00;
                    HoldingRegsWriteAddress[1] = 0x00;
                }
            }
        }

        private void textBoxRegValue_00_TextChanged(object sender, EventArgs e)
        {
            textBoxRegValue_00.Text = testHexString(textBoxRegValue_00.Text, 4, ref HoldingRegsWriteValues[0]);
        }



        private void textBoxRegValue_01_TextChanged(object sender, EventArgs e)
        {
            textBoxRegValue_01.Text = testHexString(textBoxRegValue_01.Text, 4, ref HoldingRegsWriteValues[1]);

        }

        private void textBoxRegValue_02_TextChanged(object sender, EventArgs e)
        {
            textBoxRegValue_02.Text = testHexString(textBoxRegValue_02.Text, 4, ref HoldingRegsWriteValues[2]);

        }

        private void textBoxRegValue_03_TextChanged(object sender, EventArgs e)
        {
            textBoxRegValue_03.Text = testHexString(textBoxRegValue_03.Text, 4, ref HoldingRegsWriteValues[3]);

        }

       string testHexString(string inputString, int length, ref ushort outPut)
        {
            string workString = inputString;
            ushort workOutPut = outPut;
            if (workString.Length > length)
            {
                workString = workString.Substring(0, length);
            }
            if (workString.Length == 4)
            {
                int discarded = 0;
                byte[] result = new byte[2];

                result = HexEncoding.GetBytes(workString, out discarded);
                try
                {
                     outPut = (ushort)((result[0] << 8) + result[1]);
                     return workString;
                }
                catch
                {
                    AsyncMessageBox asyncMSGBOX = new AsyncMessageBox("No valid Hex value");
                    asyncMSGBOX.Show();
                    workString = "";
                    outPut = 0;
                    return workString;
                }
            }
           return workString;
        }

       

      

      
    }
}
