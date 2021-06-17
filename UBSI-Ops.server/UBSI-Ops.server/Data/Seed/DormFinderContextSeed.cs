using System;
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
            

            await context.SaveChangesAsync();
        }

        public Collection<Customer> GetCustomers()
        {
            return new Collection<Customer>()
            {
                new Customer()
                {
                    Code = "00000001",
                    Name = "John Doe"
                },
                new Customer()
                {
                    Code = "00000002",
                    Name = "Jane Doe"
                }
            };
        }
       
    }
}
