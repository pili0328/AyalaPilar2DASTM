using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Controladora;

namespace Vista
{
    public partial class FormCliente : Form
    {

        public FormCliente()
        {
            InitializeComponent();
        }

        public void CargarDGVCLIENTE()
        {
            dgvClientes.DataSource = null;

            var clien = Controladora.ControladoraCuentaYCliente.Instancia.ListarCliente();
            var dgv = clien.Select(x => new
            {
                Nombre = x.Nombre,
                Apellido = x.Apellido,
                DNI = x.DNI,
                Telefono = x.Telefono
            }).ToList();

            dgvClientes.DataSource = dgv;
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            CargarDGVCLIENTE();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var controladora = ControladoraCuentaYCliente.Instancia;
            try
            {
                Cliente cl = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    DNI = txtDNI.Text,
                    Telefono = int.Parse(txtTelefono.Text)
                };

                string resultado = controladora.Agregar(cl);

                CargarDGVCLIENTE();

                txtNombre.Clear();
                txtApellido.Clear();
                txtDNI.Clear();
                txtTelefono.Clear();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el codigo" + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    FormCuentaCorriente cuenta = new FormCuentaCorriente();
                    string dni = dgvClientes.SelectedRows[0].Cells["DNI"].Value.ToString();

                    var cliente = Controladora.ControladoraCuentaYCliente.Instancia.ListarCliente().FirstOrDefault(x => x.DNI == dni);

                    if (cliente != null)
                    {
                        Controladora.ControladoraCuentaYCliente.Instancia.Eliminar(cliente);
                        CargarDGVCLIENTE();
                        cuenta.CargarClientesDUD();
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en eliminar el cliente! " + ex.Message);
            }
        }

        private void CargarDatosCliente(Cliente cliente)
        {
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtDNI.Text = cliente.DNI;
            txtTelefono.Text = cliente.Telefono.ToString();
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                string dni = dgvClientes.SelectedRows[0].Cells["DNI"].Value.ToString();

                var cliente = Controladora.ControladoraCuentaYCliente.Instancia
                    .ListarCliente()
                    .FirstOrDefault(x => x.DNI == dni);

                if (cliente != null)
                    CargarDatosCliente(cliente);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var controladora = ControladoraCuentaYCliente.Instancia;

                if (dgvClientes.SelectedRows.Count > 0)
                {
                    string dni = dgvClientes.SelectedRows[0].Cells["DNI"].Value.ToString();

                    var cliente = controladora.ListarCliente().FirstOrDefault(x => x.DNI == dni);

                    if (cliente != null)
                    {
                        cliente.Nombre = txtNombre.Text;
                        cliente.Apellido = txtApellido.Text;
                        cliente.DNI = txtDNI.Text;
                        cliente.Telefono = int.Parse(txtTelefono.Text);

                        var resultado = controladora.Modificar(cliente);
                        CargarDGVCLIENTE();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar " + ex.Message);
            }
        }

        private void btnVOLVER_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }
}
