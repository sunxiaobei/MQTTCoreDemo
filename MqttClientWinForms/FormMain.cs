using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MqttClientWinForms.Service;

namespace MqttClientWinForms
{
    public partial class FormMain : Form
    {
        MqttClient _mqttClient { get; set; }

        bool _isConnect = false;

        string _ip;
        int _port;
        string _userName;
        string _userPwd;

        List<Log> LogList = new List<Log>();

        public FormMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _ip = textIP.Text;
            _port = Convert.ToInt32(textPort.Text);
            _userName = textUserName.Text;
            _userPwd = textUserPwd.Text;

            if (_mqttClient == null)
            {
                _mqttClient = new MqttClient();
            }
            _mqttClient.LogEvent += MqttLog;

            _mqttClient.MqttClientConnect(_ip, _port, _userName, _userPwd);

        }
        public void MqttLog(string message)
        {
            AddLog(message);
        }
        private void AddLog(string msg)
        {
            if (LogList.Count > 99)
            {
                LogList = LogList.Skip(LogList.Count - 100).Take(100).ToList();
            }

            LogList.Add(new Log
            {
                CreateTime = DateTime.Now.ToString("HH:mm:ss"),
                Msg = msg
            });

            if (LogList != null)
            {
                rtBoxLog.Text = string.Join("\r", LogList.OrderByDescending(m => m.CreateTime).Select(m => m.CreateTime + "   " + m.Msg).ToArray());

            }

        }

        private void btnDisConnect_Click(object sender, EventArgs e)
        {
            _mqttClient.MqttDisconnected();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            _mqttClient.MqttSubscribe(textKey.Text);
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            _mqttClient.Publish(textKey.Text, textSendMassage.Text);
        }

        private void btnUnSubscribe_Click(object sender, EventArgs e)
        {
            _mqttClient.MqttUnSubscribe(textKey.Text);
        }
    }
    public class Log
    {
        public string? CreateTime { get; set; }
        public string? Msg { get; set; }

    }
}
