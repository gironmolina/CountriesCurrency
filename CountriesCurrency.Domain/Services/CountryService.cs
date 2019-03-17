using System.Collections.Generic;
using System.Threading.Tasks;
using CountriesCurrency.Domain.Interfaces;
using CountriesCurrency.Entities;
using CountriesCurrency.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;

namespace CountriesCurrency.Domain.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly ILogger<CountryService> _logger;

        public CountryService(ICountryRepository countryRepository, ILogger<CountryService> logger)
        {
            _countryRepository = countryRepository;
            _logger = logger;
        }

        public async Task<IEnumerable<CountryEntity>> GetCountries(string currency)
        {
            _logger.LogInformation($"GetCountries by currency:{currency} was called");
            var countries = await _countryRepository.GetCountriesByCurrency(currency)
                .ConfigureAwait(false);
            return countries;
        }
    }
}
