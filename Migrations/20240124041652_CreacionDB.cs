using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_PRUEBA_PROGRESO3.Migrations
{
    /// <inheritdoc />
    public partial class CreacionDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    idTarea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreTarea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcionTarea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estadoTarea = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.idTarea);
                });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "idTarea", "descripcionTarea", "estadoTarea", "nombreTarea" },
                values: new object[] { 1, "20 ejercicios", "Pendiente", "Matematicas" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarea");
        }
    }
}
