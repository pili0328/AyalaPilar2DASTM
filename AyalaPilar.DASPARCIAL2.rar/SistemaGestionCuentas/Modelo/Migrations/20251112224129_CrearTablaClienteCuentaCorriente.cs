using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class CrearTablaClienteCuentaCorriente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_CuentasCorrientes_CuentaCorrienteId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_CuentaCorrienteId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CuentaCorrienteId",
                table: "Clientes");

            migrationBuilder.CreateTable(
                name: "ClienteCuentaCorriente",
                columns: table => new
                {
                    ClientesClienteId = table.Column<int>(type: "int", nullable: false),
                    CuentasCorrienteCuentaCorrienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteCuentaCorriente", x => new { x.ClientesClienteId, x.CuentasCorrienteCuentaCorrienteId });
                    table.ForeignKey(
                        name: "FK_ClienteCuentaCorriente_Clientes_ClientesClienteId",
                        column: x => x.ClientesClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClienteCuentaCorriente_CuentasCorrientes_CuentasCorrienteCuentaCorrienteId",
                        column: x => x.CuentasCorrienteCuentaCorrienteId,
                        principalTable: "CuentasCorrientes",
                        principalColumn: "CuentaCorrienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClienteCuentaCorriente_CuentasCorrienteCuentaCorrienteId",
                table: "ClienteCuentaCorriente",
                column: "CuentasCorrienteCuentaCorrienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClienteCuentaCorriente");

            migrationBuilder.AddColumn<int>(
                name: "CuentaCorrienteId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CuentaCorrienteId",
                table: "Clientes",
                column: "CuentaCorrienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_CuentasCorrientes_CuentaCorrienteId",
                table: "Clientes",
                column: "CuentaCorrienteId",
                principalTable: "CuentasCorrientes",
                principalColumn: "CuentaCorrienteId");
        }
    }
}
