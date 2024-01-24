using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_PRUEBA_PROGRESO3.Migrations
{
    /// <inheritdoc />
    public partial class SeagregaUsuarioResultados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nombreGanador",
                table: "Resultados",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "idResultado",
                table: "Resultados",
                newName: "idUsuario");

            migrationBuilder.AddColumn<bool>(
                name: "CantidadVictorias",
                table: "Resultados",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaResultado",
                table: "Resultados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "resultado",
                table: "Resultados",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadVictorias",
                table: "Resultados");

            migrationBuilder.DropColumn(
                name: "fechaResultado",
                table: "Resultados");

            migrationBuilder.DropColumn(
                name: "resultado",
                table: "Resultados");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Resultados",
                newName: "nombreGanador");

            migrationBuilder.RenameColumn(
                name: "idUsuario",
                table: "Resultados",
                newName: "idResultado");
        }
    }
}
