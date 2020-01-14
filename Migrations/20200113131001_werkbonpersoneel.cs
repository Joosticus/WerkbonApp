using Microsoft.EntityFrameworkCore.Migrations;

namespace WerkbonApplicatie.Migrations
{
    public partial class werkbonpersoneel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Werkbonpersoneel",
                columns: table => new
                {
                    PersoneelID = table.Column<int>(nullable: false),
                    WerkbonID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Werkbonpersoneel", x => new { x.PersoneelID, x.WerkbonID });
                    table.ForeignKey(
                        name: "FK_Werkbonpersoneel_Personeel_PersoneelID",
                        column: x => x.PersoneelID,
                        principalTable: "Personeel",
                        principalColumn: "PersoneelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Werkbonpersoneel_Werkbon_WerkbonID",
                        column: x => x.WerkbonID,
                        principalTable: "Werkbon",
                        principalColumn: "WerkbonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Werkbonpersoneel_WerkbonID",
                table: "Werkbonpersoneel",
                column: "WerkbonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Werkbonpersoneel");
        }
    }
}
