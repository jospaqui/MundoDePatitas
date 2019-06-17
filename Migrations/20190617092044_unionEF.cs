using Microsoft.EntityFrameworkCore.Migrations;

namespace Patitas.Migrations
{
    public partial class unionEF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "AspNetUsers",
                nullable: true);
        }
    }
}
