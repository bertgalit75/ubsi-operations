using FluentAssertions;
using System.Text.Json;
using System.Threading.Tasks;
using UBSI_Ops.server.Customers.Models;
using Xunit;

namespace UBSI_Ops.server.FunctionalTests
{
    public class CustomerApiTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly CustomWebApplicationFactory _factory;

        public CustomerApiTest(CustomWebApplicationFactory factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task ShouldRetrieveCustomerList()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/customers");

            // Assert
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var customers = JsonSerializer.Deserialize<PaginatedListTest<CustomerDto>>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            customers.Should().NotBeNull();
        }

        [Fact]
        public async Task ShouldRetrieveSpecificCustomerList()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/customers/0002");

            // Assert
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var customer = JsonSerializer.Deserialize<CustomerDto>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            customer.Name.Should().Be("Jane Doe");
            customer.Code.Should().Be("0002");
        }
    }
}
