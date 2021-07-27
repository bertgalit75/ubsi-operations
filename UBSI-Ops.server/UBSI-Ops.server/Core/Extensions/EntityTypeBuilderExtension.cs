using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Core.Extensions
{
    public static class EntityTypeBuilderExtension
    {
        public static void HasBaseEntityProperties<T>(this EntityTypeBuilder<T> builder) where T : class, IBaseEntity
        {
            builder.Property(t => t.CreatedAt)
                .HasColumnName("CREATED_AT")
                .HasColumnType("TIMESTAMP(7)").HasDefaultValueSql("CURRENT_TIMESTAMP").ValueGeneratedOnAdd();

            builder.Property(t => t.UpdatedAt)
                .HasColumnName("UPDATED_AT")
                .HasColumnType("TIMESTAMP(7)").HasDefaultValueSql("CURRENT_TIMESTAMP").ValueGeneratedOnAddOrUpdate();
        }
    }
}
