using Microsoft.EntityFrameworkCore.Migrations;

namespace Patitas.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FotoTipo",
                table: "TipoMascotas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoTipo",
                table: "TipoMascotas");
        }
    }
}
