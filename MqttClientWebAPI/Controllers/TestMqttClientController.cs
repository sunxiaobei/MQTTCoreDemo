using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MqttClientWebAPI.Service;

namespace MqttClientWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestMqttClientController : ControllerBase
    {
        /// <summary>
        /// 客户端发送消息
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Test(string data)
        {
            MqttClient.Publish(data);
            return Ok();
        }
    }
}
