using Microsoft.EntityFrameworkCore;
using Ropes.API.Core.Extensions;
using Ropes.API.Core.Paging;
using Ropes.API.Data;
using Ropes.API.Entities;
using Ropes.API.Services;
using System.Linq;
using System.Threading.Tasks;

namespace Ropes.API.Permissions
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
