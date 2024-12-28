using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_task_1.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
