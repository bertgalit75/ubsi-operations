using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UBSI_Ops.server.Entities
{
    public class ImplementationOrder:IBaseEntity
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int ClientId { get; set; }

        public int AgencyId { get; set; }

        public int AccountExecutiveId { get; set; }

        public int Tagline { get; set; }

        public string Product { get; set; }

        public string BookingOrderNo { get; set; }

        public string PurchaseOrderNo { get; set; }

        public string ReferenceCENo { get; set; }

        public DateTime CreatedAt { get; }

        public string CreatedById { get; }

        public DateTime UpdatedAt { get; }

        public string UpdatedById { get; }
    }
}
