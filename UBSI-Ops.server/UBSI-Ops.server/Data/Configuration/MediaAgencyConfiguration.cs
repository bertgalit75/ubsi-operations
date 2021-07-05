using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Core.Extensions;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Data.Configuration
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
        }
    }
}
