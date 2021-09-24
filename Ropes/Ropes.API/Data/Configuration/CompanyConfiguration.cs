using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ropes.API.Companies;

namespace Ropes.API.Data.Configuration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("COMPANIES");

            builder.HasKey(t => t.Code);

            builder.Property(t => t.Code).
                HasColumnName("CODE").
                HasColumnType("VARCHAR2").
                HasMaxLength(1).
                IsRequired();

            builder.Property(t => t.Name).
                HasColumnName("NAME").
                HasColumnType("VARCHAR2").
                HasMaxLength(40);

            builder.Property(t => t.Address1).
                HasColumnName("ADDR1").
                HasColumnType("VARCHAR2").
                HasMaxLength(40);

            builder.Property(t => t.Address2).
                HasColumnName("ADDR2").
                HasColumnType("VARCHAR2").
                HasMaxLength(40);

            builder.Property(t => t.TIN).
                HasColumnName("TIN").
                HasColumnType("VARCHAR2").
                HasMaxLength(40);

            builder.Property(t => t.SSS).
                HasColumnName("SSS").
                HasColumnType("VARCHAR2").
                HasMaxLength(40);

            builder.Property(t => t.SigName).
                HasColumnName("SIGNAME").
                HasColumnType("VARCHAR2").
                HasMaxLength(40);

            builder.Property(t => t.SigPos).
                HasColumnName("SIGPOS").
                HasColumnType("VARCHAR2").
                HasMaxLength(40);

            builder.Property(t => t.SigTIN).
                HasColumnName("SIGTIN").
                HasColumnType("VARCHAR2").
                HasMaxLength(40);
        }
    }
}
