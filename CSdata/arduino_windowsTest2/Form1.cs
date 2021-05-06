using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;


namespace arduino_windowsTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        bool isConnect = serialConnect();

        if (!isConnect)

             {

            MessageBox.Show("SerialPort Open Error");

             }

           else

                {

            MessageBox.Show("SerialPort Open OK");

            }



        }

        public bool serialConnect()
        {

            serialPort.PortName = "COM5";

            serialPort.BaudRate = 9600;

            serialPort.DataBits = 8;

            serialPort.Parity = Parity.None;

            serialPort.StopBits = StopBits.One;

            serialPort.RtsEnable = false;

            serialPort.DtrEnable = false;

            try
            {

                serialPort.Open();

                return true;

            }
            catch
            {

                return false;

            }



        }


        private void button1_Click(object sender, EventArgs e)
        {

            byte[] datas = new byte[255];

datas[0] = 0x31;

if (serialPort.IsOpen) serialPort.Write(datas, 0, 1);



        }

        private void button2_Click(object sender, EventArgs e)
        {

            byte[] datas = new byte[255];

            datas[0] = 0x30;

            if (serialPort.IsOpen) serialPort.Write(datas, 0, 1);



        }
    }
}
