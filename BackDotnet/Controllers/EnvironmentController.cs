using Microsoft.AspNetCore.Mvc;

namespace BackDotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnvironmentController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public EnvironmentController(
            IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("GetEnvironment")]
        public IActionResult GetEnvironment()
        {
            string environment = _configuration.GetValue<string>("Environment");

            return StatusCode(StatusCodes.Status200OK, environment);
        }
    }
}