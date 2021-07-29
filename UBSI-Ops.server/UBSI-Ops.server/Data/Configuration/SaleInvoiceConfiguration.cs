using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBSI_Ops.server.SalesInvoices;

namespace UBSI_Ops.server.Data.Configuration
{
    public class SaleInvoiceConfiguration : IEntityTypeConfiguration<SalesInvoice>
    {
        public void Configure(EntityTypeBuilder<SalesInvoice> builder)
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
        }
    }
}
