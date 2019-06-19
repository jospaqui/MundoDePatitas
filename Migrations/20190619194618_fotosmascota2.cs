using Microsoft.EntityFrameworkCore.Migrations;

namespace Patitas.Migrations
{
    public partial class fotosmascota2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_AspNetUsers_Id1",
                table: "Mascotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Refugios_IdRefugio",
                table: "Mascotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Refugios_AspNetUsers_Id1",
                table: "Refugios");

            migrationBuilder.DropIndex(
                name: "IX_Refugios_Id1",
                table: "Refugios");

            migrationBuilder.DropIndex(
                name: "IX_Mascotas_Id1",
                table: "Mascotas");

            migrationBuilder.DropIndex(
                name: "IX_Mascotas_IdRefugio",
                table: "Mascotas");

            migrationBuilder.DropColumn(
                name: "Id1",
                table: "Refugios");

            migrationBuilder.DropColumn(
                name: "Id1",
                table: "Mascotas");

            migrationBuilder.DropColumn(
                name: "IdRefugio",
                table: "Mascotas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Id1",
                table: "Refugios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id1",
                table: "Mascotas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdRefugio",
                table: "Mascotas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Refugios_Id1",
                table: "Refugios",
                column: "Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_Id1",
                table: "Mascotas",
                column: "Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_IdRefugio",
                table: "Mascotas",
                column: "IdRefugio");

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_AspNetUsers_Id1",
                table: "Mascotas",
                column: "Id1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Refugios_IdRefugio",
                table: "Mascotas",
                column: "IdRefugio",
                principalTable: "Refugios",
                principalColumn: "IdRefugio",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refugios_AspNetUsers_Id1",
                table: "Refugios",
                column: "Id1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
