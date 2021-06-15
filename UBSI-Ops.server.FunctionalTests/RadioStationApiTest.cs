using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UBSI_Ops.server.Entities;
using FluentAssertions;
using Xunit;
using System;
using UBSI_Ops.server.RadioStations.Models;

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
        public async Task ShouldRetrieveRadioStation()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/api/radiostation/NAG");
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var property = JsonSerializer.Deserialize<RadioStationDto>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            property.Should().NotBeNull();
        }

        [Fact]
        public async Task ShouldRetrieveAllRadioStations()
        {
            // Arrange
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/radiostation");

            // Assert
            response.EnsureSuccessStatusCode();
        }
    }
}
