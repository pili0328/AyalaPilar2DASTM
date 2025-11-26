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
    public partial class FormMayores : Form
    {
        public FormMayores()
        {
            InitializeComponent();
        }

        public void Cargar()
        {
            RepositorioAdolescentes ra = new RepositorioAdolescentes();
            DGVmayores.DataSource = ra.mayoresEdad();
        }

        private void FormMayores_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
