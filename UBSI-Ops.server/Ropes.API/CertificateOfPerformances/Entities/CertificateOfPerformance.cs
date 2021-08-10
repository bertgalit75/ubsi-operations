using System;
using System.Collections.ObjectModel;
using Ropes.API.Entities;
using Ropes.API.ImplementationOrders;

namespace Ropes.API.CertificateOfPerformances
{
    public class CertificateOfPerformance : IBaseEntity
    {
        public string Code { get; set; }

        public string ImplementationOrderCode { get; set; }

        public ImplementationOrder ImplementationOrder { get; set; }

        public DateTime CreatedAt { get; }

        public string CreatedByCode { get; }

        public DateTime UpdatedAt { get; }

        public string UpdatedByCode { get; }

        public Collection<CertificateOfPerformanceTimelog> TimeLogs { get; set; }
    }
}
