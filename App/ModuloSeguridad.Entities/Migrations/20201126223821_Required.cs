using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuloSeguridad.Entities.Migrations
{
    public partial class Required : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Acciones_Nombre",
                table: "Acciones");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Acciones",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Acciones_Nombre",
                table: "Acciones",
                column: "Nombre",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Acciones_Nombre",
                table: "Acciones");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Acciones",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_Acciones_Nombre",
                table: "Acciones",
                column: "Nombre",
                unique: true,
                filter: "[Nombre] IS NOT NULL");
        }
    }
}
