using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WerkbonApplicatie.Migrations
{
    public partial class extra_adressen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Extra_Laadadres",
                table: "Werkbon",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Extra_Losadres",
                table: "Werkbon",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Extra_Laadadres",
                table: "Werkbon");

            migrationBuilder.DropColumn(
                name: "Extra_Losadres",
                table: "Werkbon");

        }
    }
}
