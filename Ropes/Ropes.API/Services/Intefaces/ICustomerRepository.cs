using System.Threading.Tasks;
using Ropes.API.Core.Paging;
using Ropes.API.Entities;

namespace Ropes.API.Services.Intefaces
{
    public interface ICustomerRepository
    {
        Task<PaginatedList<Customer>> List(PageOptions options);

        Task<PaginatedList<Customer>> SearchList(PageOptions options, string search);

        Task<Customer> View(string _search);
    }
}
