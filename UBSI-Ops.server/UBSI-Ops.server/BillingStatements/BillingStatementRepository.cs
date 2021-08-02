using AutoMapper;
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
        private readonly IMapper _mapper;

        public BillingStatementRepository(OperationContext context, IMapper mapper)
            : base(context)
        {
            _mapper = mapper;
        }

        public async Task<PaginatedList<BillingStatement>> List(PageOptions options)
        {
            string direction = null;

            if (options.Direction == "ascend") { direction = "asc"; }
            else if (options.Direction == "descend") { direction = "desc"; }

            var query = _context.BillingStatements
                        .Include(t => t.Customer)
                        .Include(t => t.MediaAgency)
                        .AsQueryable();

            query.ForEachAsync(x =>
                    x.TotalAmount = _context.BillingStatementItems
                    .Where(c => c.BillingStatementCode == x.Code)
                    .Sum(x => x.NetPrice));

            query = options.Sort switch
            {
                "code" => query.OrderBy(t => t.Code, direction),
                "io" => query.OrderBy(t => t.ImplmentationOrderCode, direction),
                "client" => query.OrderBy(t => t.Customer.Name, direction),
                "agency" => query.OrderBy(t => t.MediaAgency.Name, direction),
                "totalAmount" => query.OrderBy(t => t.TotalAmount, direction),
                "date" => query.OrderBy(t => t.Date, direction),
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
