using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UBSI_Ops.server.Migrations
{
    public partial class FixUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "USERNAME",
                table: "EZ_USERS",
                type: "NVARCHAR2(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TWOFACTORENABLED",
                table: "EZ_USERS",
                type: "NUMBER(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SECURITYSTAMP",
                table: "EZ_USERS",
                type: "NVARCHAR2(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PHONENUMBERCONFIRMED",
                table: "EZ_USERS",
                type: "NUMBER(1)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
               name: "PHONENUMBER",
               table: "EZ_USERS",
               type: "NVARCHAR2(50)",
               maxLength: 50,
               nullable: true);

            migrationBuilder.AddColumn<string>(
               name: "NORMALIZEDUSERNAME",
               table: "EZ_USERS",
               type: "NVARCHAR2(50)",
               maxLength: 50,
               nullable: true);

            migrationBuilder.AddColumn<string>(
               name: "NORMALIZEDEMAIL",
               table: "EZ_USERS",
               type: "NVARCHAR2(50)",
               maxLength: 50,
               nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset?>(
               name: "LOCKOUTEND",
               table: "EZ_USERS",
               type: "TIMESTAMP(7) WITH TIME ZONE",
               nullable: true);

            migrationBuilder.AddColumn<bool>(
               name: "LOCKOUTENABLED",
               table: "EZ_USERS",
               type: "NUMBER(1)",
               maxLength: 50,
               nullable: true);

            migrationBuilder.AddColumn<string>(
               name: "ID",
               table: "EZ_USERS",
               type: "NVARCHAR2(50)",
               maxLength: 50,
               nullable: true);

            migrationBuilder.AddColumn<bool>(
               name: "EMAILCONFIRMED",
               table: "EZ_USERS",
               type: "NUMBER(1)",
               maxLength: 50,
               nullable: true);

            migrationBuilder.AddColumn<string>(
               name: "EMAIL",
               table: "EZ_USERS",
               type: "NVARCHAR2(50)",
               maxLength: 50,
               nullable: true);

            migrationBuilder.AddColumn<int>(
               name: "ACCESSFAILEDCOUNT",
               table: "EZ_USERS",
               type: "NUMBER(10)",
               maxLength: 50,
               nullable: true);

            migrationBuilder.AddColumn<string>(
               name: "CONCURRENTCURRENCYSTAMP",
               table: "EZ_USERS",
               type: "NVARCHAR2(50)",
               maxLength: 50,
               nullable: true);

            migrationBuilder.AddColumn<string>(
               name: "UserId",
               table: "EZ_USERS",
               type: "NVARCHAR2(2000)",
               maxLength: 50,
               nullable: true);

            migrationBuilder.AddColumn<int>(
               name: "USERROLEID",
               table: "EZ_USERS",
               type: "NUMBER(10)",
               maxLength: 50,
               nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "USERNAME",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "TWOFACTORENABLED",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "SECURITYSTAMP",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "PHONENUMBERCONFIRMED",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "PHONENUMBER",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "NORMALIZEDUSERNAME",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "NORMALIZEDEMAIL",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "LOCKOUTEND",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "LOCKOUTENABLED",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "EMAILCONFIRMED",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "EMAIL",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "ACCESSFAILEDCOUNT",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "CONCURRENTCURRENCYSTAMP",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "USERROLEID",
                table: "EZ_USERS");

        }
    }
}
