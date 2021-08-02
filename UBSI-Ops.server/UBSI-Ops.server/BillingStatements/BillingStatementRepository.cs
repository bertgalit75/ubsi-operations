using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Extensions;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Services;

namespace UBSI_Ops.server.BillingStatements
{
    public class BillingStatementRepository : Repository, IBillingStatementRepository
    {
        public BillingStatementRepository(OperationContext context)
            : base(context)
        {
        }

        public async Task<PaginatedList<BillingStatement>> List(PageOptions options)
        {
            string direction = null;

            if (options.Direction == "ascend") { direction = "asc"; }
            else if (options.Direction == "descend") { direction = "desc"; }

            var query = _context.BillingStatements.Include(t => t.Customer).Include(t => t.MediaAgency).
                AsQueryable();
            query = options.Sort switch
            {
                "customerCode" => query.OrderBy(t => t.Code, direction),

                _ => query
            };

            var billingStatements = await query
                .Page(options)
                .ToListAsync();

            var total = await query.CountAsync();

            return new PaginatedList<BillingStatement>(billingStatements, total);
        }
    }
}
