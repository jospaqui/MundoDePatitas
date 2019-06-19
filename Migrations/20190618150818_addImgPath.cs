using Microsoft.EntityFrameworkCore.Migrations;

namespace Patitas.Migrations
{
    public partial class addImgPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgPath",
                table: "FotosMascotas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgPath",
                table: "FotosMascotas");
        }
    }
}
