using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Data.Configuration
{
    public class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            builder.ToTable("ROLE_PERMISSION");

            builder.HasKey(t => t.Code);

            builder.Property(t => t.Code).HasColumnName("CODE").HasColumnType("NUMBER(10)");

            builder.Property(t => t.PermissionCode).HasColumnName("PERMISSION_CODE").HasColumnType("NUMBER(10)");

            builder.Property(t => t.RoleId).HasColumnType("VARCHAR2(20)").HasColumnName("ROLE_ID");

            builder.HasOne(t => t.Permission)
             .WithMany()
             .HasForeignKey(t => t.PermissionCode);

            builder.Property(t => t.View).HasColumnName("VIEW").HasColumnType("NUMBER(1)");

            builder.Property(t => t.Add).HasColumnName("ADD").HasColumnType("NUMBER(1)");

            builder.Property(t => t.Edit).HasColumnName("EDIT").HasColumnType("NUMBER(1)");

            builder.Property(t => t.Delete).HasColumnName("DELETE").HasColumnType("NUMBER(1)");
        }
    }
}
