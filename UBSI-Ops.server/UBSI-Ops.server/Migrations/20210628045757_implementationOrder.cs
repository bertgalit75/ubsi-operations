using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UBSI_Ops.server.Migrations
{
    public partial class implementationOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IMPLEMENTATION_ORDER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", maxLength: 11, nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    DATE = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    CLIENT_ID = table.Column<int>(type: "NUMBER(10)", maxLength: 11, nullable: false),
                    AGENCY_ID = table.Column<int>(type: "NUMBER(10)", maxLength: 11, nullable: false),
                    AE_ID = table.Column<int>(type: "NUMBER(10)", maxLength: 11, nullable: false),
                    TAGLINE = table.Column<int>(type: "NUMBER(10)", maxLength: 30, nullable: false),
                    BO_NO = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: true),
                    PO_NO = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: true),
                    REF_NO = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: true),
                    CREATED_AT = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    CREATED_BY_ID = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: true),
                    UPDATED_AT = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    UPDATED_BY_ID = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMPLEMENTATION_ORDER", x => x.ID);
                });

           
            migrationBuilder.CreateTable(
                name: "IMPLEMENTATION_ORDER_BOOKING",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", maxLength: 11, nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    IMPLEMENTATION_ORDER_ID = table.Column<int>(type: "NUMBER(10)", maxLength: 11, nullable: false),
                    STATION_ID = table.Column<int>(type: "NUMBER(10)", maxLength: 11, nullable: false),
                    PERIOD_START = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    PERIOD_END = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    DURATION = table.Column<int>(type: "NUMBER(10)", maxLength: 11, nullable: false),
                    SPOT = table.Column<int>(type: "NUMBER(10)", maxLength: 11, nullable: false),
                    GROSS = table.Column<int>(type: "NUMBER(10)", maxLength: 11, nullable: false),
                    CREATED_AT = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    CREATED_BY_ID = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: true),
                    UPDATED_AT = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    UPDATED_BY_ID = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMPLEMENTATION_ORDER_BOOKING", x => x.ID);
                    table.ForeignKey(
                        name: "FK_IMPLEMENTATION_ORDER_BOOKING_IMPLEMENTATION_ORDER_IMPLEMENTATION_ORDER_ID",
                        column: x => x.IMPLEMENTATION_ORDER_ID,
                        principalTable: "IMPLEMENTATION_ORDER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IMPLEMENTATION_ORDER_BOOKING_IMPLEMENTATION_ORDER_ID",
                table: "IMPLEMENTATION_ORDER_BOOKING",
                column: "IMPLEMENTATION_ORDER_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "IMPLEMENTATION_ORDER_BOOKING");


            migrationBuilder.DropTable(
                name: "IMPLEMENTATION_ORDER");
        }
    }
}
