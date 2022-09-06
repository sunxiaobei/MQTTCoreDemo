namespace MqttClientWinForms
{
    partial class FormMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.textSendMassage = new System.Windows.Forms.TextBox();
            this.textKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDisConnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textUserPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtBoxLog = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSendMessage);
            this.panel1.Controls.Add(this.btnSubscribe);
            this.panel1.Controls.Add(this.textSendMassage);
            this.panel1.Controls.Add(this.textKey);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDisConnect);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.textUserPwd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textUserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textPort);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textIP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 245);
            this.panel1.TabIndex = 2;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSendMessage.Location = new System.Drawing.Point(488, 189);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(155, 36);
            this.btnSendMessage.TabIndex = 48;
            this.btnSendMessage.Text = "发送";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubscribe.Location = new System.Drawing.Point(488, 144);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(155, 37);
            this.btnSubscribe.TabIndex = 47;
            this.btnSubscribe.Text = "订阅";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            // 
            // textSendMassage
            // 
            this.textSendMassage.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textSendMassage.Location = new System.Drawing.Point(149, 189);
            this.textSendMassage.Name = "textSendMassage";
            this.textSendMassage.Size = new System.Drawing.Size(288, 28);
            this.textSendMassage.TabIndex = 46;
            // 
            // textKey
            // 
            this.textKey.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textKey.Location = new System.Drawing.Point(149, 149);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(288, 28);
            this.textKey.TabIndex = 45;
            this.textKey.Text = "topic_01";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(61, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 44;
            this.label6.Text = "发送消息";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(61, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "订阅消息";
            // 
            // btnDisConnect
            // 
            this.btnDisConnect.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDisConnect.Location = new System.Drawing.Point(488, 82);
            this.btnDisConnect.Name = "btnDisConnect";
            this.btnDisConnect.Size = new System.Drawing.Size(155, 37);
            this.btnDisConnect.TabIndex = 42;
            this.btnDisConnect.Text = "断开连接";
            this.btnDisConnect.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConnect.Location = new System.Drawing.Point(485, 24);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(158, 37);
            this.btnConnect.TabIndex = 41;
            this.btnConnect.Text = "连接服务端";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // textUserPwd
            // 
            this.textUserPwd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textUserPwd.Location = new System.Drawing.Point(322, 91);
            this.textUserPwd.Name = "textUserPwd";
            this.textUserPwd.Size = new System.Drawing.Size(115, 28);
            this.textUserPwd.TabIndex = 40;
            this.textUserPwd.Text = "123456";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(269, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = " 密码";
            // 
            // textUserName
            // 
            this.textUserName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textUserName.Location = new System.Drawing.Point(122, 91);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(131, 28);
            this.textUserName.TabIndex = 38;
            this.textUserName.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(59, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "用户名";
            // 
            // textPort
            // 
            this.textPort.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPort.Location = new System.Drawing.Point(322, 29);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(115, 28);
            this.textPort.TabIndex = 36;
            this.textPort.Text = "10086";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(274, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "端口";
            // 
            // textIP
            // 
            this.textIP.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textIP.Location = new System.Drawing.Point(122, 29);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(131, 28);
            this.textIP.TabIndex = 34;
            this.textIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "IP地址";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtBoxLog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 245);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 311);
            this.panel2.TabIndex = 1;
            // 
            // rtBoxLog
            // 
            this.rtBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtBoxLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtBoxLog.Location = new System.Drawing.Point(0, 0);
            this.rtBoxLog.Name = "rtBoxLog";
            this.rtBoxLog.Size = new System.Drawing.Size(740, 311);
            this.rtBoxLog.TabIndex = 34;
            this.rtBoxLog.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 556);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "MQTT客户端";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnSendMessage;
        private Button btnSubscribe;
        private TextBox textSendMassage;
        private TextBox textKey;
        private Label label6;
        private Label label5;
        private Button btnDisConnect;
        private Button btnConnect;
        private TextBox textUserPwd;
        private Label label4;
        private TextBox textUserName;
        private Label label3;
        private TextBox textPort;
        private Label label2;
        private TextBox textIP;
        private Label label1;
        private RichTextBox rtBoxLog;
    }
}