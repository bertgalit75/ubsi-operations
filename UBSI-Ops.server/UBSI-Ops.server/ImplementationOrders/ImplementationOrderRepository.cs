using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Extensions;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.ImplementationOrders;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Services
{
    public class ImplementationOrderRepository : Repository, IImplementationOrderRepository
    {
        private readonly IMediaAgencyRepository _mediaAgencyRepository;

        public ImplementationOrderRepository(OperationContext context, IMediaAgencyRepository mediaAgencyRepository)
            : base(context)
        {
            _mediaAgencyRepository = mediaAgencyRepository;
        }

        public async Task Add(ImplementationOrder implementationOrder)
        {
            if (implementationOrder.AgencyCode != null)
            {
                var agency = await _mediaAgencyRepository.View(implementationOrder.AgencyCode);

                if (agency != null)
                {
                    _context.ImplementationOrders.Add(implementationOrder);
                    await _context.SaveChangesAsync();
                }
            }
            else
            {
                _context.ImplementationOrders.Add(implementationOrder);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<PaginatedList<ImplementationOrder>> List(PageOptions options)
        {
            string direction = null;

            if (options.Direction == "ascend") { direction = "asc"; }
            else if (options.Direction == "descend") { direction = "desc"; }

            var query = _context.ImplementationOrders.Include(x => x.Bookings).Include(x => x.MediaAgency).Include(x => x.Customer).AsQueryable();

            query = options.Sort switch
            {
                "code" => query.OrderBy(t => t.Code, direction),
                "client" => query.OrderBy(t => t.Customer.Name, direction),
                "agency" => query.OrderBy(t => t.MediaAgency.Name, direction),
                "date" => query.OrderBy(t => t.Date, direction),
                "product" => query.OrderBy(t => t.Product, direction),
                _ => query
            };

            var mediaAgencies = await query
                .Page(options)
                .ToListAsync();

            var total = await query.CountAsync();

            return new PaginatedList<ImplementationOrder>(mediaAgencies, total);
        }
    }
}
