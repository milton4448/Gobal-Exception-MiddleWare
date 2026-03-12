using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestLoggingMiddlewareController : ControllerBase
    {
        [HttpGet]
        public IActionResult get() 
        { 
            return Ok("Logging Middleware Working");
        }
    }
}
