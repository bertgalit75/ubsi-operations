using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace UBSI_Ops.server.Migrations
{
    public partial class ReCreateRoleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
              name: "EZ_USER_ROLES");

            migrationBuilder.DropTable(
               name: "EZ_ROLES");

            migrationBuilder.CreateTable(
                name: "EZ_ROLES",
                columns: table => new
                {
                    ID = table.Column<string>(type: "VARCHAR2(20)", maxLength: 20, nullable: false),
                    CREATED_AT = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CREATED_BY_CODE = table.Column<string>(type: "VARCHAR2(50)", maxLength: 50, nullable: true),
                    UPDATED_AT = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UPDATED_BY_CODE = table.Column<string>(type: "VARCHAR2(50)", maxLength: 50, nullable: true),
                    NAME = table.Column<string>(type: "VARCHAR2(20)", maxLength: 20, nullable: true),
                    NORMALIZE_NAME = table.Column<string>(type: "VARCHAR2(20)", maxLength: 20, nullable: true),
                    CONCURRENCY_TIMESTAMP = table.Column<string>(type: "VARCHAR2(36)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EZ_ROLES", x => x.ID);
                });



            migrationBuilder.CreateTable(
                name: "EZ_USER_ROLES",
                columns: table => new
                {
                    USER_ID = table.Column<string>(type: "VARCHAR2(30)", maxLength: 30, nullable: false),
                    ROLE_ID = table.Column<string>(type: "VARCHAR2(11)", maxLength: 11, nullable: false),
                    TYPE = table.Column<string>(type: "VARCHAR2(30)", maxLength: 30, nullable: true),
                    BRANCH_ID = table.Column<decimal>(type: "NUMBER", maxLength: 11, nullable: false),
                    CREATED_AT = table.Column<DateTime>(type: "DATE", nullable: false),
                    CREATED_BY = table.Column<string>(type: "VARCHAR2(30)", maxLength: 30, nullable: true),
                    UPDATED_AT = table.Column<DateTime>(type: "DATE", nullable: false),
                    UPDATED_BY = table.Column<string>(type: "VARCHAR2(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EZ_USER_ROLES", x => new { x.USER_ID, x.ROLE_ID });

                    table.ForeignKey(
                        name: "FK_EZ_USER_ROLES_EZ_ROLES_ROLE_ID",
                        column: x => x.ROLE_ID,
                        principalTable: "EZ_ROLES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EZ_DEBTORS_VW");

            migrationBuilder.DropTable(
                name: "EZ_STATIONS");

            migrationBuilder.DropTable(
                name: "EZ_USER_ROLES");

            migrationBuilder.DropTable(
                name: "IMPLEMENTATION_ORDER_BOOKING");

            migrationBuilder.DropTable(
                name: "SPERSONS");

            migrationBuilder.DropTable(
                name: "VENDORS");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "EZ_ROLES");

            migrationBuilder.DropTable(
                name: "IMPLEMENTATION_ORDER");

            migrationBuilder.DropTable(
                name: "EZ_USERS");
        }
    }
}
