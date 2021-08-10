using System.Threading.Tasks;
using Ropes.API.Core.Paging;
using Ropes.API.Entities.Identity;

namespace Ropes.API.Services.Intefaces
{
    public interface IUserRepository
    {
        Task<PaginatedList<User>> List(PageOptions options);

        Task<UserRole> GetUserRole(string id);
    }
}
