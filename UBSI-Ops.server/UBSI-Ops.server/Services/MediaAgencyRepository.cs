using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.MediaAgencies.Models;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Services
{
    public class MediaAgencyRepository : Repository, IMediaAgencyRepository
    {
        public MediaAgencyRepository(OperationContext context) : base(context)
        {

        }

        public async Task<MediaAgency> CreateMediaAgency(MediaAgency mediaAgency)
        {
            await _context.MediaAgencies.AddAsync(mediaAgency);
            await _context.SaveChangesAsync();

            return mediaAgency;
        }
    }
}
