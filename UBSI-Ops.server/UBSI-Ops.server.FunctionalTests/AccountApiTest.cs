using FluentAssertions;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UBSI_Ops.server.Models.Request;
using Xunit;

namespace UBSI_Ops.server.FunctionalTests
{
    public class AccountApiTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly CustomWebApplicationFactory _factory;

        public AccountApiTest(CustomWebApplicationFactory factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task ShouldRetrieveUserToken()
        {
            var loginModel = new LoginModel()
            {
                Username = "admin",
                Password = "admin@!45"
            };

            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.PostAsync("/api/account/login", new StringContent(JsonSerializer.Serialize(loginModel), Encoding.UTF8, "application/json"));

            var responseContent = await response.Content.ReadAsStringAsync();
            var loginResult = JsonSerializer.Deserialize<LoginResult>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            loginResult.Token.Should().NotBeNullOrEmpty();
        }

        public class LoginResult
        {
            public string Token { get; set; }
        }
    }
}
