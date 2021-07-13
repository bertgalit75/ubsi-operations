using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using UBSI_Ops.server.ImplementationOrders.Models;
using Xunit;

namespace UBSI_Ops.server.FunctionalTests
{
    public class ImplementationOrderApiTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly CustomWebApplicationFactory _factory;

        public ImplementationOrderApiTest(CustomWebApplicationFactory factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task ShouldCreateImplementationOrder()
        {
            // Arrange
            var client = _factory.CreateClient();
            var createDto = new CreateImplementationOrderDto()
            {
                IONo = "M100",
                AgencyCode = "001"
            };

            var json = JsonSerializer.Serialize(createDto);

            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            // Act
            var response = await client.PostAsync("api/implementation-orders", content);

            // Assert
            response.EnsureSuccessStatusCode();
        }
    }
}
