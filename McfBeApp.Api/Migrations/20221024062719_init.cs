using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace McfBeApp.Api.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ms_storage_location",
                columns: table => new
                {
                    location_id = table.Column<string>(type: "VARCHAR(10)", maxLength: 10, nullable: false),
                    location_name = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ms_storage_location", x => x.location_id);
                });

            migrationBuilder.CreateTable(
                name: "tr_bpkb",
                columns: table => new
                {
                    agreement_number = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    bpkb_number = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: true),
                    bpkp_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    faktur_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    location_id = table.Column<string>(type: "VARCHAR(10)", maxLength: 10, nullable: true),
                    police_no = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: true),
                    bpkp_date_in = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tr_bpkb", x => x.agreement_number);
                    table.ForeignKey(
                        name: "FK_tr_bpkb_ms_storage_location_location_id",
                        column: x => x.location_id,
                        principalTable: "ms_storage_location",
                        principalColumn: "location_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tr_bpkb_location_id",
                table: "tr_bpkb",
                column: "location_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tr_bpkb");

            migrationBuilder.DropTable(
                name: "ms_storage_location");
        }
    }
}
