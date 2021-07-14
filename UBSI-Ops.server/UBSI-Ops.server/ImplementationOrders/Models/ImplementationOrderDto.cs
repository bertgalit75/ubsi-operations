using System;
using System.Collections.ObjectModel;

namespace UBSI_Ops.server.ImplementationOrders.Models
{
    public class ImplementationOrderDto
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

        public Collection<BookingDto> Bookings { get; set; }

        public class BookingDto
        {
            public int Code { get; set; }

            public string StationCode { get; set; }

            public DateTime PeriodStart { get; set; }

            public DateTime PeriodEnd { get; set; }

            public int Duration { get; set; }

            public int Spot { get; set; }

            public decimal Gross { get; set; }

            public bool Monday { get; set; }

            public bool Tuesday { get; set; }

            public bool Wednesday { get; set; }

            public bool Thursday { get; set; }

            public bool Friday { get; set; }

            public bool Saturday { get; set; }

            public bool Sunday { get; set; }
        }
    }
}
