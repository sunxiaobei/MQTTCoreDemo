using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Protocol;
using MQTTnet.Server;

namespace MqttClientWinForms.Service
{
    public class MqttClient
    {
        public delegate void LogEventArg(string message);

        public event LogEventArg LogEvent;

        private IMqttClient _mqttClient { get; set; }


        /// <summary>
        /// MqttClientConnect("127.0.0.1", 10086, "admin", "123456")  连接服务器
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <param name="userName"></param>
        /// <param name="userPwd"></param>
        public void MqttClientConnect(string ip, int port, string userName, string userPwd)
        {
            var optionsBuilder = new MqttClientOptionsBuilder()
                .WithTcpServer(ip, port) // 要访问的mqtt服务端的 ip 和 端口号
                .WithCredentials(userName, userPwd) // 要访问的mqtt服务端的用户名和密码
                .WithClientId(Guid.NewGuid().ToString().Substring(0, 10).Replace("-", "")) // 设置客户端id
                .WithCleanSession()
                .WithTls(new MqttClientOptionsBuilderTlsParameters
                {
                    UseTls = false  // 是否使用 tls加密
                });

            var clientOptions = optionsBuilder.Build();
            _mqttClient = new MqttFactory().CreateMqttClient();

            _mqttClient.ConnectedAsync += MqttClient_ConnectedAsync; // 客户端连接成功事件
            _mqttClient.DisconnectedAsync += MqttClient_DisconnectedAsync; // 客户端连接关闭事件
            _mqttClient.ApplicationMessageReceivedAsync += MqttClient_ApplicationMessageReceivedAsync; // 收到消息事件

            _mqttClient.ConnectAsync(clientOptions);
        }

        public bool MqttDisconnected()
        {
            if (LogEvent != null)
            {
                LogEvent($"关闭与服务器连接……");
            }
            if (_mqttClient.IsConnected)
            {
                _mqttClient.DisconnectAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 订阅消息主题
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool MqttSubscribe(string key)
        {
            if (LogEvent != null)
            {
                LogEvent($"订阅消息：订阅消息=【{key}】");
            }
            if (_mqttClient.IsConnected)
            {
                // MqttQualityOfServiceLevel: （QoS）:  0 最多一次，接收者不确认收到消息，并且消息不被发送者存储和重新发送提供与底层 TCP 协议相同的保证。
                // 1: 保证一条消息至少有一次会传递给接收方。发送方存储消息，直到它从接收方收到确认收到消息的数据包。一条消息可以多次发送或传递。
                // 2: 保证每条消息仅由预期的收件人接收一次。级别2是最安全和最慢的服务质量级别，保证由发送方和接收方之间的至少两个请求/响应（四次握手）。
                _mqttClient.SubscribeAsync(key, MqttQualityOfServiceLevel.AtLeastOnce);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 取消订阅消息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool MqttUnSubscribe(string key)
        {
            if (LogEvent != null)
            {
                LogEvent($"取消订阅消息：取消订阅消息=【{key}】");
            }
            if (_mqttClient.IsConnected)
            {
               _mqttClient.UnsubscribeAsync(key);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="data"></param>
        public void Publish(string key, string data)
        {
            if (LogEvent != null)
            {
                LogEvent($"发送消息：订阅主题=【{key}】。消息内容=【{data}】");
            }
            var message = new MqttApplicationMessage
            {
                Topic = key,
                Payload = Encoding.Default.GetBytes(data),
                QualityOfServiceLevel = MqttQualityOfServiceLevel.AtLeastOnce,
                Retain = true  // 服务端是否保留消息。true为保留，如果有新的订阅者连接，就会立马收到该消息。
            };
            _mqttClient.PublishAsync(message);
        }

        /// <summary>
        /// 客户端连接关闭事件
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        private Task MqttClient_DisconnectedAsync(MqttClientDisconnectedEventArgs arg)
        {
            if (LogEvent != null)
            {
                LogEvent($"客户端已断开与服务端的连接……");
            }
            return Task.CompletedTask;
        }

        /// <summary>
        /// 客户端连接成功事件
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        private Task MqttClient_ConnectedAsync(MqttClientConnectedEventArgs arg)
        {
            if (LogEvent != null)
            {
                LogEvent($"客户端已连接服务端……");
            }
            return Task.CompletedTask;
        }

        /// <summary>
        /// 收到消息事件
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        private Task MqttClient_ApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs arg)
        {
            if (LogEvent != null)
            {
                LogEvent($"收到消息：客户端ID=【{arg.ClientId}】接收到消息。 Topic主题=【{arg.ApplicationMessage.Topic}】 消息=【{Encoding.UTF8.GetString(arg.ApplicationMessage.Payload)}】 qos等级=【{arg.ApplicationMessage.QualityOfServiceLevel}】");
            }
            return Task.CompletedTask;
        }       

    }
}
