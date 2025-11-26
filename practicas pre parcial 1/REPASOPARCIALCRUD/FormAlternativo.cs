using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPASOPARCIALCRUD
{
    public partial class FormAlternativo : Form
    {

        private int? id;
        public FormAlternativo(int? Id = null)
        {
            InitializeComponent();
            id = Id;
            if (this.id != null)
                LoadData();
        }

        private void LoadData()
        {
            RepositorioSocio rp = new RepositorioSocio();
            Socio s = rp.BuscarID((int)id);
            txtNombre.Text = s.Nombre;
            txtApellido.Text = s.Apellido;
            txtDNI.Text = s.DNI.ToString();
            dtpFecha.Text = s.FechaNacimiento.ToShortDateString();
            ndNumSocio.Value = s.NumSocio;
            ckbCuota.Checked = s.CuotaAlDia;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            RepositorioSocio rp = new RepositorioSocio();
            try
            {
                if (id == null)
                    rp.Agregar(txtNombre.Text,txtApellido.Text, int.Parse(txtDNI.Text),dtpFecha.Value,(int)ndNumSocio.Value,ckbCuota.Checked);
                else
                    rp.Modificar((int)id,txtNombre.Text, txtApellido.Text, int.Parse(txtDNI.Text), dtpFecha.Value, (int)ndNumSocio.Value, ckbCuota.Checked);

                this.Close();
            }
                       catch(Exception ex) 
            {
                throw new Exception("Error al cargar " + ex.Message);
            }

        }
    }
}
