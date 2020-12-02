using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuloSeguridad.Entities.Migrations
{
    public partial class GrupoNoDescripcion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Grupos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Grupos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
