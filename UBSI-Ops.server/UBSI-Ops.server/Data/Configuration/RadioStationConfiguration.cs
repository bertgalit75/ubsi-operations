using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ropes.API.Entities;

namespace Ropes.API.Data.Configuration
{
    public class RadioStationConfiguration : IEntityTypeConfiguration<RadioStation>
    {
        public void Configure(EntityTypeBuilder<RadioStation> builder)
        {
            builder.ToTable("EZ_STATIONS");

            builder.HasKey(t => t.Code);

            builder.Property(t => t.Code)
                .HasColumnName("STN_CODE")
                .HasMaxLength(10);

            builder.Property(t => t.Name)
                .HasColumnName("STN_NAME")
                .HasMaxLength(60);
        }
    }
}
