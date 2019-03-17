using System.Linq;
using CountriesCurrency.Domain.Services;
using CountriesCurrency.Infrastructure.Interfaces;
using CountriesCurrency.UnitTests.Utils;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace CountriesCurrency.UnitTests.Domain
{
    public class CountryServiceTests
    {
        [Fact]
        public void CountryService_GetCountries_ShouldReturnExpectedResults()
        {
            // Arrange
            var repositoryMock = new Mock<ICountryRepository>();
            repositoryMock.Setup(repository => repository.GetCountriesByCurrency(It.IsAny<string>())).ReturnsAsync(Helper.GetMockCountries());
            var loggerMock = new Mock<ILogger<CountryService>>();
            var countryService = new CountryService(repositoryMock.Object, loggerMock.Object);

            // Act
            var result = countryService.GetCountries("any").Result;

            // Assert
            Assert.Equal(4, result.Count());
        }
    }
}
