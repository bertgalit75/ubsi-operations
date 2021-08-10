using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Ropes.API.Core.Extensions;
using Ropes.API.Core.Paging;
using Ropes.API.Data;
using Ropes.API.Services;

namespace Ropes.API.BillingStatements
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
                "date" => query.OrderBy(t => t.Date, direction),
                "perno" => query.OrderBy(t => t.Date.Year + t.Date.Month, direction),
                "formNumber" => query.OrderBy(t => t.FormNumber, direction),
                "aeCode" => query.OrderBy(t => t.Customer.AECode, direction),
                "aeName" => query.OrderBy(t => t.Customer.AEName, direction),
                "customerCode" => query.OrderBy(t => t.Customer.Code, direction),
                "customerName" => query.OrderBy(t => t.Customer.Name, direction),
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
