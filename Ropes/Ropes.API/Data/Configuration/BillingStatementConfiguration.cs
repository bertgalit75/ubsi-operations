using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ropes.API.BillingStatements;

namespace Ropes.API.Data.Configuration
{
    public class BillingStatementConfiguration : IEntityTypeConfiguration<BillingStatement>
    {
        public void Configure(EntityTypeBuilder<BillingStatement> builder)
        {
            builder.ToTable("UBSI_INVOICE_HDR");

            builder.HasKey(t => t.Code);

            builder.Property(t => t.Code).HasColumnName("UIH_NBR").HasColumnType("NUMBER(10)");

            builder.Property(t => t.Date).HasColumnName("UIH_DATE").HasColumnType("DATE");

            builder.Property(t => t.CustomerCode).HasColumnName("UIH_CUS_CODE").HasColumnType("VARCHAR(8)");

            builder.Property(t => t.Encoder).HasColumnName("UIH_ENCODER").HasColumnType("VARCHAR(15)");

            builder.Property(t => t.Printed).HasColumnName("UIH_PRINTED").HasColumnType("VARCHAR(1)");

            builder.Property(t => t.FormNumber).HasColumnName("UIH_FORM_NBR").HasColumnType("NUMBER(8)");

            builder.Property(t => t.Frequency).HasColumnName("UIH_FREQUENCY").HasColumnType("VARCHAR(15)");

            builder.Property(t => t.ContractNo).HasColumnName("UIH_CONTRACTNO").HasColumnType("VARCHAR(50)");

            builder.Property(t => t.CPNO).HasColumnName("UIH_CPNO").HasColumnType("VARCHAR(50)");

            builder.Property(t => t.BONO).HasColumnName("UIH_BONO").HasColumnType("VARCHAR(50)");

            builder.Property(t => t.CENO).HasColumnName("UIH_CENO").HasColumnType("VARCHAR(50)");

            builder.Property(t => t.ImplmentationOrderCode).HasColumnName("IMPLEMENTATION_ORDER_CODE").HasColumnType("VARCHAR2(10)");

            builder.Property(t => t.AgencyCode).HasColumnName("AGENCY_CODE").HasColumnType("NVARCHAR2(40)");

            builder.HasOne(t => t.MediaAgency)
                .WithMany()
                .HasForeignKey(t => t.AgencyCode);

            builder.HasOne(t => t.Customer)
                .WithMany()
                .HasForeignKey(t => t.CustomerCode);

            builder.HasOne(t => t.ImplementationOrder)
               .WithMany()
               .HasForeignKey(t => t.ImplmentationOrderCode);

            builder.HasMany(t => t.BillingStatementItems)
             .WithOne(t => t.BillingStatement)
             .HasForeignKey(t => t.BillingStatementCode);
        }
    }
}
