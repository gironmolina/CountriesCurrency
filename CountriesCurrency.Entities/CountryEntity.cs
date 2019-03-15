using System;
using System.Collections.Generic;

namespace CountriesCurrency.Entities
{
    public class CountryEntity
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public double? Area { get; set; }
        public IEnumerable<string> Borders { get; set; }
        public IEnumerable<CurrenciesEntity> Currencies { get; set; }
    }
}
