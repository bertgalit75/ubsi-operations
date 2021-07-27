using System.Collections.Generic;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Entities.Identity;

namespace UBSI_Ops.server.Services.Intefaces
{
    public interface IRoleRepository
    {
        Task<PaginatedList<Role>> List(PageOptions _options);

        Task<IEnumerable<Role>> GetRolesByUserRole(IEnumerable<UserRole> userRoles);
    }
}
