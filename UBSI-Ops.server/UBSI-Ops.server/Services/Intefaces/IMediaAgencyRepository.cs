using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Services.Intefaces
{
    public interface IMediaAgencyRepository
    {
        Task<MediaAgency> CreateMediaAgency(MediaAgency mediaAgency);

        Task<PaginatedList<MediaAgency>> List(PageOptions options);

        Task<MediaAgency> View(string code);
    }
}
