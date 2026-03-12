using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestGlobalExceptionController : ControllerBase
    {
        [HttpGet]
        //[Route("ex")]
        public IActionResult GetGlobalException() {
            //return Ok("Logging Middleware Working");

            throw new Exception("Something went wrong.....");
        }
    }
}
