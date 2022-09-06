using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace MqttDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestMQTTController : ControllerBase
    {
        /// <summary>
        /// 服务端发送消息
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Test(string data)
        {
            MqttService.PublishData(data);
            return Ok();
        }
    }
}
