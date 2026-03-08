using Microsoft.AspNetCore.Mvc;

namespace HelloAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            return Ok("Hello From ASP.NET CORE Practice API I have changed many things welcomes");
        }

    }
}
