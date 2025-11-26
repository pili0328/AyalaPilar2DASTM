namespace MUSIQUITA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            RepositorioMusica repo = new RepositorioMusica();
            if (repo.OK())
            {
                MessageBox.Show("CONECTADO");
            }
            else
            {
                MessageBox.Show("NO");
            }

        }

        public void Cargar()
        {
            RepositorioMusica repo = new RepositorioMusica();
            DGV.DataSource = repo.ListadoMusica();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormLlenar llene = new FormLlenar();
            llene.ShowDialog();
            Cargar();
        }

        public int BuscaId()
        {
            try
            {
                return int.Parse(DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR!" + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = BuscaId();

            if (id != null)
            {
                FormLlenar llenar = new FormLlenar(id);
                llenar.ShowDialog();
                Cargar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            RepositorioMusica mus = new RepositorioMusica();
            mus.Eliminar(BuscaId());
            Cargar();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            FormPlaylist play = new FormPlaylist();
            play.ShowDialog();
        }
    }
}

