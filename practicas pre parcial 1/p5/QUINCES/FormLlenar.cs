using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUINCES
{
    public partial class FormLlenar : Form
    {
        private int? Id;

        public FormLlenar(int? id = null)
        {
            InitializeComponent();
            Id = id;
            if (this.Id != null)
                LoadData();

        }

        private void LoadData()
        {
            RepositorioInvitado ri = new RepositorioInvitado();
            Persona pp = ri.BuscoId((int)Id);

            txtNombre.Text = pp.Nombre;
            txtApellido.Text = pp.Apellido;
            dtpFecha.Value = pp.FechaNacimiento;
            nudInvitado.Value = pp.NumInvitado;
            cbxINVITADO.Checked = pp.MeInvitaron;
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            RepositorioInvitado ri = new RepositorioInvitado();

            try
            {
                if (Id == null)
                    ri.Agregar(txtNombre.Text,txtApellido.Text,dtpFecha.Value,(int)nudInvitado.Value,cbxINVITADO.Checked);
                else
                    ri.Modificar((int)Id,txtNombre.Text, txtApellido.Text, dtpFecha.Value, (int)nudInvitado.Value, cbxINVITADO.Checked);

                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error !! " + ex.Message);
            }
        }
    }
}
