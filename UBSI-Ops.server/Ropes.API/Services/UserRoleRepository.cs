using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ropes.API.Data;
using Ropes.API.Entities.Identity;
using Ropes.API.Services.Intefaces;

namespace Ropes.API.Services
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
