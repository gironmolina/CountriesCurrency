using System.Collections.Generic;
using System.Threading.Tasks;
using CountriesCurrency.CrossCutting.Helpers;
using CountriesCurrency.Entities;
using CountriesCurrency.Infrastructure.Interfaces;

namespace CountriesCurrency.Infrastructure.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        public CountryRepository()
        {
            
        }

        public async Task<IList<CountryEntity>> GetCountriesByCurrency()
        {
            var asd = "https://restcountries.eu/rest/v2/currency/eur";
            var transactions = await HttpClientHelpers.GetAsync<IList<CountryEntity>>(asd)
                .ConfigureAwait(false);
            return transactions;
        }
    }
}
