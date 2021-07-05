﻿using System;

namespace UBSI_Ops.server.Entities
{
    public class ImplementationOrder : IBaseEntity
    {
        public int Code { get; set; }

        public DateTime Date { get; set; }

        public string ClientCode { get; set; }

        public string AgencyCode { get; set; }

        public string AccountExecutiveCode { get; set; }

        public string Tagline { get; set; }

        public string ProductCode { get; set; }

        public string BookingOrderNo { get; set; }

        public string PurchaseOrderNo { get; set; }

        public string ReferenceCENo { get; set; }

        public DateTime CreatedAt { get; }

        public string CreatedByCode { get; }

        public DateTime UpdatedAt { get; }

        public string UpdatedByCode { get; }
    }
}