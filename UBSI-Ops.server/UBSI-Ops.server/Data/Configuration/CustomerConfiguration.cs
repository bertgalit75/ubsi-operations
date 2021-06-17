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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("EZ_CUSTOMER_VW");

            builder.HasNoKey();

            builder.Property(t => t.Name).HasColumnName("CUS_NAME").HasMaxLength(49);

            builder.Property(t => t.Code).HasColumnName("CUS_CODE").HasMaxLength(8);
        }
    }
}
