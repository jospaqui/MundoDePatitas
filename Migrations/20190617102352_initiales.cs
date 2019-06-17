using Microsoft.EntityFrameworkCore.Migrations;

namespace Patitas.Migrations
{
    public partial class initiales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "Mascotas");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "FotosMascotas");

            migrationBuilder.AlterColumn<string>(
                name: "Tamaño",
                table: "Mascotas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Mascotas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PuedeEstarSolo",
                table: "Mascotas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Personalidades",
                table: "Mascotas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Mascotas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Mascotas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Mascotas",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Mascotas");

            migrationBuilder.AlterColumn<string>(
                name: "Tamaño",
                table: "Mascotas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Mascotas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PuedeEstarSolo",
                table: "Mascotas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Personalidades",
                table: "Mascotas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Mascotas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Mascotas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Ubicacion",
                table: "Mascotas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "FotosMascotas",
                nullable: false,
                defaultValue: 0);
        }
    }
}
