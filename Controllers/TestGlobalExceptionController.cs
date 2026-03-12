using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestGlobalExceptionController : ControllerBase
    {
        [HttpGet]
        [Route("ex")]
        public IActionResult Get() { 
            throw new Exception("Something wet wrong..");
        }
    }
}
