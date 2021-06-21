using System.Collections.ObjectModel;
using System.Threading.Tasks;
using UBSI_Ops.server.Entities;

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
            await context.SaveChangesAsync();
        }

        public Collection<Customer> GetCustomers()
        {
            return new Collection<Customer>()
            {
                new Customer()
                {
                    Name = "John Doe"
                },
                new Customer()
                {
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


    }
}
