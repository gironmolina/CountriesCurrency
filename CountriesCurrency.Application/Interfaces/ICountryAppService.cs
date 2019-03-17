using System.Collections.Generic;
using System.Threading.Tasks;
using CountriesCurrency.Application.Dtos;

namespace CountriesCurrency.Application.Interfaces
{
    public interface ICountryAppService
    {
        Task<List<CountryDto>> GetCountriesAdapter(string currency);
    }
}
