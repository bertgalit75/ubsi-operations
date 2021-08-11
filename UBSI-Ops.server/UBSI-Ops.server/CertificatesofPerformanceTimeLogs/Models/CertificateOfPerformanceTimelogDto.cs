using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.CertificatesofPerformance.Models;

namespace UBSI_Ops.server.CertificatesofPerformanceTimeLogs.Models
{
    public class CertificateOfPerformanceTimeLogDto
    {
        public string Code { get; set; }

        public string CertificateOfPerformanceCode { get; set; }

        public DateTime Date { get; set; }

        public DateTime Timestamp { get; set; }

        public CertificateOfPerformanceDto CertificateOfPerformance { get; set; }
    }
}
