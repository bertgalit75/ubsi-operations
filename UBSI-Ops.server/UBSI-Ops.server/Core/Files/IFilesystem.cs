using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace UBSI_Ops.server.Core.Files
{
    public interface IFilesystem
    {
        Task<string> Move(IFormFile file, string destFile);

        Task<string> Move(Stream stream, string destFile);

        Task<Stream> Get(string location);

        Task Remove(string location);
    }
}
