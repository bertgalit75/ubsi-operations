using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBSI_Ops.server.CertificateOfPerformances;
using UBSI_Ops.server.Core.Extensions;

namespace UBSI_Ops.server.Data.Configuration
{
    public class CertificateOfPerformanceConfiguration : IEntityTypeConfiguration<CertificateOfPerformance>
    {
        public void Configure(EntityTypeBuilder<CertificateOfPerformance> builder)
        {
            builder.ToTable("CERTIFICATE_OF_PERFORMANCE");

            builder.HasKey(t => t.Code);

            builder.Property(t => t.Code)
                .HasColumnName("CODE")
                .HasColumnType("VARCHAR2(10)");

            builder.Property(t => t.ImplementationOrderCode)
                .HasColumnName("IMPLEMENTATION_ORDER_CODE")
                .HasColumnType("VARCHAR2(10)");

            builder.Property(t => t.CreatedByCode)
                .HasColumnName("CREATED_BY_CODE")
                .HasColumnType("VARCHAR2(20)");

            builder.Property(t => t.UpdatedByCode)
                .HasColumnName("UPDATED_BY_CODE")
                .HasColumnType("VARCHAR2(20)");

            builder.HasBaseEntityProperties();

            builder.HasOne(t => t.ImplementationOrder)
                .WithMany(t => t.Certifications)
                .HasForeignKey(t => t.ImplementationOrderCode);
        }
    }
}
