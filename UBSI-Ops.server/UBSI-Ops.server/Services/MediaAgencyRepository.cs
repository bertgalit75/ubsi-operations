using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Extensions;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Services
{
    public class MediaAgencyRepository : Repository, IMediaAgencyRepository
    {
        public MediaAgencyRepository(OperationContext context) : base(context)
        {
        }

        public async Task<MediaAgency> CreateMediaAgency(MediaAgency mediaAgency)
        {
            await _context.MediaAgencies.AddAsync(mediaAgency);
            await _context.SaveChangesAsync();

            return mediaAgency;
        }

        public async Task<PaginatedList<MediaAgency>> List(PageOptions options)
        {
            string direction = null;

            if (options.Direction == "ascend") { direction = "asc"; }
            else if (options.Direction == "descend") { direction = "desc"; }

            var query = _context.MediaAgencies.AsQueryable();

            query = options.Sort switch
            {
                "code" => query.OrderBy(t => t.Code, direction),
                "name" => query.OrderBy(t => t.Name, direction),
                "address" => query.OrderBy(t => t.AddressLine + " " + t.City + ", " + t.Province, direction),
                _ => query
            };

            var mediaAgencies = await query
                .Page(options)
                .ToListAsync();

            var total = await query.CountAsync();

            return new PaginatedList<MediaAgency>(mediaAgencies, total);
        }
    }
}
