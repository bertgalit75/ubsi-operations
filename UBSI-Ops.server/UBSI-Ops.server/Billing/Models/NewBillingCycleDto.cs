using System;

namespace UBSI_Ops.server.Billing.Models
{
    public class NewBillingCycleDto
    {
        public DateTime PeriodStart { get; set; }

        public DateTime PeriodEnd { get; set; }
    }
}
