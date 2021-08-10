using System.Threading.Tasks;
using Ropes.API.Core.Paging;
using Ropes.API.Entities;

namespace Ropes.API.Services.Intefaces
{
    public interface IVendorRepository
    {
        Task<PaginatedList<Vendor>> List(PageOptions _options);

        Task<Vendor> View(string _vendorCode);
    }
}
