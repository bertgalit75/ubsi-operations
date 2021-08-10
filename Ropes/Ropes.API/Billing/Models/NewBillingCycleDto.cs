using System;

namespace Ropes.API.Billing.Models
{
    public class NewBillingCycleDto
    {
        public DateTime PeriodStart { get; set; }

        public DateTime PeriodEnd { get; set; }
    }
}
