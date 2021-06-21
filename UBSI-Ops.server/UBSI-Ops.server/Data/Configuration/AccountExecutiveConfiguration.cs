using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.Data.Configuration
{
    public class AccountExecutiveConfiguration : IEntityTypeConfiguration<AccountExecutive>
    {
        public void Configure(EntityTypeBuilder<AccountExecutive> builder)
        {
            builder.ToTable("SPERSONS");

            builder.HasKey(t => t.Code);

            builder.Property(t => t.Code).HasColumnName("SP_CODE").HasMaxLength(6);

            builder.Property(t => t.LastName).HasColumnName("SP_LAST_NAME").HasMaxLength(20);

            builder.Property(t => t.FirstName).HasColumnName("SP_FIRST_NAME").HasMaxLength(20);

            builder.Property(t => t.MiddleInitial).HasColumnName("SP_MID_INITIAL").HasMaxLength(1);

            builder.Property(t => t.RegionCode).HasColumnName("SP_MA_SR_CODE").HasMaxLength(3);

            builder.Property(t => t.AreaCode).HasColumnName("SP_MA_CODE").HasMaxLength(3);

            builder.Property(t => t.Company).HasColumnName("CO").HasMaxLength(1);


        }
    }
}
