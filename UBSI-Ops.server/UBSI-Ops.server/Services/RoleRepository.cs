using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Extensions;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Entities.Identity;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Services
{
    public class RoleRepository : Repository, IRoleRepository
    {
        public RoleRepository(OperationContext operationContext) : base(operationContext)
        {
        }

        public async Task<PaginatedList<Role>> List(PageOptions options)
        {
            string direction = null;

            if (options.Direction == "ascend") { direction = "asc"; }
            else if (options.Direction == "descend") { direction = "desc"; }

            var query = _context.Roles.AsQueryable();

            query = options.Sort switch
            {
                "code" => query.OrderBy(t => t.Id, direction),
                "name" => query.OrderBy(t => t.Name, direction),
                _ => query
            };

            var radioStations = await query
                .Page(options)
                .ToListAsync();

            var total = await query.CountAsync();

            return new PaginatedList<Role>(radioStations, total);
        }

        public async Task<IEnumerable<Role>> GetRolesByUserRole(IEnumerable<UserRole> userRoles)
        {
            return await _context.Roles.Where(r => userRoles.Select(ur => ur.RoleId).Contains(r.Id)).ToListAsync();
        }
    }
}
