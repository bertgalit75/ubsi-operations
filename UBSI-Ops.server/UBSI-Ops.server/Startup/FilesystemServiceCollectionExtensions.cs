using UBSI_Ops.server.Core.Files;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace UBSI_Ops.server
{
    public static class FilesystemServiceCollectionExtensions
    {
        public static IServiceCollection AddFilesystem(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IFilesystem>(serviceProvider =>
            {
                return (configuration["Filesystem:Type"]) switch
                {
                    "local" => new LocalFilesystem(configuration["Filesystem:RootDirectory"]),
                    "s3" => new S3Filesystem(configuration["Filesystem:Bucket"]),
                    "memory" => new MemoryFileSystem(),
                    _ => new NullFilesystem(),
                };
            });

            return services;
        }
    }
}
