using Microsoft.EntityFrameworkCore.Migrations;


#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class ClienteCuentaCorrienteNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_CuentasCorrientes_CuentaCorrienteId",
                table: "Clientes");

            migrationBuilder.AlterColumn<int>(
                name: "CuentaCorrienteId",
                table: "Clientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_CuentasCorrientes_CuentaCorrienteId",
                table: "Clientes",
                column: "CuentaCorrienteId",
                principalTable: "CuentasCorrientes",
                principalColumn: "CuentaCorrienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_CuentasCorrientes_CuentaCorrienteId",
                table: "Clientes");

            migrationBuilder.AlterColumn<int>(
                name: "CuentaCorrienteId",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_CuentasCorrientes_CuentaCorrienteId",
                table: "Clientes",
                column: "CuentaCorrienteId",
                principalTable: "CuentasCorrientes",
                principalColumn: "CuentaCorrienteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
