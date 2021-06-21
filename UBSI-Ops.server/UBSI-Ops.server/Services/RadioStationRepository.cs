using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Extensions;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Services
{
    public class RadioStationRepository:Repository,IRadioStationRepository
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
            return await _context.RadioStations.Where(x=>x.Code== stationCode).FirstOrDefaultAsync();
        }
    }
}
