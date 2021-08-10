using System.Collections.Generic;
using System.Threading.Tasks;
using Ropes.API.Core.Paging;
using Ropes.API.Entities.Identity;

namespace Ropes.API.Services.Intefaces
{
    public interface IRoleRepository
    {
        Task<PaginatedList<Role>> List(PageOptions _options);

        Task<IEnumerable<Role>> GetRolesByUserRole(IEnumerable<UserRole> userRoles);
    }
}
