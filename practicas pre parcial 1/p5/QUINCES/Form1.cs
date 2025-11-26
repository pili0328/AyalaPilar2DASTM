namespace QUINCES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void Cargar()
        {
            RepositorioInvitado ri = new RepositorioInvitado();
            DGV.DataSource = ri.ListadoInvitado();
        }

        private void btnConectado_Click(object sender, EventArgs e)
        {
            RepositorioInvitado ri = new RepositorioInvitado();

            if (ri.OK())
            {
                MessageBox.Show("CONECTADO");
            }
            else
            {
                MessageBox.Show("no");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormLlenar llenar = new FormLlenar();
            llenar.ShowDialog();
            Cargar();
        }

        public int BuscoId()
        {
            try
            {
                return int.Parse(DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Error !! " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = BuscoId();

            if (id != null)
            {
                FormLlenar llenar = new FormLlenar(id);
                llenar.ShowDialog();
                Cargar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            RepositorioInvitado ri = new RepositorioInvitado();
            ri.Eliminar(BuscoId());
            Cargar();
        }

        private void btnInvitadoSi_Click(object sender, EventArgs e)
        {
            FormSi si = new FormSi();
            si.ShowDialog();
        }
    }
}
