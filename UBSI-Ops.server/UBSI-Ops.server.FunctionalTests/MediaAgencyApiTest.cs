using FluentAssertions;
using System.Net.Http;
using System.Text;
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
        public async Task ShouldCreateNewMediaAgency()
        {
            // Arrange
            var client = _factory.CreateClient();

            var dto = new MediaAgencyDto()
            {
                Name = "Agency",
                Email = "AgencyTest@gmail.com",
                Code = "0003",
                ContactNo = "0999",
                Fax = "125",
                Remarks = "Remarks 0003"
            };

            // Act
            var response = await client.PostAsync(
                "/api/agencies",
                new StringContent(JsonSerializer.Serialize(dto), Encoding.UTF8, "application/json"));

            // Assert
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var mediaAgency = JsonSerializer.Deserialize<MediaAgencyDto>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            mediaAgency.Name.Should().Be("Agency");
        }

        [Fact]
        public async Task ShouldRetrieveMediaAgencyList()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/agencies");

            // Assert
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var mediaAgencies = JsonSerializer.Deserialize<PaginatedListTest<MediaAgencyDto>>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            mediaAgencies.Items.Should().NotBeEmpty();
        }

        [Fact]
        public async Task ShouldRetrieveSpecificAgency()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/agencies/2");

            // Assert
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var customer = JsonSerializer.Deserialize<MediaAgencyDto>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            customer.Name.Should().Be("MediaCom");
            customer.Province.Should().Be("Isabela");
        }
    }
}
