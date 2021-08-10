using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ropes.API.Entities;

namespace Ropes.API.Services.Intefaces
{
    public interface IFileEntryRepository
    {
        Task Create(FileEntry file);
    }
}
