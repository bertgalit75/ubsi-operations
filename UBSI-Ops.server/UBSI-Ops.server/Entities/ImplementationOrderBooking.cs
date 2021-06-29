using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UBSI_Ops.server.Entities
{
    public class ImplementationOrderBooking :IBaseEntity
    {
        public int Id { get; set; }

        public int ImplementationOrderId { get; set; }

        public int StationId { get; set; }

        public DateTime PeriodStart  { get; set; }

        public DateTime PeriodEnd { get; set; }

        public int Duration { get; set; }

        public int Spot { get; set; }

        public int Gross { get; set; }

        public DateTime CreatedAt { get; }

        public string CreatedById { get; }

        public DateTime UpdatedAt { get; }

        public string UpdatedById { get; }

        public ImplementationOrder ImplementationOrder { get; set; }
    }
}
