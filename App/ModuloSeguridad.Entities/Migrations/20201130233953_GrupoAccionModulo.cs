using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuloSeguridad.Entities.Migrations
{
    public partial class GrupoAccionModulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrupoAcciones");

            migrationBuilder.CreateTable(
                name: "AccionModulos",
                columns: table => new
                {
                    AccionModuloId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccionId = table.Column<int>(type: "int", nullable: false),
                    ModuloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccionModulos", x => x.AccionModuloId);
                    table.ForeignKey(
                        name: "FK_AccionModulos_Acciones_AccionId",
                        column: x => x.AccionId,
                        principalTable: "Acciones",
                        principalColumn: "AccionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccionModulos_Modulos_ModuloId",
                        column: x => x.ModuloId,
                        principalTable: "Modulos",
                        principalColumn: "ModuloId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GrupoAccionModulos",
                columns: table => new
                {
                    GrupoId = table.Column<int>(type: "int", nullable: false),
                    AccionModuloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoAccionModulos", x => new { x.GrupoId, x.AccionModuloId });
                    table.ForeignKey(
                        name: "FK_GrupoAccionModulos_AccionModulos_AccionModuloId",
                        column: x => x.AccionModuloId,
                        principalTable: "AccionModulos",
                        principalColumn: "AccionModuloId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrupoAccionModulos_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "GrupoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccionModulos_AccionId",
                table: "AccionModulos",
                column: "AccionId");

            migrationBuilder.CreateIndex(
                name: "IX_AccionModulos_ModuloId",
                table: "AccionModulos",
                column: "ModuloId");

            migrationBuilder.CreateIndex(
                name: "IX_GrupoAccionModulos_AccionModuloId",
                table: "GrupoAccionModulos",
                column: "AccionModuloId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrupoAccionModulos");

            migrationBuilder.DropTable(
                name: "AccionModulos");

            migrationBuilder.CreateTable(
                name: "GrupoAcciones",
                columns: table => new
                {
                    GrupoId = table.Column<int>(type: "int", nullable: false),
                    AccionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoAcciones", x => new { x.GrupoId, x.AccionId });
                    table.ForeignKey(
                        name: "FK_GrupoAcciones_Acciones_AccionId",
                        column: x => x.AccionId,
                        principalTable: "Acciones",
                        principalColumn: "AccionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrupoAcciones_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "GrupoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GrupoAcciones_AccionId",
                table: "GrupoAcciones",
                column: "AccionId");
        }
    }
}
