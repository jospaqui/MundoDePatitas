using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Patitas.Migrations
{
    public partial class unionE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adopciones_Usuarios_IdUser",
                table: "Adopciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Usuarios_IdUser",
                table: "Mascotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Preguntas_Usuarios_IdUser",
                table: "Preguntas");

            migrationBuilder.DropForeignKey(
                name: "FK_Refugios_Usuarios_IdUser",
                table: "Refugios");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Refugios_IdUser",
                table: "Refugios");

            migrationBuilder.DropIndex(
                name: "IX_Preguntas_IdUser",
                table: "Preguntas");

            migrationBuilder.DropIndex(
                name: "IX_Mascotas_IdUser",
                table: "Mascotas");

            migrationBuilder.DropIndex(
                name: "IX_Adopciones_IdUser",
                table: "Adopciones");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Refugios");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Preguntas");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Mascotas");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Adopciones");

            migrationBuilder.AddColumn<string>(
                name: "Id1",
                table: "Refugios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id1",
                table: "Preguntas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id1",
                table: "Mascotas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaDeRegistro",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id1",
                table: "Adopciones",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Refugios_Id1",
                table: "Refugios",
                column: "Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Preguntas_Id1",
                table: "Preguntas",
                column: "Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_Id1",
                table: "Mascotas",
                column: "Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Adopciones_Id1",
                table: "Adopciones",
                column: "Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Adopciones_AspNetUsers_Id1",
                table: "Adopciones",
                column: "Id1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_AspNetUsers_Id1",
                table: "Mascotas",
                column: "Id1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Preguntas_AspNetUsers_Id1",
                table: "Preguntas",
                column: "Id1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Refugios_AspNetUsers_Id1",
                table: "Refugios",
                column: "Id1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adopciones_AspNetUsers_Id1",
                table: "Adopciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_AspNetUsers_Id1",
                table: "Mascotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Preguntas_AspNetUsers_Id1",
                table: "Preguntas");

            migrationBuilder.DropForeignKey(
                name: "FK_Refugios_AspNetUsers_Id1",
                table: "Refugios");

            migrationBuilder.DropIndex(
                name: "IX_Refugios_Id1",
                table: "Refugios");

            migrationBuilder.DropIndex(
                name: "IX_Preguntas_Id1",
                table: "Preguntas");

            migrationBuilder.DropIndex(
                name: "IX_Mascotas_Id1",
                table: "Mascotas");

            migrationBuilder.DropIndex(
                name: "IX_Adopciones_Id1",
                table: "Adopciones");

            migrationBuilder.DropColumn(
                name: "Id1",
                table: "Refugios");

            migrationBuilder.DropColumn(
                name: "Id1",
                table: "Preguntas");

            migrationBuilder.DropColumn(
                name: "Id1",
                table: "Mascotas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FechaDeRegistro",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Id1",
                table: "Adopciones");

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Refugios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Preguntas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Mascotas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Adopciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUser = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Apellidos = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FechaDeRegistro = table.Column<DateTime>(nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    PasswordConfirm = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    token_recovery = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUser);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Refugios_IdUser",
                table: "Refugios",
                column: "IdUser",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Preguntas_IdUser",
                table: "Preguntas",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_IdUser",
                table: "Mascotas",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Adopciones_IdUser",
                table: "Adopciones",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Adopciones_Usuarios_IdUser",
                table: "Adopciones",
                column: "IdUser",
                principalTable: "Usuarios",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Usuarios_IdUser",
                table: "Mascotas",
                column: "IdUser",
                principalTable: "Usuarios",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Preguntas_Usuarios_IdUser",
                table: "Preguntas",
                column: "IdUser",
                principalTable: "Usuarios",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refugios_Usuarios_IdUser",
                table: "Refugios",
                column: "IdUser",
                principalTable: "Usuarios",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
