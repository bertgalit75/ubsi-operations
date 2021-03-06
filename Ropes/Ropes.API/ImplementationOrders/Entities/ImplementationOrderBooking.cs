using System;
using Ropes.API.Entities;

namespace Ropes.API.ImplementationOrders
{
    public class ImplementationOrderBooking : IBaseEntity
    {
        public int Code { get; set; }

        public string ImplementationOrderCode { get; set; }

        public string StationCode { get; set; }

        public DateTime PeriodStart { get; set; }

        public DateTime PeriodEnd { get; set; }

        public int Duration { get; set; }

        public int NoOfSpots { get; set; }

        public decimal GrossAmount { get; set; }

        public bool Monday { get; set; }

        public bool Tuesday { get; set; }

        public bool Wednesday { get; set; }

        public bool Thursday { get; set; }

        public bool Friday { get; set; }

        public bool Saturday { get; set; }

        public bool Sunday { get; set; }

        public DateTime CreatedAt { get; }

        public string CreatedByCode { get; }

        public DateTime UpdatedAt { get; }

        public string UpdatedByCode { get; }

        public ImplementationOrder ImplementationOrder { get; set; }
    }
}
