
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Protocol;
using System.Text;

namespace MqttClientWebAPI.Service
{
    public class MqttClientService : IHostedService, IDisposable
    {
        /// <summary>
        /// IDisposable
        /// </summary>
        public void Dispose()
        {

        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            var optionsBuilder = new MqttClientOptionsBuilder()
                .WithTcpServer("127.0.0.1", 10086) // 要访问的mqtt服务端的 ip 和 端口号
                .WithCredentials("admin", "123456") // 要访问的mqtt服务端的用户名和密码
                .WithClientId("testclient04") // 设置客户端id
                .WithCleanSession()
                .WithTls(new MqttClientOptionsBuilderTlsParameters
                {
                    UseTls = false  // 是否使用 tls加密
                });
            var clientOptions = optionsBuilder.Build();  //客户端配置

            MqttClient._mqttClient = new MqttFactory().CreateMqttClient();  // 创建客户端

            MqttClient._mqttClient.ConnectedAsync += _mqttClient_ConnectedAsync; // 客户端连接成功事件
            MqttClient._mqttClient.DisconnectedAsync += _mqttClient_DisconnectedAsync; // 客户端连接关闭事件
            MqttClient._mqttClient.ApplicationMessageReceivedAsync += _mqttClient_ApplicationMessageReceivedAsync; // 收到消息事件

            MqttClient._mqttClient.ConnectAsync(clientOptions); // 创建连接
            
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        /// <summary>
        /// 客户端连接关闭事件
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        private Task _mqttClient_DisconnectedAsync(MqttClientDisconnectedEventArgs arg)
        {
            Console.WriteLine($"客户端已断开与服务端的连接……");
            return Task.CompletedTask;
        }

        /// <summary>
        /// 客户端连接成功事件
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        private Task _mqttClient_ConnectedAsync(MqttClientConnectedEventArgs arg)
        {
            Console.WriteLine($"客户端已连接服务端……");

            // 订阅消息主题
            // MqttQualityOfServiceLevel: （QoS）:  0 最多一次，接收者不确认收到消息，并且消息不被发送者存储和重新发送提供与底层 TCP 协议相同的保证。
            // 1: 保证一条消息至少有一次会传递给接收方。发送方存储消息，直到它从接收方收到确认收到消息的数据包。一条消息可以多次发送或传递。
            // 2: 保证每条消息仅由预期的收件人接收一次。级别2是最安全和最慢的服务质量级别，保证由发送方和接收方之间的至少两个请求/响应（四次握手）。
            MqttClient._mqttClient.SubscribeAsync("topic_01", MqttQualityOfServiceLevel.AtLeastOnce);

            //_mqttClient.UnsubscribeAsync("topic_02");  // 取消订阅
            //_mqttClient.SubscribeAsync("topic_02", MqttQualityOfServiceLevel.AtLeastOnce); // 订阅消息

            return Task.CompletedTask;
        }

        /// <summary>
        /// 收到消息事件
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        private Task _mqttClient_ApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs arg)
        {
            Console.WriteLine($"ApplicationMessageReceivedAsync：客户端ID=【{arg.ClientId}】接收到消息。 Topic主题=【{arg.ApplicationMessage.Topic}】 消息=【{Encoding.UTF8.GetString(arg.ApplicationMessage.Payload)}】 qos等级=【{arg.ApplicationMessage.QualityOfServiceLevel}】");
            return Task.CompletedTask;
        }
    }
}
