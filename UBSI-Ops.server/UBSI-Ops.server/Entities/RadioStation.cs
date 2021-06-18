using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UBSI_Ops.server.Entities
{
    public class RadioStation
    {
        public int Id { get; private set; }
        public string stn_code { get; set; }
        public string stn_name { get; set; }
    }
}
