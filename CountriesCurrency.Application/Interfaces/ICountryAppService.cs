using System;
using System.Collections.Generic;
using System.Text;
using CountriesCurrency.Application.Dtos;

namespace CountriesCurrency.Application.Interfaces
{
    public interface ICountryAppService
    {
        List<CountryDto> GetByCurrency(string currency);
    }
}
