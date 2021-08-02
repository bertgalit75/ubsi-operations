using FluentAssertions;
using System.Text.Json;
using System.Threading.Tasks;
using UBSI_Ops.server.BillingStatements.Models;
using Xunit;

namespace UBSI_Ops.server.FunctionalTests
{
    public class BillingStatementApiTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly CustomWebApplicationFactory _factory;

        public BillingStatementApiTest(CustomWebApplicationFactory factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task ShouldRetrieveBillingStatementList()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/billing-statements");

            // Assert
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var accountExecutives = JsonSerializer.Deserialize<PaginatedListTest<BillingStatementDto>>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            accountExecutives.Items.Should().NotBeNull();
        }
    }
}
