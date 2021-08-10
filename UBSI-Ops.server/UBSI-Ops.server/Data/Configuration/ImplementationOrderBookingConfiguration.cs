using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ropes.API.Core.Extensions;
using Ropes.API.ImplementationOrders;

namespace Ropes.API.Data.Configuration
{
    public class ImplementationOrderBookingConfiguration : IEntityTypeConfiguration<ImplementationOrderBooking>
    {
        public void Configure(EntityTypeBuilder<ImplementationOrderBooking> builder)
        {
            builder.ToTable("IMPLEMENTATION_ORDER_BOOKING");

            builder.HasKey(t => t.Code);

            builder.Property(t => t.Code)
                .HasColumnName("CODE");

            builder.Property(t => t.ImplementationOrderCode)
                .HasColumnName("IMPLEMENTATION_ORDER_CODE")
                .HasColumnType("VARCHAR2(10)");

            builder.Property(t => t.StationCode)
                .HasColumnName("STATION_CODE")
                .HasColumnType("VARCHAR2(10)");

            builder.Property(t => t.PeriodEnd)
                .HasColumnName("PERIOD_END");

            builder.Property(t => t.PeriodStart)
                .HasColumnName("PERIOD_START");

            builder.Property(t => t.Duration)
                .HasColumnName("DURATION");

            builder.Property(t => t.NoOfSpots)
                .HasColumnName("NO_OF_SPOTS");

            builder.Property(t => t.GrossAmount)
                .HasColumnName("GROSS_AMOUNT");

            builder.Property(t => t.Monday)
                .HasColumnName("MONDAY");

            builder.Property(t => t.Tuesday)
                .HasColumnName("TUESDAY");

            builder.Property(t => t.Wednesday)
                .HasColumnName("WEDNESDAY");

            builder.Property(t => t.Thursday)
                .HasColumnName("THURSDAY");

            builder.Property(t => t.Friday)
                .HasColumnName("FRIDAY");

            builder.Property(t => t.Saturday)
                .HasColumnName("SATURDAY");

            builder.Property(t => t.Sunday)
                .HasColumnName("SUNDAY");

            builder.Property(t => t.CreatedByCode)
                .HasColumnName("CREATED_BY_CODE")
                .HasColumnType("VARCHAR2(20)");

            builder.Property(t => t.CreatedByCode)
                .HasColumnName("UPDATED_BY_CODE")
                .HasColumnType("VARCHAR2(20)");

            builder.HasBaseEntityProperties();

            builder.HasOne(t => t.ImplementationOrder)
                .WithMany(t => t.Bookings)
                .HasForeignKey(t => t.ImplementationOrderCode);
        }
    }
}
