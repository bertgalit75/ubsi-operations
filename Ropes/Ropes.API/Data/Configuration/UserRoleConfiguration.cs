using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ropes.API.Entities.Identity;

namespace Ropes.API.Data.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("EZ_USER_ROLES");

            builder.Property(t => t.UserRoleId).HasColumnType("NUMBER").HasColumnName("USER_ROLE_ID").HasMaxLength(11);

            builder.Property(t => t.RoleId).HasColumnType("VARCHAR2").HasColumnName("ROLE_ID").HasMaxLength(11);

            builder.HasOne(t => t.Role)
             .WithMany()
             .HasForeignKey(t => t.RoleId);

            builder.Property(t => t.BranchId).HasColumnType("NUMBER").HasColumnName("BRANCH_ID").HasMaxLength(11);

            builder.Property(t => t.Type).HasColumnType("VARCHAR2").HasColumnName("TYPE").HasMaxLength(30);

            builder.Property(t => t.UserId).HasColumnType("VARCHAR2").HasColumnName("USER_ID").HasMaxLength(30);

            builder.Property(t => t.CreatedById).HasColumnType("VARCHAR2").HasColumnName("CREATED_BY").HasMaxLength(30);

            builder.Property(t => t.UpdatedById).HasColumnType("VARCHAR2").HasColumnName("UPDATED_BY").HasMaxLength(30);

            builder.Property(t => t.CreatedAt).HasColumnType("DATE").HasColumnName("CREATED_AT");

            builder.Property(t => t.UpdatedAt).HasColumnType("DATE").HasColumnName("UPDATED_AT");
        }
    }
}
