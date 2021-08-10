using Microsoft.EntityFrameworkCore.Migrations;

namespace Ropes.API.Migrations
{
    public partial class UpdateUserPasswordlength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AU_PASSWORD",
                table: "EZ_USERS",
                type: "VARCHAR2(32)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(30)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AU_PASSWORD",
                table: "EZ_USERS",
                type: "VARCHAR2(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(32)");
        }
    }
}
