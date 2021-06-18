using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Data.Configuration
{
    public class RadioStationConfiguration : IEntityTypeConfiguration<RadioStation>
    {
        public void Configure(EntityTypeBuilder<RadioStation> builder)
        {
            builder.ToTable("EZ_STATIONS");
            builder.HasKey(t => t.stn_code);
            builder.Property(t=>t.stn_code).HasColumnName("STN_CODE").HasMaxLength(10);
            builder.Property(t => t.stn_name).HasColumnName("STN_NAME").HasMaxLength(60);
        }
    }
}
