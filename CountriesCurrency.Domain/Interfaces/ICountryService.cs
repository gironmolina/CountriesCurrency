using System.Collections.Generic;
using System.Threading.Tasks;
using CountriesCurrency.Entities;

namespace CountriesCurrency.Domain.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryEntity>>GetCountries(string currency);
    }
}
