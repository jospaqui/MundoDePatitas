using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Patitas.Migrations
{
    public partial class fotosmascota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FotosMascotas");

            migrationBuilder.AddColumn<string>(
                name: "FotoMascota",
                table: "Mascotas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoMascota",
                table: "Mascotas");

            migrationBuilder.CreateTable(
                name: "FotosMascotas",
                columns: table => new
                {
                    IdFotoMascota = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdMascota = table.Column<int>(nullable: false),
                    ImgPath = table.Column<string>(nullable: true),
                    nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotosMascotas", x => x.IdFotoMascota);
                    table.ForeignKey(
                        name: "FK_FotosMascotas_Mascotas_IdMascota",
                        column: x => x.IdMascota,
                        principalTable: "Mascotas",
                        principalColumn: "IdMascota",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FotosMascotas_IdMascota",
                table: "FotosMascotas",
                column: "IdMascota");
        }
    }
}
