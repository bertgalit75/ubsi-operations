using HashidsNet;
using Microsoft.Extensions.DependencyInjection;
using UBSI_Ops.server.Auth;
using UBSI_Ops.server.Core.View;
using UBSI_Ops.server.Data.Configuration;
using UBSI_Ops.server.Services;
using UBSI_Ops.server.Services.Intefaces;
using UBSI_Ops.server.Services.Services;

namespace UBSI_Ops.server
{
    public static class DomainServiceCollectionExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            //Repositories
            services.AddTransient<IRadioStationRepository, RadioStationRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IVendorRepository, VendorRepository>();
            services.AddTransient<IAccountExecutiveRepository, AccountExecutiveRepository>();

            services.AddScoped<LoginService>();
            services.AddScoped<JwtConfiguration>();
            services.AddScoped<ICurrentUser, CurrentUser>();
            services.AddScoped<AccountService>();
            services.AddScoped<UserTokenService>();
            services.AddScoped<TokenService>();
            services.AddScoped<GenerateDefaultImageService>();

            services.AddScoped<ViewRenderService>();

            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddSingleton<IHashids>(services => new Hashids("secret"));

            return services;
        }
    }
}
