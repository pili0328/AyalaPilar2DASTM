using Controladora;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Vista
{
    public partial class FormCuentaCorriente : Form
    {
        public FormCuentaCorriente()
        {
            InitializeComponent();
        }

        private void FormCuentaCorriente_Load_1(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                context.Database.EnsureCreated();
                MessageBox.Show("Base y tablas creadas!!");
            }


            Cargar();
            CargarClientesDUD();
            CargarTipo();
            CargarDescripcion();
        }

        public void Cargar()
        {
            var cuentas = Controladora.ControladoraCuentaYCliente.Instancia.Listar();

            var datos = cuentas.SelectMany(cuenta => cuenta.Movimientos.Select(mov => new
            {
                CuentaCorrienteId = cuenta.CuentaCorrienteId,
                Nombre = cuenta.Clientes.FirstOrDefault()?.Nombre ?? "(no hay cliente)",
                Apellido = cuenta.Clientes.FirstOrDefault()?.Apellido ?? "",
                DNI = cuenta.Clientes.FirstOrDefault()?.DNI ?? "",
                Telefono = cuenta.Clientes.FirstOrDefault()?.Telefono ?? 0,
                Tipo = mov.Tipo,
                Descripcion = mov.Descripcion,
                Monto = mov.Monto,
            })).ToList();

            dgvListadoCuentas.DataSource = null;
            dgvListadoCuentas.DataSource = datos;

        }

        public void CargarClientesDUD()
        {
            dudCliente.Items.Clear();
            var clientes = ControladoraCuentaYCliente.Instancia.ListarCliente();
            foreach (var cc in clientes)
            {
                dudCliente.Items.Add(cc);
            }
        }

        public void CargarTipo()
        {
            dudTipo.Items.Clear();
            dudTipo.Items.Add("Debito");
            dudTipo.Items.Add("Credito");
        }

        public void CargarDescripcion()
        {
            // cargos, compras, consumos, pagos, abonos
            dudDescripcion.Items.Clear();
            dudDescripcion.Items.Add("cargo");
            dudDescripcion.Items.Add("compra");
            dudDescripcion.Items.Add("consumo");
            dudDescripcion.Items.Add("pago");
            dudDescripcion.Items.Add("bono");
        }


        // para mostrar el estado actual de la cuenta seleccionada
        private void dgvListadoCuentas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListadoCuentas.SelectedRows.Count > 0)
            {
                var id = (int)dgvListadoCuentas.SelectedRows[0].Cells["CuentaCorrienteId"].Value;
                var cuenta = Controladora.ControladoraCuentaYCliente.Instancia.Listar();
                var seleccion = cuenta.FirstOrDefault(x => x.CuentaCorrienteId == id);

                if (seleccion != null)
                {
                    var mostrar = cuenta.Where(x => x.CuentaCorrienteId == id).Select(x => new
                    {
                        CuentaCorrienteId = x.CuentaCorrienteId,
                        EstadoCuenta = x.EstadoCuenta
                    }).ToList();

                    dgvEstadoActual.DataSource = mostrar;
                }
            }
        }

        private void btnRegistrarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (dudCliente.SelectedIndex < 0)
                    throw new Exception("Seleccionar un cliente para asociar con cuenta");

                if (dudDescripcion.SelectedIndex < 0)
                    throw new Exception("Seleccionar una descripcion del movimiento que hara");

                if (dudTipo.SelectedIndex < 0)
                    throw new Exception("Seleccionar un tipo de cuenta que utilizara");

                if (string.IsNullOrWhiteSpace(txtMonto.Text))
                    throw new Exception("Debe ingresar un valor a la cuenta");

                if (float.Parse(txtMonto.Text) < 0)
                    throw new Exception("El monto debe tener un valor positivo");

                var clientes = (Cliente)dudCliente.SelectedItem;
                var seleccion = dudTipo.SelectedItem.ToString();
                var descripcion = dudDescripcion.SelectedItem.ToString();
                float monto = float.Parse(txtMonto.Text);

                Movimiento mov = new Movimiento
                {
                    Descripcion = descripcion,
                    Monto = monto,
                    Tipo = seleccion
                };

                CuentaCorriente cc = new CuentaCorriente
                {
                    Movimientos = new List<Movimiento> { mov },
                    Clientes = new List<Cliente> { clientes },
                    EstadoCuenta = "Activa"
                };

                ControladoraCuentaYCliente.Instancia.AsocioCuenta(cc, clientes);

                Cargar();

            }
            catch (Exception ex)
            {
                throw new Exception("Error! " + ex.Message);
            }

        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListadoCuentas.SelectedRows.Count > 0)
                {
                    var id = (int)dgvListadoCuentas.SelectedRows[0].Cells["CuentaCorrienteId"].Value;

                    var cuenta = Controladora.ControladoraCuentaYCliente.Instancia.Listar().FirstOrDefault(x => x.CuentaCorrienteId == id);

                    if (cuenta != null)
                        Controladora.ControladoraCuentaYCliente.Instancia.EliminarCuenta(cuenta);
                    Cargar();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en eliminar el cliente! " + ex.Message);
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormCliente cliente = new FormCliente();
            cliente.ShowDialog();

        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            if (dgvListadoCuentas.SelectedRows.Count > 0)
            {
                var Nombre = dgvListadoCuentas.SelectedRows[0].Cells["Nombre"].Value.ToString();
                var cliente = Controladora.ControladoraCuentaYCliente.Instancia.ListarCliente().FirstOrDefault(x => x.Nombre == Nombre);

                if (cliente != null)
                {
                    FormRegistroMovimientos mov = new FormRegistroMovimientos(cliente);
                    mov.ShowDialog();
                }
            }
        }

  
    }
}
