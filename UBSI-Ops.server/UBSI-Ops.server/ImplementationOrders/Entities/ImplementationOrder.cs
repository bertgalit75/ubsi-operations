using System;
using System.Collections.ObjectModel;
using UBSI_Ops.server.CertificateOfPerformances;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.ImplementationOrders
{
    public class ImplementationOrder : IBaseEntity
    {
        public string Code { get; set; }

        public DateTime Date { get; set; }

        public string ClientCode { get; set; }

        public string AgencyCode { get; set; }

        public string AccountExecutiveCode { get; set; }

        public string Tagline { get; set; }

        public string Product { get; set; }

        public string BookingOrderNo { get; set; }

        public string PurchaseOrderNo { get; set; }

        public string ReferenceCENo { get; set; }

        public DateTime CreatedAt { get; }

        public string CreatedByCode { get; }

        public DateTime UpdatedAt { get; }

        public string UpdatedByCode { get; }

        public Collection<ImplementationOrderBooking> Bookings { get; set; }

        public Collection<CertificateOfPerformance> Certifications { get; set; }

        public Customer Customer { get; set; }

        public MediaAgency MediaAgency { get; set; }
    }
}
