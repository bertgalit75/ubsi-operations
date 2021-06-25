using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Data.Configuration
{
    public class VendorConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.ToTable("VENDORS");

            builder.HasKey(t => t.Code);

            builder.Property(t => t.Code).HasColumnName("VCODE").HasMaxLength(8);

            builder.Property(t => t.Name).HasColumnName("VNAME").HasMaxLength(35);

            builder.Property(t => t.Address).HasColumnName("VADDR").HasMaxLength(100);

            builder.Property(t => t.Type).HasColumnName("VTYPE").HasMaxLength(1);

            builder.Property(t => t.Telephone).HasColumnName("VTEL").HasMaxLength(25);

            builder.Property(t => t.FAX).HasColumnName("VFAX").HasMaxLength(20);

            builder.Property(t => t.Contact).HasColumnName("VCONTACT").HasMaxLength(25);

            builder.Property(t => t.TIN).HasColumnName("VTIN").HasMaxLength(20);

            builder.Property(t => t.Company).HasColumnName("CO").HasMaxLength(1);

            builder.Property(t => t.PayTo).HasColumnName("PAYTO").HasMaxLength(40)
                ;
            builder.Property(t => t.IsUtility).HasColumnName("IS_UTILITY").HasMaxLength(1);
        }
    }
}
