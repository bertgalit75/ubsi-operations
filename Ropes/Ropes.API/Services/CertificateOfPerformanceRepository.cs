using Microsoft.EntityFrameworkCore;
using Ropes.API.CertificateOfPerformances;
using Ropes.API.Core.Extensions;
using Ropes.API.Core.Paging;
using Ropes.API.Data;
using Ropes.API.Services.Intefaces;
using System.Linq;
using System.Threading.Tasks;

namespace Ropes.API.Services
{
    public class CertificateOfPerformanceRepository : Repository, ICertificateOfPerformance
    {
        public CertificateOfPerformanceRepository(OperationContext context) : base(context)
        {
        }

        public async Task<PaginatedList<CertificateOfPerformance>> ListCP(PageOptions options)
        {
            string direction = null;

            if (options.Direction == "ascend") { direction = "asc"; }
            else if (options.Direction == "descend") { direction = "desc"; }

            //var query = _context.Users.AsQueryable();

            var query = _context.CertificateOfPerformances.Include(c => c.ImplementationOrder).Include(c => c.TimeLogs).
                AsQueryable();

            query = options.Sort switch
            {
                "code" => query.OrderBy(t => t.Code, direction),
                "implementationOrderCode" => query.OrderBy(x => x.ImplementationOrderCode, direction),
                _ => query
            };

            var cps = await query
                .Page(options)
                .ToListAsync();

            var total = await query.CountAsync();

            return new PaginatedList<CertificateOfPerformance>(cps, total);
        }
    }
}
