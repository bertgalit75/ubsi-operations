using Microsoft.EntityFrameworkCore.Migrations;

namespace Ropes.API.Migrations
{
    public partial class CreateTableMediaAgency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MEDIAAGENCY",
                columns: table => new
                {
                    CODE = table.Column<string>(type: "NVARCHAR2(40)", maxLength: 40, nullable: false),
                    NAME = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: true),
                    CONTACT_NO = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: true),
                    FAX = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: true),
                    EMAIL = table.Column<string>(type: "NVARCHAR2(40)", maxLength: 40, nullable: true),
                    REMARKS = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEDIAAGENCY", x => x.CODE);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MEDIAAGENCY");
        }
    }
}
