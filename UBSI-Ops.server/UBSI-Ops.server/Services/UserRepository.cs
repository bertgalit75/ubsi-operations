using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Ropes.API.Core.Extensions;
using Ropes.API.Core.Paging;
using Ropes.API.Data;
using Ropes.API.Entities.Identity;
using Ropes.API.Services.Intefaces;

namespace Ropes.API.Services
{
    public class UserRepository : Repository, IUserRepository
    {
        private readonly IMapper _mapper;

        public UserRepository(OperationContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
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

            //var query = _context.Users.AsQueryable();

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
