using Microsoft.EntityFrameworkCore.Migrations;

namespace WerkbonApplicatie.Migrations
{
    public partial class verhuizing_personeel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Verhuizing_Personeel",
                columns: table => new
                {
                    PersoneelID = table.Column<int>(nullable: false),
                    VerhuizingID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verhuizing_Personeel", x => new { x.PersoneelID, x.VerhuizingID });
                    table.ForeignKey(
                        name: "FK_Verhuizing_Personeel_Personeel_PersoneelID",
                        column: x => x.PersoneelID,
                        principalTable: "Personeel",
                        principalColumn: "PersoneelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Verhuizing_Personeel_Verhuizing_VerhuizingID",
                        column: x => x.VerhuizingID,
                        principalTable: "Verhuizing",
                        principalColumn: "VerhuizingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Verhuizing_Personeel_VerhuizingID",
                table: "Verhuizing_Personeel",
                column: "VerhuizingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Verhuizing_Personeel");
        }
    }
}
