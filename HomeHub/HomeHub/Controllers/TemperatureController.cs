using HomeHub.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace HomeHub.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TemperatureController : ControllerBase
    {
        private readonly ITemperatureService temperatureService;

        public TemperatureController(ITemperatureService temperatureService)
        {
            this.temperatureService = temperatureService;
        }

        [HttpGet()]
        public  Task<double> Get()
        {
            return this.temperatureService.ReadAsync();
        }
    }
}