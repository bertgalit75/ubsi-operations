using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Services.Intefaces
{
    public interface IRadioStationRepository
    {
        Task<PaginatedList<RadioStation>> List(PageOptions _options);
        Task<RadioStation> View(string _stationCode);
    }
}
