using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CountriesCurrency.CrossCutting.Helpers;
using CountriesCurrency.Entities;
using CountriesCurrency.Infrastructure.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CountriesCurrency.Infrastructure.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ILogger<CountryRepository> _logger;
        private readonly IConfiguration _config;

        public CountryRepository(ILogger<CountryRepository> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public async Task<IList<CountryEntity>> GetCountriesByCurrency(string currency)
        {
            try
            {
                _logger.LogInformation($"GetCountriesByCurrency by {currency} was called");
                var restCountriesApi = _config["RestCountriesApi"];
                var url = $"{restCountriesApi}{currency.ToLowerInvariant()}";
                var countries = await HttpClientHelpers.GetAsync<IList<CountryEntity>>(url)
                    .ConfigureAwait(false);
                return countries;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get countries by {currency} : {ex}");
                throw;
            }
        }
    }
}
