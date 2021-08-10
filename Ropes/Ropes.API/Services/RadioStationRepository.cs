using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Ropes.API.Core.Extensions;
using Ropes.API.Core.Paging;
using Ropes.API.Data;
using Ropes.API.Entities;
using Ropes.API.Services.Intefaces;

namespace Ropes.API.Services
{
    public class RadioStationRepository : Repository, IRadioStationRepository
    {
        public RadioStationRepository(OperationContext operationContext) : base(operationContext)
        {
        }

        public async Task<PaginatedList<RadioStation>> List(PageOptions options)
        {
            var query = _context.RadioStations.AsQueryable();

            query = options.Sort switch
            {
                "code" => query.OrderBy(t => t.Code, options.Direction),
                "name" => query.OrderBy(t => t.Name, options.Direction),
                _ => query
            };

            var radioStations = await query
                .Page(options)
                .ToListAsync();

            var total = await query.CountAsync();

            return new PaginatedList<RadioStation>(radioStations, total);
        }

        public async Task<RadioStation> View(string stationCode)
        {
            return await _context.RadioStations.Where(x => x.Code == stationCode).FirstOrDefaultAsync();
        }
    }
}
