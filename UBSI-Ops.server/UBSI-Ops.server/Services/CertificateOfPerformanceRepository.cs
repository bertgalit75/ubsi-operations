using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.CertificateOfPerformances;
using UBSI_Ops.server.Core.Extensions;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Services
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
