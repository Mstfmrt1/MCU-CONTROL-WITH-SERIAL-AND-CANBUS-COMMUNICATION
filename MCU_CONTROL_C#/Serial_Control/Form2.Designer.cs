namespace Serial_Control
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CboxSTOPBIT = new System.Windows.Forms.ComboBox();
            this.CboxPARITYBITS = new System.Windows.Forms.ComboBox();
            this.CboxDATA = new System.Windows.Forms.ComboBox();
            this.CboxBAUD = new System.Windows.Forms.ComboBox();
            this.CboxCOMPORT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxRTS = new System.Windows.Forms.CheckBox();
            this.checkBoxDTR = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBoxAddtoOldData = new System.Windows.Forms.CheckBox();
            this.labelDataInLength = new System.Windows.Forms.Label();
            this.checkBoxAlwaysUpdate = new System.Windows.Forms.CheckBox();
            this.buttonClearDataIn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDataIn = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxWriteline = new System.Windows.Forms.CheckBox();
            this.checkBoxWrite = new System.Windows.Forms.CheckBox();
            this.dataoutlengthlabel = new System.Windows.Forms.Label();
            this.btnClearData = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSendData = new System.Windows.Forms.Button();
            this.textboxDataout = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.HighButton = new System.Windows.Forms.Button();
            this.LowButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // CboxSTOPBIT
            // 
            this.CboxSTOPBIT.FormattingEnabled = true;
            this.CboxSTOPBIT.Items.AddRange(new object[] {
            "One ",
            "Two"});
            this.CboxSTOPBIT.Location = new System.Drawing.Point(164, 196);
            this.CboxSTOPBIT.Name = "CboxSTOPBIT";
            this.CboxSTOPBIT.Size = new System.Drawing.Size(121, 28);
            this.CboxSTOPBIT.TabIndex = 8;
            this.CboxSTOPBIT.Text = "One";
            // 
            // CboxPARITYBITS
            // 
            this.CboxPARITYBITS.FormattingEnabled = true;
            this.CboxPARITYBITS.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.CboxPARITYBITS.Location = new System.Drawing.Point(164, 242);
            this.CboxPARITYBITS.Name = "CboxPARITYBITS";
            this.CboxPARITYBITS.Size = new System.Drawing.Size(121, 28);
            this.CboxPARITYBITS.TabIndex = 7;
            this.CboxPARITYBITS.Text = "None";
            // 
            // CboxDATA
            // 
            this.CboxDATA.FormattingEnabled = true;
            this.CboxDATA.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.CboxDATA.Location = new System.Drawing.Point(164, 145);
            this.CboxDATA.Name = "CboxDATA";
            this.CboxDATA.Size = new System.Drawing.Size(121, 28);
            this.CboxDATA.TabIndex = 6;
            this.CboxDATA.Text = "8";
            // 
            // CboxBAUD
            // 
            this.CboxBAUD.FormattingEnabled = true;
            this.CboxBAUD.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.CboxBAUD.Location = new System.Drawing.Point(164, 98);
            this.CboxBAUD.Name = "CboxBAUD";
            this.CboxBAUD.Size = new System.Drawing.Size(121, 28);
            this.CboxBAUD.TabIndex = 5;
            this.CboxBAUD.Text = "9600";
            // 
            // CboxCOMPORT
            // 
            this.CboxCOMPORT.FormattingEnabled = true;
            this.CboxCOMPORT.Location = new System.Drawing.Point(164, 48);
            this.CboxCOMPORT.Name = "CboxCOMPORT";
            this.CboxCOMPORT.Size = new System.Drawing.Size(121, 28);
            this.CboxCOMPORT.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM PORT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxRTS);
            this.groupBox1.Controls.Add(this.checkBoxDTR);
            this.groupBox1.Controls.Add(this.CboxSTOPBIT);
            this.groupBox1.Controls.Add(this.CboxPARITYBITS);
            this.groupBox1.Controls.Add(this.CboxDATA);
            this.groupBox1.Controls.Add(this.CboxBAUD);
            this.groupBox1.Controls.Add(this.CboxCOMPORT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 330);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM PORT SPECIFICATION";
            // 
            // checkBoxRTS
            // 
            this.checkBoxRTS.AutoSize = true;
            this.checkBoxRTS.Location = new System.Drawing.Point(180, 301);
            this.checkBoxRTS.Name = "checkBoxRTS";
            this.checkBoxRTS.Size = new System.Drawing.Size(135, 24);
            this.checkBoxRTS.TabIndex = 10;
            this.checkBoxRTS.Text = "RTS ENABLE";
            this.checkBoxRTS.UseVisualStyleBackColor = true;
            this.checkBoxRTS.CheckedChanged += new System.EventHandler(this.checkBoxRTS_CheckedChanged);
            // 
            // checkBoxDTR
            // 
            this.checkBoxDTR.AutoSize = true;
            this.checkBoxDTR.Location = new System.Drawing.Point(6, 301);
            this.checkBoxDTR.Name = "checkBoxDTR";
            this.checkBoxDTR.Size = new System.Drawing.Size(136, 24);
            this.checkBoxDTR.TabIndex = 9;
            this.checkBoxDTR.Text = "DTR ENABLE";
            this.checkBoxDTR.UseVisualStyleBackColor = true;
            this.checkBoxDTR.CheckedChanged += new System.EventHandler(this.checkBoxDTR_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(13, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 191);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Statuslabel);
            this.groupBox7.Location = new System.Drawing.Point(134, 9);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(181, 84);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "COM PORT STATUS";
            // 
            // Statuslabel
            // 
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Statuslabel.Location = new System.Drawing.Point(58, 36);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(52, 35);
            this.Statuslabel.TabIndex = 5;
            this.Statuslabel.Text = "OFF";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 127);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(309, 39);
            this.progressBar1.TabIndex = 2;
            
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(6, 54);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.Location = new System.Drawing.Point(6, 9);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(114, 39);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBoxAddtoOldData);
            this.groupBox6.Controls.Add(this.labelDataInLength);
            this.groupBox6.Controls.Add(this.checkBoxAlwaysUpdate);
            this.groupBox6.Controls.Add(this.buttonClearDataIn);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.textBoxDataIn);
            this.groupBox6.Location = new System.Drawing.Point(340, 254);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(303, 230);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "RECEIVER CONTROL";
            // 
            // checkBoxAddtoOldData
            // 
            this.checkBoxAddtoOldData.AutoSize = true;
            this.checkBoxAddtoOldData.Location = new System.Drawing.Point(143, 112);
            this.checkBoxAddtoOldData.Name = "checkBoxAddtoOldData";
            this.checkBoxAddtoOldData.Size = new System.Drawing.Size(149, 24);
            this.checkBoxAddtoOldData.TabIndex = 1;
            this.checkBoxAddtoOldData.Text = "Add to Old Data";
            this.checkBoxAddtoOldData.UseVisualStyleBackColor = true;
            this.checkBoxAddtoOldData.CheckedChanged += new System.EventHandler(this.checkBoxAddtoOldData_CheckedChanged);
            // 
            // labelDataInLength
            // 
            this.labelDataInLength.AutoSize = true;
            this.labelDataInLength.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataInLength.Location = new System.Drawing.Point(116, 187);
            this.labelDataInLength.Name = "labelDataInLength";
            this.labelDataInLength.Size = new System.Drawing.Size(45, 35);
            this.labelDataInLength.TabIndex = 1;
            this.labelDataInLength.Text = "00";
            // 
            // checkBoxAlwaysUpdate
            // 
            this.checkBoxAlwaysUpdate.AutoSize = true;
            this.checkBoxAlwaysUpdate.Location = new System.Drawing.Point(143, 82);
            this.checkBoxAlwaysUpdate.Name = "checkBoxAlwaysUpdate";
            this.checkBoxAlwaysUpdate.Size = new System.Drawing.Size(141, 24);
            this.checkBoxAlwaysUpdate.TabIndex = 0;
            this.checkBoxAlwaysUpdate.Text = "Always Update";
            this.checkBoxAlwaysUpdate.UseVisualStyleBackColor = true;
            this.checkBoxAlwaysUpdate.CheckedChanged += new System.EventHandler(this.checkBoxAlwaysUpdate_CheckedChanged);
            // 
            // buttonClearDataIn
            // 
            this.buttonClearDataIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClearDataIn.Location = new System.Drawing.Point(12, 82);
            this.buttonClearDataIn.Name = "buttonClearDataIn";
            this.buttonClearDataIn.Size = new System.Drawing.Size(125, 66);
            this.buttonClearDataIn.TabIndex = 3;
            this.buttonClearDataIn.Text = "CLEAR DATA IN";
            this.buttonClearDataIn.UseVisualStyleBackColor = true;
            this.buttonClearDataIn.Click += new System.EventHandler(this.buttonClearDataIn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 35);
            this.label8.TabIndex = 0;
            this.label8.Text = "DATA IN LENGTH ";
            // 
            // textBoxDataIn
            // 
            this.textBoxDataIn.Location = new System.Drawing.Point(12, 25);
            this.textBoxDataIn.Multiline = true;
            this.textBoxDataIn.Name = "textBoxDataIn";
            this.textBoxDataIn.Size = new System.Drawing.Size(272, 51);
            this.textBoxDataIn.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxWriteline);
            this.groupBox3.Controls.Add(this.checkBoxWrite);
            this.groupBox3.Controls.Add(this.dataoutlengthlabel);
            this.groupBox3.Controls.Add(this.btnClearData);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnSendData);
            this.groupBox3.Controls.Add(this.textboxDataout);
            this.groupBox3.Location = new System.Drawing.Point(340, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 236);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TRANSMITTER CONTROL";
            // 
            // checkBoxWriteline
            // 
            this.checkBoxWriteline.AutoSize = true;
            this.checkBoxWriteline.Location = new System.Drawing.Point(149, 132);
            this.checkBoxWriteline.Name = "checkBoxWriteline";
            this.checkBoxWriteline.Size = new System.Drawing.Size(102, 24);
            this.checkBoxWriteline.TabIndex = 2;
            this.checkBoxWriteline.Text = "WriteLine";
            this.checkBoxWriteline.UseVisualStyleBackColor = true;
            this.checkBoxWriteline.CheckedChanged += new System.EventHandler(this.checkBoxWriteline_CheckedChanged);
            // 
            // checkBoxWrite
            // 
            this.checkBoxWrite.AutoSize = true;
            this.checkBoxWrite.Location = new System.Drawing.Point(12, 132);
            this.checkBoxWrite.Name = "checkBoxWrite";
            this.checkBoxWrite.Size = new System.Drawing.Size(72, 24);
            this.checkBoxWrite.TabIndex = 3;
            this.checkBoxWrite.Text = "Write";
            this.checkBoxWrite.UseVisualStyleBackColor = true;
            this.checkBoxWrite.CheckedChanged += new System.EventHandler(this.checkBoxWrite_CheckedChanged);
            // 
            // dataoutlengthlabel
            // 
            this.dataoutlengthlabel.AutoSize = true;
            this.dataoutlengthlabel.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataoutlengthlabel.Location = new System.Drawing.Point(116, 189);
            this.dataoutlengthlabel.Name = "dataoutlengthlabel";
            this.dataoutlengthlabel.Size = new System.Drawing.Size(45, 35);
            this.dataoutlengthlabel.TabIndex = 1;
            this.dataoutlengthlabel.Text = "00";
            // 
            // btnClearData
            // 
            this.btnClearData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearData.Location = new System.Drawing.Point(149, 82);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(125, 44);
            this.btnClearData.TabIndex = 3;
            this.btnClearData.Text = "CLEAR DATA OUT";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "DATA OUT LENGTH ";
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(12, 82);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(125, 44);
            this.btnSendData.TabIndex = 2;
            this.btnSendData.Text = "SEND DATA";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // textboxDataout
            // 
            this.textboxDataout.Location = new System.Drawing.Point(12, 25);
            this.textboxDataout.Multiline = true;
            this.textboxDataout.Name = "textboxDataout";
            this.textboxDataout.Size = new System.Drawing.Size(262, 51);
            this.textboxDataout.TabIndex = 3;
            this.textboxDataout.TextChanged += new System.EventHandler(this.textboxDataout_TextChanged);
            this.textboxDataout.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxDataout_KeyDown);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.trackBar1);
            this.groupBox4.Location = new System.Drawing.Point(673, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(401, 179);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PWM CONTROL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(171, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 35);
            this.label9.TabIndex = 9;
            this.label9.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 35);
            this.label7.TabIndex = 9;
            this.label7.Text = "PWM VALUE";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 42);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(386, 69);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(21, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 35);
            this.label12.TabIndex = 11;
            this.label12.Text = "IN1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(21, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 35);
            this.label13.TabIndex = 12;
            this.label13.Text = "IN2";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(673, 212);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(401, 148);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ANALOG INPUT";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(238, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 26);
            this.textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 26);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 26);
            this.textBox1.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(263, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 35);
            this.label14.TabIndex = 15;
            // 
            // HighButton
            // 
            this.HighButton.Location = new System.Drawing.Point(6, 37);
            this.HighButton.Name = "HighButton";
            this.HighButton.Size = new System.Drawing.Size(148, 50);
            this.HighButton.TabIndex = 16;
            this.HighButton.Text = "OUT HIGH";
            this.HighButton.UseVisualStyleBackColor = true;
            this.HighButton.Click += new System.EventHandler(this.HighButton_Click_1);
            // 
            // LowButton
            // 
            this.LowButton.Location = new System.Drawing.Point(202, 37);
            this.LowButton.Name = "LowButton";
            this.LowButton.Size = new System.Drawing.Size(148, 50);
            this.LowButton.TabIndex = 17;
            this.LowButton.Text = "OUT LOW";
            this.LowButton.UseVisualStyleBackColor = true;
            this.LowButton.Click += new System.EventHandler(this.LowButton_Click_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 94);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(137, 24);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "YELLOW LED";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(202, 94);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 24);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "RED LED";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 124);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(116, 24);
            this.radioButton3.TabIndex = 20;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "BLUE RED";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(202, 124);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(113, 24);
            this.radioButton4.TabIndex = 21;
            this.radioButton4.Text = "BLUE LED";
            this.radioButton4.UseVisualStyleBackColor = true;
            
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.HighButton);
            this.groupBox8.Controls.Add(this.radioButton4);
            this.groupBox8.Controls.Add(this.LowButton);
            this.groupBox8.Controls.Add(this.radioButton3);
            this.groupBox8.Controls.Add(this.radioButton1);
            this.groupBox8.Controls.Add(this.radioButton2);
            this.groupBox8.Location = new System.Drawing.Point(674, 366);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(391, 173);
            this.groupBox8.TabIndex = 22;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "LED STATUS";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 546);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "SERIAL CONTROL UNIT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CboxSTOPBIT;
        private System.Windows.Forms.ComboBox CboxPARITYBITS;
        private System.Windows.Forms.ComboBox CboxDATA;
        private System.Windows.Forms.ComboBox CboxBAUD;
        private System.Windows.Forms.ComboBox CboxCOMPORT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxRTS;
        private System.Windows.Forms.CheckBox checkBoxDTR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label Statuslabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBoxAddtoOldData;
        private System.Windows.Forms.Label labelDataInLength;
        private System.Windows.Forms.CheckBox checkBoxAlwaysUpdate;
        private System.Windows.Forms.Button buttonClearDataIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDataIn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxWriteline;
        private System.Windows.Forms.CheckBox checkBoxWrite;
        private System.Windows.Forms.Label dataoutlengthlabel;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox textboxDataout;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button HighButton;
        private System.Windows.Forms.Button LowButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
    }
}

