using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Entities.Identity;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Services
{
    public class RoleRepository : Repository, IRoleRepository
    {
        public RoleRepository(OperationContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Role>> GetRolesByUserRole(IEnumerable<UserRole> userRoles)
        {
            return await _context.Roles.Where(r => userRoles.Select(ur => ur.RoleId).Contains(r.Id)).ToListAsync();
        }
    }
}
