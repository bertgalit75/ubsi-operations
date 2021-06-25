using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UBSI_Ops.server.Migrations
{
    public partial class UserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EZ_USER_ROLES",
                columns: table => new
                {
                    USER_ROLE_ID = table.Column<decimal>(type: "NUMBER", maxLength: 11, nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    ROLE_ID = table.Column<decimal>(type: "NUMBER", maxLength: 11, nullable: false),
                    USER_ID = table.Column<string>(type: "VARCHAR2(30)", maxLength: 30, nullable: true),
                    TYPE = table.Column<string>(type: "VARCHAR2(30)", maxLength: 30, nullable: true),
                    BRANCH_ID = table.Column<decimal>(type: "NUMBER", maxLength: 11, nullable: false),
                    CREATED_AT = table.Column<DateTime>(type: "DATE", nullable: false),
                    CREATED_BY = table.Column<string>(type: "VARCHAR2(30)", maxLength: 30, nullable: true),
                    UPDATED_AT = table.Column<DateTime>(type: "DATE", nullable: false),
                    UPDATED_BY = table.Column<string>(type: "VARCHAR2(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EZ_USER_ROLES", x => x.USER_ROLE_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EZ_USER_ROLES");
        }
    }
}
