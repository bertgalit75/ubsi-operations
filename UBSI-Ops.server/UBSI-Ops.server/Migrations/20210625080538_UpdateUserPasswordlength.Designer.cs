﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using Ropes.API.Data;

namespace Ropes.API.Migrations
{
    [DbContext(typeof(OperationContext))]
    [Migration("20210625080538_UpdateUserPasswordlength")]
    partial class UpdateUserPasswordlength
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UBSI_Ops.server.Entities.AccountExecutive", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(6)
                        .HasColumnType("NVARCHAR2(6)")
                        .HasColumnName("SP_CODE");

                    b.Property<string>("AreaCode")
                        .HasMaxLength(3)
                        .HasColumnType("NVARCHAR2(3)")
                        .HasColumnName("SP_MA_CODE");

                    b.Property<string>("Company")
                        .HasMaxLength(1)
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("CO");

                    b.Property<string>("FirstName")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("SP_FIRST_NAME");

                    b.Property<string>("LastName")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("SP_LAST_NAME");

                    b.Property<string>("MiddleInitial")
                        .HasMaxLength(1)
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("SP_MID_INITIAL");

                    b.Property<string>("RegionCode")
                        .HasMaxLength(3)
                        .HasColumnType("NVARCHAR2(3)")
                        .HasColumnName("SP_MA_SR_CODE");

                    b.HasKey("Code");

                    b.ToTable("SPERSONS");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.Customer", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(40)
                        .HasColumnType("NVARCHAR2(40)")
                        .HasColumnName("CUS_CODE");

                    b.Property<string>("AECode")
                        .HasMaxLength(6)
                        .HasColumnType("NVARCHAR2(6)")
                        .HasColumnName("CUS_SP_CODE");

                    b.Property<string>("AEName")
                        .HasMaxLength(1050)
                        .HasColumnType("NVARCHAR2(1050)")
                        .HasColumnName("SP_NAME");

                    b.Property<string>("AreaCode")
                        .HasMaxLength(3)
                        .HasColumnType("NVARCHAR2(3)")
                        .HasColumnName("CUS_MA_CODE");

                    b.Property<string>("BillingAddress")
                        .HasMaxLength(500)
                        .HasColumnType("NVARCHAR2(500)")
                        .HasColumnName("CUS_BILLING_ADDR");

                    b.Property<string>("ContactPerson")
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)")
                        .HasColumnName("CUS_CONTACT");

                    b.Property<decimal>("CreditLimit")
                        .HasColumnType("decimal(12,2)")
                        .HasColumnName("CUS_CREDIT_LIMIT");

                    b.Property<string>("CreditStatus")
                        .HasMaxLength(5)
                        .HasColumnType("NVARCHAR2(5)")
                        .HasColumnName("CUS_CREDIT_STATUS");

                    b.Property<string>("CreditTermsCode")
                        .HasMaxLength(8)
                        .HasColumnType("NVARCHAR2(8)")
                        .HasColumnName("CUS_CT_CODE");

                    b.Property<string>("Fax")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("CUS_FAX");

                    b.Property<string>("GroupCode")
                        .HasMaxLength(5)
                        .HasColumnType("NVARCHAR2(5)")
                        .HasColumnName("CUS_CG_CODE");

                    b.Property<string>("IsActive")
                        .HasMaxLength(1)
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("CUS_ACTIVE");

                    b.Property<string>("IsVatInclusive")
                        .HasMaxLength(1)
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("CUS_VAT_INCLUSIVE");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)")
                        .HasColumnName("CUS_NAME");

                    b.Property<string>("RegionCode")
                        .HasMaxLength(3)
                        .HasColumnType("NVARCHAR2(3)")
                        .HasColumnName("CUS_MA_SR_CODE");

                    b.Property<string>("TIN")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("CUS_TIN");

                    b.Property<string>("Telephone")
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)")
                        .HasColumnName("CUS_TELEPHONE");

                    b.Property<string>("Type")
                        .HasMaxLength(1)
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("CUS_TYPE");

                    b.HasKey("Code");

                    b.ToTable("EZ_DEBTORS_VW");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.Identity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("EZ_ROLES");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.Identity.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("NUMBER")
                        .HasColumnName("USER_ROLE_ID")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchId")
                        .HasMaxLength(11)
                        .HasColumnType("NUMBER")
                        .HasColumnName("BRANCH_ID");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DATE")
                        .HasColumnName("CREATED_AT");

                    b.Property<string>("CreatedById")
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR2(30)")
                        .HasColumnName("CREATED_BY");

                    b.Property<int>("RoleId")
                        .HasMaxLength(11)
                        .HasColumnType("NUMBER")
                        .HasColumnName("ROLE_ID");

                    b.Property<string>("Type")
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR2(30)")
                        .HasColumnName("TYPE");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("DATE")
                        .HasColumnName("UPDATED_AT");

                    b.Property<string>("UpdatedById")
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR2(30)")
                        .HasColumnName("UPDATED_BY");

                    b.Property<string>("UserId")
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR2(30)")
                        .HasColumnName("USER_ID");

                    b.HasKey("UserRoleId");

                    b.ToTable("EZ_USER_ROLES");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.RadioStation", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(10)
                        .HasColumnType("NVARCHAR2(10)")
                        .HasColumnName("STN_CODE");

                    b.Property<string>("Name")
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR2(60)")
                        .HasColumnName("STN_NAME");

                    b.HasKey("Code");

                    b.ToTable("EZ_STATIONS");
                });

            modelBuilder.Entity("UBSI_Ops.server.Entities.Vendor", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(8)
                        .HasColumnType("NVARCHAR2(8)")
                        .HasColumnName("VCODE");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("VADDR");

                    b.Property<string>("Company")
                        .HasMaxLength(1)
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("CO");

                    b.Property<string>("Contact")
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)")
                        .HasColumnName("VCONTACT");

                    b.Property<string>("FAX")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("VFAX");

                    b.Property<string>("IsUtility")
                        .HasMaxLength(1)
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("IS_UTILITY");

                    b.Property<string>("Name")
                        .HasMaxLength(35)
                        .HasColumnType("NVARCHAR2(35)")
                        .HasColumnName("VNAME");

                    b.Property<string>("PayTo")
                        .HasMaxLength(40)
                        .HasColumnType("NVARCHAR2(40)")
                        .HasColumnName("PAYTO");

                    b.Property<string>("TIN")
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)")
                        .HasColumnName("VTIN");

                    b.Property<string>("Telephone")
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)")
                        .HasColumnName("VTEL");

                    b.Property<string>("Type")
                        .HasMaxLength(1)
                        .HasColumnType("NVARCHAR2(1)")
                        .HasColumnName("VTYPE");

                    b.HasKey("Code");

                    b.ToTable("VENDORS");
                });
#pragma warning restore 612, 618
        }
    }
}
