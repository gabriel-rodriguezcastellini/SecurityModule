using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuloSeguridad.Entities.Migrations
{
    public partial class Modulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ModuloPadreId",
                table: "Modulos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modulos_ModuloPadreId",
                table: "Modulos",
                column: "ModuloPadreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modulos_Modulos_ModuloPadreId",
                table: "Modulos",
                column: "ModuloPadreId",
                principalTable: "Modulos",
                principalColumn: "ModuloId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modulos_Modulos_ModuloPadreId",
                table: "Modulos");

            migrationBuilder.DropIndex(
                name: "IX_Modulos_ModuloPadreId",
                table: "Modulos");

            migrationBuilder.DropColumn(
                name: "ModuloPadreId",
                table: "Modulos");
        }
    }
}
