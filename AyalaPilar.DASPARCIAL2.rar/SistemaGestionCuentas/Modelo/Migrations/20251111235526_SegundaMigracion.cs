using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CuentasCorrientes_CuentasCorrientes_CuentaCorrienteId1",
                table: "CuentasCorrientes");

            migrationBuilder.DropIndex(
                name: "IX_CuentasCorrientes_CuentaCorrienteId1",
                table: "CuentasCorrientes");

            migrationBuilder.DropColumn(
                name: "CuentaCorrienteId1",
                table: "CuentasCorrientes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CuentaCorrienteId1",
                table: "CuentasCorrientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CuentasCorrientes_CuentaCorrienteId1",
                table: "CuentasCorrientes",
                column: "CuentaCorrienteId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CuentasCorrientes_CuentasCorrientes_CuentaCorrienteId1",
                table: "CuentasCorrientes",
                column: "CuentaCorrienteId1",
                principalTable: "CuentasCorrientes",
                principalColumn: "CuentaCorrienteId");
        }
    }
}
