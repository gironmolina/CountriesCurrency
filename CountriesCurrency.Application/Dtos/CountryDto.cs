using System.Collections.Generic;

namespace CountriesCurrency.Application.Dtos
{
    public class CountryDto
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public double? Area { get; set; }
        public IEnumerable<string> Borders { get; set; }
        public IEnumerable<CurrenciesDto> Currencies { get; set; }
    }
}
