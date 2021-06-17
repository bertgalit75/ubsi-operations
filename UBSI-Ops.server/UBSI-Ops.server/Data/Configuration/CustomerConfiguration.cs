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
            builder.ToTable("EZ_DEBTORS_VW");

            builder.HasKey(t => t.Code);

            builder.Property(t => t.Code).HasColumnName("CUS_CODE").
                HasMaxLength(40);

            builder.Property(t => t.Name).HasColumnName("CUS_NAME").
                HasMaxLength(200);

            builder.Property(t => t.BillingAddress).HasColumnName("CUS_BILLING_ADDRESS").
                HasMaxLength(500);

            builder.Property(t => t.RegionCode).HasColumnName("CUS_MA_SR_CODE").
                HasMaxLength(3);

            builder.Property(t => t.AreaCode).HasColumnName("CUS_MA_CODE").
                HasMaxLength(3);

            builder.Property(t => t.CreditLimit).HasColumnName("CUS_CREDIT_LIMIT").
                HasColumnType("decimal(12,2)");

            builder.Property(t => t.IsVatInclusive).HasColumnName("CUS_VAT_EXCLUSIVE").
                HasMaxLength(1);

            builder.Property(t => t.CreditStatus).HasColumnName("CUS_CREDIT_STATUS").
                HasMaxLength(5);

            builder.Property(t => t.IsActive).HasColumnName("CUS_ACTIVE").
                HasMaxLength(1);

            builder.Property(t => t.AECode).HasColumnName("CUS_SP_CODE").
                HasMaxLength(6);

            builder.Property(t => t.AEName).HasColumnName("SP_NAME").
                HasMaxLength(1050);

            builder.Property(t => t.Telephone).HasColumnName("CUS_TELEPHONE").
                HasMaxLength(25);

            builder.Property(t => t.Fax).HasColumnName("CUS_FAX").
                HasMaxLength(20);

            builder.Property(t => t.ContactPerson).HasColumnName("CUS_CONTACT").
                HasMaxLength(25);

            //builder.Property(t => t.CO_CODE).HasColumnName("CO_CODE").
                //HasMaxLength(1);

            builder.Property(t => t.CreditTermsCode).HasColumnName("CUS_CT_CODE").
                HasMaxLength(8);

            builder.Property(t => t.GroupCode).HasColumnName("CUS_CG_CODE").
                HasMaxLength(5);

            builder.Property(t => t.Type).HasColumnName("CUS_TYPE").
                HasMaxLength(1);

            builder.Property(t => t.TIN).HasColumnName("CUS_TIN").
                HasMaxLength(20);
        }
    }
}
