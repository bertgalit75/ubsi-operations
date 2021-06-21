namespace UBSI_Ops.server.Customers.Models
{
    public class CustomerDto
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string BillingAddress { get; set; }

        public string RegionCode { get; set; }

        public string AreaCode { get; set; }

        public decimal CreditLimit { get; set; }

        public string IsVatInclusive { get; set; }

        public string CreditStatus { get; set; }

        public string IsActive { get; set; }

        public string AECode { get; set; }

        public string AEName { get; set; }

        public string Telephone { get; set; }

        public string Fax { get; set; }

        public string ContactPerson { get; set; }

        //public string CO_CODE { get; set; }

        public string CreditTermsCode { get; set; }

        public string GroupCode { get; set; }

        public string Type { get; set; }

        public string TIN { get; set; }
    }
}
