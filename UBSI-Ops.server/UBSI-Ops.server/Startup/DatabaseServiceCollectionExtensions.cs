using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UBSI_Ops.server.Data;

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
