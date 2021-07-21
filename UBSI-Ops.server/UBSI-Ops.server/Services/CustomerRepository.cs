using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Extensions;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Services
{
    public class CustomerRepository : Repository, ICustomerRepository
    {
        public CustomerRepository(OperationContext context) : base(context)
        {
        }

        public async Task<PaginatedList<Customer>> List(PageOptions options)
        {
            string direction = null;

            if (options.Direction == "ascend") { direction = "asc"; }
            else if (options.Direction == "descend") { direction = "desc"; }

            var query = _context.Customers.
                AsQueryable();

            query = options.Sort switch
            {
                "customerCode" => query.OrderBy(t => t.Code, direction),
                "customerName" => query.OrderBy(x => x.Name, direction),
                "regionCode" => query.OrderBy(t => t.RegionCode, direction),
                "areaCode" => query.OrderBy(t => t.AreaCode, direction),
                "ae" => query.OrderBy(t => t.AEName, direction),
                "creditTerms" => query.OrderBy(t => t.CreditTermsCode, direction),
                _ => query
            };

            var customers = await query
                .Page(options)
                .ToListAsync();

            var total = await query.CountAsync();

            return new PaginatedList<Customer>(customers, total);
        }

        public async Task<PaginatedList<Customer>> SearchList(PageOptions options, string search)
        {
            var query = _context.Customers.
                Where(t => t.Name.Contains(search)).
                AsQueryable();

            query = options.Sort switch
            {
                "name" => query.OrderBy(t => t.Name, options.Direction),
                _ => query
            };

            var customers = await query
                .Page(options)
                .ToListAsync();

            var total = await query.CountAsync();

            return new PaginatedList<Customer>(customers, total);
        }

        public async Task<Customer> View(string code)
        {
            return await _context.Customers.Where(x => x.Code == code).FirstOrDefaultAsync();
        }
    }
}
