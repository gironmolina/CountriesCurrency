using System.Collections.Generic;
using CountriesCurrency.Application.Dtos;
using CountriesCurrency.Entities;

namespace CountriesCurrency.UnitTests.Utils
{
    public class Helper
    {
        public static List<CountryEntity> GetMockCountries()
        {
            return new List<CountryEntity>
            {
                new CountryEntity
                {
                    Name = "Spain",
                    Population = 46438422,
                    Area = 505992.0,
                    Borders = new List<string>
                    {
                        "AND",
                        "FRA",
                        "GIB",
                        "PRT",
                        "MAR"
                    },
                    Currencies = new List<CurrenciesEntity>
                    {
                        new CurrenciesEntity
                        {
                            Code = "EUR",
                            Name = "Euro",
                            Symbol = "€"
                        }
                    }
                },
                new CountryEntity
                {
                    Name = "Latvia",
                    Population = 1961600,
                    Area = 64559.0,
                    Borders = new List<string>
                    {
                        "BLR",
                        "EST",
                        "LTU",
                        "RUS"
                    },
                    Currencies = new List<CurrenciesEntity>
                    {
                        new CurrenciesEntity
                        {
                            Code = "EUR",
                            Name = "Euro",
                            Symbol = "€"
                        }
                    }
                },
                new CountryEntity
                {
                    Name = "Venezuela",
                    Population = 31028700,
                    Area = 916445.0,
                    Borders = new List<string>
                    {
                        "BRA",
                        "COL",
                        "GUY"
                    },
                    Currencies = new List<CurrenciesEntity>
                    {
                        new CurrenciesEntity
                        {
                            Code = "VEF",
                            Name = "Venezuelan bolívar",
                            Symbol = "Bs F"
                        }
                    }
                },
                new CountryEntity
                {
                    Name = "Panama",
                    Population = 3814672,
                    Area = null,
                    Borders = new List<string>
                    {
                        "COL",
                        "CRI"
                    },
                    Currencies = new List<CurrenciesEntity>
                    {
                        new CurrenciesEntity
                        {
                            Code = "USD",
                            Name = "United States dollar",
                            Symbol = "$"
                        }
                    }
                },
            };
        }

        public static List<CountryDto> GetMockCountriesDto()
        {
            return new List<CountryDto>
            {
                new CountryDto
                {
                    Name = "Spain",
                    Population = 46438422,
                    Area = 505992.0,
                    Borders = new List<string>
                    {
                        "AND",
                        "FRA",
                        "GIB",
                        "PRT",
                        "MAR"
                    },
                    Currencies = new List<CurrenciesDto>
                    {
                        new CurrenciesDto
                        {
                            Code = "EUR",
                            Name = "Euro",
                            Symbol = "€"
                        }
                    }
                },
                new CountryDto
                {
                    Name = "Latvia",
                    Population = 1961600,
                    Area = 64559.0,
                    Borders = new List<string>
                    {
                        "BLR",
                        "EST",
                        "LTU",
                        "RUS"
                    },
                    Currencies = new List<CurrenciesDto>
                    {
                        new CurrenciesDto
                        {
                            Code = "EUR",
                            Name = "Euro",
                            Symbol = "€"
                        }
                    }
                },
                new CountryDto
                {
                    Name = "Venezuela",
                    Population = 31028700,
                    Area = 916445.0,
                    Borders = new List<string>
                    {
                        "BRA",
                        "COL",
                        "GUY"
                    },
                    Currencies = new List<CurrenciesDto>
                    {
                        new CurrenciesDto
                        {
                            Code = "VEF",
                            Name = "Venezuelan bolívar",
                            Symbol = "Bs F"
                        }
                    }
                },
                new CountryDto
                {
                    Name = "Panama",
                    Population = 3814672,
                    Area = null,
                    Borders = new List<string>
                    {
                        "COL",
                        "CRI"
                    },
                    Currencies = new List<CurrenciesDto>
                    {
                        new CurrenciesDto
                        {
                            Code = "USD",
                            Name = "United States dollar",
                            Symbol = "$"
                        }
                    }
                },
            };
        }
    }
}
