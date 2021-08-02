using System;
using UBSI_Ops.server.Customers.Models;
using UBSI_Ops.server.ImplementationOrders;
using UBSI_Ops.server.MediaAgencies.Models;

namespace UBSI_Ops.server.BillingStatements.Models
{
    public class BillingStatementDto
    {
        public int Code { get; set; }

        public DateTime Date { get; set; }

        public string CustomerCode { get; set; }

        public string Encoder { get; set; }

        public string Printed { get; set; }

        public int FormNumber { get; set; }

        public string Frequency { get; set; }

        public string ContractNo { get; set; }

        public string ImplmentationOrderCode { get; set; }

        public CustomerDto Customer { get; set; }

        public MediaAgencyDto MediaAgency { get; set; }

        public ImplementationOrder ImplementationOrder { get; set; }
    }
}
