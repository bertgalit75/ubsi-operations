using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace UBSI_Ops.server.Migrations
{
    public partial class CreateCPTimelogTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FILE",
                table: "CERTIFICATE_OF_PERFORMANCE");

            migrationBuilder.CreateTable(
                name: "CERTIFICATE_OF_PERFORMANCE_TIMELOG",
                columns: table => new
                {
                    CODE = table.Column<string>(type: "VARCHAR2(10)", nullable: false),
                    CERTIFICATE_OF_PERFORMANCE_CODE = table.Column<string>(type: "VARCHAR2(10)", nullable: true),
                    DATE = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    TIMESTAMP = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CERTIFICATE_OF_PERFORMANCE_TIMELOG", x => x.CODE);
                    table.ForeignKey(
                        name: "FK_CERTIFICATE_OF_PERFORMANCE_TIMELOG_CERTIFICATE_OF_PERFORMANCE_CERTIFICATE_OF_PERFORMANCE_CODE",
                        column: x => x.CERTIFICATE_OF_PERFORMANCE_CODE,
                        principalTable: "CERTIFICATE_OF_PERFORMANCE",
                        principalColumn: "CODE",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CERTIFICATE_OF_PERFORMANCE_TIMELOG_CERTIFICATE_OF_PERFORMANCE_CODE",
                table: "CERTIFICATE_OF_PERFORMANCE_TIMELOG",
                column: "CERTIFICATE_OF_PERFORMANCE_CODE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CERTIFICATE_OF_PERFORMANCE_TIMELOG");

            migrationBuilder.AddColumn<string>(
                name: "FILE",
                table: "CERTIFICATE_OF_PERFORMANCE",
                type: "VARCHAR2(40)",
                nullable: true);
        }
    }
}
