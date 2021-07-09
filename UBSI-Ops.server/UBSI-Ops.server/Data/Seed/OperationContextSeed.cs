using System.Collections.ObjectModel;
using System.Threading.Tasks;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.Entities.Identity;

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
            await context.SaveChangesAsync();
        }

        public Collection<MediaAgency> GetMediaAgencies()
        {
            return new Collection<MediaAgency>()
            {
                new MediaAgency()
                {
                    Name = "John Doe",
                    Code = "0001",
                    ContactNo = "0999",
                    Email = "JohnDoe@gmail.com",
                    Fax = "123",
                    Remarks = "Remarks 0001"
                },
                new MediaAgency()
                {
                    Name = "Jane Doe",
                    ContactNo = "0999",
                    Code = "0002",
                    Email = "JaneDoe@gmail.com",
                    Fax = "124",
                    Remarks = "Remakrs 0002"
                    
                }
            };
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
                    Id = "1",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = "c06617466ae4a7d621cd"
                }
            };
        }
    }
}
