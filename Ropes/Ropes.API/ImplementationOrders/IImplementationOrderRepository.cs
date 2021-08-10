using System.Threading.Tasks;
using Ropes.API.Core.Paging;
using Ropes.API.ImplementationOrders;

namespace Ropes.API.Services.Intefaces
{
    public interface IImplementationOrderRepository
    {
        Task Add(ImplementationOrder implementationOrder);

        Task<PaginatedList<ImplementationOrder>> Filter(PageOptions pageOptions, int year, int month);

        Task<PaginatedList<ImplementationOrder>> List(PageOptions options);
    }
}
