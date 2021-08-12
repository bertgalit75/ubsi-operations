using Ropes.API.CertificatesofPerformanceTimeLogs.Models;
using Ropes.API.ImplementationOrders.Models;
using System.Collections.ObjectModel;

namespace Ropes.API.CertificatesofPerformance.Models
{
    public class CertificateOfPerformanceDto
    {
        public string Code { get; set; }

        public string ImplementationOrderCode { get; set; }

        public ImplementationOrderDto ImplementationOrder { get; set; }

        public Collection<CertificateOfPerformanceTimeLogDto> TimeLogs { get; set; }
    }
}
