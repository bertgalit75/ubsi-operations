using Hangfire;
using Hangfire.Oracle.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace UBSI_Ops.server
{
    public static class HangfireServiceCollectionExtensions
    {
        public static IServiceCollection AddHangfireService(this IServiceCollection services, IConfiguration configuration)
        {
            switch (configuration["Hangfire:Type"])
            {
                case "oracle":
                    {
                        UseOracle(services, configuration);
                        break;
                    }
            }

            return services;
        }

        private static void UseOracle(IServiceCollection services, IConfiguration configuration)
        {
            GlobalConfiguration.Configuration.UseStorage(new OracleStorage(
                configuration.GetConnectionString("hangfire"),
                new OracleStorageOptions
                {
                    TransactionIsolationLevel = System.Data.IsolationLevel.ReadCommitted,
                    QueuePollInterval = TimeSpan.FromSeconds(15),
                    JobExpirationCheckInterval = TimeSpan.FromHours(1),
                    CountersAggregateInterval = TimeSpan.FromMinutes(5),
                    PrepareSchemaIfNecessary = true,
                    DashboardJobListLimit = 50000,
                    TransactionTimeout = TimeSpan.FromMinutes(1),
                    //SchemaName = "hangfire"
                }));

            services.AddHangfire(config => { });
        }
    }
}
