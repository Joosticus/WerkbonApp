using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WerkbonAppTest3.Migrations
{
    public partial class klant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klant",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RekeningID = table.Column<int>(nullable: false),
                    Naam = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(nullable: false),
                    Contactpersoon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klant", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Klant_Rekening_RekeningID",
                        column: x => x.RekeningID,
                        principalTable: "Rekening",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Klant_RekeningID",
                table: "Klant",
                column: "RekeningID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Klant");
        }
    }
}
