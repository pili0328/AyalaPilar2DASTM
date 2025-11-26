using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CuentasCorrientes",
                columns: table => new
                {
                    CuentaCorrienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstadoCuenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CuentaCorrienteId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentasCorrientes", x => x.CuentaCorrienteId);
                    table.ForeignKey(
                        name: "FK_CuentasCorrientes_CuentasCorrientes_CuentaCorrienteId1",
                        column: x => x.CuentaCorrienteId1,
                        principalTable: "CuentasCorrientes",
                        principalColumn: "CuentaCorrienteId");
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    CuentaCorrienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_Clientes_CuentasCorrientes_CuentaCorrienteId",
                        column: x => x.CuentaCorrienteId,
                        principalTable: "CuentasCorrientes",
                        principalColumn: "CuentaCorrienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movimientos",
                columns: table => new
                {
                    MovimientoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Monto = table.Column<float>(type: "real", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CuentaCorrienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimientos", x => x.MovimientoId);
                    table.ForeignKey(
                        name: "FK_Movimientos_CuentasCorrientes_CuentaCorrienteId",
                        column: x => x.CuentaCorrienteId,
                        principalTable: "CuentasCorrientes",
                        principalColumn: "CuentaCorrienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CuentaCorrienteId",
                table: "Clientes",
                column: "CuentaCorrienteId");

            migrationBuilder.CreateIndex(
                name: "IX_CuentasCorrientes_CuentaCorrienteId1",
                table: "CuentasCorrientes",
                column: "CuentaCorrienteId1");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_CuentaCorrienteId",
                table: "Movimientos",
                column: "CuentaCorrienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Movimientos");

            migrationBuilder.DropTable(
                name: "CuentasCorrientes");
        }
    }
}
