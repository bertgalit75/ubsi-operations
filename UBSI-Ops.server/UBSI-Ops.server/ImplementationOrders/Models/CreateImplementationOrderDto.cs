using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UBSI_Ops.server.ImplementationOrders.Models
{
    public class CreateImplementationOrderDto
    {
        [Required]
        public string IONo { get; set; }

        public string AgencyCode { get; set; }

        [Required]
        public string AccountExecutiveCode { get; set; }

        [Required]
        public string ClientCode { get; set; }

        [Required]
        public DateTime IODate { get; set; }

        public string Product { get; set; }

        public string Tagline { get; set; }

        public string BookingOrderNo { get; set; }

        public string PurchaseOrderNo { get; set; }

        public string ReferenceCENo { get; set; }

        public ICollection<BookingDto> Bookings { get; set; }

        public class BookingDto
        {
            [Required]
            public string StationCode { get; set; }

            [Required]
            public DateTime PeriodStart { get; set; }

            [Required]
            public DateTime PeriodEnd { get; set; }

            public string Material { get; set; }

            public bool Monday { get; set; }

            public bool Tuesday { get; set; }

            public bool Wednesday { get; set; }

            public bool Thursday { get; set; }

            public bool Friday { get; set; }

            public bool Saturday { get; set; }

            public bool Sunday { get; set; }

            [Required]
            public int Quantity { get; set; }

            [Required]
            public int Duration { get; set; }

            [Required]
            public decimal Gross { get; set; }
        }
    }
}
