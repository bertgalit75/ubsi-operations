using Ropes.API.ChartOfAccounts;
using System.Collections.ObjectModel;

namespace Ropes.API.Companies
{
    public class Company
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string TIN { get; set; }

        public string SSS { get; set; }

        public string SigName { get; set; }

        public string SigPos { get; set; }

        public string SigTIN { get; set; }

        public Collection<ChartOfAccount> ChartOfAccounts { get; set; }
    }
}
