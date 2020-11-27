using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuloSeguridad.Entities.Migrations
{
    public partial class Constraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Grupos",
                newName: "Codigo");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Grupos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modulos_Nombre",
                table: "Modulos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_Codigo",
                table: "Grupos",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Formularios_Nombre",
                table: "Formularios",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EstadoUsuarios_Nombre",
                table: "EstadoUsuarios",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EstadoGrupos_Nombre",
                table: "EstadoGrupos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Acciones_Nombre",
                table: "Acciones",
                column: "Nombre",
                unique: true,
                filter: "[Nombre] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Modulos_Nombre",
                table: "Modulos");

            migrationBuilder.DropIndex(
                name: "IX_Grupos_Codigo",
                table: "Grupos");

            migrationBuilder.DropIndex(
                name: "IX_Formularios_Nombre",
                table: "Formularios");

            migrationBuilder.DropIndex(
                name: "IX_EstadoUsuarios_Nombre",
                table: "EstadoUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_EstadoGrupos_Nombre",
                table: "EstadoGrupos");

            migrationBuilder.DropIndex(
                name: "IX_Acciones_Nombre",
                table: "Acciones");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Grupos");

            migrationBuilder.RenameColumn(
                name: "Codigo",
                table: "Grupos",
                newName: "Nombre");
        }
    }
}
