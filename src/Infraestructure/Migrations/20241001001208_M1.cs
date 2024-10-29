using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "jugador",
                columns: table => new
                {
                    pkJugador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    posicion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jugador", x => x.pkJugador);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    idLog = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mensaje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ipAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomFuncion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusLog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datos = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.idLog);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    PkPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorFav = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CancionFav = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComidaFav = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.PkPersona);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jugador");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
