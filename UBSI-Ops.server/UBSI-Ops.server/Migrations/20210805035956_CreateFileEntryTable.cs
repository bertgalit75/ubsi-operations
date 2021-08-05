using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UBSI_Ops.server.Migrations
{
    public partial class CreateFileEntryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FILE_ENTRY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    FILENAME = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    MEDIATYPE = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    LENGTH = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    PATH = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CREATED_BY_CODE = table.Column<string>(type: "VARCHAR2(50)", maxLength: 50, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    UPDATED_BY_CODE = table.Column<string>(type: "VARCHAR2(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FILE_ENTRY", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FILE_ENTRY");
        }
    }
}
