using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.Services
{
    public class FileEntryRepository : Repository, IFileEntryRepository
    {
        public FileEntryRepository(OperationContext context) : base(context)
        {

        }

        public async Task Create(FileEntry fileEntry)
        {
            _context.FileEntries.Add(fileEntry);
            await _context.SaveChangesAsync();
        }
    }
}
