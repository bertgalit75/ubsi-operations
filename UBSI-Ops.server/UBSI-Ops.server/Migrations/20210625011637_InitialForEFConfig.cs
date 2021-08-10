using Microsoft.EntityFrameworkCore.Migrations;

namespace Ropes.API.Migrations
{
    public partial class InitialForEFConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Customers",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
            //            .Annotation("Oracle:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
            //        CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
            //        CreatedById = table.Column<int>(type: "NUMBER(10)", nullable: false),
            //        UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
            //        UpdatedById = table.Column<int>(type: "NUMBER(10)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Customers", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EZ_STATIONS",
            //    columns: table => new
            //    {
            //        STN_CODE = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: false),
            //        STN_NAME = table.Column<string>(type: "NVARCHAR2(60)", maxLength: 60, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EZ_STATIONS", x => x.STN_CODE);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SPERSONS",
            //    columns: table => new
            //    {
            //        SP_CODE = table.Column<string>(type: "NVARCHAR2(6)", maxLength: 6, nullable: false),
            //        SP_LAST_NAME = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: true),
            //        SP_FIRST_NAME = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: true),
            //        SP_MID_INITIAL = table.Column<string>(type: "NVARCHAR2(1)", maxLength: 1, nullable: true),
            //        SP_MA_SR_CODE = table.Column<string>(type: "NVARCHAR2(3)", maxLength: 3, nullable: true),
            //        SP_MA_CODE = table.Column<string>(type: "NVARCHAR2(3)", maxLength: 3, nullable: true),
            //        CO = table.Column<string>(type: "NVARCHAR2(1)", maxLength: 1, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SPERSONS", x => x.SP_CODE);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "VENDORS",
            //    columns: table => new
            //    {
            //        VCODE = table.Column<string>(type: "NVARCHAR2(8)", maxLength: 8, nullable: false),
            //        VNAME = table.Column<string>(type: "NVARCHAR2(35)", maxLength: 35, nullable: true),
            //        VADDR = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: true),
            //        VTYPE = table.Column<string>(type: "NVARCHAR2(1)", maxLength: 1, nullable: true),
            //        VTEL = table.Column<string>(type: "NVARCHAR2(25)", maxLength: 25, nullable: true),
            //        VFAX = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: true),
            //        VCONTACT = table.Column<string>(type: "NVARCHAR2(25)", maxLength: 25, nullable: true),
            //        VTIN = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: true),
            //        CO = table.Column<string>(type: "NVARCHAR2(1)", maxLength: 1, nullable: true),
            //        PAYTO = table.Column<string>(type: "NVARCHAR2(40)", maxLength: 40, nullable: true),
            //        IS_UTILITY = table.Column<string>(type: "NVARCHAR2(1)", maxLength: 1, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_VENDORS", x => x.VCODE);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "EZ_STATIONS");

            migrationBuilder.DropTable(
                name: "SPERSONS");

            migrationBuilder.DropTable(
                name: "VENDORS");
        }
    }
}
