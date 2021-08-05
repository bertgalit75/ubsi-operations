using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;

namespace UBSI_Ops.server.BillingStatements
{
    public interface IBillingStatementRepository
    {
        Task<PaginatedList<BillingStatement>> List(PageOptions options);
    }
}
