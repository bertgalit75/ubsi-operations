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
    public class VendorRepository : Repository, IVendorRepository
    {

        public VendorRepository(OperationContext operationContext) : base(operationContext)
        {

        }
        public async Task<PaginatedList<Vendor>> List(PageOptions options)
        {
            var query = _context.Vendors.AsQueryable();

            query = options.Sort switch
            {
                "code" => query.OrderBy(t => t.Code, options.Direction),
                "name" => query.OrderBy(t => t.Name, options.Direction),
                "address" => query.OrderBy(t => t.Address, options.Direction),
                "contact" => query.OrderBy(t => t.Contact, options.Direction),
                "tin" => query.OrderBy(t => t.TIN, options.Direction),
                "payto" => query.OrderBy(t => t.PayTo, options.Direction),
                _ => query
            };

            var vendors = await query
                .Page(options)
                .ToListAsync();

            var total = await query.CountAsync();

            return new PaginatedList<Vendor>(vendors, total);
        }
        public async Task<Vendor> View(string vendorCode)
        {
            return await _context.Vendors.Where(x => x.Code == vendorCode).FirstOrDefaultAsync();
        }
    }
}
