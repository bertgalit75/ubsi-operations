using System.Threading.Tasks;
using Ropes.API.Core.Paging;
using Ropes.API.Entities;

namespace Ropes.API.Services.Intefaces
{
    public interface IAccountExecutiveRepository
    {
        Task<PaginatedList<AccountExecutive>> List(PageOptions _options);

        Task<AccountExecutive> View(string _code);
    }
}
