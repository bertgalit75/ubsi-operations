using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace UBSI_Ops.server.Migrations
{
    public partial class alterRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
              name: "CREATED_BY_CODE",
              table: "EZ_ROLES",
              type: "VARCHAR2(50)",
              nullable: true,
              maxLength: 50);

            migrationBuilder.AddColumn<DateTime>(
            name: "UPDATED_AT",
            table: "EZ_ROLES",
            type: "TIMESTAMP(7)",
            nullable: false,
            defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<DateTime?>(
              name: "CREATED_AT",
              table: "EZ_ROLES",
              type: "TIMESTAMP(7)",
              nullable: false,
              defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<string>(
              name: "UPDATED_BY_CODE",
              table: "EZ_ROLES",
              type: "VARCHAR2(50)",
              nullable: true,
              maxLength: 50);

            migrationBuilder.RenameColumn(name: "Id", table: "EZ_ROLES", newName: "ID");

            migrationBuilder.RenameColumn(name: "Name", table: "EZ_ROLES", newName: "NAME");

            migrationBuilder.RenameColumn(name: "NormalizedName", table: "EZ_ROLES", newName: "NORMALIZED_NAME");

            migrationBuilder.RenameColumn(name: "ConcurrencyStamp", table: "EZ_ROLES", newName: "CONCURRENCY_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ID",
                table: "EZ_ROLES",
                type: "VARCHAR2(20)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER");

            migrationBuilder.AlterColumn<string>(
              name: "ROLE_ID",
              table: "EZ_USER_ROLES",
              type: "VARCHAR2(20)",
              nullable: false,
              oldClrType: typeof(int),
              oldType: "NUMBER");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
              name: "CREATED_BY_CODE",
              table: "EZ_ROLES");

            migrationBuilder.DropColumn(
              name: "UPDATED_AT",
              table: "EZ_ROLES");

            migrationBuilder.DropColumn(
              name: "CREATED_AT",
              table: "EZ_ROLES");

            migrationBuilder.DropColumn(
              name: "UPDATED_BY_CODE",
              table: "EZ_ROLES");

            migrationBuilder.RenameColumn(name: "ID", table: "EZ_ROLES", newName: "Id");

            migrationBuilder.RenameColumn(name: "NAME", table: "EZ_ROLES", newName: "Name");

            migrationBuilder.RenameColumn(name: "NORMALIZED_NAME", table: "EZ_ROLES", newName: "NormalizedName");

            migrationBuilder.RenameColumn(name: "CONCURRENCY_TIMESTAMP", table: "EZ_ROLES", newName: "ConcurrencyStamp");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "EZ_ROLES",
                type: "NUMBER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "VARCHAR2(20)");

            migrationBuilder.AlterColumn<int>(
              name: "ROLE_ID",
              table: "EZ_USER_ROLES",
              type: "NUMBER",
              nullable: false,
              oldClrType: typeof(int),
              oldType: "VARCHAR2(20)");
        }
    }
}
