using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Patitas.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anuncios",
                columns: table => new
                {
                    IdAnuncio = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Contenido = table.Column<string>(nullable: true),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anuncios", x => x.IdAnuncio);
                });

            migrationBuilder.CreateTable(
                name: "ListaDeEspera",
                columns: table => new
                {
                    IdListaEspera = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    TipoMascota = table.Column<string>(nullable: true),
                    SexoMascota = table.Column<string>(nullable: true),
                    Tamanio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaDeEspera", x => x.IdListaEspera);
                });

            migrationBuilder.CreateTable(
                name: "Mensajes",
                columns: table => new
                {
                    IdMensaje = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Asunto = table.Column<string>(nullable: true),
                    Contenido = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    IsRead = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensajes", x => x.IdMensaje);
                });

            migrationBuilder.CreateTable(
                name: "TipoMascotas",
                columns: table => new
                {
                    IdTipoMascota = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMascotas", x => x.IdTipoMascota);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    PasswordConfirm = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    token_recovery = table.Column<string>(nullable: true),
                    FechaDeRegistro = table.Column<DateTime>(nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "Veterinarias",
                columns: table => new
                {
                    IdVeterinaria = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Responsable = table.Column<string>(nullable: true),
                    Telefono = table.Column<int>(nullable: false),
                    Logo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinarias", x => x.IdVeterinaria);
                });

            migrationBuilder.CreateTable(
                name: "Adopciones",
                columns: table => new
                {
                    IdAdoptante = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DNI = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    FechaAdop = table.Column<DateTime>(nullable: false),
                    IdUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adopciones", x => x.IdAdoptante);
                    table.ForeignKey(
                        name: "FK_Adopciones_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Refugios",
                columns: table => new
                {
                    IdRefugio = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Ubicacion = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefono = table.Column<int>(nullable: false),
                    FechaDeCreacion = table.Column<DateTime>(nullable: false),
                    Logo = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refugios", x => x.IdRefugio);
                    table.ForeignKey(
                        name: "FK_Refugios_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mascotas",
                columns: table => new
                {
                    IdMascota = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    Tamaño = table.Column<string>(nullable: true),
                    PuedeEstarSolo = table.Column<string>(nullable: true),
                    Personalidades = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Ubicacion = table.Column<string>(nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    IdTipoMascota = table.Column<int>(nullable: false),
                    IdRefugio = table.Column<int>(nullable: false),
                    IdUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascotas", x => x.IdMascota);
                    table.ForeignKey(
                        name: "FK_Mascotas_Refugios_IdRefugio",
                        column: x => x.IdRefugio,
                        principalTable: "Refugios",
                        principalColumn: "IdRefugio",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mascotas_TipoMascotas_IdTipoMascota",
                        column: x => x.IdTipoMascota,
                        principalTable: "TipoMascotas",
                        principalColumn: "IdTipoMascota",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mascotas_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FotosMascotas",
                columns: table => new
                {
                    IdFotoMascota = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    MyProperty = table.Column<int>(nullable: false),
                    IdMascota = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Preguntas",
                columns: table => new
                {
                    IdPregunta = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Contenido = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    IdMascota = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preguntas", x => x.IdPregunta);
                    table.ForeignKey(
                        name: "FK_Preguntas_Mascotas_IdMascota",
                        column: x => x.IdMascota,
                        principalTable: "Mascotas",
                        principalColumn: "IdMascota",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Preguntas_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adopciones_IdUser",
                table: "Adopciones",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_FotosMascotas_IdMascota",
                table: "FotosMascotas",
                column: "IdMascota");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_IdRefugio",
                table: "Mascotas",
                column: "IdRefugio");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_IdTipoMascota",
                table: "Mascotas",
                column: "IdTipoMascota");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_IdUser",
                table: "Mascotas",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Preguntas_IdMascota",
                table: "Preguntas",
                column: "IdMascota");

            migrationBuilder.CreateIndex(
                name: "IX_Preguntas_IdUser",
                table: "Preguntas",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Refugios_IdUser",
                table: "Refugios",
                column: "IdUser",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adopciones");

            migrationBuilder.DropTable(
                name: "Anuncios");

            migrationBuilder.DropTable(
                name: "FotosMascotas");

            migrationBuilder.DropTable(
                name: "ListaDeEspera");

            migrationBuilder.DropTable(
                name: "Mensajes");

            migrationBuilder.DropTable(
                name: "Preguntas");

            migrationBuilder.DropTable(
                name: "Veterinarias");

            migrationBuilder.DropTable(
                name: "Mascotas");

            migrationBuilder.DropTable(
                name: "Refugios");

            migrationBuilder.DropTable(
                name: "TipoMascotas");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
