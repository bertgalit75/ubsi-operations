using Microsoft.EntityFrameworkCore.Migrations;

namespace UBSI_Ops.server.Migrations
{
    public partial class alterBillingStatement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UIH_CUS_CODE",
                table: "UBSI_INVOICE_HDR",
                type: "VARCHAR(40)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(8)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AGENCY_CODE",
                table: "UBSI_INVOICE_HDR",
                type: "NVARCHAR2(40)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IMPLEMENTATION_ORDER_CODE",
                table: "UBSI_INVOICE_HDR",
                type: "VARCHAR2(10)",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "GROSS_AMOUNT",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "DECIMAL(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.CreateIndex(
                name: "IX_UBSI_INVOICE_HDR_AGENCY_CODE",
                table: "UBSI_INVOICE_HDR",
                column: "AGENCY_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_UBSI_INVOICE_HDR_IMPLEMENTATION_ORDER_CODE",
                table: "UBSI_INVOICE_HDR",
                column: "IMPLEMENTATION_ORDER_CODE");

            migrationBuilder.AddForeignKey(
                name: "FK_UBSI_INVOICE_HDR_EZ_DEBTORS_VW_UIH_CUS_CODE",
                table: "UBSI_INVOICE_HDR",
                column: "UIH_CUS_CODE",
                principalTable: "DEBTORS",
                principalColumn: "CUS_CODE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UBSI_INVOICE_HDR_IMPLEMENTATION_ORDER_IMPLEMENTATION_ORDER_CODE",
                table: "UBSI_INVOICE_HDR",
                column: "IMPLEMENTATION_ORDER_CODE",
                principalTable: "IMPLEMENTATION_ORDER",
                principalColumn: "CODE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UBSI_INVOICE_HDR_MEDIAAGENCY_AGENCY_CODE",
                table: "UBSI_INVOICE_HDR",
                column: "AGENCY_CODE",
                principalTable: "MEDIAAGENCY",
                principalColumn: "CODE",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UBSI_INVOICE_HDR_EZ_DEBTORS_VW_UIH_CUS_CODE",
                table: "UBSI_INVOICE_HDR");

            migrationBuilder.DropForeignKey(
                name: "FK_UBSI_INVOICE_HDR_IMPLEMENTATION_ORDER_IMPLEMENTATION_ORDER_CODE",
                table: "UBSI_INVOICE_HDR");

            migrationBuilder.DropForeignKey(
                name: "FK_UBSI_INVOICE_HDR_MEDIAAGENCY_AGENCY_CODE",
                table: "UBSI_INVOICE_HDR");

            migrationBuilder.DropIndex(
                name: "IX_UBSI_INVOICE_HDR_AGENCY_CODE",
                table: "UBSI_INVOICE_HDR");

            migrationBuilder.DropIndex(
                name: "IX_UBSI_INVOICE_HDR_IMPLEMENTATION_ORDER_CODE",
                table: "UBSI_INVOICE_HDR");

            migrationBuilder.DropColumn(
                name: "AGENCY_CODE",
                table: "UBSI_INVOICE_HDR");

            migrationBuilder.DropColumn(
                name: "IMPLEMENTATION_ORDER_CODE",
                table: "UBSI_INVOICE_HDR");

            migrationBuilder.AlterColumn<string>(
                name: "UIH_CUS_CODE",
                table: "UBSI_INVOICE_HDR",
                type: "VARCHAR(8)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(40)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "GROSS_AMOUNT",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18, 2)");
        }
    }
}
