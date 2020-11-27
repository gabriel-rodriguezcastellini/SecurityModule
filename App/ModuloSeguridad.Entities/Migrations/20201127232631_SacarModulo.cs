using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuloSeguridad.Entities.Migrations
{
    public partial class SacarModulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acciones_Formularios_FormularioId",
                table: "Acciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Modulos_Modulos_ModuloPadreId",
                table: "Modulos");

            migrationBuilder.DropTable(
                name: "Formularios");

            migrationBuilder.DropIndex(
                name: "IX_Modulos_ModuloPadreId",
                table: "Modulos");

            migrationBuilder.DropIndex(
                name: "IX_Acciones_FormularioId",
                table: "Acciones");

            migrationBuilder.DropColumn(
                name: "ModuloPadreId",
                table: "Modulos");

            migrationBuilder.DropColumn(
                name: "FormularioId",
                table: "Acciones");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ModuloPadreId",
                table: "Modulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormularioId",
                table: "Acciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Formularios",
                columns: table => new
                {
                    FormularioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActualizadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    EliminadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModuloId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formularios", x => x.FormularioId);
                    table.ForeignKey(
                        name: "FK_Formularios_Modulos_ModuloId",
                        column: x => x.ModuloId,
                        principalTable: "Modulos",
                        principalColumn: "ModuloId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modulos_ModuloPadreId",
                table: "Modulos",
                column: "ModuloPadreId");

            migrationBuilder.CreateIndex(
                name: "IX_Acciones_FormularioId",
                table: "Acciones",
                column: "FormularioId");

            migrationBuilder.CreateIndex(
                name: "IX_Formularios_ModuloId",
                table: "Formularios",
                column: "ModuloId");

            migrationBuilder.CreateIndex(
                name: "IX_Formularios_Nombre",
                table: "Formularios",
                column: "Nombre",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Acciones_Formularios_FormularioId",
                table: "Acciones",
                column: "FormularioId",
                principalTable: "Formularios",
                principalColumn: "FormularioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modulos_Modulos_ModuloPadreId",
                table: "Modulos",
                column: "ModuloPadreId",
                principalTable: "Modulos",
                principalColumn: "ModuloId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
