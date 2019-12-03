using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WerkbonAppTest3.Migrations
{
    public partial class uitvoeringsdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UitvoeringsData",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedewerkerID = table.Column<int>(nullable: false),
                    Vertrekuur = table.Column<DateTime>(nullable: false),
                    Inpakuren = table.Column<int>(nullable: false),
                    Montageuren = table.Column<int>(nullable: false),
                    Aantal_Laden = table.Column<int>(nullable: false),
                    Start_Laden = table.Column<DateTime>(nullable: false),
                    Eind_Laden = table.Column<DateTime>(nullable: false),
                    Laaduren = table.Column<int>(nullable: false),
                    Aantal_Lossen = table.Column<int>(nullable: false),
                    Start_Lossen = table.Column<DateTime>(nullable: false),
                    Eind_Lossen = table.Column<DateTime>(nullable: false),
                    Losuren = table.Column<int>(nullable: false),
                    Aankomst_Tijd = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UitvoeringsData", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UitvoeringsData_Medewerker_MedewerkerID",
                        column: x => x.MedewerkerID,
                        principalTable: "Medewerker",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UitvoeringsData_MedewerkerID",
                table: "UitvoeringsData",
                column: "MedewerkerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UitvoeringsData");
        }
    }
}
