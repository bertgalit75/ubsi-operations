using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.MediaAgencies.Models;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Services.Intefaces
{
    public interface IMediaAgencyRepository
    {
        Task<MediaAgency> CreateMediaAgency(MediaAgency mediaAgency);
    }
}
