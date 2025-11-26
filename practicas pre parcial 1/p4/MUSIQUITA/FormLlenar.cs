using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSIQUITA
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
            RepositorioMusica mus = new RepositorioMusica();
            Musica m = mus.Buscar((int)Id);

            txtNombre.Text = m.Nombre;
            txtDuracion.Text = m.Duracion_Minutos.ToString();
            ckbPlaylist.Checked = m.Agrego;
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            RepositorioMusica mus = new RepositorioMusica();

            try
            {
                if (Id == null)
                    mus.Agrego(txtNombre.Text,int.Parse(txtDuracion.Text),ckbPlaylist.Checked);
                else
                    mus.Modificar((int)Id,txtNombre.Text, int.Parse(txtDuracion.Text), ckbPlaylist.Checked);

                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR!" + ex.Message);
            }

        }
    }
}
