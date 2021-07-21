using FluentAssertions;
using System.Text.Json;
using System.Threading.Tasks;
using UBSI_Ops.server.RadioStations.Models;
using Xunit;

namespace UBSI_Ops.server.FunctionalTests
{
    public class RadioStationApiTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly CustomWebApplicationFactory _factory;

        public RadioStationApiTest(CustomWebApplicationFactory factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task ShouldRetrieveRadioStationList()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/radio-stations");

            // Assert
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var radiosStations = JsonSerializer.Deserialize<PaginatedListTest<RadioStationDto>>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            radiosStations.Items.Should().NotBeEmpty();
        }

        [Fact]
        public async Task ShouldRetrieveSpecificRadioStation()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/radio-stations/NAG");

            // Assert
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var radioStation = JsonSerializer.Deserialize<RadioStationDto>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            radioStation.Code.Should().Be("NAG");
            radioStation.Name.Should().Be("Naga 106.3");
        }
    }
}
