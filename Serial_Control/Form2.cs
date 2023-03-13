using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using PCANDevice;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace Serial_Control
{
    public partial class Form2 : Form
    {
        string[] ports = SerialPort.GetPortNames();
        string sendWith;
        string DataIn;
        string DataOut;
        

 

        public Form2()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {



            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

            foreach (string port in ports)
                CboxCOMPORT.Items.Add(port);
            CboxCOMPORT.SelectedIndex = 0;

            btnOpen.Enabled = true;
            btnClose.Enabled = false;

            checkBoxDTR.Checked = false;
            serialPort1.DtrEnable = false;

            checkBoxRTS.Checked = false;
            serialPort1.RtsEnable = false;

            btnSendData.Enabled = false;
            checkBoxWrite.Checked = true;
            checkBoxWriteline.Checked = false;
            sendWith = "Write";
            checkBoxAddtoOldData.Checked = true;
            checkBoxAlwaysUpdate.Checked = false;

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = CboxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(CboxBAUD.Text);
                serialPort1.DataBits = Convert.ToInt32(CboxDATA.Text);
                // try to convert the string to an enum. 
                // cbox argument is a span containing the name or value to convert.
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CboxSTOPBIT.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), CboxPARITYBITS.Text);
                serialPort1.Open();
                progressBar1.Value = 100;
                btnSendData.Enabled = true;
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                Statuslabel.Text = "ON";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                Statuslabel.Text = "OFF";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                Statuslabel.Text = "OFF";
                serialPort1.DiscardInBuffer();
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();

            }
        }
        int pwm;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pwm = trackBar1.Value;
            trackBar1.Minimum = 0;
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
            
            label9.Text = Convert.ToString(pwm);
            if (serialPort1.IsOpen)
            {
                byte[] b = BitConverter.GetBytes(pwm);//It will assign the pwm variable to the byte array as 1 byte.
                serialPort1.Write("P");
                serialPort1.Write(b, 0, 1);//Sending array b as 1 elements from offset 0
                

            }

        }



        private void btnSendData_Click(object sender, EventArgs e)
        {
            DataOut = textboxDataout.Text;
            if (serialPort1.IsOpen)
            {
                try
                {
                    if (textboxDataout.Text != "")
                    {
                        if (sendWith == "Write")
                        {
                            serialPort1.Write(DataOut);
                        }
                        else if (sendWith == "WriteLine")
                        {
                            serialPort1.WriteLine(DataOut);
                        }
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            if (textboxDataout.Text != "")

            {
                textboxDataout.Clear();
            }
        }



        private void checkBoxDTR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDTR.Checked)
            {
                serialPort1.DtrEnable = true;
                MessageBox.Show("DTR ENABLE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                serialPort1.DtrEnable = false;
        }

        private void checkBoxRTS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRTS.Checked)
            {
                serialPort1.RtsEnable = true;
                MessageBox.Show("RTS ENABLE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                serialPort1.RtsEnable = false;
        }
        int dataout_length;
        private void textboxDataout_TextChanged(object sender, EventArgs e)
        {
            dataout_length = textboxDataout.TextLength;
            dataoutlengthlabel.Text = Convert.ToString(dataout_length);
            textboxDataout.Text = textboxDataout.Text.Replace(Environment.CommandLine, "");

        }

        private void textboxDataout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (serialPort1.IsOpen)
                {
                    DataOut = textboxDataout.Text;
                    if (sendWith == "Write")
                        serialPort1.Write(DataOut);
                    else if (sendWith == "WriteLine")
                        serialPort1.WriteLine(DataOut);
                }
            }
        }
        private void checkBoxWrite_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWrite.Checked)
            {
                sendWith = "Write";
                checkBoxWriteline.Checked = false;
                checkBoxWrite.Checked = true;
            }
        }

        private void checkBoxWriteline_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWriteline.Checked)
            {
                sendWith = "WriteLine";
                checkBoxWriteline.Checked = true;
                checkBoxWrite.Checked = false;
            }
        }

        private void buttonClearDataIn_Click(object sender, EventArgs e)
        {
            if (textBoxDataIn.Text != "")
            {
                textBoxDataIn.Clear();
            }
        }

        private void checkBoxAlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAlwaysUpdate.Checked)
            {
                checkBoxAlwaysUpdate.Checked = true;
                checkBoxAddtoOldData.Checked = false;

            }
            else { checkBoxAddtoOldData.Checked = true; }
        }

        private void checkBoxAddtoOldData_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAddtoOldData.Checked)
            {
                checkBoxAddtoOldData.Checked = true;
                checkBoxAlwaysUpdate.Checked = false;
            }
            else { checkBoxAlwaysUpdate.Checked = true; }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            DataIn = serialPort1.ReadLine();
            int Datainlength = DataIn.Length;
            labelDataInLength.Text = Datainlength.ToString();

            if (checkBoxAlwaysUpdate.Checked)
            {
                textBoxDataIn.Text = DataIn;
            }
            else if (checkBoxAddtoOldData.Checked)
            {
                textBoxDataIn.Text += DataIn;
            }
            
            /*string [] splitted_data = DataIn.Split('-');
            if(splitted_data.Length>=2)
            {
                textBox3.Text = DataIn;
                textBox1.Text = splitted_data[0] + "mV";
                textBox2.Text = splitted_data[1] + "mV";
                //serialPort1.DiscardInBuffer();
            }*/
           
            

        }




        private void HighButton_Click_1(object sender, EventArgs e)
        {
            HighButton.BackColor = Color.Green;
            LowButton.BackColor = Color.Red;

            if (radioButton1.Checked)
            {
                serialPort1.Write("H1");
            }
            else if (radioButton2.Checked)
            {
                serialPort1.Write("H2");

            }

            else if (radioButton3.Checked)
            {
                serialPort1.Write("H3");
            }

            else if (radioButton4.Checked)
            {
                serialPort1.Write("H4");
            }
        }

        private void LowButton_Click_1(object sender, EventArgs e)
        {
            LowButton.BackColor = Color.Green;
            HighButton.BackColor = Color.Red;
            if (radioButton1.Checked)
            {
                serialPort1.Write("L1");
            }
            else if (radioButton2.Checked)
            {
                serialPort1.Write("L2");

            }

            else if (radioButton3.Checked)
            {
                serialPort1.Write("L3");
            }

            else if (radioButton4.Checked)
            {
                serialPort1.Write("L4");
            }
        }


    }
}



