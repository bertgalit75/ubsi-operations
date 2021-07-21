using System.Threading.Tasks;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.ImplementationOrders;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Services
{
    public class ImplementationOrderRepository : Repository, IImplementationOrderRepository
    {
        public ImplementationOrderRepository(OperationContext context)
            : base(context)
        {
        }

        public async Task Add(ImplementationOrder implementationOrder)
        {
            _context.ImplementationOrders.Add(implementationOrder);
            await _context.SaveChangesAsync();
        }
    }
}
