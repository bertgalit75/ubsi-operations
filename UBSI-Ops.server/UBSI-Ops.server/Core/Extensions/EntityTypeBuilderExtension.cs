using UBSI_Ops.server.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UBSI_Ops.server.Core.Extensions
{
    public static class EntityTypeBuilderExtension
    {
        public static void HasBaseEntityProperties<T>(this EntityTypeBuilder<T> builder) where T : class, IBaseEntity
        {
            builder.Property(t => t.CreatedAt)
                .HasColumnName("CREATED_AT")
                .HasColumnType("TIMESTAMP");

            builder.Property(t => t.UpdatedAt)
                .HasColumnName("UPDATED_AT")
                .HasColumnType("TIMESTAMP");
        }
    }
}
