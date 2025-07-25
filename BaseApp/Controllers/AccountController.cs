using Microsoft.AspNetCore.Mvc;

namespace BaseApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public AccountController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "RegisterUser")]
        public bool RegisterUser()
        {
            return true;
        }

    }
}
