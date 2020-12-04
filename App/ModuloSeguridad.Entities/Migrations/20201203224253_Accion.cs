using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuloSeguridad.Entities.Migrations
{
    public partial class Accion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Acciones",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Acciones");
        }
    }
}
