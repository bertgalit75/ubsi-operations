using FluentAssertions;
using System.Text.Json;
using System.Threading.Tasks;
using UBSI_Ops.server.AccountExecutives.Models;
using Xunit;

namespace UBSI_Ops.server.FunctionalTests
{
    public class AccountExecutiveApiTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly CustomWebApplicationFactory _factory;

        public AccountExecutiveApiTest(CustomWebApplicationFactory factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task ShouldRetrieveAccountExecutiveList()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/account-executives");

            // Assert
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var accountExecutives = JsonSerializer.Deserialize<PaginatedListTest<AccountExecutiveDto>>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            accountExecutives.Items.Should().NotBeNull();
        }

        [Fact]
        public async Task ShouldRetrieveSpecificAccountExecutive()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/account-executives/606006");

            // Assert
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var accountExecutive = JsonSerializer.Deserialize<AccountExecutiveDto>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            accountExecutive.Code.Should().Be("606006");
            accountExecutive.AreaCode.Should().Be("DAG");
        }
    }
}
