using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Data.Configuration
{
    public class FileEntryConfiguration : IEntityTypeConfiguration<FileEntry>
    {
        public void Configure(EntityTypeBuilder<FileEntry> builder)
        {
            builder.ToTable("FILE_ENTRY");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .HasColumnName("ID");

            builder.Property(t => t.Filename)
                .HasMaxLength(255)
                .HasColumnName("FILENAME")
                .IsRequired();

            builder.Property(t => t.MediaType)
                .HasMaxLength(255)
                .HasColumnName("MEDIATYPE")
                .IsRequired();

            builder.Property(t => t.Length)
                .HasColumnName("LENGTH");

            builder.Property(t => t.Path)
                .HasColumnName("PATH")
                .IsRequired();
        }
    }
}
