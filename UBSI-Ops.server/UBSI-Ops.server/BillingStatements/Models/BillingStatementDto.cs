using System;
using Ropes.API.Customers.Models;
using Ropes.API.ImplementationOrders;
using Ropes.API.MediaAgencies.Models;

namespace Ropes.API.BillingStatements.Models
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

        public int TotalAmount { get; set; }

        public string ImplmentationOrderCode { get; set; }

        public CustomerDto Customer { get; set; }

        public MediaAgencyDto MediaAgency { get; set; }

        public ImplementationOrder ImplementationOrder { get; set; }
    }
}
