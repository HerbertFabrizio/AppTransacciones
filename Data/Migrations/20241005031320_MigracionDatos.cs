using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppTransacciones.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigracionDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_transaccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Remitente = table.Column<string>(type: "TEXT", nullable: false),
                    Destinatario = table.Column<string>(type: "TEXT", nullable: false),
                    Pais_origen = table.Column<string>(type: "TEXT", nullable: false),
                    Destino = table.Column<string>(type: "TEXT", nullable: false),
                    Monto = table.Column<double>(type: "REAL", nullable: false),
                    Tasa_cambio = table.Column<double>(type: "REAL", nullable: true),
                    monto_final = table.Column<double>(type: "REAL", nullable: true),
                    Estado_Transaccion = table.Column<string>(type: "TEXT", nullable: true),
                    TipoMonto = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_transaccion", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_transaccion");
        }
    }
}
