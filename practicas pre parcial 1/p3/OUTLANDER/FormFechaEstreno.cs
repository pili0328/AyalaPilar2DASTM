using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUTLANDER
{
    public partial class FormFechaEstreno : Form
    {
        public FormFechaEstreno()
        {
            InitializeComponent();
        }

        public void Cargar()
        {
            RepositorioSeries ser = new RepositorioSeries();
            DGVestreno.DataSource = ser.FechaEstreno();
        }

        private void FormFechaEstreno_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
