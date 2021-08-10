using FluentAssertions;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Ropes.API.Roles.Models;
using Xunit;

namespace Ropes.API.FunctionalTests
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

        [Fact]
        public async Task ShouldCreateRole()
        {
            var createRole = new CreateRoleDto()
            {
                Name = "User",
            };

            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.PostAsync("/api/roles/new", new StringContent(JsonSerializer.Serialize(createRole), Encoding.UTF8, "application/json"));

            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var newRole = JsonSerializer.Deserialize<RoleDto>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            newRole.Id.Should().Be("2");
            newRole.NormalizedName.Should().Be("User");
            newRole.Name.Should().Be("User");
        }
    }
}
