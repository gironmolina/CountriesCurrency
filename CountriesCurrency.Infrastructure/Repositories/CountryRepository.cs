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
            var asd = "http://quiet-stone-2094.herokuapp.com/transactions.json";
            var transactions = await HttpClientHelpers.GetAsync<IList<CountryEntity>>(asd)
                .ConfigureAwait(false);
            return transactions;
        }
    }
}
