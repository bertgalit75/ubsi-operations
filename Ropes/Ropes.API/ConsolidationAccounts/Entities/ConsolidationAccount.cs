using Ropes.API.ChartOfAccounts;
using System.Collections.ObjectModel;

namespace Ropes.API.ConsolidationAccounts
{
    public class ConsolidationAccount
    {
        public string Code { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }

        public string Class { get; set; }

        public string Balance { get; set; }

        public Collection<ChartOfAccount> ChartOfAccounts { get; set; }
    }
}
