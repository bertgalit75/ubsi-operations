using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ropes.API.Entities;

namespace Ropes.API.Data.Configuration
{
    public class MediaAgencyConfiguration : IEntityTypeConfiguration<MediaAgency>
    {
        public void Configure(EntityTypeBuilder<MediaAgency> builder)
        {
            builder.ToTable("MEDIAAGENCY");

            builder.HasKey(t => t.Code);

            builder.Property(t => t.Code).HasColumnName("CODE").
                HasMaxLength(40);

            builder.Property(t => t.Name).HasColumnName("NAME").
                HasMaxLength(200);

            builder.Property(t => t.ContactNo).HasColumnName("CONTACT_NO").
                HasMaxLength(20);

            builder.Property(t => t.Fax).HasColumnName("FAX").
                HasMaxLength(20);

            builder.Property(t => t.Email).HasColumnName("EMAIL").
                HasMaxLength(40);

            builder.Property(t => t.Remarks).HasColumnName("REMARKS").
                HasMaxLength(1000);

            builder.Property(t => t.Province).HasColumnName("PROVINCE").
                HasMaxLength(20);

            builder.Property(t => t.City).HasColumnName("CITY").
                HasMaxLength(20);

            builder.Property(t => t.AddressLine).HasColumnName("ADDRESSLINE").
                HasMaxLength(50);
        }
    }
}
