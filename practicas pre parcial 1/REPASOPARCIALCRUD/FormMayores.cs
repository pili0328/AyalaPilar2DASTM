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
    public partial class FormMayores : Form
    {
        private int? Id;
        public FormMayores(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            RepositorioSocio sc = new RepositorioSocio();
            DGVmayores.DataSource = sc.MayoresEdad();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
