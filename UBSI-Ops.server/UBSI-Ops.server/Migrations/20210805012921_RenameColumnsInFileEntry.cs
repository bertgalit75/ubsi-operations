using Microsoft.EntityFrameworkCore.Migrations;

namespace UBSI_Ops.server.Migrations
{
    public partial class RenameColumnsInFileEntry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreatedByCode",
                table: "FILE_ENTRY",
                type: "NVARCHAR2(50)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedByCode",
                table: "FILE_ENTRY",
                type: "NVARCHAR2(50)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.RenameColumn(name: "CreatedByCode", table: "FILE_ENTRY", newName: "CREATED_BY_CODE");

            migrationBuilder.RenameColumn(name: "UpdatedByCode", table: "FILE_ENTRY", newName: "UPDATED_BY_CODE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CREATED_BY_CODE",
                table: "FILE_ENTRY",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NVARCHAR2(50)");

            migrationBuilder.AlterColumn<string>(
                name: "UPDATED_BY_CODE",
                table: "FILE_ENTRY",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NVARCHAR2(50)");

            migrationBuilder.RenameColumn(name: "CREATED_BY_CODE", table: "FILE_ENTRY", newName: "CreatedByCode");

            migrationBuilder.RenameColumn(name: "UPDATED_BY_CODE", table: "FILE_ENTRY", newName: "UpdatedByCode");
        }
    }
}
