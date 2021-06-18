using System.Net.Http;
using System.Threading.Tasks;
using UBSI_Ops.server.Entities;
using FluentAssertions;
using Xunit;
using System;
using UBSI_Ops.server.RadioStations.Models;
using System.Text.Json;
using UBSI_Ops.server.Services.Intefaces;

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
        public async Task ShouldRetrieveRadioStationDetails()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetStringAsync("/api/radiostation");
            response.Should().BeNull();
            // Assert
            //var radioStation = JsonSerializer.Deserialize<RadioStationDto>(response);

            //radioStation.stn_code.Should().Be("NAG");


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
