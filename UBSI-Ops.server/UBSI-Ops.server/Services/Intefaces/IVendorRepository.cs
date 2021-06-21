using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Services.Intefaces
{
    public interface IVendorRepository
    {
        Task<PaginatedList<Vendor>> List(PageOptions _options);
        Task<Vendor> View(string _vendorCode);
    }
}
