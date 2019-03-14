using System.Collections.Generic;

namespace CountriesCurrency.Application.Dtos
{
    public class CountryDto
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public double Area { get; set; }
        public List<CountryDto> Borders { get; set; }
    }
}
