using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using CountriesCurrency.Application.Dtos;
using CountriesCurrency.API;
using Newtonsoft.Json;
using Xunit;

namespace CountriesCurrency.IntegrationTests.Controllers
{
    public class CountriesControllerTest : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;
        private string countriesEndpoint = "/api/v1/countries?currency=";

        public CountriesControllerTest(CustomWebApplicationFactory<Startup> factory)
        {
            // Arrange
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetCountriesByCurrency_EUR_ShouldReturnExpectedResult()
        {
            // Act
            var httpResponse = await _client.GetAsync($"{countriesEndpoint}eur");

            // Assert
            httpResponse.EnsureSuccessStatusCode();

            // Deserialize and examine results.
            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            var countries = JsonConvert.DeserializeObject<IEnumerable<CountryDto>>(stringResponse).ToList();
            Assert.Equal(36, countries.Count());
            Assert.True(countries.All(country => country.Currencies.Any(currency => currency.Code == "EUR")));
        }

        [Fact]
        public async Task GetCountriesByCurrency_InvalidCurrency_ShouldReturnExpectedResult()
        {
            // Act
            var httpResponse = await _client.GetAsync($"{countriesEndpoint}xxx");

            // Assert
            Assert.False(httpResponse.IsSuccessStatusCode);
            Assert.Equal(HttpStatusCode.BadRequest, httpResponse.StatusCode);
        }

        [Theory]
        [InlineData("eur")]
        [InlineData("afn")]
        [InlineData("all")]
        public async Task GetCountriesByCurrency_AnyValidCurrency_ShouldReturnExpectedResult(string currency)
        {
            // Act
            var httpResponse = await _client.GetAsync($"{countriesEndpoint}{currency}");

            // Assert.
            httpResponse.EnsureSuccessStatusCode();

            // Deserialize and examine results.
            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            var countries = JsonConvert.DeserializeObject<IEnumerable<CountryDto>>(stringResponse);
            Assert.True(countries.All(country => country.Currencies.Any(c => c.Code == currency.ToUpper())));
        }
    }
}
