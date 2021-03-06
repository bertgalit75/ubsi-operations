using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using Ropes.API.Data;
using Ropes.API.Data.Seed;

namespace Ropes.API.FunctionalTests
{
    public class CustomWebApplicationFactory : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            base.ConfigureWebHost(builder);

            builder.ConfigureServices(services =>
            {
                //services
                //    .AddAuthentication(opts =>
                //    {
                //        opts.DefaultAuthenticateScheme = TestAuthHandler.TestScheme;
                //        opts.DefaultChallengeScheme = TestAuthHandler.TestScheme;
                //    })
                //    .AddScheme<AuthenticationSchemeOptions, TestAuthHandler>(TestAuthHandler.TestScheme, null);

                ReplaceDbContextWithTesting(services);
                SeedDatabase(services);
            });
        }

        private void ReplaceDbContextWithTesting(IServiceCollection services)
        {
            var descriptor = services.SingleOrDefault(
                t => t.ServiceType == typeof(DbContextOptions<OperationContext>));

            if (descriptor != null)
            {
                services.Remove(descriptor);
            }

            services.AddDbContext<OperationContext>(options =>
            {
                options.UseInMemoryDatabase("InMemoryDbTesting");
            });
        }

        private void SeedDatabase(IServiceCollection services)
        {
            var sp = services.BuildServiceProvider();
            using var scope = sp.CreateScope();

            var scopedServices = scope.ServiceProvider;
            var context = scopedServices.GetRequiredService<OperationContext>();
            var logger = scopedServices
                .GetRequiredService<ILogger<CustomWebApplicationFactory>>();

            context.Database.EnsureCreated();

            try
            {
                new OperationContextSeed().Seed(context).Wait();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred seeding the " +
                    "database with test messages. Error: {Message}", ex.Message);
            }
        }
    }
}
