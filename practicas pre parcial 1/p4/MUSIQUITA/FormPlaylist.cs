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
    public partial class FormPlaylist : Form
    {
        public FormPlaylist()
        {
            InitializeComponent();
        }

        public void Cargar()
        {
            RepositorioMusica mus = new RepositorioMusica();
            DGVplay.DataSource = mus.Playslist();
        }

        private void FormPlaylist_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
