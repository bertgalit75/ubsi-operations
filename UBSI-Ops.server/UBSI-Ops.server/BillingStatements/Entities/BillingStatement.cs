using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.ImplementationOrders;

namespace UBSI_Ops.server.BillingStatements
{
    public class BillingStatement
    {
        public int Code { get; set; }

        public DateTime Date { get; set; }

        public string CustomerCode { get; set; }

        public string Encoder { get; set; }

        public string Printed { get; set; }

        public int FormNumber { get; set; }

        public string Frequency { get; set; }

        public string ContractNo { get; set; }

        public string CPNO { get; set; }

        public string BONO { get; set; }

        public string CENO { get; set; }

        public string ImplmentationOrderCode { get; set; }

        public string AgencyCode { get; set; }

        public Customer Customer { get; set; }

        public MediaAgency MediaAgency { get; set; }

        public ImplementationOrder ImplementationOrder { get; set; }

        public Collection<BillingStatementItem> BillingStatementItems { get; set; }

        [NotMapped]
        public int TotalAmount { get; set; }
    }
}
