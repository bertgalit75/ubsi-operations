using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBSI_Ops.server.CertificateOfPerformances;

namespace UBSI_Ops.server.Data.Configuration
{
    public class CertificateOfPerformanceTimelogConfiguration : IEntityTypeConfiguration<CertificateOfPerformanceTimelog>
    {
        public void Configure(EntityTypeBuilder<CertificateOfPerformanceTimelog> builder)
        {
            builder.ToTable("CERTIFICATE_OF_PERFORMANCE_TIMELOG");

            builder.HasKey(t => t.Code);

            builder.Property(t => t.Code)
                .HasColumnName("CODE")
                .HasColumnType("VARCHAR2(10)");

            builder.Property(t => t.CertificateOfPerformanceCode)
                .HasColumnName("CERTIFICATE_OF_PERFORMANCE_CODE")
                .HasColumnType("VARCHAR2(10)");

            builder.Property(t => t.Date)
                .HasColumnName("DATE")
                .HasColumnType("TIMESTAMP(7)");

            builder.Property(t => t.Timestamp)
                .HasColumnName("TIMESTAMP")
                .HasColumnType("TIMESTAMP(7)");

            builder.HasOne(t => t.CertificateOfPerformance)
                .WithMany(t => t.TimeLogs)
                .HasForeignKey(t => t.CertificateOfPerformanceCode);
        }
    }
}
