using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ropes.API.Data;
using Ropes.API.Entities;
using Ropes.API.Services.Intefaces;

namespace Ropes.API.Services
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
