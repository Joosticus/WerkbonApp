using Microsoft.EntityFrameworkCore.Migrations;

namespace WerkbonApplicatie.Migrations
{
    public partial class werkbonimage3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GuidSecond",
                table: "Werkbon",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageSecond",
                table: "Werkbon",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GuidSecond",
                table: "Werkbon");

            migrationBuilder.DropColumn(
                name: "ImageSecond",
                table: "Werkbon");
        }
    }
}
