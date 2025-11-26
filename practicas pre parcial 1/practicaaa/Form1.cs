namespace SeguimosPracticando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        public void Actualizar()
        {
            RepositorioAdolescentes ra = new RepositorioAdolescentes();
            DGV.DataSource = ra.ListadoAdolescentes();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            RepositorioAdolescentes ra = new RepositorioAdolescentes();

            if (ra.OK())
            {
                MessageBox.Show("CONECTADOOOO");
            }
            else
            {
                MessageBox.Show("NO SE CONECTO");
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormLlenar llenar = new FormLlenar();
            llenar.ShowDialog();
            Actualizar();
        }

        public int BuscarID()
        {
            try
            {
                return int.Parse(DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Error!!" + ex.Message);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = BuscarID();
            if (id != null)
            {
                FormLlenar llenar = new FormLlenar(id);
                llenar.ShowDialog();
                Actualizar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            RepositorioAdolescentes ra = new RepositorioAdolescentes();
            ra.Eliminar(BuscarID());
            Actualizar();

        }

        private void btnMayores_Click(object sender, EventArgs e)
        {
            FormMayores mayores = new FormMayores();
            mayores.ShowDialog();

        }

        private void btnAyala_Click(object sender, EventArgs e)
        {
            FormAyala ayala = new FormAyala();
            ayala.ShowDialog();
        }
    }
}
