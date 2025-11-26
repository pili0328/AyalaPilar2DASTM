namespace REPASOPARCIALCRUD
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

        private void btnConexion_Click(object sender, EventArgs e)
        {
            RepositorioSocio rp = new RepositorioSocio();
            if (rp.OK())
                MessageBox.Show("Conectado!!");
            else
                MessageBox.Show("No se conecto :(");

        }

        public void Actualizar()
        {
            RepositorioSocio rp = new RepositorioSocio();
            DGV.DataSource = rp.ListadoSocio();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAlternativo alternativo = new FormAlternativo();
            alternativo.ShowDialog();
            Actualizar();
        }

        public int Busco()
        {
            try
            {
                return int.Parse(DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? Id = Busco();
            if (Id != null)
            {
                FormAlternativo alt = new FormAlternativo(Id);
                alt.ShowDialog();
                Actualizar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = Busco();

            if (Id != null)
            {
                RepositorioSocio rp = new RepositorioSocio();
                rp.Eliminar((int)Id);
                Actualizar();
            }

        }

        private void btnCuota_Click(object sender, EventArgs e)
        {
            FormCuotaAlDia dia = new FormCuotaAlDia();
            dia.ShowDialog();
            
            
        }

        private void btnMayores_Click(object sender, EventArgs e)
        {
            FormMayores may = new FormMayores();
            may.ShowDialog();
        }
    }
}
