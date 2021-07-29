using System;

namespace UBSI_Ops.server.SalesInvoices
{
    public class SalesInvoice
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
    }
}
