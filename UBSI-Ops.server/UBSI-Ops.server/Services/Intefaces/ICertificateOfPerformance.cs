using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.CertificateOfPerformances;
using UBSI_Ops.server.CertificatesofPerformance.Models;
using UBSI_Ops.server.Core.Paging;

namespace UBSI_Ops.server.Services.Intefaces
{
    public interface ICertificateOfPerformance
    {
        Task<PaginatedList<CertificateOfPerformance>> ListCP(PageOptions options);
    }
}
