using Microsoft.EntityFrameworkCore.Migrations;

namespace UBSI_Ops.server.Migrations
{
    public partial class AlterImplementationOrderBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FRIDAY",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MONDAY",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SATURDAY",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SUNDAY",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "THURSDAY",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TUESDAY",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "WEDNESDAY",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FRIDAY",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropColumn(
                name: "MONDAY",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropColumn(
                name: "SATURDAY",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropColumn(
                name: "SUNDAY",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropColumn(
                name: "THURSDAY",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropColumn(
                name: "TUESDAY",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropColumn(
                name: "WEDNESDAY",
                table: "IMPLEMENTATION_ORDER_BOOKING");
        }
    }
}
