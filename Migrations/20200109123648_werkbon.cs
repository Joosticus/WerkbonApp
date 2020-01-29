using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WerkbonApplicatie.Migrations
{
    public partial class werkbon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Werkbon",
                columns: table => new
                {
                    WerkbonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Klant_Naam = table.Column<string>(nullable: true),
                    Voornaam = table.Column<string>(nullable: true),
                    Achternaam = table.Column<string>(nullable: true),
                    Telefoonnummer = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    Inpakken = table.Column<bool>(nullable: false),
                    Uitpakken = table.Column<bool>(nullable: false),
                    Montage = table.Column<bool>(nullable: false),
                    Demontage = table.Column<bool>(nullable: false),
                    Laden = table.Column<bool>(nullable: false),
                    Lossen = table.Column<bool>(nullable: false),
                    Ophangen_Lamp = table.Column<bool>(nullable: false),
                    Afhalen_Lamp = table.Column<bool>(nullable: false),
                    Aansluiten_Witgoed = table.Column<bool>(nullable: false),
                    Afsluiten_Witgoed = table.Column<bool>(nullable: false),
                    Intern_Transport = table.Column<bool>(nullable: false),
                    Schade_Veroorzaakt = table.Column<bool>(nullable: false),
                    Schade_Besproken = table.Column<bool>(nullable: false),
                    Schade_Beschrijving = table.Column<string>(nullable: true),
                    Kenteken = table.Column<string>(nullable: true),
                    Aanvangstijd = table.Column<DateTime>(nullable: false),
                    Volume = table.Column<int>(nullable: false),
                    Merk_Kraan = table.Column<string>(nullable: true),
                    Traploper = table.Column<bool>(nullable: false),
                    Rolsteiger = table.Column<bool>(nullable: false),
                    Drempelplaat = table.Column<bool>(nullable: false),
                    Groot_Volume_Bak = table.Column<bool>(nullable: false),
                    Wasmachinebeugel = table.Column<bool>(nullable: false),
                    Noppenfolie = table.Column<bool>(nullable: false),
                    Eenpersoons_Matrashoes = table.Column<bool>(nullable: false),
                    Tweepersoons_Matrashoes = table.Column<bool>(nullable: false),
                    Barrel = table.Column<bool>(nullable: false),
                    Handymankoffers = table.Column<bool>(nullable: false),
                    Extra_Materiaal = table.Column<string>(nullable: true),
                    Vertrekuur_Zaak = table.Column<DateTime>(nullable: true),
                    Inpakken_Manuren = table.Column<int>(nullable: true),
                    Uitpakken_Manuren = table.Column<int>(nullable: true),
                    Montage_Manuren = table.Column<int>(nullable: true),
                    Demontage_Manuren = table.Column<int>(nullable: true),
                    Aantal_Geladen = table.Column<int>(nullable: true),
                    Starttijd_Laden = table.Column<DateTime>(nullable: true),
                    Eindtijd_Laden = table.Column<DateTime>(nullable: true),
                    Laaduur_Totaal = table.Column<int>(nullable: true),
                    Aantal_Gelost = table.Column<int>(nullable: true),
                    Starttijd_Lossen = table.Column<DateTime>(nullable: true),
                    Eindtijd_Lossen = table.Column<DateTime>(nullable: true),
                    Losuur_Totaal = table.Column<int>(nullable: true),
                    Aankomsttijd_Zaak = table.Column<DateTime>(nullable: true),
                    Bedrag = table.Column<int>(nullable: false),
                    Betaalwijze = table.Column<string>(nullable: true),
                    KostenPlaats = table.Column<string>(nullable: true),
                    LaadAdres = table.Column<string>(nullable: true),
                    LaadPlaats = table.Column<string>(nullable: true),
                    LaadEtage = table.Column<int>(nullable: true),
                    LosAdres = table.Column<string>(nullable: true),
                    LosPlaats = table.Column<string>(nullable: true),
                    LosEtage = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Werkbon", x => x.WerkbonID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Werkbon");
        }
    }
}
