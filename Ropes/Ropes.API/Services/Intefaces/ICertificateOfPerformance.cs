using Ropes.API.CertificateOfPerformances;
using Ropes.API.Core.Paging;
using System.Threading.Tasks;

namespace Ropes.API.Services.Intefaces
{
    public interface ICertificateOfPerformance
    {
        Task<PaginatedList<CertificateOfPerformance>> ListCP(PageOptions options);
    }
}
