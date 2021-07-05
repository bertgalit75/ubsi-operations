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
    public class ImplementationOrderRepository : Repository, IImplementationOrderRepository
    {
        public ImplementationOrderRepository(OperationContext context) : base(context)
        {

        }
        public async Task<PaginatedList<ImplementationOrder>> List(PageOptions options)
        {
            string direction = null;

            if (options.Direction == "ascend") { direction = "asc"; }

            else if (options.Direction == "descend") { direction = "desc"; }

            var query = _context.ImplementationOrders.
                AsQueryable();

            query = options.Sort switch
            {
                "ioNumber" => query.OrderBy(t => t.Code, direction),
                "client" => query.OrderBy(x => x.ClientCode, direction),
                "agency" => query.OrderBy(t => t.AgencyCode, direction),
                "station" => query.OrderBy(t => t.AgencyCode, direction),
                _ => query
            };

            var implementationOrder = await query
                .Page(options)
                .ToListAsync();

            var total = await query.CountAsync();

            return new PaginatedList<ImplementationOrder>(implementationOrder, total);
        }
    }
}
