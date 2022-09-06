using MQTTnet;
using MQTTnet.Protocol;
using MQTTnet.Client;
using System.Text;
namespace MqttClientWebAPI.Service
{
    public class MqttClient
    {
        public static IMqttClient _mqttClient { get; set; }

        /// <summary>
        /// 客户端推送消息
        /// </summary>
        /// <param name="data"></param>
        public static void Publish(string data)
        {
            var message = new MqttApplicationMessage
            {
                Topic = "topic_01",
                Payload = Encoding.Default.GetBytes(data),
                QualityOfServiceLevel = MqttQualityOfServiceLevel.AtLeastOnce,
                Retain = true  // 服务端是否保留消息。true为保留，如果有新的订阅者连接，就会立马收到该消息。
            };
            _mqttClient.PublishAsync(message);
        }

    }
}
