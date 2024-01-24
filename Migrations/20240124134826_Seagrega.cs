using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_PRUEBA_PROGRESO3.Migrations
{
    /// <inheritdoc />
    public partial class Seagrega : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CantidadVictorias",
                table: "Resultados",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "CantidadVictorias",
                table: "Resultados",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
