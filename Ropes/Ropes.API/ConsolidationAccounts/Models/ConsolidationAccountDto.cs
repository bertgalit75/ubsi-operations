using Ropes.API.ChartOfAccounts.Models;
using System.Collections.ObjectModel;

namespace Ropes.API.ConsolidationAccounts.Models
{
    public class ConsolidationAccountDto
    {
        public string Code { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }

        public string Class { get; set; }

        public string Balance { get; set; }

        public Collection<ChartOfAccountDto> ChartOfAccounts { get; set; }
    }
}
