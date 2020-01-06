using Microsoft.EntityFrameworkCore.Migrations;

namespace WerkbonApplicatie.Migrations
{
    public partial class personeel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personeel",
                columns: table => new
                {
                    PersoneelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pesoneel_VoorNaam = table.Column<string>(nullable: true),
                    Personeel_Achternaam = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Functie = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeel", x => x.PersoneelID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personeel");
        }
    }
}
