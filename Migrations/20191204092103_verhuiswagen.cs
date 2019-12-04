using Microsoft.EntityFrameworkCore.Migrations;

namespace WerkbonAppTest3.Migrations
{
    public partial class verhuiswagen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Verhuiswagen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kenteken = table.Column<string>(nullable: true),
                    Volume = table.Column<int>(nullable: false),
                    Merknaam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verhuiswagen", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Verhuiswagen");
        }
    }
}
