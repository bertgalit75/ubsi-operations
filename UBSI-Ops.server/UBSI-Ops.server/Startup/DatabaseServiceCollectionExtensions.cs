using UBSI_Ops.server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace UBSI_Ops.server
{
    public static class DatabaseServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OperationContext>(options =>
            {
                options.UseOracle(configuration.GetConnectionString("operations"));
            });

            return services;
        }
    }
}
