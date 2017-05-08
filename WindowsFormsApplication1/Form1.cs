using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                serialPort1.PortName = textBox1.Text;
                serialPort1.BaudRate = int.Parse(textBox2.Text);
                serialPort1.Open();
                
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string text = serialPort1.ReadLine();
                MessageBox.Show(text);
                label1.Text += text;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
