using System;

namespace Ropes.API.CertificateOfPerformances
{
    public class CertificateOfPerformanceTimelog
    {
        public string Code { get; set; }

        public string CertificateOfPerformanceCode { get; set; }

        public DateTime Date { get; set; }

        public DateTime Timestamp { get; set; }

        public CertificateOfPerformance CertificateOfPerformance { get; set; }
    }
}
