using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBSI_Ops.server.Core.Extensions;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Data.Configuration
{
    public class ImplementationOrderBookingConfiguration : IEntityTypeConfiguration<ImplementationOrderBooking>
    {
        public void Configure(EntityTypeBuilder<ImplementationOrderBooking> builder)
        {
            builder.ToTable("IMPLEMENTATION_ORDER_BOOKING");

            builder.HasKey(t => t.Code);

            builder.Property(t => t.Code).HasColumnName("CODE").HasColumnType("NUMBER(10)");

            builder.HasOne(t => t.ImplementationOrder)
             .WithMany()
             .HasForeignKey(t => t.ImplementationOrderCode);

            builder.Property(t => t.ImplementationOrderCode).HasColumnName("IMPLEMENTATION_ORDER_CODE").HasColumnType("NUMBER(10)");

            builder.Property(t => t.StationCode).HasColumnName("STATION_CODE").HasColumnType("VARCHAR2(20)");

            builder.Property(t => t.PeriodEnd).HasColumnName("PERIOD_END").HasColumnType("TIMESTAMP(7)");

            builder.Property(t => t.PeriodStart).HasColumnName("PERIOD_START").HasColumnType("TIMESTAMP(7)");

            builder.Property(t => t.Duration).HasColumnName("DURATION").HasColumnType("NUMBER(10)");

            builder.Property(t => t.Spot).HasColumnName("SPOT").HasColumnType("NUMBER(10)");

            builder.Property(t => t.Gross).HasColumnName("GROSS").HasColumnType("NUMBER(18,2)");

            builder.Property(t => t.CreatedByCode).HasColumnName("CREATED_BY_CODE").HasColumnType("VARCHAR2(20)");

            builder.Property(t => t.CreatedByCode).HasColumnName("UPDATED_BY_CODE").HasColumnType("VARCHAR2(20)");

            builder.HasBaseEntityProperties();

        }
    }
}
