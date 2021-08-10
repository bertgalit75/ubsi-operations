using Microsoft.EntityFrameworkCore.Migrations;

namespace Ropes.API.Migrations
{
    public partial class AddProductInIO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PRODUCT",
                table: "IMPLEMENTATION_ORDER",
                type: "NVARCHAR2(30)",
                maxLength: 30,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PRODUCT",
                table: "IMPLEMENTATION_ORDER");
        }
    }
}
