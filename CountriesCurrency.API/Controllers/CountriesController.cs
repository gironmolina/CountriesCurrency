using System;
using System.Threading.Tasks;
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
        public async Task<IActionResult> Get(string currency)
        {
            try
            {
                var result = await _countryAppService.GetCountriesAdapter(currency).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get countries: {ex}");
                return BadRequest("Failed to get countries");
            }
        }
    }
}
