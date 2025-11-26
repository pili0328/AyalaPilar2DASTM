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
    public partial class FormTemporadas : Form
    {
        public FormTemporadas()
        {
            InitializeComponent();
        }

        public void Cargar()
        {
            RepositorioSeries ser = new RepositorioSeries();
            DGVtemporadas.DataSource = ser.Temporadas();
        }
        private void FormTemporadas_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
