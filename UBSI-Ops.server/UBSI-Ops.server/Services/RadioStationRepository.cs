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
                "code" => query.OrderBy(t => t.STN_CODE, options.Direction),
                "name" => query.OrderBy(t => t.STN_NAME, options.Direction),
                _ => query
            };

            var radioStations = await query
                .Page(options)
                .ToListAsync();

            var total = await query.CountAsync();

            return new PaginatedList<RadioStation>(radioStations, total);
        }
    }
}
