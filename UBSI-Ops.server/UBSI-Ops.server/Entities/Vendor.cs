using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UBSI_Ops.server.Entities
{
    public class Vendor
    {
        public string VendorCode { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public string VendorType { get; set; }
        public string VendorTelephone { get; set; }
        public string VendorFAX { get; set; }
        public string VendorContact { get; set; }
        public string VendorTIN { get; set; }
        public string VendorCO { get; set; }
        public string VendorPAYTO { get; set; }
        public string IsUtility { get; set; }
    }
}
