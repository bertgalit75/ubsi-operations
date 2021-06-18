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

            builder.HasKey(t => t.VendorCode);

            builder.Property(t => t.VendorCode).HasColumnName("VCODE").HasMaxLength(8);

            builder.Property(t => t.VendorName).HasColumnName("VNAME").HasMaxLength(35);

            builder.Property(t => t.VendorAddress).HasColumnName("VADDR").HasMaxLength(100);

            builder.Property(t => t.VendorType).HasColumnName("VTYPE").HasMaxLength(1);

            builder.Property(t => t.VendorTelephone).HasColumnName("VTEL").HasMaxLength(25);

            builder.Property(t => t.VendorFAX).HasColumnName("VFAX").HasMaxLength(20);

            builder.Property(t => t.VendorContact).HasColumnName("VCONTACT").HasMaxLength(25);

            builder.Property(t => t.VendorTIN).HasColumnName("VTIN").HasMaxLength(20);

            builder.Property(t => t.VendorCompany).HasColumnName("CO").HasMaxLength(1);

            builder.Property(t => t.VendorPAYTO).HasColumnName("PAYTO").HasMaxLength(40)
                ;
            builder.Property(t => t.IsUtility).HasColumnName("IS_UTILITY").HasMaxLength(1);
        }
    }
}
