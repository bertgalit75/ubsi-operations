using System.Collections.Generic;
using System.Threading.Tasks;
using UBSI_Ops.server.Entities.Identity;

namespace UBSI_Ops.server.Services.Intefaces
{
    public interface IUserRoleRepository
    {
        Task<IEnumerable<UserRole>> GetUserRolesByUsers(IEnumerable<User> users);
    }
}
