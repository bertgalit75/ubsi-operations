using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ropes.API.BillingStatements;

namespace Ropes.API.Data.Configuration
{
    public class BillingStatementItemConfiguration : IEntityTypeConfiguration<BillingStatementItem>
    {
        public void Configure(EntityTypeBuilder<BillingStatementItem> builder)
        {
            builder.HasKey(t => t.DNO);
            builder.ToTable("UBSI_INVOICE_DTL");

            builder.Property(t => t.BillingStatementCode).HasColumnName("UID_UIH_NBR").HasColumnType("NUMBER(10)");

            builder.Property(t => t.DNO).HasColumnName("UID_DNO").HasColumnType("NUMBER(2)");

            builder.Property(t => t.Particular).HasColumnName("UID_PARTIC").HasColumnType("VARCHAR2(500)");

            builder.Property(t => t.Gross).HasColumnName("UID_GROSS_PRICE").HasColumnType("NUMBER(12)");

            builder.Property(t => t.Discount).HasColumnName("UID_DISCOUNT").HasColumnType("NUMBER(10)");

            builder.Property(t => t.NetPrice).HasColumnName("UID_NET_PRICE").HasColumnType("NUMBER(12)");
        }
    }
}
