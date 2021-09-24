using Ropes.API.Companies.Models;
using Ropes.API.ConsolidationAccounts.Models;

namespace Ropes.API.ChartOfAccounts.Models
{
    public class ChartOfAccountDto
    {
        public string Code { get; set; }

        public string CompanyCode { get; set; }

        public CompanyDto Company { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }

        public string Balance { get; set; }

        public string Class { get; set; }

        public string Description { get; set; }

        public string ConsolidationAccountCode { get; set; }

        public ConsolidationAccountDto ConsolidationAccount { get; set; }
    }
}
