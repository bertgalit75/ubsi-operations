using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Data.Seed;

namespace UBSI_Ops.server
{
    public static class DatabaseServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            switch (configuration["Database:Type"])
            {
                case "oracle":
                    {
                        AddOracle(services, configuration);
                        break;
                    }
                case "inmemory":
                    {
                        AddInMemory(services);
                        break;
                    }
            };

            return services;
        }

        private static void AddOracle(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OperationContext>(options =>
            {
                options.UseOracle(configuration.GetConnectionString("operations"));
            });
        }

        private static void AddInMemory(IServiceCollection services)
        {
            services.AddDbContext<OperationContext>(options =>
            {
                options.UseInMemoryDatabase("InMemoryDbTesting");
            });

            var sp = services.BuildServiceProvider();
            using var scope = sp.CreateScope();

            var scopedServices = scope.ServiceProvider;
            var context = scopedServices.GetRequiredService<OperationContext>();
            //var logger = scopedServices
            //    .GetRequiredService<ILogger>();

            context.Database.EnsureCreated();

            try
            {
                new OperationContextSeed().Seed(context).Wait();
            }
            catch (Exception ex)
            {
                //logger.LogError(ex, "An error occurred seeding the " +
                //    "database with test messages. Error: {Message}", ex.Message);
            }
        }
    }
}
