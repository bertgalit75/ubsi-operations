using System.Threading.Tasks;
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
    }
}
