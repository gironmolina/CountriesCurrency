using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CountriesCurrency.Application.Dtos;
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

        /// <summary>
        /// GET Countries by currency
        /// </summary>
        /// <response code="200">Returns countries by currency.</response>
        /// <response code="400">Bad request.</response> 
        [HttpGet]
        [ProducesResponseType(typeof(List<CountryDto>), 200)]
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
