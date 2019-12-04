using Microsoft.EntityFrameworkCore.Migrations;

namespace WerkbonAppTest3.Migrations
{
    public partial class laadadres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Laadadres",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Straat = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    Plaats = table.Column<string>(nullable: true),
                    Etage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laadadres", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Losadres",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Straat = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    Plaats = table.Column<string>(nullable: true),
                    Etage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Losadres", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Laadadres");

            migrationBuilder.DropTable(
                name: "Losadres");
        }
    }
}
