using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuloSeguridad.Entities.Migrations
{
    public partial class RemoveEliminado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EliminadoPor",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "FechaEliminacion",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Modulos");

            migrationBuilder.DropColumn(
                name: "EliminadoPor",
                table: "Modulos");

            migrationBuilder.DropColumn(
                name: "FechaEliminacion",
                table: "Modulos");

            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Grupos");

            migrationBuilder.DropColumn(
                name: "EliminadoPor",
                table: "Grupos");

            migrationBuilder.DropColumn(
                name: "FechaEliminacion",
                table: "Grupos");

            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "EstadoUsuarios");

            migrationBuilder.DropColumn(
                name: "EliminadoPor",
                table: "EstadoUsuarios");

            migrationBuilder.DropColumn(
                name: "FechaEliminacion",
                table: "EstadoUsuarios");

            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "EstadoGrupos");

            migrationBuilder.DropColumn(
                name: "EliminadoPor",
                table: "EstadoGrupos");

            migrationBuilder.DropColumn(
                name: "FechaEliminacion",
                table: "EstadoGrupos");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Acciones");

            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Acciones");

            migrationBuilder.DropColumn(
                name: "EliminadoPor",
                table: "Acciones");

            migrationBuilder.DropColumn(
                name: "FechaEliminacion",
                table: "Acciones");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EliminadoPor",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaEliminacion",
                table: "Usuarios",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Modulos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EliminadoPor",
                table: "Modulos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaEliminacion",
                table: "Modulos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Grupos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EliminadoPor",
                table: "Grupos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaEliminacion",
                table: "Grupos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "EstadoUsuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EliminadoPor",
                table: "EstadoUsuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaEliminacion",
                table: "EstadoUsuarios",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "EstadoGrupos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EliminadoPor",
                table: "EstadoGrupos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaEliminacion",
                table: "EstadoGrupos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Acciones",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Acciones",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EliminadoPor",
                table: "Acciones",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaEliminacion",
                table: "Acciones",
                type: "datetime2",
                nullable: true);
        }
    }
}
