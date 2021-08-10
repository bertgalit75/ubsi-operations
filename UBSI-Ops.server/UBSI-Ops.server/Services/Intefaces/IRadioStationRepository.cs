using System.Threading.Tasks;
using Ropes.API.Core.Paging;
using Ropes.API.Entities;

namespace Ropes.API.Services.Intefaces
{
    public interface IRadioStationRepository
    {
        Task<PaginatedList<RadioStation>> List(PageOptions _options);

        Task<RadioStation> View(string _stationCode);
    }
}
