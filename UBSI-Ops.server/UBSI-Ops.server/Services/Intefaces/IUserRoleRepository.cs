using System.Collections.Generic;
using System.Threading.Tasks;
using Ropes.API.Entities.Identity;

namespace Ropes.API.Services.Intefaces
{
    public interface IUserRoleRepository
    {
        Task<IEnumerable<UserRole>> GetUserRolesByUsers(IEnumerable<User> users);
    }
}
