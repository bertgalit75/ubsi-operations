using Microsoft.EntityFrameworkCore.Migrations;

namespace UBSI_Ops.server.Migrations
{
    public partial class alterRolePermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RoleId",
                table: "ROLE_PERMISSION",
                type: "VARCHAR2(20)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ROLE_PERMISSION_RoleId",
                table: "ROLE_PERMISSION",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ROLE_PERMISSION_EZ_ROLES_RoleId",
                table: "ROLE_PERMISSION",
                column: "RoleId",
                principalTable: "EZ_ROLES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ROLE_PERMISSION_EZ_ROLES_RoleId",
                table: "ROLE_PERMISSION");

            migrationBuilder.DropIndex(
                name: "IX_ROLE_PERMISSION_RoleId",
                table: "ROLE_PERMISSION");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "ROLE_PERMISSION");
        }
    }
}
