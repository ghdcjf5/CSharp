using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;  //Serial 통신에 쓰일 함수 불러옴



namespace SerialArduinoControl
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string Text); 

        public Form1()
        {
            InitializeComponent();
             getAvailablePorts();            // 사용가능한 포트 불러오기함수
        }

        void getAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();         //사용가능한 포트를 받아와서
            comboBox1.Items.AddRange(ports);                    //ComPort 콤보박스에 리스트로 추가
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
           try
            {                
                if (comboBox1.Text == "" || comboBox2.Text ==""|| comboBox1.Text == null)
                {
                    richTextBox2.Text = "포트 세팅이 안 되어 있습니다. \n";        //사용가능한 포트, BaudRate 지정안할시 처리
                }
                else
                {                    
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);                
                    serialPort1.DataBits = 8;   //기본 데이터 비트 지정
                    serialPort1.StopBits = StopBits.One;    //기본 스탑비트 지정
                    serialPort1.Parity = Parity.None;       //기본 패리티 비트 지정
                    serialPort1.RtsEnable = false;
                    serialPort1.DtrEnable = false;
                    serialPort1.Encoding = Encoding.UTF8;   // 2byte전송 한글표시 
                    serialPort1.Open();                     //선택한 serialPort 오픈
                           
                    button1.Enabled = true;                 //button1(send)버튼 Enable
                    richTextBox1.Enabled = true;
                    btnOpenPort.Enabled = false;
                    btnClosePort.Enabled = true;

                    richTextBox2.Text = serialPort1.PortName + " 포트가 OPEN 되었습니다 \n";
                }
                
            }
            catch(UnauthorizedAccessException)      //접근 불가 예외처리
            {
                richTextBox2.Text = serialPort1.PortName + "  포트를 OPEN 할수 없습니다 \n";
            }
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = serialPort1.PortName + "  포트를 CLOSE 합니다 \n";
            
            serialPort1.Close();        //사용중인 Port Close
            button1.Enabled = false;                        
            btnClosePort.Enabled = false;
            btnOpenPort.Enabled = true;
            richTextBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)                                 
            {                
                 serialPort1.WriteLine(richTextBox1.Text);                
            }   
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           if (serialPort1.IsOpen)
            {
                string data = serialPort1.ReadExisting();   //serial포트에 있는 데이터를 불러와서 변수 저장
 
                if (data != string.Empty)
                {
                    char[] values = data.ToCharArray();
                    int value = Convert.ToInt32(values[0]);
 
                    //data = value.ToString();/////////////////////
                    DataProcessing(data);
                }
            }

        }

        private void DataProcessing(string Text)
        {
            if (this.richTextBox2.InvokeRequired)
            {
                SetTextCallback dp = new SetTextCallback(DataProcessing);
                this.Invoke(dp, new object[] { Text }); //콜벡한 대이터를 변환
            }
            else
            {
                this.richTextBox2.Text += (Text);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
        }        
    }
}
