using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCANDevice;
using System.Threading;
using System.Diagnostics;
using System.Runtime;

namespace Serial_Control
{
    public partial class Form3 : Form
    {
        public static bool sendflag = false;
        public static bool sendflagRe = false;
        public static bool sendpwmflag = false;
        public static string INP1Text = "LOW";
        public static string INP1Color = "";
        public static string INP2Text = "LOW";
        public static string INP2Color = "";
        public static string INP3Text = "LOW";
        public static string INP3Color = "";

        public static int AINP1Text = 0;
        public static int AINP2Text = 0;
        public static int AINP3Text = 0;
        public static int AINP4Text = 0;
        

        private Thread readThread;
        List<ushort> interfaces = PCANDevice.PCANManager.GetAllAvailable();
        PCANDevice.PCANManager pcan = new PCANDevice.PCANManager();

        public Form3()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            try
            {
                pcan.Connect(interfaces[0], PCANDevice.TPCANBaudrate.PCAN_BAUD_250K);
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show("PCAN MEVCUT DEĞİL!", "HATA", buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK || result == DialogResult.Cancel)
                {
                    System.Environment.Exit(1);
                }
            }

            InitializeComponent();
            //pcan.AddReceiveCallback(callback);

            readThread = new Thread(new ThreadStart(startCallback));
            readThread.Start();
            //pcan.SendFrame(1, 8, new byte[] { 0, 1, 2, 3, 4, 5, 6, 7 });
            //pcan.SendFrameExt(0x7ff1, 8, new byte[] { 0, 1, 2, 3, 4, 5, 6, 7 });
            pcan.ActivateAutoReceive();
        }
        public void startCallback()
        {
            pcan.AddReceiveCallback(callback);
        }
        public void startReceive()
        {
            pcan.ActivateAutoReceive();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //INP1
            
            if (INP1Color == "OrangeRed")
                radioButtonINP1.BackColor = Color.OrangeRed;
            else if (INP1Color == "LightGreen")
                radioButtonINP1.BackColor = Color.LightGreen;

            //INP2
            
            if (INP2Color == "OrangeRed")
                radioButtonINP2.BackColor = Color.OrangeRed;
            else if (INP1Color == "LightGreen")
                radioButtonINP2.BackColor = Color.LightGreen;

            //INP3
            
            if (INP3Color == "OrangeRed")
                radioButtonINP3.BackColor = Color.OrangeRed;
            else if (INP1Color == "LightGreen")
                radioButtonINP3.BackColor = Color.LightGreen;


            /// AINP1
            textBoxAINP1.Text = AINP1Text.ToString();
            labelAINP11.Text = Convert.ToString(AINP1Text) + " mV";

            /// AINP2
            textBoxAINP2.Text = AINP2Text.ToString();
            labelAINP22.Text = Convert.ToString(AINP2Text) + " mV";
        }
        public static int callback(object[] args)
        {
            TPCANMsg msg = (TPCANMsg)args[0];
            string msgID = Convert.ToString(msg.ID.ToString("X")); // convert to decimal 
            Debug.WriteLine(Convert.ToString(msg.ID.ToString("X")).PadLeft(8, '0'));
            Debug.WriteLine(BitConverter.ToString(msg.DATA));



            if (msgID == "502")
            {

                int x = 0;
                //string msgdata0 = Convert.ToString(msg.DATA[0]);

                string msgdata0 = Convert.ToString(msg.DATA[0].ToString("X"));
                string msgdata1 = Convert.ToString(msg.DATA[1].ToString("X"));
                string msgdata2 = Convert.ToString(msg.DATA[2].ToString("X"));
                int byte0 = Convert.ToInt32(msgdata0, 16);
                int byte1 = Convert.ToInt32(msgdata1, 16);
                int byte2 = Convert.ToInt32(msgdata2, 16);

                AINP3Text = byte1;
                AINP4Text = byte2;


                int mask = 0b_00000001;

                /// read INP1,INP2,INP3 WITH MASK 
                while (x < 2)
                {

                    int byte01 = byte0 & mask;
                    Debug.WriteLine(byte0);
                    Debug.WriteLine(byte01);
                    
                    //// INP1
                    if (x == 0 & byte01 == 0b_00000001)
                    {
                        INP1Text = "HIGH";
                        INP1Color = "OrangeRed";
                    }
                    else if (x == 0 & byte01 == 0b_00000000)
                    {
                        INP1Text = "LOW";
                        INP1Color = "LightGreen";
                    }
                    /////INP2
                    if (x == 1 & byte01 == 0b_00000010)
                    {
                        INP2Text = "HIGH";
                        INP2Color = "OrangeRed";
                    }
                    else if (x == 1 & byte01 == 0b_00000000)
                    {
                        INP2Text = "LOW";
                        INP2Color = "LightGreen";
                    }
                    mask = mask << 1;
                    x++;


                }
            }
            return 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int portnumber = 0;
            int portstatus = 0;
            int portstatusvalue = 0;


            string msgid = "";

            //// OUTA
            for (int i = 1; i < 4; i++)
            {
                if (((RadioButton)groupBox1.Controls["radioBtnOUTA" + (i)]).Checked == true) // SELECT OUTA"i"
                {

                    if (((RadioButton)panel1.Controls["radioButtonpwmA" + (i)]).Checked == false)  // Not Select PWM
                    {

                        if (((RadioButton)panel1.Controls["radioBtnOUTA" + (i) + (1)]).Checked == true) // High 
                        {

                            if (((CheckBox)panel1.Controls["checkBoxOUTA" + (i)]).Checked == true)  // OverWrite
                            {
                                portnumber = i;
                                portstatus = 00;
                                sendflag = true;


                                break;
                            }
                            else
                            {
                                portnumber = i;
                                portstatus = 01;
                                sendflag = true;


                                break;
                            }
                        }
                        else if (((RadioButton)panel1.Controls["radioBtnOUTA" + (i) + (2)]).Checked == true) // Low
                        {


                            portnumber = i;
                            portstatus = 00;
                            sendflag = true;
                            break;
                        }
                    }

                    else if (((RadioButton)panel1.Controls["radioButtonpwmA" + (i)]).Checked == true) // Selected Pwm
                    { 
                        if (((TextBox)panel1.Controls["textBoxPwmOutA" + (i)]).Text == "")
                        {
                            MessageBox.Show("PWM VALUE NOT ENTERED! OutA" + i.ToString() + " PWM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            int pwm = Convert.ToInt32(((TextBox)panel1.Controls["textBoxPwmOutA" + (i)]).Text);
                            if (pwm < 0 || pwm > 255)
                            {
                                MessageBox.Show("PWM VALUE ENTERED INCORRECTLY! OutA" + i.ToString() + " PWM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                portnumber = i;
                                portstatus = pwm;
                                sendflag = true;
                                sendpwmflag = true;


                                break;
                            }
                        }
                    }

                }
            }

            if (sendflag == true)
            {
                string c0 = "";
                string f1 = "";

                if (sendpwmflag == true)
                {
                    c0 = "C0";
                    f1 = "FE";
                }
                else
                {
                    c0 = "C0";
                    f1 = "F1";
                }

                msgid = "11111111";
                //Pcan.SendFrame CanID Message , Length ve data array to send  
                pcan.SendFrameExt(Convert.ToInt32(msgid, 16), 8, new byte[] { Convert.ToByte(Convert.ToInt32(c0, 16)), Convert.ToByte(Convert.ToInt32(f1, 16)), Convert.ToByte(portnumber), Convert.ToByte(portstatus) });//veriler (16) hex olarak yollanıyor
                Debug.WriteLine("ID:11111111");
                Debug.WriteLine("MSG: " + BitConverter.ToString(new byte[] { Convert.ToByte(Convert.ToInt32(c0, 16)), Convert.ToByte(Convert.ToInt32(f1, 16)), Convert.ToByte(portnumber), Convert.ToByte(portstatus) }));
            }

        }

        private void radioBtnOUTA1_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnOUTA1.BackColor = Color.Green;
            radioBtnOUTA2.BackColor = SystemColors.ControlLight;
            radioBtnOUTA3.BackColor = SystemColors.ControlLight;
        }

        private void radioBtnOUTA2_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnOUTA2.BackColor = Color.Green;
            radioBtnOUTA1.BackColor = SystemColors.ControlLight;
            radioBtnOUTA3.BackColor = SystemColors.ControlLight;
        }

        private void radioBtnOUTA3_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnOUTA3.BackColor = Color.Green;
            radioBtnOUTA1.BackColor = SystemColors.ControlLight;
            radioBtnOUTA2.BackColor = SystemColors.ControlLight;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }


        
    }
}
    
    
    











   