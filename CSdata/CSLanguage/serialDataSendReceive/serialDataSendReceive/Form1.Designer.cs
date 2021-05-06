namespace serialDataSendReceive
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.richTextBox_received = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // richTextBox_received
            // 
            this.richTextBox_received.Location = new System.Drawing.Point(294, 62);
            this.richTextBox_received.Name = "richTextBox_received";
            this.richTextBox_received.Size = new System.Drawing.Size(254, 274);
            this.richTextBox_received.TabIndex = 0;
            this.richTextBox_received.Text = "";
            this.richTextBox_received.TextChanged += new System.EventHandler(this.richTextBox_received_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 77);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox_received);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.RichTextBox richTextBox_received;
        private System.Windows.Forms.Button button1;
    }
}

