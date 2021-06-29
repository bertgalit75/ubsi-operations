using System;

namespace UBSI_Ops.server.Entities
{
    public class ImplementationOrderBooking : IBaseEntity
    {
        public int Code { get; set; }

        public int ImplementationOrderCode { get; set; }

        public string StationCode { get; set; }

        public DateTime PeriodStart { get; set; }

        public DateTime PeriodEnd { get; set; }

        public int Duration { get; set; }

        public int Spot { get; set; }

        public decimal Gross { get; set; }

        public DateTime CreatedAt { get; }

        public string CreatedByCode { get; }

        public DateTime UpdatedAt { get; }

        public string UpdatedByCode { get; }

        public ImplementationOrder ImplementationOrder { get; set; }
    }
}
