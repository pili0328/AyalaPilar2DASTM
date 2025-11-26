using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUINCES
{
    public partial class FormSi : Form
    {
        public FormSi()
        {
            InitializeComponent();
        }

        public void Cargar()
        {
            RepositorioInvitado ri = new RepositorioInvitado();
            DGVsiOsi.DataSource = ri.InvitadosSioSi();
        }

        private void FormSi_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
