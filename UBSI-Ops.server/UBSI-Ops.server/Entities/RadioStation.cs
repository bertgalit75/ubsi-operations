using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UBSI_Ops.server.Entities
{
    public class RadioStation
    {
        public string stn_code { get; set; }
        public string stn_name { get; set; }
    }
}
