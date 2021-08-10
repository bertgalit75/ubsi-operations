using System.Threading.Tasks;
using Ropes.API.Core.Paging;

namespace Ropes.API.BillingStatements
{
    public interface IBillingStatementRepository
    {
        Task<PaginatedList<BillingStatement>> List(PageOptions options);
    }
}
