using FluentAssertions;
using System.Text.Json;
using System.Threading.Tasks;
using UBSI_Ops.server.Roles.Models;
using Xunit;

namespace UBSI_Ops.server.FunctionalTests
{
    public class RoleApiTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly CustomWebApplicationFactory _factory;

        public RoleApiTest(CustomWebApplicationFactory factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task ShouldRetrieveRoleList()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/roles");

            // Assert
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var roles = JsonSerializer.Deserialize<PaginatedListTest<RoleDto>>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            roles.Items.Should().NotBeNull();
        }
    }
}
