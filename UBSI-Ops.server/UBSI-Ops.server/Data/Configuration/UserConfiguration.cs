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

            builder.HasKey(t => t.UserId);

            builder.Property(t => t.UserId).HasColumnType("VARCHAR2").HasColumnName("AU_USERID").HasMaxLength(30);

            builder.Property(t => t.Password).HasColumnType("VARCHAR2").HasColumnName("AU_PASSWORD").HasMaxLength(32);

            builder.Property(t => t.EnrolledOn).HasColumnType("DATE").HasColumnName("AU_ENROLLED_ON");

            builder.Property(t => t.LockedOn).HasColumnType("DATE").HasColumnName("AU_LOCKED_ON");

            builder.Property(t => t.Name).HasColumnType("VARCHAR2").HasColumnName("AU_NAME").HasMaxLength(50);


        }
    }
}
