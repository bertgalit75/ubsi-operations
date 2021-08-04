using FluentAssertions;
using System.Collections.ObjectModel;
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
                Code = "M100",
                AgencyCode = "001",
                ClientCode = "001",
                AccountExecutiveCode = "001",
                Tagline = "Surf Detergent Bili Na",
                Date = new System.DateTime(2020, 1, 1),
                Product = "Surf Detergent",
                BookingOrderNo = "BO#102391023",
                PurchaseOrderNo = "2340A9812031",
                ReferenceCENo = "109230123901231",
                Bookings = new Collection<CreateImplementationOrderDto.BookingDto>()
                {
                    new CreateImplementationOrderDto.BookingDto()
                    {
                        StationCode = "001",
                        PeriodStart = new System.DateTime(2020, 1, 1),
                        PeriodEnd = new System.DateTime(2020, 1, 31),
                        Material = "Surf 30s",
                        Monday = true,
                        Tuesday = true,
                        Wednesday = true,
                        Thursday = true,
                        Friday = true,
                        Saturday = false,
                        Sunday = false,
                        Quantity = 4,
                        Duration = 30,
                        Gross = 10000
                    }
                }
            };

            var json = JsonSerializer.Serialize(createDto);

            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            // Act
            var response = await client.PostAsync("api/implementation-orders", content);
            var responseContent = await response.Content.ReadAsStringAsync();
            var implementationOrer = JsonSerializer.Deserialize<ImplementationOrderDto>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            // Assert
            response.EnsureSuccessStatusCode();
            implementationOrer.Code.Should().Be("M100");
            implementationOrer.Bookings.Should().NotBeEmpty();
        }

        [Fact]
        public async Task ShouldRetrieveIOFilteredByDate()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/implementation-orders/2020/1/filter");

            // Assert
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var filteredImplemetationOrder = JsonSerializer.Deserialize<PaginatedListTest<ImplementationOrderDto>>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            filteredImplemetationOrder.Items.Should().NotBeEmpty();
        }
    }
}
