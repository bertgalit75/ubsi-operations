using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBSI_Ops.server.Core.Extensions;
using UBSI_Ops.server.ImplementationOrders;

namespace UBSI_Ops.server.Data.Configuration
{
    public class ImplementationOrderConfiguration : IEntityTypeConfiguration<ImplementationOrder>
    {
        public void Configure(EntityTypeBuilder<ImplementationOrder> builder)
        {
            builder.ToTable("IMPLEMENTATION_ORDER");

            builder.HasKey(t => t.Code);

            builder.Property(t => t.Code)
                .HasColumnName("CODE")
                .HasColumnType("VARCHAR2(10)");

            builder.Property(t => t.Date)
                .HasColumnName("DATE");

            builder.Property(t => t.ClientCode)
                .HasColumnName("CLIENT_CODE")
                .HasColumnType("VARCHAR2(8)");

            builder.Property(t => t.AgencyCode)
                .HasColumnName("AGENCY_CODE")
                .HasColumnType("VARCHAR2(20)");

            builder.Property(t => t.AccountExecutiveCode)
                .HasColumnName("ACCOUNT_EXECUTIVE_CODE")
                .HasColumnType("VARCHAR2(6)");

            builder.Property(t => t.Tagline)
                .HasColumnName("TAGLINE")
                .HasColumnType("VARCHAR2(1000)");

            builder.Property(t => t.Product)
                .HasColumnName("PRODUCT")
                .HasColumnType("VARCHAR2(100)");

            builder.Property(t => t.BookingOrderNo)
                .HasColumnName("BOOKING_ORDER_NO")
                .HasColumnType("VARCHAR2(30)");

            builder.Property(t => t.PurchaseOrderNo)
                .HasColumnName("PURCHASE_ORDER_NO")
                .HasColumnType("VARCHAR2(30)");

            builder.Property(t => t.ReferenceCENo)
                .HasColumnName("REFERENCE_CE_NO")
                .HasColumnType("VARCHAR2(30)");

            builder.Property(t => t.CreatedByCode)
                .HasColumnName("CREATED_BY_CODE")
                .HasColumnType("VARCHAR2(20)");

            builder.Property(t => t.UpdatedByCode)
                .HasColumnName("UPDATED_BY_CODE")
                .HasColumnType("VARCHAR2(20)");

            builder.HasOne(t => t.MediaAgency)
                .WithMany()
                .HasForeignKey(t => t.AgencyCode);

            builder.HasOne(t => t.Customer)
                .WithMany()
                .HasForeignKey(t => t.ClientCode);

            builder.HasBaseEntityProperties();
        }
    }
}
