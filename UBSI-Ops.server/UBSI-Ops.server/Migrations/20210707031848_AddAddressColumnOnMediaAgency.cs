using Microsoft.EntityFrameworkCore.Migrations;

namespace UBSI_Ops.server.Migrations
{
    public partial class AddAddressColumnOnMediaAgency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ADDRESSLINE",
                table: "MEDIAAGENCY",
                type: "NVARCHAR2(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CITY",
                table: "MEDIAAGENCY",
                type: "NVARCHAR2(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PROVINCE",
                table: "MEDIAAGENCY",
                type: "NVARCHAR2(20)",
                maxLength: 20,
                nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ADDRESSLINE",
                table: "MEDIAAGENCY");

            migrationBuilder.DropColumn(
                name: "CITY",
                table: "MEDIAAGENCY");

            migrationBuilder.DropColumn(
                name: "PROVINCE",
                table: "MEDIAAGENCY");
        }
    }
}
