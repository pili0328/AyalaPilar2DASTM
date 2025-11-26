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
    public partial class FormVistas : Form
    {
        
        public FormVistas()
        {
            InitializeComponent();
        }

        private void btnCargarDato_Click(object sender, EventArgs e)
        {
            RepositorioPelicula pelis = new RepositorioPelicula();
            DGVver.DataSource = pelis.Vistas();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
