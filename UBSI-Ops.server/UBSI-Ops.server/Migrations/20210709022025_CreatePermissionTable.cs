using Microsoft.EntityFrameworkCore.Migrations;

namespace UBSI_Ops.server.Migrations
{
    public partial class CreatePermissionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PERMISSION",
                columns: table => new
                {
                    CODE = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "VARCHAR2(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERMISSION", x => x.CODE);
                });

            migrationBuilder.CreateTable(
                name: "ROLE_PERMISSION",
                columns: table => new
                {
                    CODE = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    PERMISSION_CODE = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    VIEW = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    ADD = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    EDIT = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DELETE = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROLEPERMISSION", x => x.CODE);
                    table.ForeignKey(
                        name: "FK_ROLEPERMISSION_PERMISSION_PERMISSION_CODE",
                        column: x => x.PERMISSION_CODE,
                        principalTable: "PERMISSION",
                        principalColumn: "CODE",
                        onDelete: ReferentialAction.Cascade);
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.DropTable(
                name: "ROLEPERMISSION");

            migrationBuilder.DropTable(
                name: "PERMISSION");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EZ_USERS",
                table: "EZ_USERS");
        }
    }
}
