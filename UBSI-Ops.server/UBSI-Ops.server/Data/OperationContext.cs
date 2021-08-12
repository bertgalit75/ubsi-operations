using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UBSI_Ops.server.BillingStatements;
using UBSI_Ops.server.CertificateOfPerformances;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.Entities.Identity;
using UBSI_Ops.server.ImplementationOrders;

namespace UBSI_Ops.server.Data
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

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<AccountExecutive> AccountExecutives { get; set; }

        public DbSet<MediaAgency> MediaAgencies { get; set; }

        public DbSet<ImplementationOrder> ImplementationOrders { get; set; }

        public DbSet<BillingStatement> BillingStatements { get; set; }

        public DbSet<BillingStatementItem> BillingStatementItems { get; set; }

        public DbSet<FileEntry> FileEntries { get; set; }

        public DbSet<CertificateOfPerformance> CertificateOfPerformances { get; set; }

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
