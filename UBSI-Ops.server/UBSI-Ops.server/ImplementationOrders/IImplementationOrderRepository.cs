using System.Threading.Tasks;
using UBSI_Ops.server.ImplementationOrders;

namespace UBSI_Ops.server.Services.Intefaces
{
    public interface IImplementationOrderRepository
    {
        Task Add(ImplementationOrder implementationOrder);
    }
}
