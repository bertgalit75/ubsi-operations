using HashidsNet;
using Microsoft.Extensions.DependencyInjection;
using UBSI_Ops.server.Auth;
using UBSI_Ops.server.BillingStatements;
using UBSI_Ops.server.Core.View;
using UBSI_Ops.server.Data.Configuration;
using UBSI_Ops.server.MediaAgencies.Services;
using UBSI_Ops.server.Permissions;
using UBSI_Ops.server.Services;
using UBSI_Ops.server.Services.Intefaces;
using UBSI_Ops.server.Services.Services;
using UBSI_Ops.server.Users.Services;

namespace UBSI_Ops.server
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
            services.AddTransient<IPermissionRepository, PermissionRepository>();

            services.AddScoped<LoginService>();
            services.AddScoped<JwtConfiguration>();
            services.AddScoped<ICurrentUser, CurrentUser>();
            services.AddScoped<AccountService>();
            services.AddScoped<UserService>();
            services.AddScoped<UserTokenService>();
            services.AddScoped<TokenService>();
            services.AddScoped<GenerateDefaultImageService>();
            services.AddScoped<RoleService>();

            services.AddScoped<ViewRenderService>();

            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddScoped<MediaAgencyService>();

            services.AddSingleton<IHashids>(services => new Hashids("secret"));

            return services;
        }
    }
}
