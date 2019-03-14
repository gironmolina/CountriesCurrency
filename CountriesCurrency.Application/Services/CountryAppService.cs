using System;
using System.Collections.Generic;
using System.Text;
using CountriesCurrency.Application.Dtos;
using CountriesCurrency.Application.Interfaces;
using CountriesCurrency.Domain.Interfaces;

namespace CountriesCurrency.Application.Services
{
    public class CountryAppService : ICountryAppService
    {
        private readonly ICountryService _countryService;

        public CountryAppService(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public List<CountryDto> GetByCurrency(string currency)
        {
            var asd = _countryService.asd();
            return null;
        }
    }
}
