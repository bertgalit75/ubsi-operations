using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBSI_Ops.server.Core.Extensions;
using UBSI_Ops.server.Entities.Identity;

namespace UBSI_Ops.server.Data.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("EZ_ROLES");

            builder.Property(t => t.Id).HasColumnType("VARCHAR2").HasColumnName("ID").HasMaxLength(20);

            builder.Property(t => t.Name).HasColumnType("VARCHAR2").HasColumnName("NAME").HasMaxLength(20);

            builder.Property(t => t.NormalizedName).HasColumnType("VARCHAR2").HasColumnName("NORMALIZED_NAME").HasMaxLength(20);

            builder.Property(t => t.ConcurrencyStamp).HasColumnType("VARCHAR2").HasColumnName("CONCURRENCY_TIMESTAMP").HasMaxLength(36);

            builder.Property(t => t.CreatedByCode).HasColumnType("VARCHAR2").HasColumnName("CREATED_BY_CODE").HasMaxLength(50);

            builder.Property(t => t.UpdatedByCode).HasColumnType("VARCHAR2").HasColumnName("UPDATED_BY_CODE").HasMaxLength(50);

            builder.HasMany(t => t.RolePermissions)
              .WithOne(t => t.Role)
              .HasForeignKey(t => t.RoleId);

            builder.HasBaseEntityProperties();
        }
    }
}
