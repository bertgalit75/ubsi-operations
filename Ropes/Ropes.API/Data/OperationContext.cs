using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ropes.API.BillingStatements;
using Ropes.API.CertificateOfPerformances;
using Ropes.API.ChartOfAccounts;
using Ropes.API.Companies;
using Ropes.API.ConsolidationAccounts;
using Ropes.API.Entities;
using Ropes.API.Entities.Identity;
using Ropes.API.ImplementationOrders;

namespace Ropes.API.Data
{
    public class OperationContext
        : IdentityDbContext<
            User,
            Role,
            string,
            IdentityUserClaim<string>,
            UserRole,
            IdentityUserLogin<string>,
            IdentityRoleClaim<string>,
            IdentityUserToken<string>>
    {
        public DbSet<RadioStation> RadioStations { get; set; }

        public DbSet<CertificateOfPerformance> CertificateOfPerformances { get; set; }

        public DbSet<ChartOfAccount> ChartOfAccounts { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<ConsolidationAccount> ConsolidationAccounts { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<AccountExecutive> AccountExecutives { get; set; }

        public DbSet<MediaAgency> MediaAgencies { get; set; }

        public DbSet<ImplementationOrder> ImplementationOrders { get; set; }

        public DbSet<BillingStatement> BillingStatements { get; set; }

        public DbSet<BillingStatementItem> BillingStatementItems { get; set; }

        public DbSet<FileEntry> FileEntries { get; set; }

        public DbSet<Permission> Permissions { get; set; }

        public OperationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OperationContext).Assembly);
        }
    }
}
