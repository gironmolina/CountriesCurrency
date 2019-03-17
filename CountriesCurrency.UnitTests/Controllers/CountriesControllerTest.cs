using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using CountriesCurrency.Application.Dtos;
using CountriesCurrency.Application.Interfaces;
using CountriesCurrency.API.Controllers;
using CountriesCurrency.UnitTests.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace CountriesCurrency.UnitTests.Controllers
{
    public class CountriesControllerTest
    {
        [Fact]
        public async Task GetCountriesByCurrency_ShouldReturnExpectedResult()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<CountriesController>>();
            var countryAppServiceMock = new Mock<ICountryAppService>();
            countryAppServiceMock.Setup(repository => repository.GetCountriesAdapter(It.IsAny<string>()))
                .ReturnsAsync(Helper.GetMockCountriesDto());
            var controller = new CountriesController(loggerMock.Object, countryAppServiceMock.Object);

            // Act
            var result = await controller.Get(It.IsAny<string>()).ConfigureAwait(false) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            var items = Assert.IsType<List<CountryDto>>(result.Value);
            Assert.Equal(4, items.Count);
        }

        [Fact]
        public async Task GetCountriesByCurrency_ThrowException_ShouldReturnExpectedResult()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<CountriesController>>();
            var countryAppServiceMock = new Mock<ICountryAppService>();
            countryAppServiceMock.Setup(repository => repository.GetCountriesAdapter(It.IsAny<string>()))
                .Throws(new Exception());
            var controller = new CountriesController(loggerMock.Object, countryAppServiceMock.Object);

            // Act
            var result = await controller.Get(It.IsAny<string>()).ConfigureAwait(false) as BadRequestObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal((int)HttpStatusCode.BadRequest, result.StatusCode);
            Assert.Equal("Failed to get countries", result.Value);
        }
    }
}
