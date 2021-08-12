using Microsoft.EntityFrameworkCore.Migrations;

namespace Ropes.API.Migrations
{
    public partial class renameRoleId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ROLE_PERMISSION_EZ_ROLES_RoleId",
                table: "ROLE_PERMISSION");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "ROLE_PERMISSION",
                newName: "ROLE_ID");

            migrationBuilder.RenameIndex(
                name: "IX_ROLE_PERMISSION_RoleId",
                table: "ROLE_PERMISSION",
                newName: "IX_ROLE_PERMISSION_ROLE_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ROLE_PERMISSION_EZ_ROLES_ROLE_ID",
                table: "ROLE_PERMISSION",
                column: "ROLE_ID",
                principalTable: "EZ_ROLES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ROLE_PERMISSION_EZ_ROLES_ROLE_ID",
                table: "ROLE_PERMISSION");

            migrationBuilder.RenameColumn(
                name: "ROLE_ID",
                table: "ROLE_PERMISSION",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_ROLE_PERMISSION_ROLE_ID",
                table: "ROLE_PERMISSION",
                newName: "IX_ROLE_PERMISSION_RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ROLE_PERMISSION_EZ_ROLES_RoleId",
                table: "ROLE_PERMISSION",
                column: "RoleId",
                principalTable: "EZ_ROLES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
