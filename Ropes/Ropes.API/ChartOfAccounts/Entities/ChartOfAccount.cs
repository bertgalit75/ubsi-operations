using Ropes.API.Companies;
using Ropes.API.ConsolidationAccounts;

namespace Ropes.API.ChartOfAccounts
{
    public class ChartOfAccount
    {
        public string Code { get; set; }

        public string CompanyCode { get; set; }

        public Company Company { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }

        public string Balance { get; set; }

        public string Class { get; set; }

        public string Description { get; set; }

        public string ConsolidationAccountCode { get; set; }

        public ConsolidationAccount ConsolidationAccount { get; set; }
    }
}
