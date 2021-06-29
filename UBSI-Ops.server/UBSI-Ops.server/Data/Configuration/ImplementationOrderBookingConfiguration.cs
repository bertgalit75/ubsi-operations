using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Extensions;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Data.Configuration
{
    public class ImplementationOrderBookingConfiguration : IEntityTypeConfiguration<ImplementationOrderBooking>
    {
        public void Configure(EntityTypeBuilder<ImplementationOrderBooking> builder)
        {
            builder.ToTable("IMPLEMENTATION_ORDER_BOOKING");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id).HasColumnName("ID").HasMaxLength(11);

            builder.HasOne(t => t.ImplementationOrder)
             .WithMany()
             .HasForeignKey(t => t.ImplementationOrderId);

            builder.Property(t => t.ImplementationOrderId).HasColumnName("IMPLEMENTATION_ORDER_ID").HasMaxLength(11);

            builder.Property(t => t.StationId).HasColumnName("STATION_ID").HasMaxLength(11);

            builder.Property(t => t.PeriodEnd).HasColumnName("PERIOD_END").HasColumnType("TIMESTAMP");

            builder.Property(t => t.PeriodStart).HasColumnName("PERIOD_START").HasColumnType("TIMESTAMP");

            builder.Property(t => t.Duration).HasColumnName("DURATION").HasMaxLength(11);

            builder.Property(t => t.Spot).HasColumnName("SPOT").HasMaxLength(11);

            builder.Property(t => t.Gross).HasColumnName("GROSS").HasMaxLength(11);

            builder.Property(t => t.CreatedById).HasColumnName("CREATED_BY_ID").HasMaxLength(30);

            builder.Property(t => t.UpdatedById).HasColumnName("UPDATED_BY_ID").HasMaxLength(30);

            builder.HasBaseEntityProperties();

        }
    }
}
