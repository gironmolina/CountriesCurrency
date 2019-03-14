using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CountriesCurrency.Entities;

namespace CountriesCurrency.Domain.Interfaces
{
    public interface ICountryService
    {
        Task<IList<CountryEntity>> asd();
    }
}
