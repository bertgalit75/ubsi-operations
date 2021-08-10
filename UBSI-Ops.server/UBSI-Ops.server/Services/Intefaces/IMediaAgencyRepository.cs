using System.Threading.Tasks;
using Ropes.API.Core.Paging;
using Ropes.API.Entities;

namespace Ropes.API.Services.Intefaces
{
    public interface IMediaAgencyRepository
    {
        Task<MediaAgency> CreateMediaAgency(MediaAgency mediaAgency);

        Task<PaginatedList<MediaAgency>> List(PageOptions options);

        Task<MediaAgency> View(string code);
    }
}
