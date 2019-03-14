using System;
using CountriesCurrency.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CountriesCurrency.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ILogger<CountriesController> _logger;
        private readonly ICountryAppService _countryAppService;

        public CountriesController(
            ILogger<CountriesController> logger,
            ICountryAppService countryAppService)
        {
            _logger = logger;
            _countryAppService = countryAppService;
        }

        [HttpGet]
        public IActionResult Get(string currency)
        {
            try
            {
                var result = _countryAppService.GetByCurrency("");
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get orders: {ex}");
                return BadRequest();
            }
        }
    }
}
