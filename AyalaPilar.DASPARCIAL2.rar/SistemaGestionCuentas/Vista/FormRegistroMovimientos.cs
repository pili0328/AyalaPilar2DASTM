using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Entidades;
using System;
using System.Windows.Forms;

using Controladora;

namespace Vista
{
    public partial class FormRegistroMovimientos : Form
    {
        private Cliente clienteSeleccionado;
        public FormRegistroMovimientos(Cliente cliente)
        {
            InitializeComponent();
            clienteSeleccionado = cliente;
        }

        private void FormRegistroMovimientos_Load(object sender, EventArgs e)
        {
            CargarMovimientos();
            CargarSaldos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarMovimientos()
        {
            try
            {
                var cuentasCliente = Controladora.ControladoraCuentaYCliente.Instancia
                    .Listar()
                    .Where(cc => cc.Clientes.Any(cl => cl.ClienteId == clienteSeleccionado.ClienteId))
                    .ToList();

                if (!cuentasCliente.Any())
                {
                    dgvMovimientos.DataSource = null;
                    return;
                }

                var movimientos = cuentasCliente.SelectMany(cc => cc.Movimientos).ToList();

                var datos = movimientos.Select(m => new
                    {
                        Cuenta = m.Cuenta.CuentaCorrienteId,
                        Fecha = m.Fecha.ToShortDateString(),
                        Descripción = m.Descripcion,
                        Tipo = m.Tipo,
                        Monto = m.Monto
                    }).OrderBy(m => m.Fecha).ToList();

                dgvMovimientos.DataSource = null;
                dgvMovimientos.DataSource = datos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en mostrar el historial de moviemientos" + ex.Message);
            }
        }
        private void CargarSaldos()
        {
            try
            {
                var cuentasCliente = Controladora.ControladoraCuentaYCliente.Instancia
                    .Listar()
                    .Where(cc => cc.Clientes.Any(cl => cl.ClienteId == clienteSeleccionado.ClienteId))
                    .ToList();

                if (!cuentasCliente.Any())
                {
                    dgvResumen.DataSource = null;
                    return;
                }

                var movimientosCliente = Controladora.ControladoraMovimientos.Instancia.ListarMovimientosDeCliente(clienteSeleccionado);            

                float totalCreditos = movimientosCliente.Where(m => m.Monto > 0).Sum(m => m.Monto);
                float totalDebitos = -1 * movimientosCliente.Where(m => m.Monto > 0).Sum(m => Math.Abs(m.Monto));
                float saldo = totalCreditos + totalDebitos;


                var resumen = new[] { new
                {
                    Cliente = clienteSeleccionado.Nombre + " " + clienteSeleccionado.Apellido,
                    Créditos = totalCreditos,
                    Débitos = totalDebitos,
                    Saldo_Total = saldo
                }}.ToList();

                dgvResumen.DataSource = resumen;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al calcular saldos: " + ex.Message);
            }
        }
    }
}
