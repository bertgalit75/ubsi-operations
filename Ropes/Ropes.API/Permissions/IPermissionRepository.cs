using Ropes.API.Core.Paging;
using Ropes.API.Entities;
using System.Threading.Tasks;

namespace Ropes.API.Permissions
{
    public interface IPermissionRepository
    {
        Task<PaginatedList<Permission>> List(PageOptions options);
    }
}
