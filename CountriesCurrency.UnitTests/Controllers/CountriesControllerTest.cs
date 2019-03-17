using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CountriesCurrency.UnitTests.Controllers
{
    public class CountriesControllerTest
    {
        [Fact]
        public async Task Values_Get_All()
        {
            // Arrange
            //var controller = new PersonsController(new PersonService());

            //// Act
            //var result = await controller.Get();

            //// Assert
            //var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            //var persons = okResult.Value.Should().BeAssignableTo<IEnumerable<Person>>().Subject;

            //persons.Count().Should().Be(50);
        }


        [Fact]
        public void CountryService_GetCountries_ShouldReturnExpectedResults()
        {
            // Arrange
            //var repositoryMock = new Mock<ICountryRepository>();
            //repositoryMock.Setup(x => x.GetCountriesByCurrency(It.IsAny<string>())).ReturnsAsync(Helper.GetMockCountries());
            //var loggerMock = new Mock<ILogger<CountryService>>();
            //var countryService = new CountryService(repositoryMock.Object, loggerMock.Object);

            //// Act
            //var result = countryService.GetCountries("any").Result;

            //// Assert
            //Assert.Equal(4, result.Count());
        }
    }
}
