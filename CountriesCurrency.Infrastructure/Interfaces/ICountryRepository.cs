using System.Collections.Generic;
using System.Threading.Tasks;
using CountriesCurrency.Entities;

namespace CountriesCurrency.Infrastructure.Interfaces
{
    public interface ICountryRepository
    {
        Task<IList<CountryEntity>> GetCountriesByCurrency(string currency);
    }
}
