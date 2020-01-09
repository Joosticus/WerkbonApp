using Microsoft.EntityFrameworkCore.Migrations;

namespace WerkbonApplicatie.Migrations
{
    public partial class adres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adres",
                columns: table => new
                {
                    AdresID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VerhuizingID = table.Column<int>(nullable: false),
                    Straat = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    Huisnummer = table.Column<string>(nullable: true),
                    Plaats = table.Column<string>(nullable: true),
                    Etage = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adres", x => x.AdresID);
                    table.ForeignKey(
                        name: "FK_Adres_Verhuizing_VerhuizingID",
                        column: x => x.VerhuizingID,
                        principalTable: "Verhuizing",
                        principalColumn: "VerhuizingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adres_VerhuizingID",
                table: "Adres",
                column: "VerhuizingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adres");
        }
    }
}
