using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ropes.API.ChartOfAccounts;

namespace Ropes.API.Data.Configuration
{
    public class ChartOfAccountConfiguration : IEntityTypeConfiguration<ChartOfAccount>
    {
        public void Configure(EntityTypeBuilder<ChartOfAccount> builder)
        {
            builder.ToTable("COA");

            builder.HasKey(t => t.Code);

            builder.Property(t => t.Code).
                HasColumnName("ACODE").
                HasColumnType("VARCHAR2").
                HasMaxLength(4).
                IsRequired();

            builder.Property(t => t.CompanyCode).
                HasColumnName("CO").
                HasColumnType("VARCHAR2").
                HasMaxLength(1);

            builder.HasOne(t => t.Company).
                WithMany(t => t.ChartOfAccounts).
                HasForeignKey(t => t.CompanyCode);

            builder.Property(t => t.Title).
                HasColumnName("ATITLE").
                HasColumnType("VARCHAR2").
                HasMaxLength(40);

            builder.Property(t => t.Type).
                HasColumnName("ATYPE").
                HasColumnType("VARCHAR2").
                HasMaxLength(1);

            builder.Property(t => t.Balance).
                HasColumnName("ABAL").
                HasColumnType("VARCHAR2").
                HasMaxLength(1);

            builder.Property(t => t.Class).
                HasColumnName("ACLASS").
                HasColumnType("VARCHAR2").
                HasMaxLength(2);

            builder.Property(t => t.ConsolidationAccountCode).
                HasColumnName("CACODE").
                HasColumnType("VARCHAR2").
                HasMaxLength(3);

            builder.HasOne(t => t.ConsolidationAccount).
                WithMany(t => t.ChartOfAccounts).
                HasForeignKey(t => t.ConsolidationAccountCode);

            builder.Property(t => t.Description).
                HasColumnName("ADESC").
                HasColumnType("VARCHAR2").
                HasMaxLength(2000);
        }
    }
}
