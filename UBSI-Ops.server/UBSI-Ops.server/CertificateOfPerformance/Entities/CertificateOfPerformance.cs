using System;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.ImplementationOrders;

namespace UBSI_Ops.server.CertificateOfPerformances
{
    public class CertificateOfPerformance : IBaseEntity
    {
        public string Code { get; set; }

        public string ImplementationOrderCode { get; set; }

        public string File { get; set; }

        public ImplementationOrder ImplementationOrder { get; set; }

        public DateTime CreatedAt { get; }

        public string CreatedByCode { get; }

        public DateTime UpdatedAt { get; }

        public string UpdatedByCode { get; }
    }
}
