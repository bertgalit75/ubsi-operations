using HashidsNet;
using Microsoft.Extensions.DependencyInjection;
using Ropes.API.Auth;
using Ropes.API.BillingStatements;
using Ropes.API.CertificatesofPerformance.Services;
using Ropes.API.Core.View;
using Ropes.API.Data.Configuration;
using Ropes.API.MediaAgencies.Services;
using Ropes.API.Services;
using Ropes.API.Services.Intefaces;
using Ropes.API.Services.Services;
using Ropes.API.Users.Services;

namespace Ropes.API
{
    public static class DomainServiceCollectionExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            //Repositories
            services.AddTransient<IRadioStationRepository, RadioStationRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IMediaAgencyRepository, MediaAgencyRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IVendorRepository, VendorRepository>();
            services.AddTransient<IAccountExecutiveRepository, AccountExecutiveRepository>();
            services.AddTransient<IMediaAgencyRepository, MediaAgencyRepository>();
            services.AddTransient<IUserRoleRepository, UserRoleRepository>();
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IImplementationOrderRepository, ImplementationOrderRepository>();
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IBillingStatementRepository, BillingStatementRepository>();
            services.AddTransient<IFileEntryRepository, FileEntryRepository>();
            services.AddTransient<ICertificateOfPerformance, CertificateOfPerformanceRepository>();

            services.AddScoped<LoginService>();
            services.AddScoped<JwtConfiguration>();
            services.AddScoped<ICurrentUser, CurrentUser>();
            services.AddScoped<AccountService>();
            services.AddScoped<UserService>();
            services.AddScoped<UserTokenService>();
            services.AddScoped<TokenService>();
            services.AddScoped<GenerateDefaultImageService>();
            services.AddScoped<RoleService>();
            services.AddScoped<CertificateOfPerformanceService>();

            services.AddScoped<ViewRenderService>();

            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddScoped<MediaAgencyService>();

            services.AddSingleton<IHashids>(services => new Hashids("secret"));

            return services;
        }
    }
}
