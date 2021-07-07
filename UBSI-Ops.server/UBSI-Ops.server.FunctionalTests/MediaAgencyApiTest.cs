using FluentAssertions;
using System.Text.Json;
using System.Threading.Tasks;
using UBSI_Ops.server.MediaAgencies.Models;
using Xunit;

namespace UBSI_Ops.server.FunctionalTests
{
    public class MediaAgencyApiTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly CustomWebApplicationFactory _factory;

        public MediaAgencyApiTest(CustomWebApplicationFactory factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task ShouldRetrieveMediaAgencyList()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/media-agencies");

            // Assert
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var mediaAgencies = JsonSerializer.Deserialize<PaginatedListTest<MediaAgencyDto>>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            mediaAgencies.Items.Should().NotBeEmpty();
        }
    }
}
