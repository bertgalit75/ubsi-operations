using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ropes.API.Entities;

namespace Ropes.API.Data.Configuration
{
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("PERMISSION");

            builder.HasKey(t => t.Code);

            builder.Property(t => t.Code).HasColumnName("CODE").HasColumnType("NUMBER(10)");

            builder.Property(t => t.Name).HasColumnName("NAME").HasColumnType("VARCHAR2(20)");
        }
    }
}
