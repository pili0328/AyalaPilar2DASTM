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
    public partial class FormCuotaAlDia : Form
    {
        private int? id;
        public FormCuotaAlDia(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            
        }

       
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            RepositorioSocio rp = new RepositorioSocio();
            DGVcuota.DataSource = rp.CantidadSocios();
        }
    }
}
