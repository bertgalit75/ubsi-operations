using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.CertificateOfPerformances;
using UBSI_Ops.server.CertificatesofPerformanceTimeLogs.Models;
using UBSI_Ops.server.ImplementationOrders.Models;

namespace UBSI_Ops.server.CertificatesofPerformance.Models
{
    public class CertificateOfPerformanceDto
    {
        public string Code { get; set; }

        public string ImplementationOrderCode { get; set; }

        public ImplementationOrderDto ImplementationOrder { get; set; }

        public Collection<CertificateOfPerformanceTimeLogDto> TimeLogs { get; set; }
    }
}
