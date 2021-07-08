using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBSI_Ops.server.Entities.Identity;

namespace UBSI_Ops.server.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("EZ_USERS");

            builder.Property(t => t.Id).HasColumnName("AU_USERID").HasMaxLength(30);

            builder.Property(t => t.PasswordHash).HasColumnName("AU_PASSWORD").HasMaxLength(32);

            builder.Property(t => t.EnrolledOn).HasColumnName("AU_ENROLLED_ON").IsRequired(false);

            builder.Property(t => t.LockedOn).HasColumnName("AU_LOCKED_ON").IsRequired(false);

            builder.Property(t => t.Name).HasColumnName("AU_NAME").HasMaxLength(50);

            builder.Property(t => t.UserName).HasColumnName("USERNAME").HasMaxLength(20);

            builder.Property(t => t.TwoFactorEnabled).HasColumnName("TWOFACTORENABLED");

            builder.Property(t => t.ConcurrencyStamp).HasColumnName("CONCURRENTCURRENCYSTAMP").HasMaxLength(20);

            builder.Property(t => t.AccessFailedCount).HasColumnName("ACCESSFAILEDCOUNT");

            builder.Property(t => t.Email).HasColumnName("EMAIL").HasMaxLength(20);

            builder.Property(t => t.EmailConfirmed).HasColumnName("EMAILCONFIRMED");

            builder.Property(t => t.LockoutEnabled).HasColumnName("LOCKOUTENABLED");

            builder.Property(t => t.LockoutEnd).HasColumnName("LOCKOUTEND");

            builder.Property(t => t.NormalizedEmail).HasColumnName("NORMALIZEDEMAIL").HasMaxLength(20);

            builder.Property(t => t.PhoneNumber).HasColumnName("PHONENUMBER").HasMaxLength(20);

            builder.Property(t => t.PhoneNumberConfirmed).HasColumnName("PHONENUMBERCONFIRMED");

            builder.Property(t => t.SecurityStamp).HasColumnName("SECURITYSTAMP").HasMaxLength(20);

            builder.Property(t => t.NormalizedUserName).HasColumnName("NORMALIZEDUSERNAME").HasMaxLength(20);
        }
    }
}
