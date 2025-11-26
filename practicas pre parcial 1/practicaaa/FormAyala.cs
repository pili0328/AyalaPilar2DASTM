using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeguimosPracticando
{
    public partial class FormAyala : Form
    {
        public FormAyala()
        {
            InitializeComponent();
        }

        public void Cargar()
        {
            RepositorioAdolescentes ra = new RepositorioAdolescentes();
            DGVayala.DataSource = ra.ApellidoAyala();
        }

        private void FormAyala_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
