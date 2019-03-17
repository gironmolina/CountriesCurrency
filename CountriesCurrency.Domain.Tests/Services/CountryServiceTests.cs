using System.Collections.Generic;
using System.Linq;
using CountriesCurrency.Domain.Services;
using CountriesCurrency.Entities;
using CountriesCurrency.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace CountriesCurrency.Domain.Tests.Services
{
    public class CountryServiceTests
    {
        [Fact]
        public void CountryService_GetCountries_ShouldReturnExpectedResults()
        {
            // Arrange
            var repositoryMock = new Mock<ICountryRepository>();
            repositoryMock.Setup(x => x.GetCountriesByCurrency(It.IsAny<string>())).ReturnsAsync(GetCountries);
            var loggerMock = new Mock<ILogger<CountryService>>();
            var countryService = new CountryService(repositoryMock.Object, loggerMock.Object);

            // Act
            var result = countryService.GetCountries("").Result;

            // Assert
            Assert.Equal(4, result.Count());
        }

        private IList<CountryEntity> GetCountries()
        {
            throw new System.NotImplementedException();
        }

        //private List<CountryEntity> GetCountries()
        //{
        //    return new List<CountryEntity>
        //    {
        //        new CountryEntity
        //        {
        //            Name = "Spain",
        //            Population = 46438422,
        //            Area = 505992.0,
        //            Borders = new List<string>
        //            {
        //                "AND",
        //                "FRA",
        //                "GIB",
        //                "PRT",
        //                "MAR"
        //            },
        //            Currencies = new List<CurrenciesEntity>
        //            {
        //                new CurrenciesEntity
        //                {
        //                    Code = "EUR",
        //                    Name = "Euro",
        //                    Symbol = "€"
        //                }
        //            }
        //        },
        //        new CountryEntity
        //        {
        //            Name = "Latvia",
        //            Population = 1961600,
        //            Area = 64559.0,
        //            Borders = new List<string>
        //            {
        //                "BLR",
        //                "EST",
        //                "LTU",
        //                "RUS"
        //            },
        //            Currencies = new List<CurrenciesEntity>
        //            {
        //                new CurrenciesEntity
        //                {
        //                    Code = "EUR",
        //                    Name = "Euro",
        //                    Symbol = "€"
        //                }
        //            }
        //        },
        //        new CountryEntity
        //        {
        //            Name = "Venezuela",
        //            Population = 31028700,
        //            Area = 916445.0,
        //            Borders = new List<string>
        //            {
        //                "BRA",
        //                "COL",
        //                "GUY"
        //            },
        //            Currencies = new List<CurrenciesEntity>
        //            {
        //                new CurrenciesEntity
        //                {
        //                    Code = "VEF",
        //                    Name = "Venezuelan bolívar",
        //                    Symbol = "Bs F"
        //                }
        //            }
        //        },
        //        new CountryEntity
        //        {
        //            Name = "Panama",
        //            Population = 3814672,
        //            Area = null,
        //            Borders = new List<string>
        //            {
        //                "COL",
        //                "CRI"
        //            },
        //            Currencies = new List<CurrenciesEntity>
        //            {
        //                new CurrenciesEntity
        //                {
        //                    Code = "USD",
        //                    Name = "United States dollar",
        //                    Symbol = "$"
        //                }
        //            }
        //        },
        //    };
        //}
    }
}
