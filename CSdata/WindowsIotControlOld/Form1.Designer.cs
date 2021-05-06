namespace WindowsIotControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ledOnbutton = new System.Windows.Forms.Button();
            this.ledOffbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxReceive = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port Name";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(125, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 23);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // btnClosePort
            // 
            this.btnClosePort.Location = new System.Drawing.Point(167, 135);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(97, 23);
            this.btnClosePort.TabIndex = 12;
            this.btnClosePort.Text = "Close Port";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(26, 135);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(93, 23);
            this.btnOpenPort.TabIndex = 11;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(27, 380);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(237, 56);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 25);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "0";
            // 
            // ledOnbutton
            // 
            this.ledOnbutton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ledOnbutton.Location = new System.Drawing.Point(27, 172);
            this.ledOnbutton.Name = "ledOnbutton";
            this.ledOnbutton.Size = new System.Drawing.Size(237, 76);
            this.ledOnbutton.TabIndex = 15;
            this.ledOnbutton.Text = "Led On";
            this.ledOnbutton.UseVisualStyleBackColor = true;
            this.ledOnbutton.Click += new System.EventHandler(this.ledOnbutton_Click);
            // 
            // ledOffbutton
            // 
            this.ledOffbutton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ledOffbutton.Location = new System.Drawing.Point(27, 254);
            this.ledOffbutton.Name = "ledOffbutton";
            this.ledOffbutton.Size = new System.Drawing.Size(237, 65);
            this.ledOffbutton.TabIndex = 16;
            this.ledOffbutton.Text = "Led Off";
            this.ledOffbutton.UseVisualStyleBackColor = true;
            this.ledOffbutton.Click += new System.EventHandler(this.ledOffbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsIotControl.Properties.Resources.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(362, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "스위치 상태";
            // 
            // richTextBoxReceive
            // 
            this.richTextBoxReceive.Location = new System.Drawing.Point(347, 182);
            this.richTextBoxReceive.Name = "richTextBoxReceive";
            this.richTextBoxReceive.Size = new System.Drawing.Size(223, 81);
            this.richTextBoxReceive.TabIndex = 19;
            this.richTextBoxReceive.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(495, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "수신";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 441);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.richTextBoxReceive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ledOffbutton);
            this.Controls.Add(this.ledOnbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnClosePort);
            this.Controls.Add(this.btnOpenPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ledOnbutton;
        private System.Windows.Forms.Button ledOffbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxReceive;
        private System.Windows.Forms.Button btnClear;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label4;
    }
}

