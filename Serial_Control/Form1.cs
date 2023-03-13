using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ff1 = new Form1();
            Form2 ff2 = new Form2();
            Form1.ActiveForm.Hide();
            ff2.Show();
            string message = "USB SERIAL CONTROL MONITOR";
            MessageBox.Show(message, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ff1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 ff1 = new Form1();
            Form3 ff3 = new Form3();
            Form1.ActiveForm.Hide();
            ff3.Show();
            string message = "CAN CONTROL MONITOR";
            MessageBox.Show(message, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ff1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
