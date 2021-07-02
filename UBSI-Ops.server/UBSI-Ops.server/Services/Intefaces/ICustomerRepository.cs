using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Services.Intefaces
{
    public interface ICustomerRepository
    {
        Task<PaginatedList<Customer>> List(PageOptions options);
        Task<PaginatedList<Customer>> SearchList(PageOptions options, string search);
        Task<Customer> View(string _search);
    }
}
