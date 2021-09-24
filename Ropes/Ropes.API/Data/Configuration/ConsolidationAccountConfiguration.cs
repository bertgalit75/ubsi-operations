using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ropes.API.ConsolidationAccounts;

namespace Ropes.API.Data.Configuration
{
    public class ConsolidationAccountConfiguration : IEntityTypeConfiguration<ConsolidationAccount>
    {
        public void Configure(EntityTypeBuilder<ConsolidationAccount> builder)
        {
            builder.ToTable("CONSACCT");

            builder.HasKey(t => t.Code);

            builder.Property(t => t.Code).
                HasColumnName("CACODE").
                HasColumnType("VARCHAR2").
                HasMaxLength(3).
                IsRequired();

            builder.Property(t => t.Title).
                HasColumnName("CATITLE").
                HasColumnType("VARCHAR2").
                HasMaxLength(40);

            builder.Property(t => t.Type).
                HasColumnName("CATYPE").
                HasColumnType("VARCHAR2").
                HasMaxLength(1);

            builder.Property(t => t.Class).
                HasColumnName("CACLASS").
                HasColumnType("VARCHAR2").
                HasMaxLength(2);

            builder.Property(t => t.Balance).
                HasColumnName("CABAL").
                HasColumnType("VARCHAR2").
                HasMaxLength(1);
        }
    }
}
