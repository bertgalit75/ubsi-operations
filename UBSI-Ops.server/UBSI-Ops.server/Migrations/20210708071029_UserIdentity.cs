using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace UBSI_Ops.server.Migrations
{
    public partial class UserIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                name: "ACCESSFAILEDCOUNT",
                table: "EZ_USERS",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CONCURRENTCURRENCYSTAMP",
                table: "EZ_USERS",
                type: "NVARCHAR2(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EMAIL",
                table: "EZ_USERS",
                type: "NVARCHAR2(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EMAILCONFIRMED",
                table: "EZ_USERS",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LOCKOUTENABLED",
                table: "EZ_USERS",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LOCKOUTEND",
                table: "EZ_USERS",
                type: "TIMESTAMP(7) WITH TIME ZONE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NORMALIZEDEMAIL",
                table: "EZ_USERS",
                type: "NVARCHAR2(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NORMALIZEDUSERNAME",
                table: "EZ_USERS",
                type: "NVARCHAR2(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PHONENUMBER",
                table: "EZ_USERS",
                type: "NVARCHAR2(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PHONENUMBERCONFIRMED",
                table: "EZ_USERS",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SECURITYSTAMP",
                table: "EZ_USERS",
                type: "NVARCHAR2(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TWOFACTORENABLED",
                table: "EZ_USERS",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "USERNAME",
                table: "EZ_USERS",
                type: "NVARCHAR2(20)",
                maxLength: 20,
                nullable: true);


            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "EZ_USERS",
                column: "NORMALIZEDEMAIL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "EZ_USERS",
                column: "NORMALIZEDUSERNAME",
                unique: true,
                filter: "\"NORMALIZEDUSERNAME\" IS NOT NULL");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_EZ_USERS_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_EZ_USERS_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_EZ_USERS_USER_ID",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_EZ_USERS_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_EZ_USER_ROLES_EZ_USERS_USER_ID",
                table: "EZ_USER_ROLES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EZ_USERS",
                table: "EZ_USERS");

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "EZ_USERS");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "AU_USERID",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "ACCESSFAILEDCOUNT",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "AU_ENROLLED_ON",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "AU_LOCKED_ON",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "AU_NAME",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "AU_PASSWORD",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "CONCURRENTCURRENCYSTAMP",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "EMAIL",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "EMAILCONFIRMED",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "LOCKOUTENABLED",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "LOCKOUTEND",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "NORMALIZEDEMAIL",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "NORMALIZEDUSERNAME",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "PHONENUMBER",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "PHONENUMBERCONFIRMED",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "SECURITYSTAMP",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "TWOFACTORENABLED",
                table: "EZ_USERS");

            migrationBuilder.DropColumn(
                name: "USERNAME",
                table: "EZ_USERS");

            migrationBuilder.RenameTable(
                name: "EZ_USERS",
                newName: "User");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserTokens",
                type: "NVARCHAR2(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(30)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserLogins",
                type: "NVARCHAR2(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(30)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserClaims",
                type: "NVARCHAR2(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(30)");

            migrationBuilder.AddColumn<string>(
                name: "TempId1",
                table: "User",
                type: "NVARCHAR2(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TempId2",
                table: "User",
                type: "NVARCHAR2(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TempId3",
                table: "User",
                type: "NVARCHAR2(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TempId4",
                table: "User",
                type: "NVARCHAR2(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_User_TempId1",
                table: "User",
                column: "TempId1");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_User_TempId2",
                table: "User",
                column: "TempId2");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_User_TempId3",
                table: "User",
                column: "TempId3");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_User_TempId4",
                table: "User",
                column: "TempId4");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_User_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "User",
                principalColumn: "TempId1",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_User_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "User",
                principalColumn: "TempId2",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_User_USER_ID",
                table: "AspNetUserRoles",
                column: "USER_ID",
                principalTable: "User",
                principalColumn: "TempId3",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_User_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "User",
                principalColumn: "TempId4",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EZ_USER_ROLES_User_USER_ID",
                table: "EZ_USER_ROLES",
                column: "USER_ID",
                principalTable: "User",
                principalColumn: "TempId3",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
