using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Entities.Identity;

namespace UBSI_Ops.server.Services.Intefaces
{
    public interface IUserRepository
    {
        Task<PaginatedList<User>> List(PageOptions options);

        Task<UserRole> GetUserRole(string id);
    }
}
