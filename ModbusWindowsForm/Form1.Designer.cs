namespace ModbusWindowsForm
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSendCoil = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.buttonReadCoi = new System.Windows.Forms.Button();
            this.textBoxCoilAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonOn = new System.Windows.Forms.RadioButton();
            this.radioButtonOff = new System.Windows.Forms.RadioButton();
            this.textBoxCoilDecAddress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownCoilCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxReadResult = new System.Windows.Forms.TextBox();
            this.textBoxCoilDecAddressRead = new System.Windows.Forms.TextBox();
            this.textBoxCoilAddressRead = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonReadHoldingRegisters = new System.Windows.Forms.Button();
            this.textBoxReadHoldingRegisters = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxHoldingRegsRead = new System.Windows.Forms.TextBox();
            this.textBoxHoldingRegsDecAddressRead = new System.Windows.Forms.TextBox();
            this.numericUpDownRegsCount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonWriteSingleRegister = new System.Windows.Forms.Button();
            this.textBoxRegWriteValue = new System.Windows.Forms.TextBox();
            this.textBoxRegisterAddress = new System.Windows.Forms.TextBox();
            this.textBoxRegisterDecAddress = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonWriteHoldingRegisters = new System.Windows.Forms.Button();
            this.textBoxHoldingRegsWrite = new System.Windows.Forms.TextBox();
            this.textBoxHoldingRegsDecWrite = new System.Windows.Forms.TextBox();
            this.textBoxRegValue_00 = new System.Windows.Forms.TextBox();
            this.textBoxRegValue_01 = new System.Windows.Forms.TextBox();
            this.textBoxRegValue_02 = new System.Windows.Forms.TextBox();
            this.textBoxRegValue_03 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.numericUpDownWriteRegsCount = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxReadInputRegisters_1 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.buttonReadInputRegisters = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxReadInputRegisters = new System.Windows.Forms.TextBox();
            this.numericUpDownRegsCount2 = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxInputRegsRead = new System.Windows.Forms.TextBox();
            this.textBoxInputRegsDecAddressRead = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.labelComPort = new System.Windows.Forms.Label();
            this.textBoxComPort = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.buttonRoundTest = new System.Windows.Forms.Button();
            this.textBoxFloatTestInput = new System.Windows.Forms.TextBox();
            this.textBoxFloatTestResult = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoilCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegsCount)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWriteRegsCount)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegsCount2)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSendCoil
            // 
            this.buttonSendCoil.Location = new System.Drawing.Point(23, 99);
            this.buttonSendCoil.Name = "buttonSendCoil";
            this.buttonSendCoil.Size = new System.Drawing.Size(172, 22);
            this.buttonSendCoil.TabIndex = 0;
            this.buttonSendCoil.Text = "Write Coil";
            this.buttonSendCoil.UseVisualStyleBackColor = true;
            this.buttonSendCoil.Click += new System.EventHandler(this.buttonSendCoil_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(12, 58);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(39, 20);
            this.textBoxAddress.TabIndex = 3;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client Address in HEX (2 Digits 0 - F )";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(42, 20);
            this.textBox2.TabIndex = 5;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(18, 476);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(376, 166);
            this.tbData.TabIndex = 6;
            // 
            // buttonReadCoi
            // 
            this.buttonReadCoi.Location = new System.Drawing.Point(35, 99);
            this.buttonReadCoi.Name = "buttonReadCoi";
            this.buttonReadCoi.Size = new System.Drawing.Size(134, 23);
            this.buttonReadCoi.TabIndex = 7;
            this.buttonReadCoi.Text = "Read Coils";
            this.buttonReadCoi.UseVisualStyleBackColor = true;
            this.buttonReadCoi.Click += new System.EventHandler(this.buttonReadCoils_Click);
            // 
            // textBoxCoilAddress
            // 
            this.textBoxCoilAddress.Location = new System.Drawing.Point(6, 25);
            this.textBoxCoilAddress.Name = "textBoxCoilAddress";
            this.textBoxCoilAddress.Size = new System.Drawing.Size(63, 20);
            this.textBoxCoilAddress.TabIndex = 9;
            this.textBoxCoilAddress.TextChanged += new System.EventHandler(this.textBoxCoilAddress_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Address (4 Hex Digits)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Content";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOn);
            this.groupBox1.Controls.Add(this.radioButtonOff);
            this.groupBox1.Location = new System.Drawing.Point(93, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 36);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonOn
            // 
            this.radioButtonOn.AutoSize = true;
            this.radioButtonOn.Location = new System.Drawing.Point(59, 13);
            this.radioButtonOn.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.radioButtonOn.Name = "radioButtonOn";
            this.radioButtonOn.Size = new System.Drawing.Size(39, 17);
            this.radioButtonOn.TabIndex = 1;
            this.radioButtonOn.Text = "On";
            this.radioButtonOn.UseVisualStyleBackColor = true;
            // 
            // radioButtonOff
            // 
            this.radioButtonOff.AutoSize = true;
            this.radioButtonOff.Checked = true;
            this.radioButtonOff.Location = new System.Drawing.Point(6, 13);
            this.radioButtonOff.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.radioButtonOff.Name = "radioButtonOff";
            this.radioButtonOff.Size = new System.Drawing.Size(39, 17);
            this.radioButtonOff.TabIndex = 0;
            this.radioButtonOff.TabStop = true;
            this.radioButtonOff.Text = "Off";
            this.radioButtonOff.UseVisualStyleBackColor = true;
            this.radioButtonOff.CheckedChanged += new System.EventHandler(this.radioButtonOff_CheckedChanged);
            // 
            // textBoxCoilDecAddress
            // 
            this.textBoxCoilDecAddress.Location = new System.Drawing.Point(6, 52);
            this.textBoxCoilDecAddress.Name = "textBoxCoilDecAddress";
            this.textBoxCoilDecAddress.ReadOnly = true;
            this.textBoxCoilDecAddress.Size = new System.Drawing.Size(63, 20);
            this.textBoxCoilDecAddress.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textBoxCoilDecAddress);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxCoilAddress);
            this.panel1.Controls.Add(this.buttonSendCoil);
            this.panel1.Location = new System.Drawing.Point(15, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 154);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.numericUpDownCoilCount);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxReadResult);
            this.panel2.Controls.Add(this.textBoxCoilDecAddressRead);
            this.panel2.Controls.Add(this.textBoxCoilAddressRead);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonReadCoi);
            this.panel2.Location = new System.Drawing.Point(251, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 154);
            this.panel2.TabIndex = 15;
            // 
            // numericUpDownCoilCount
            // 
            this.numericUpDownCoilCount.Location = new System.Drawing.Point(145, 26);
            this.numericUpDownCoilCount.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownCoilCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCoilCount.Name = "numericUpDownCoilCount";
            this.numericUpDownCoilCount.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownCoilCount.TabIndex = 23;
            this.numericUpDownCoilCount.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Result";
            // 
            // textBoxReadResult
            // 
            this.textBoxReadResult.Location = new System.Drawing.Point(75, 59);
            this.textBoxReadResult.Name = "textBoxReadResult";
            this.textBoxReadResult.Size = new System.Drawing.Size(143, 20);
            this.textBoxReadResult.TabIndex = 15;
            // 
            // textBoxCoilDecAddressRead
            // 
            this.textBoxCoilDecAddressRead.Location = new System.Drawing.Point(6, 59);
            this.textBoxCoilDecAddressRead.Name = "textBoxCoilDecAddressRead";
            this.textBoxCoilDecAddressRead.ReadOnly = true;
            this.textBoxCoilDecAddressRead.Size = new System.Drawing.Size(63, 20);
            this.textBoxCoilDecAddressRead.TabIndex = 14;
            // 
            // textBoxCoilAddressRead
            // 
            this.textBoxCoilAddressRead.Location = new System.Drawing.Point(6, 33);
            this.textBoxCoilAddressRead.Name = "textBoxCoilAddressRead";
            this.textBoxCoilAddressRead.Size = new System.Drawing.Size(63, 20);
            this.textBoxCoilAddressRead.TabIndex = 12;
            this.textBoxCoilAddressRead.TextChanged += new System.EventHandler(this.textBoxCoilAddressRead_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Address (4 Hex Digits)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "(Dezimal)";
            // 
            // buttonReadHoldingRegisters
            // 
            this.buttonReadHoldingRegisters.Location = new System.Drawing.Point(16, 119);
            this.buttonReadHoldingRegisters.Name = "buttonReadHoldingRegisters";
            this.buttonReadHoldingRegisters.Size = new System.Drawing.Size(152, 23);
            this.buttonReadHoldingRegisters.TabIndex = 17;
            this.buttonReadHoldingRegisters.Text = "Read Holding Registers";
            this.buttonReadHoldingRegisters.UseVisualStyleBackColor = true;
            this.buttonReadHoldingRegisters.Click += new System.EventHandler(this.buttonReadHoldingRegisters_Click);
            // 
            // textBoxReadHoldingRegisters
            // 
            this.textBoxReadHoldingRegisters.Location = new System.Drawing.Point(16, 93);
            this.textBoxReadHoldingRegisters.Name = "textBoxReadHoldingRegisters";
            this.textBoxReadHoldingRegisters.Size = new System.Drawing.Size(152, 20);
            this.textBoxReadHoldingRegisters.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Result";
            // 
            // textBoxHoldingRegsRead
            // 
            this.textBoxHoldingRegsRead.Location = new System.Drawing.Point(16, 24);
            this.textBoxHoldingRegsRead.Name = "textBoxHoldingRegsRead";
            this.textBoxHoldingRegsRead.Size = new System.Drawing.Size(63, 20);
            this.textBoxHoldingRegsRead.TabIndex = 20;
            this.textBoxHoldingRegsRead.TextChanged += new System.EventHandler(this.textBoxHoldingRegsRead_TextChanged);
            // 
            // textBoxHoldingRegsDecAddressRead
            // 
            this.textBoxHoldingRegsDecAddressRead.Location = new System.Drawing.Point(16, 50);
            this.textBoxHoldingRegsDecAddressRead.Name = "textBoxHoldingRegsDecAddressRead";
            this.textBoxHoldingRegsDecAddressRead.ReadOnly = true;
            this.textBoxHoldingRegsDecAddressRead.Size = new System.Drawing.Size(63, 20);
            this.textBoxHoldingRegsDecAddressRead.TabIndex = 21;
            // 
            // numericUpDownRegsCount
            // 
            this.numericUpDownRegsCount.Location = new System.Drawing.Point(129, 60);
            this.numericUpDownRegsCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRegsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRegsCount.Name = "numericUpDownRegsCount";
            this.numericUpDownRegsCount.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownRegsCount.TabIndex = 22;
            this.numericUpDownRegsCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Regs Count";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.buttonReadHoldingRegisters);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBoxReadHoldingRegisters);
            this.panel3.Controls.Add(this.numericUpDownRegsCount);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBoxHoldingRegsRead);
            this.panel3.Controls.Add(this.textBoxHoldingRegsDecAddressRead);
            this.panel3.Location = new System.Drawing.Point(504, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 154);
            this.panel3.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Address (4 Hex Digits)";
            // 
            // buttonWriteSingleRegister
            // 
            this.buttonWriteSingleRegister.Location = new System.Drawing.Point(49, 108);
            this.buttonWriteSingleRegister.Name = "buttonWriteSingleRegister";
            this.buttonWriteSingleRegister.Size = new System.Drawing.Size(133, 23);
            this.buttonWriteSingleRegister.TabIndex = 25;
            this.buttonWriteSingleRegister.Text = "Write Single Register";
            this.buttonWriteSingleRegister.UseVisualStyleBackColor = true;
            this.buttonWriteSingleRegister.Click += new System.EventHandler(this.buttonWriteSingleRegister_Click);
            // 
            // textBoxRegWriteValue
            // 
            this.textBoxRegWriteValue.Location = new System.Drawing.Point(130, 50);
            this.textBoxRegWriteValue.Name = "textBoxRegWriteValue";
            this.textBoxRegWriteValue.Size = new System.Drawing.Size(39, 20);
            this.textBoxRegWriteValue.TabIndex = 26;
            this.textBoxRegWriteValue.TextChanged += new System.EventHandler(this.textBoxRegWriteValue_TextChanged);
            // 
            // textBoxRegisterAddress
            // 
            this.textBoxRegisterAddress.Location = new System.Drawing.Point(22, 24);
            this.textBoxRegisterAddress.Name = "textBoxRegisterAddress";
            this.textBoxRegisterAddress.Size = new System.Drawing.Size(63, 20);
            this.textBoxRegisterAddress.TabIndex = 27;
            this.textBoxRegisterAddress.TextChanged += new System.EventHandler(this.textBoxRegisterAddress_TextChanged);
            // 
            // textBoxRegisterDecAddress
            // 
            this.textBoxRegisterDecAddress.Location = new System.Drawing.Point(22, 50);
            this.textBoxRegisterDecAddress.Name = "textBoxRegisterDecAddress";
            this.textBoxRegisterDecAddress.ReadOnly = true;
            this.textBoxRegisterDecAddress.Size = new System.Drawing.Size(63, 20);
            this.textBoxRegisterDecAddress.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.buttonWriteSingleRegister);
            this.panel4.Controls.Add(this.textBoxRegisterAddress);
            this.panel4.Controls.Add(this.textBoxRegisterDecAddress);
            this.panel4.Controls.Add(this.textBoxRegWriteValue);
            this.panel4.Location = new System.Drawing.Point(251, 271);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 157);
            this.panel4.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(127, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Value (4 Hex Digits)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Address (4 Hex Digits)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightGreen;
            this.label12.Location = new System.Drawing.Point(12, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Function 05 (Write Coil)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightGreen;
            this.label13.Location = new System.Drawing.Point(248, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Function 01 (Read Coils)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightGreen;
            this.label14.Location = new System.Drawing.Point(501, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Function 03 (Read multiple Registers)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightGreen;
            this.label15.Location = new System.Drawing.Point(248, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Function 06 (Write single Register)";
            // 
            // buttonWriteHoldingRegisters
            // 
            this.buttonWriteHoldingRegisters.Location = new System.Drawing.Point(39, 131);
            this.buttonWriteHoldingRegisters.Name = "buttonWriteHoldingRegisters";
            this.buttonWriteHoldingRegisters.Size = new System.Drawing.Size(137, 23);
            this.buttonWriteHoldingRegisters.TabIndex = 34;
            this.buttonWriteHoldingRegisters.Text = "Write Holding Registers";
            this.buttonWriteHoldingRegisters.UseVisualStyleBackColor = true;
            this.buttonWriteHoldingRegisters.Click += new System.EventHandler(this.buttonWriteHoldingRegisters_Click);
            // 
            // textBoxHoldingRegsWrite
            // 
            this.textBoxHoldingRegsWrite.Location = new System.Drawing.Point(23, 27);
            this.textBoxHoldingRegsWrite.Name = "textBoxHoldingRegsWrite";
            this.textBoxHoldingRegsWrite.Size = new System.Drawing.Size(63, 20);
            this.textBoxHoldingRegsWrite.TabIndex = 35;
            this.textBoxHoldingRegsWrite.TextChanged += new System.EventHandler(this.textBoxHoldingRegsWrite_TextChanged);
            // 
            // textBoxHoldingRegsDecWrite
            // 
            this.textBoxHoldingRegsDecWrite.Location = new System.Drawing.Point(23, 53);
            this.textBoxHoldingRegsDecWrite.Name = "textBoxHoldingRegsDecWrite";
            this.textBoxHoldingRegsDecWrite.ReadOnly = true;
            this.textBoxHoldingRegsDecWrite.Size = new System.Drawing.Size(63, 20);
            this.textBoxHoldingRegsDecWrite.TabIndex = 36;
            // 
            // textBoxRegValue_00
            // 
            this.textBoxRegValue_00.Location = new System.Drawing.Point(113, 27);
            this.textBoxRegValue_00.Name = "textBoxRegValue_00";
            this.textBoxRegValue_00.Size = new System.Drawing.Size(63, 20);
            this.textBoxRegValue_00.TabIndex = 37;
            this.textBoxRegValue_00.TextChanged += new System.EventHandler(this.textBoxRegValue_00_TextChanged);
            // 
            // textBoxRegValue_01
            // 
            this.textBoxRegValue_01.Location = new System.Drawing.Point(113, 53);
            this.textBoxRegValue_01.Name = "textBoxRegValue_01";
            this.textBoxRegValue_01.Size = new System.Drawing.Size(63, 20);
            this.textBoxRegValue_01.TabIndex = 38;
            this.textBoxRegValue_01.TextChanged += new System.EventHandler(this.textBoxRegValue_01_TextChanged);
            // 
            // textBoxRegValue_02
            // 
            this.textBoxRegValue_02.Location = new System.Drawing.Point(113, 79);
            this.textBoxRegValue_02.Name = "textBoxRegValue_02";
            this.textBoxRegValue_02.Size = new System.Drawing.Size(63, 20);
            this.textBoxRegValue_02.TabIndex = 39;
            this.textBoxRegValue_02.TextChanged += new System.EventHandler(this.textBoxRegValue_02_TextChanged);
            // 
            // textBoxRegValue_03
            // 
            this.textBoxRegValue_03.Location = new System.Drawing.Point(113, 105);
            this.textBoxRegValue_03.Name = "textBoxRegValue_03";
            this.textBoxRegValue_03.Size = new System.Drawing.Size(63, 20);
            this.textBoxRegValue_03.TabIndex = 40;
            this.textBoxRegValue_03.TextChanged += new System.EventHandler(this.textBoxRegValue_03_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(179, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "(00)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(179, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "(01)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(179, 82);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "(02)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(179, 108);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "(03)";
            // 
            // numericUpDownWriteRegsCount
            // 
            this.numericUpDownWriteRegsCount.Location = new System.Drawing.Point(37, 101);
            this.numericUpDownWriteRegsCount.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownWriteRegsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWriteRegsCount.Name = "numericUpDownWriteRegsCount";
            this.numericUpDownWriteRegsCount.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownWriteRegsCount.TabIndex = 45;
            this.numericUpDownWriteRegsCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.buttonWriteHoldingRegisters);
            this.panel5.Controls.Add(this.textBoxHoldingRegsWrite);
            this.panel5.Controls.Add(this.textBoxHoldingRegsDecWrite);
            this.panel5.Controls.Add(this.numericUpDownWriteRegsCount);
            this.panel5.Controls.Add(this.textBoxRegValue_03);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.textBoxRegValue_02);
            this.panel5.Controls.Add(this.textBoxRegValue_01);
            this.panel5.Controls.Add(this.textBoxRegValue_00);
            this.panel5.Location = new System.Drawing.Point(502, 271);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(233, 157);
            this.panel5.TabIndex = 46;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(36, 86);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 47;
            this.label22.Text = "RegCount";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(110, 11);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "Register (4 Hex)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 11);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Address (4 Hex)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.LightGreen;
            this.label23.Location = new System.Drawing.Point(499, 255);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(182, 13);
            this.label23.TabIndex = 47;
            this.label23.Text = "Function 10 (Write multiple Registers)";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label28);
            this.panel6.Controls.Add(this.textBoxReadInputRegisters_1);
            this.panel6.Controls.Add(this.label24);
            this.panel6.Controls.Add(this.buttonReadInputRegisters);
            this.panel6.Controls.Add(this.label25);
            this.panel6.Controls.Add(this.textBoxReadInputRegisters);
            this.panel6.Controls.Add(this.numericUpDownRegsCount2);
            this.panel6.Controls.Add(this.label26);
            this.panel6.Controls.Add(this.textBoxInputRegsRead);
            this.panel6.Controls.Add(this.textBoxInputRegsDecAddressRead);
            this.panel6.Location = new System.Drawing.Point(15, 271);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(231, 196);
            this.panel6.TabIndex = 48;
            // 
            // textBoxReadInputRegisters_1
            // 
            this.textBoxReadInputRegisters_1.Location = new System.Drawing.Point(16, 119);
            this.textBoxReadInputRegisters_1.Name = "textBoxReadInputRegisters_1";
            this.textBoxReadInputRegisters_1.ReadOnly = true;
            this.textBoxReadInputRegisters_1.Size = new System.Drawing.Size(63, 20);
            this.textBoxReadInputRegisters_1.TabIndex = 26;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(13, 8);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(111, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "Address (4 Hex Digits)";
            // 
            // buttonReadInputRegisters
            // 
            this.buttonReadInputRegisters.Location = new System.Drawing.Point(26, 145);
            this.buttonReadInputRegisters.Name = "buttonReadInputRegisters";
            this.buttonReadInputRegisters.Size = new System.Drawing.Size(152, 39);
            this.buttonReadInputRegisters.TabIndex = 17;
            this.buttonReadInputRegisters.Text = "Read Input Registers";
            this.buttonReadInputRegisters.UseVisualStyleBackColor = true;
            this.buttonReadInputRegisters.Click += new System.EventHandler(this.buttonReadInputRegister_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(126, 41);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 23;
            this.label25.Text = "Regs Count";
            // 
            // textBoxReadInputRegisters
            // 
            this.textBoxReadInputRegisters.Location = new System.Drawing.Point(16, 93);
            this.textBoxReadInputRegisters.Name = "textBoxReadInputRegisters";
            this.textBoxReadInputRegisters.Size = new System.Drawing.Size(152, 20);
            this.textBoxReadInputRegisters.TabIndex = 18;
            // 
            // numericUpDownRegsCount2
            // 
            this.numericUpDownRegsCount2.Location = new System.Drawing.Point(129, 60);
            this.numericUpDownRegsCount2.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownRegsCount2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRegsCount2.Name = "numericUpDownRegsCount2";
            this.numericUpDownRegsCount2.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownRegsCount2.TabIndex = 22;
            this.numericUpDownRegsCount2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(13, 73);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 13);
            this.label26.TabIndex = 19;
            this.label26.Text = "Result";
            // 
            // textBoxInputRegsRead
            // 
            this.textBoxInputRegsRead.Location = new System.Drawing.Point(16, 24);
            this.textBoxInputRegsRead.Name = "textBoxInputRegsRead";
            this.textBoxInputRegsRead.Size = new System.Drawing.Size(63, 20);
            this.textBoxInputRegsRead.TabIndex = 20;
            this.textBoxInputRegsRead.TextChanged += new System.EventHandler(this.textBoxInputRegsRead_TextChanged);
            // 
            // textBoxInputRegsDecAddressRead
            // 
            this.textBoxInputRegsDecAddressRead.Location = new System.Drawing.Point(16, 50);
            this.textBoxInputRegsDecAddressRead.Name = "textBoxInputRegsDecAddressRead";
            this.textBoxInputRegsDecAddressRead.ReadOnly = true;
            this.textBoxInputRegsDecAddressRead.Size = new System.Drawing.Size(63, 20);
            this.textBoxInputRegsDecAddressRead.TabIndex = 21;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.LightGreen;
            this.label27.Location = new System.Drawing.Point(15, 255);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(197, 13);
            this.label27.TabIndex = 49;
            this.label27.Text = "Function 04 (Read 1 or 2 Input Register)";
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.Location = new System.Drawing.Point(12, 9);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(55, 13);
            this.labelComPort.TabIndex = 50;
            this.labelComPort.Text = "Serial Port";
            // 
            // textBoxComPort
            // 
            this.textBoxComPort.Location = new System.Drawing.Point(73, 6);
            this.textBoxComPort.Name = "textBoxComPort";
            this.textBoxComPort.ReadOnly = true;
            this.textBoxComPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxComPort.TabIndex = 51;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label34);
            this.panel7.Controls.Add(this.label33);
            this.panel7.Controls.Add(this.label32);
            this.panel7.Controls.Add(this.label31);
            this.panel7.Controls.Add(this.label30);
            this.panel7.Controls.Add(this.label29);
            this.panel7.Controls.Add(this.buttonRoundTest);
            this.panel7.Controls.Add(this.textBoxFloatTestInput);
            this.panel7.Controls.Add(this.textBoxFloatTestResult);
            this.panel7.Location = new System.Drawing.Point(440, 467);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(233, 157);
            this.panel7.TabIndex = 52;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(18, 8);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(81, 13);
            this.label29.TabIndex = 29;
            this.label29.Text = "Float Test Input";
            // 
            // buttonRoundTest
            // 
            this.buttonRoundTest.Location = new System.Drawing.Point(55, 129);
            this.buttonRoundTest.Name = "buttonRoundTest";
            this.buttonRoundTest.Size = new System.Drawing.Size(133, 23);
            this.buttonRoundTest.TabIndex = 25;
            this.buttonRoundTest.Text = "Round Test";
            this.buttonRoundTest.UseVisualStyleBackColor = true;
            this.buttonRoundTest.Click += new System.EventHandler(this.buttonRoundTest_Click);
            // 
            // textBoxFloatTestInput
            // 
            this.textBoxFloatTestInput.Location = new System.Drawing.Point(63, 77);
            this.textBoxFloatTestInput.Name = "textBoxFloatTestInput";
            this.textBoxFloatTestInput.Size = new System.Drawing.Size(159, 20);
            this.textBoxFloatTestInput.TabIndex = 27;
            // 
            // textBoxFloatTestResult
            // 
            this.textBoxFloatTestResult.Location = new System.Drawing.Point(63, 103);
            this.textBoxFloatTestResult.Name = "textBoxFloatTestResult";
            this.textBoxFloatTestResult.ReadOnly = true;
            this.textBoxFloatTestResult.Size = new System.Drawing.Size(159, 20);
            this.textBoxFloatTestResult.TabIndex = 28;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(90, 126);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(87, 13);
            this.label28.TabIndex = 53;
            this.label28.Text = "(2 Regs as Float)";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(18, 30);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(133, 13);
            this.label30.TabIndex = 30;
            this.label30.Text = "(For Tests: converts a float";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(20, 43);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(121, 13);
            this.label31.TabIndex = 31;
            this.label31.Text = "into its 4 Byte Equvalent";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(20, 56);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(98, 13);
            this.label32.TabIndex = 32;
            this.label32.Text = "and back in a float)";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(18, 80);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(31, 13);
            this.label33.TabIndex = 33;
            this.label33.Text = "Input";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(20, 106);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(37, 13);
            this.label34.TabIndex = 34;
            this.label34.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 654);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.textBoxComPort);
            this.Controls.Add(this.labelComPort);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddress);
            this.Name = "Form1";
            this.Text = "RoSchmi\'s Modbus Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoilCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegsCount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWriteRegsCount)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegsCount2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSendCoil;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button buttonReadCoi;
        private System.Windows.Forms.TextBox textBoxCoilAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonOn;
        private System.Windows.Forms.RadioButton radioButtonOff;
        private System.Windows.Forms.TextBox textBoxCoilDecAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxCoilDecAddressRead;
        private System.Windows.Forms.TextBox textBoxCoilAddressRead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxReadResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonReadHoldingRegisters;
        private System.Windows.Forms.TextBox textBoxReadHoldingRegisters;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHoldingRegsRead;
        private System.Windows.Forms.TextBox textBoxHoldingRegsDecAddressRead;
        private System.Windows.Forms.NumericUpDown numericUpDownRegsCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonWriteSingleRegister;
        private System.Windows.Forms.TextBox textBoxRegWriteValue;
        private System.Windows.Forms.TextBox textBoxRegisterAddress;
        private System.Windows.Forms.TextBox textBoxRegisterDecAddress;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonWriteHoldingRegisters;
        private System.Windows.Forms.TextBox textBoxHoldingRegsWrite;
        private System.Windows.Forms.TextBox textBoxHoldingRegsDecWrite;
        private System.Windows.Forms.TextBox textBoxRegValue_00;
        private System.Windows.Forms.TextBox textBoxRegValue_01;
        private System.Windows.Forms.TextBox textBoxRegValue_02;
        private System.Windows.Forms.TextBox textBoxRegValue_03;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numericUpDownWriteRegsCount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown numericUpDownCoilCount;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button buttonReadInputRegisters;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBoxReadInputRegisters;
        private System.Windows.Forms.NumericUpDown numericUpDownRegsCount2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxInputRegsRead;
        private System.Windows.Forms.TextBox textBoxInputRegsDecAddressRead;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.TextBox textBoxComPort;
        private System.Windows.Forms.TextBox textBoxReadInputRegisters_1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button buttonRoundTest;
        private System.Windows.Forms.TextBox textBoxFloatTestInput;
        private System.Windows.Forms.TextBox textBoxFloatTestResult;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
    }
}

