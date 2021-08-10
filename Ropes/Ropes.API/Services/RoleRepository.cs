using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ropes.API.Core.Extensions;
using Ropes.API.Core.Paging;
using Ropes.API.Data;
using Ropes.API.Entities.Identity;
using Ropes.API.Services.Intefaces;

namespace Ropes.API.Services
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
