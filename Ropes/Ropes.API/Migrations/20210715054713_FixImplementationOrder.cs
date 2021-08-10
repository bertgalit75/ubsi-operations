using Microsoft.EntityFrameworkCore.Migrations;

namespace Ropes.API.Migrations
{
    public partial class FixImplementationOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IMPLEMENTATION_ORDER_BOOKING_IMPLEMENTATION_ORDER_IMPLEMENTATION_ORDER_CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.RenameColumn(
                name: "GROSS",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                newName: "GROSS_AMOUNT");

            migrationBuilder.DropColumn(
                name: "PRODUCT_CODE",
                table: "IMPLEMENTATION_ORDER");

            migrationBuilder.RenameColumn(
                name: "SPOT",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                newName: "NO_OF_SPOTS");

            migrationBuilder.RenameColumn(
                name: "REF_NO",
                table: "IMPLEMENTATION_ORDER",
                newName: "REFERENCE_CE_NO");

            migrationBuilder.RenameColumn(
                name: "PO_NO",
                table: "IMPLEMENTATION_ORDER",
                newName: "PURCHASE_ORDER_NO");

            migrationBuilder.RenameColumn(
                name: "BO_NO",
                table: "IMPLEMENTATION_ORDER",
                newName: "BOOKING_ORDER_NO");

            migrationBuilder.RenameColumn(
                name: "AE_CODE",
                table: "IMPLEMENTATION_ORDER",
                newName: "ACCOUNT_EXECUTIVE_CODE");

            migrationBuilder.AlterColumn<string>(
                name: "STATION_CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "VARCHAR2(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IMPLEMENTATION_ORDER_CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "VARCHAR2(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<string>(
                name: "TAGLINE",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(1000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CLIENT_CODE",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(8)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CODE",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(10)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)")
                .OldAnnotation("Oracle:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "REFERENCE_CE_NO",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PURCHASE_ORDER_NO",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BOOKING_ORDER_NO",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ACCOUNT_EXECUTIVE_CODE",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(6)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(20)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PRODUCT",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(100)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_IMPLEMENTATION_ORDER_BOOKING_IMPLEMENTATION_ORDER_IMPLEMENTATION_ORDER_CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                column: "IMPLEMENTATION_ORDER_CODE",
                principalTable: "IMPLEMENTATION_ORDER",
                principalColumn: "CODE",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IMPLEMENTATION_ORDER_BOOKING_IMPLEMENTATION_ORDER_IMPLEMENTATION_ORDER_CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.RenameColumn(
                name: "GROSS_AMOUNT",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                newName: "GROSS");

            migrationBuilder.DropColumn(
                name: "PRODUCT",
                table: "IMPLEMENTATION_ORDER");

            migrationBuilder.RenameColumn(
                name: "NO_OF_SPOTS",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                newName: "SPOT");

            migrationBuilder.RenameColumn(
                name: "REFERENCE_CE_NO",
                table: "IMPLEMENTATION_ORDER",
                newName: "REF_NO");

            migrationBuilder.RenameColumn(
                name: "PURCHASE_ORDER_NO",
                table: "IMPLEMENTATION_ORDER",
                newName: "PO_NO");

            migrationBuilder.RenameColumn(
                name: "BOOKING_ORDER_NO",
                table: "IMPLEMENTATION_ORDER",
                newName: "BO_NO");

            migrationBuilder.RenameColumn(
                name: "ACCOUNT_EXECUTIVE_CODE",
                table: "IMPLEMENTATION_ORDER",
                newName: "AE_CODE");

            migrationBuilder.AlterColumn<string>(
                name: "STATION_CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "VARCHAR2(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IMPLEMENTATION_ORDER_CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(10)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "GROSS",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "NUMBER(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "TAGLINE",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(1000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CLIENT_CODE",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(8)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CODE",
                table: "IMPLEMENTATION_ORDER",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(10)")
                .Annotation("Oracle:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "REF_NO",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PO_NO",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BO_NO",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AE_CODE",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(6)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PRODUCT_CODE",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(20)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_IMPLEMENTATION_ORDER_BOOKING_IMPLEMENTATION_ORDER_IMPLEMENTATION_ORDER_CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                column: "IMPLEMENTATION_ORDER_CODE",
                principalTable: "IMPLEMENTATION_ORDER",
                principalColumn: "CODE",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
