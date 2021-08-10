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

        public async Task<MediaAgency> View(string code)
        {
            return await _context.MediaAgencies.Where(x => x.Code == code).FirstOrDefaultAsync();
        }
    }
}
