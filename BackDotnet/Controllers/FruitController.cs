using BackDotnet.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackDotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FruitController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly FruitService _fruitService; //TODO: Make interface for service

        public FruitController(
            IConfiguration configuration,
            FruitService fruitService)
        {
            _configuration = configuration;
            _fruitService = fruitService;
        }

        [HttpGet("GetFruits")]
        public async Task<IActionResult> GetFruits()
        {
            var fruits = await _fruitService.GetFruits();
            return StatusCode(StatusCodes.Status200OK, fruits);
        }
    }
}
