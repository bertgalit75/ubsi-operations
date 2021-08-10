namespace Ropes.API.BillingStatements
{
    public class BillingStatementItem
    {
        public int BillingStatementCode { get; set; }

        public string Particular { get; set; }

        public int DNO { get; set; }

        public int Gross { get; set; }

        public int Discount { get; set; }

        public int NetPrice { get; set; }

        public BillingStatement BillingStatement { get; set; }
    }
}
