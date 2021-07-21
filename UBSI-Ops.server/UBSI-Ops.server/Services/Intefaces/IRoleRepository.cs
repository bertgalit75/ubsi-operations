using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Entities.Identity;

namespace UBSI_Ops.server.Services.Intefaces
{
    public interface IRoleRepository
    {
        Task<IEnumerable<Role>> GetRolesByUserRole(IEnumerable<UserRole> userRoles);
    }
}
