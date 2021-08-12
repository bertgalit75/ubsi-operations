using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Permissions
{
    public interface IPermissionRepository
    {
        Task<PaginatedList<Permission>> List(PageOptions options);
    }
}
