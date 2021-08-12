using Ropes.API.CertificatesofPerformance.Models;
using System;

namespace Ropes.API.CertificatesofPerformanceTimeLogs.Models
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
