using Microsoft.EntityFrameworkCore.Migrations;

namespace WerkbonApplicatie.Migrations
{
    public partial class werkbonimage2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Guid",
                table: "Werkbon",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Werkbon");
        }
    }
}
