using Microsoft.EntityFrameworkCore;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Data
{
    //public class OperationContext
    //    : IdentityDbContext<
    //        User,
    //        Role,
    //        int,
    //        UserClaim,
    //        UserRole,
    //        UserLogin,
    //        RoleClaim,
    //        UserToken>

    public class OperationContext : DbContext
    {
        public DbSet<RadioStation> RadioStations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<AccountExecutive> AccountExecutives { get; set; }

        public OperationContext(DbContextOptions<OperationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OperationContext).Assembly);
        }
    }

}
