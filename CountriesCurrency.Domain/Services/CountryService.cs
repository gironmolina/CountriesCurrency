using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CountriesCurrency.Domain.Interfaces;
using CountriesCurrency.Entities;
using CountriesCurrency.Infrastructure.Interfaces;

namespace CountriesCurrency.Domain.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        //public string asd()
        //{
        //    var rates = await _countryRepository.GetCountriesByCurrency().ConfigureAwait(false);
        //    return null;
        //}
        public async Task<IList<CountryEntity>> asd()
        {
            var rates = await _countryRepository.GetCountriesByCurrency().ConfigureAwait(false);
            return null;
        }
    }
}
