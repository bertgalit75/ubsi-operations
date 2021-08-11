using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Extensions;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.Services;

namespace UBSI_Ops.server.Permissions
{
    public class PermissionRepository : Repository, IPermissionRepository
    {
        public PermissionRepository(OperationContext context)
           : base(context)
        {
        }

        public async Task<PaginatedList<Permission>> List(PageOptions options)
        {
            string direction = null;

            if (options.Direction == "ascend") { direction = "asc"; }
            else if (options.Direction == "descend") { direction = "desc"; }

            var query = _context.Permissions.AsQueryable();

            query = options.Sort switch
            {
                "name" => query.OrderBy(t => t.Code, direction),
                _ => query
            };

            var permissions = await query
                .Page(options)
                .ToListAsync();

            var total = await query.CountAsync();

            return new PaginatedList<Permission>(permissions, total);
        }
    }
}
