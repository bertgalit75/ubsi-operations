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
    public class UserRoleRepository : Repository, IUserRoleRepository
    {
        public UserRoleRepository(OperationContext context) : base(context)
        {
        }

        public async Task<IEnumerable<UserRole>> GetUserRolesByUsers(IEnumerable<User> users)
        {
            return await _context.UserRoles.Where(ur => users.Select(u => u.Id).Contains(ur.UserId)).ToListAsync();
        }
    }
}
