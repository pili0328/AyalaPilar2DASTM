using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIKE_HIMMMM
{
    public partial class FormRellenar : Form
    {
        private int? id;
        public FormRellenar(int? Id = null)
        {
            InitializeComponent();
            id = Id;

            if (this.id != null)
                LoadData();
        }

        private void LoadData()
        {
            RepositorioPelicula rp = new RepositorioPelicula();
            Pelicula pelis = rp.BuscarId((int)id);
            
            txtNombre.Text = pelis.Nombre;
            dtpEstreno.Value = pelis.Estreno;
            txtTop.Text = pelis.PuestoTOP.ToString();
            cbVista.Checked = pelis.Vista;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            RepositorioPelicula rp = new RepositorioPelicula();
            try
            {
                if (id == null)
                    rp.Agregar(txtNombre.Text, dtpEstreno.Value, int.Parse(txtTop.Text), cbVista.Checked);
                else
                    rp.Modificar((int)id, txtNombre.Text, dtpEstreno.Value, int.Parse(txtTop.Text), cbVista.Checked);

                    this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error! " + ex.Message);
            }

        }
    }
}
