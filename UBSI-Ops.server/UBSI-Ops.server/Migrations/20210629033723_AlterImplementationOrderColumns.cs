using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Ropes.API.Migrations
{
    public partial class AlterImplementationOrderColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IMPLEMENTATION_ORDER_BOOKING_IMPLEMENTATION_ORDER_IMPLEMENTATION_ORDER_ID",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IMPLEMENTATION_ORDER_BOOKING",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropIndex(
                name: "IX_IMPLEMENTATION_ORDER_BOOKING_IMPLEMENTATION_ORDER_ID",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IMPLEMENTATION_ORDER",
                table: "IMPLEMENTATION_ORDER");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropColumn(
                name: "CREATED_BY_ID",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropColumn(
                name: "IMPLEMENTATION_ORDER_ID",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropColumn(
                name: "STATION_ID",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropColumn(
                name: "UPDATED_BY_ID",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "IMPLEMENTATION_ORDER");

            migrationBuilder.DropColumn(
                name: "AE_ID",
                table: "IMPLEMENTATION_ORDER");

            migrationBuilder.DropColumn(
                name: "AGENCY_ID",
                table: "IMPLEMENTATION_ORDER");

            migrationBuilder.DropColumn(
                name: "CLIENT_ID",
                table: "IMPLEMENTATION_ORDER");

            migrationBuilder.DropColumn(
                name: "CREATED_BY_ID",
                table: "IMPLEMENTATION_ORDER");

            migrationBuilder.DropColumn(
                name: "PRODUCT",
                table: "IMPLEMENTATION_ORDER");

            migrationBuilder.DropColumn(
                name: "UPDATED_BY_ID",
                table: "IMPLEMENTATION_ORDER");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATED_AT",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PERIOD_START",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PERIOD_END",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<decimal>(
                name: "GROSS",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "NUMBER(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CREATED_AT",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AddColumn<int>(
                name: "CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0)
                .Annotation("Oracle:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IMPLEMENTATION_ORDER_CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "STATION_CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "VARCHAR2(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UPDATED_BY_CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "VARCHAR2(20)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATED_AT",
                table: "IMPLEMENTATION_ORDER",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "TAGLINE",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(20)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "REF_NO",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PO_NO",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE",
                table: "IMPLEMENTATION_ORDER",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CREATED_AT",
                table: "IMPLEMENTATION_ORDER",
                type: "TIMESTAMP(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "BO_NO",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CODE",
                table: "IMPLEMENTATION_ORDER",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0)
                .Annotation("Oracle:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "AE_CODE",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AGENCY_CODE",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CLIENT_CODE",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CREATED_BY_CODE",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PRODUCT_CODE",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UPDATED_BY_CODE",
                table: "IMPLEMENTATION_ORDER",
                type: "VARCHAR2(20)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_IMPLEMENTATION_ORDER_BOOKING",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                column: "CODE");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IMPLEMENTATION_ORDER",
                table: "IMPLEMENTATION_ORDER",
                column: "CODE");

            migrationBuilder.CreateIndex(
                name: "IX_IMPLEMENTATION_ORDER_BOOKING_IMPLEMENTATION_ORDER_CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                column: "IMPLEMENTATION_ORDER_CODE");

            migrationBuilder.AddForeignKey(
                name: "FK_IMPLEMENTATION_ORDER_BOOKING_IMPLEMENTATION_ORDER_IMPLEMENTATION_ORDER_CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                column: "IMPLEMENTATION_ORDER_CODE",
                principalTable: "IMPLEMENTATION_ORDER",
                principalColumn: "CODE",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IMPLEMENTATION_ORDER_BOOKING_IMPLEMENTATION_ORDER_IMPLEMENTATION_ORDER_CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IMPLEMENTATION_ORDER_BOOKING",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropIndex(
                name: "IX_IMPLEMENTATION_ORDER_BOOKING_IMPLEMENTATION_ORDER_CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IMPLEMENTATION_ORDER",
                table: "IMPLEMENTATION_ORDER");

            migrationBuilder.DropColumn(
                name: "CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropColumn(
                name: "IMPLEMENTATION_ORDER_CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropColumn(
                name: "STATION_CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropColumn(
                name: "UPDATED_BY_CODE",
                table: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropColumn(
                name: "CODE",
                table: "IMPLEMENTATION_ORDER");

            migrationBuilder.DropColumn(
                name: "AE_CODE",
                table: "IMPLEMENTATION_ORDER");

            migrationBuilder.DropColumn(
                name: "AGENCY_CODE",
                table: "IMPLEMENTATION_ORDER");

            migrationBuilder.DropColumn(
                name: "CLIENT_CODE",
                table: "IMPLEMENTATION_ORDER");

            migrationBuilder.DropColumn(
                name: "CREATED_BY_CODE",
                table: "IMPLEMENTATION_ORDER");

            migrationBuilder.DropColumn(
                name: "PRODUCT_CODE",
                table: "IMPLEMENTATION_ORDER");

            migrationBuilder.DropColumn(
                name: "UPDATED_BY_CODE",
                table: "IMPLEMENTATION_ORDER");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATED_AT",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PERIOD_START",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PERIOD_END",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<int>(
                name: "GROSS",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "NUMBER(10)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "NUMBER(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CREATED_AT",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "NUMBER(10)",
                maxLength: 11,
                nullable: false,
                defaultValue: 0)
                .Annotation("Oracle:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CREATED_BY_ID",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "NVARCHAR2(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IMPLEMENTATION_ORDER_ID",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "NUMBER(10)",
                maxLength: 11,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "STATION_ID",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "NUMBER(10)",
                maxLength: 11,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UPDATED_BY_ID",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                type: "NVARCHAR2(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATED_AT",
                table: "IMPLEMENTATION_ORDER",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<int>(
                name: "TAGLINE",
                table: "IMPLEMENTATION_ORDER",
                type: "NUMBER(10)",
                maxLength: 30,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "REF_NO",
                table: "IMPLEMENTATION_ORDER",
                type: "NVARCHAR2(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PO_NO",
                table: "IMPLEMENTATION_ORDER",
                type: "NVARCHAR2(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE",
                table: "IMPLEMENTATION_ORDER",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CREATED_AT",
                table: "IMPLEMENTATION_ORDER",
                type: "TIMESTAMP",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(7)");

            migrationBuilder.AlterColumn<string>(
                name: "BO_NO",
                table: "IMPLEMENTATION_ORDER",
                type: "NVARCHAR2(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR2(20)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "IMPLEMENTATION_ORDER",
                type: "NUMBER(10)",
                maxLength: 11,
                nullable: false,
                defaultValue: 0)
                .Annotation("Oracle:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AE_ID",
                table: "IMPLEMENTATION_ORDER",
                type: "NUMBER(10)",
                maxLength: 11,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AGENCY_ID",
                table: "IMPLEMENTATION_ORDER",
                type: "NUMBER(10)",
                maxLength: 11,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CLIENT_ID",
                table: "IMPLEMENTATION_ORDER",
                type: "NUMBER(10)",
                maxLength: 11,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CREATED_BY_ID",
                table: "IMPLEMENTATION_ORDER",
                type: "NVARCHAR2(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PRODUCT",
                table: "IMPLEMENTATION_ORDER",
                type: "NVARCHAR2(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UPDATED_BY_ID",
                table: "IMPLEMENTATION_ORDER",
                type: "NVARCHAR2(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_IMPLEMENTATION_ORDER_BOOKING",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IMPLEMENTATION_ORDER",
                table: "IMPLEMENTATION_ORDER",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_IMPLEMENTATION_ORDER_BOOKING_IMPLEMENTATION_ORDER_ID",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                column: "IMPLEMENTATION_ORDER_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_IMPLEMENTATION_ORDER_BOOKING_IMPLEMENTATION_ORDER_IMPLEMENTATION_ORDER_ID",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                column: "IMPLEMENTATION_ORDER_ID",
                principalTable: "IMPLEMENTATION_ORDER",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
