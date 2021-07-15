

using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Extensions;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Entities.Identity;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Services
{
    public class UserRepository : Repository, IUserRepository
    {
        public UserRepository(OperationContext context) : base(context)
        {

        }

        public async Task<UserRole> GetUserRole(string id)
        {
            UserRole role = await _context.UserRoles.Where(r => r.RoleId == "1").FirstOrDefaultAsync();

            return role;
        }

        public async Task<PaginatedList<User>> List(PageOptions options)
        {
            string direction = null;

            if (options.Direction == "ascend") { direction = "asc"; }

            else if (options.Direction == "descend") { direction = "desc"; }

            var query = _context.Users.
                AsQueryable();

            query = options.Sort switch
            {
                "name" => query.OrderBy(t => t.Name, direction),
                "email" => query.OrderBy(x => x.Email, direction),
                _ => query
            };

            var users = await query
                .Page(options)
                .ToListAsync();

            var total = await query.CountAsync();

            return new PaginatedList<User>(users, total);
        }
    }
}
