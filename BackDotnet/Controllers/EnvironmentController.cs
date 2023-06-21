using Microsoft.AspNetCore.Mvc;

namespace BackDotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnvironmentController : ControllerBase
    {
        private readonly ILogger<EnvironmentController> _logger;
        private readonly IConfiguration _configuration;

        public EnvironmentController(
            ILogger<EnvironmentController> logger,
            IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet(Name = "GetEnvironment")]
        public IActionResult Get()
        {
            string environment = _configuration.GetValue<string>("Environment");

            return StatusCode(StatusCodes.Status200OK, environment);
        }
    }
}