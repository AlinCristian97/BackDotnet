using Microsoft.AspNetCore.Mvc;

namespace BackDotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PingController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Ping() => StatusCode(StatusCodes.Status200OK);
    }
}