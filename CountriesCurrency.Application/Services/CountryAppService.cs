using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CountriesCurrency.Application.Dtos;
using CountriesCurrency.Application.Interfaces;
using CountriesCurrency.Domain.Interfaces;
using CountriesCurrency.Entities;
using Microsoft.Extensions.Logging;

namespace CountriesCurrency.Application.Services
{
    public class CountryAppService : ICountryAppService
    {
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;
        private readonly ILogger<CountryAppService> _logger;

        public CountryAppService(ICountryService countryService, IMapper mapper, ILogger<CountryAppService> logger)
        {
            _countryService = countryService;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<List<CountryDto>> GetCountriesAdapter(string currency)
        {
            _logger.LogInformation($"GetCountriesAdapter by currency:{currency} was called");
            var countries = await _countryService.GetCountries(currency).ConfigureAwait(false);
            var countriesDto = _mapper.Map<IEnumerable<CountryEntity>, IEnumerable<CountryDto>>(countries).ToList();
            return countriesDto;
        }
    }
}
