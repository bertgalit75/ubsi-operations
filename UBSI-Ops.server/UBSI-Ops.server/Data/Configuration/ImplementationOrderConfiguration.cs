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
   
    public class ImplementationOrderConfiguration : IEntityTypeConfiguration<ImplementationOrder>
    {
        public void Configure(EntityTypeBuilder<ImplementationOrder> builder)
        {
            builder.ToTable("IMPLEMENTATION_ORDER");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id).HasColumnName("ID").HasMaxLength(11);

            builder.Property(t => t.Date).HasColumnName("DATE").HasColumnType("TIMESTAMP");

            builder.Property(t => t.ClientId).HasColumnName("CLIENT_ID").HasMaxLength(11);

            builder.Property(t => t.AgencyId).HasColumnName("AGENCY_ID").HasMaxLength(11);

            builder.Property(t => t.AccountExecutiveId).HasColumnName("AE_ID").HasMaxLength(11);

            builder.Property(t => t.Tagline).HasColumnName("TAGLINE").HasMaxLength(30);

            builder.Property(t => t.Product).HasColumnName("PRODUCT").HasMaxLength(30);

            builder.Property(t => t.BookingOrderNo).HasColumnName("BO_NO").HasMaxLength(30);

            builder.Property(t => t.PurchaseOrderNo).HasColumnName("PO_NO").HasMaxLength(30);

            builder.Property(t => t.ReferenceCENo).HasColumnName("REF_NO").HasMaxLength(30);

            builder.Property(t => t.CreatedById).HasColumnName("CREATED_BY_ID").HasMaxLength(30);

            builder.Property(t => t.UpdatedById).HasColumnName("UPDATED_BY_ID").HasMaxLength(30);

            builder.HasBaseEntityProperties();

        }
    }
}
