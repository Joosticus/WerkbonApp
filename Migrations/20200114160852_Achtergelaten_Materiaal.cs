using Microsoft.EntityFrameworkCore.Migrations;

namespace WerkbonApplicatie.Migrations
{
    public partial class Achtergelaten_Materiaal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "Achtergelaten_Materiaal",
                table: "Werkbon",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Achtergelaten_Materiaal",
                table: "Werkbon");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Personeel",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
