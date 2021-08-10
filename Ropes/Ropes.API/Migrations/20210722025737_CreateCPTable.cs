using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Ropes.API.Migrations
{
    public partial class CreateCPTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CERTIFICATE_OF_PERFORMANCE",
                columns: table => new
                {
                    CODE = table.Column<string>(type: "VARCHAR2(10)", nullable: false),
                    IMPLEMENTATION_ORDER_CODE = table.Column<string>(type: "VARCHAR2(10)", nullable: true),
                    FILE = table.Column<string>(type: "VARCHAR2(40)", nullable: true),
                    CREATED_AT = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CREATED_BY_CODE = table.Column<string>(type: "VARCHAR2(20)", nullable: true),
                    UPDATED_AT = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UPDATED_BY_CODE = table.Column<string>(type: "VARCHAR2(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CERTIFICATE_OF_PERFORMANCE", x => x.CODE);
                    table.ForeignKey(
                        name: "FK_CERTIFICATE_OF_PERFORMANCE_IMPLEMENTATION_ORDER_IMPLEMENTATION_ORDER_CODE",
                        column: x => x.IMPLEMENTATION_ORDER_CODE,
                        principalTable: "IMPLEMENTATION_ORDER",
                        principalColumn: "CODE",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CERTIFICATE_OF_PERFORMANCE_IMPLEMENTATION_ORDER_CODE",
                table: "CERTIFICATE_OF_PERFORMANCE",
                column: "IMPLEMENTATION_ORDER_CODE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CERTIFICATE_OF_PERFORMANCE");
        }
    }
}
