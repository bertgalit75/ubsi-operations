using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Services.Intefaces
{
    public interface IFileEntryRepository
    {
        Task Create(FileEntry file);
    }
}
