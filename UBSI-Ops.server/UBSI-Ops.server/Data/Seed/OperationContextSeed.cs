using System.Collections.ObjectModel;
using System.Threading.Tasks;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.Entities.Identity;
using UBSI_Ops.server.ImplementationOrders;

namespace UBSI_Ops.server.Data.Seed
{
    public class OperationContextSeed
    {
        public async Task Seed(OperationContext context)
        {
            context.Customers.AddRange(GetCustomers());
            context.RadioStations.AddRange(GetRadioStations());
            context.Vendors.AddRange(GetVendors());
            context.AccountExecutives.AddRange(GetAccountExecutives());
            context.Users.AddRange(GetUsers());
            context.MediaAgencies.AddRange(GetMediaAgencies());
            context.Roles.AddRange(GetRoles());
            context.ImplementationOrders.AddRange(GetImplementationOrders());

            await context.SaveChangesAsync();
        }

        public Collection<Customer> GetCustomers()
        {
            return new Collection<Customer>()
            {
                new Customer()
                {
                    Code = "0001",
                    Name = "John Doe"
                },
                new Customer()
                {
                    Code = "0002",
                    Name = "Jane Doe"
                }
            };
        }

        public Collection<RadioStation> GetRadioStations()
        {
            return new Collection<RadioStation>()
            {
                new RadioStation()
                {
                    Code="NAG",
                    Name="Naga 106.3",
                },
                new RadioStation()
                {
                   Code="DIP",
                   Name="Dipolog 103.7",
                }
            };
        }

        public Collection<Vendor> GetVendors()
        {
            return new Collection<Vendor>()
            {
                new Vendor()
                {
                    Code="8530220",
                    Name="SALER SH..x",
                },
                new Vendor()
                {
                   Code="6513969",
                   Name="SALDEPAR..x",
                }
            };
        }

        public Collection<AccountExecutive> GetAccountExecutives()
        {
            return new Collection<AccountExecutive>()
            {
                new AccountExecutive()
                {
                    Code="606006",
                    LastName="X",
                    FirstName="Y",
                    AreaCode="DAG"
                },
                new AccountExecutive()
                {
                   Code="602022",
                    LastName="X",
                    FirstName="Y",
                    AreaCode="MLA"
                }
            };
        }

        private Collection<User> GetUsers()
        {
            return new Collection<User>()
            {
                new User()
                {
                    Id = "admin",
                    UserName = "adminUsername",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = "c06617466ae4a7d621cd"
                }
            };
        }

        private Collection<MediaAgency> GetMediaAgencies()
        {
            return new Collection<MediaAgency>()
            {
                new MediaAgency()
                {
                    Code = "1",
                    Name = "True Tiles Media",
                    AddressLine = "Roxas, Panganiban St.",
                    City = "Santiago City",
                    Province="Isabela",
                },
                 new MediaAgency()
                {
                    Code = "2",
                    Name = "MediaCom",
                    AddressLine = "Roxas, Panganiban St.",
                    City = "Santiago City",
                    Province="Isabela",
                }
            };
        }

        private Collection<Role> GetRoles()
        {
            return new Collection<Role>()
            {
                new Role()
                {
                    Id = "1",
                    Name = "admin",
                    NormalizedName = "admin",
                }
            };
        }

        private Collection<ImplementationOrder> GetImplementationOrders()
        {
            return new Collection<ImplementationOrder>()
            {
                new ImplementationOrder()
                {
                    Code = "M200",
                    AgencyCode = "002",
                    ClientCode = "002",
                    AccountExecutiveCode = "002",
                    Tagline = "Masarap kahit walang sauce",
                    Date = new System.DateTime(2020, 1, 1),
                    Product = "Chooks to go",
                    BookingOrderNo = "BO#1023910234",
                    PurchaseOrderNo = "2340A98120313",
                    ReferenceCENo = "1092301239012311",
                    Bookings = new Collection<ImplementationOrderBooking>()
                    {
                        new ImplementationOrderBooking()
                        {
                            StationCode = "002",
                            PeriodStart = new System.DateTime(2020, 1, 1),
                            PeriodEnd = new System.DateTime(2020, 1, 31),
                            Monday = true,
                            Tuesday = true,
                            Wednesday = true,
                            Thursday = true,
                            Friday = true,
                            Saturday = false,
                            Sunday = false,
                            Duration = 30,
                            NoOfSpots = 4,
                            GrossAmount = 10000
                        }
                    }
                }
            };
        }
    }
}
