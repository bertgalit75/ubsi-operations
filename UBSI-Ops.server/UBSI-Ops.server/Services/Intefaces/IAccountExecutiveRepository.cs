using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Services.Intefaces
{
    public interface IAccountExecutiveRepository
    {
        Task<PaginatedList<AccountExecutive>> List(PageOptions _options);
        Task<AccountExecutive> View(string _code);
    }
}
