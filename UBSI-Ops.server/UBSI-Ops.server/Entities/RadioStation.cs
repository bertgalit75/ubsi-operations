using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UBSI_Ops.server.Entities
{
    public class RadioStation
    {
        public string StationName { get; set; }
        public string StationCode { get; set; }
    }
}
