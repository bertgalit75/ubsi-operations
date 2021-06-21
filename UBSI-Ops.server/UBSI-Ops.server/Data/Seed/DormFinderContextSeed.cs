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
                    Name = "John Doe",
                    BillingAddress = "Quezon City",
                    RegionCode = "LOC",
                    AreaCode = "MLA",
                    CreditLimit = 0,
                    IsVatInclusive = "Y",
                    CreditStatus = "GD",
                    IsActive = "Y",
                    AECode = "606012",
                    AEName = "John",
                    Telephone = "09150000000",
                    Fax = "",
                    ContactPerson = "John",
                    CreditTermsCode = "COD",
                    GroupCode = "",
                    Type = "",
                    TIN = "",
                },
                new Customer()
                {
                    Code = "00000002",
                    Name = "Jane Doe",
                    BillingAddress = "Mandaluyong",
                    RegionCode = "PBB",
                    AreaCode = "NAT",
                    CreditLimit = 0,
                    IsVatInclusive = "Y",
                    CreditStatus = "GD",
                    IsActive = "Y",
                    AECode = "606013",
                    AEName = "John",
                    Telephone = "09150000001",
                    Fax = "",
                    ContactPerson = "John",
                    CreditTermsCode = "COD",
                    GroupCode = "",
                    Type = "",
                    TIN = "",
                }
            };
        }
       
    }
}
