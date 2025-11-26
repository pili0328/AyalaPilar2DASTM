namespace OUTLANDER
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
            RepositorioSeries series = new RepositorioSeries();
            DGV.DataSource = series.ListadoSeries();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            RepositorioSeries s = new RepositorioSeries();
            if (s.OK())
            {
                MessageBox.Show("CONECTADO");
            }
            else
            {
                MessageBox.Show("NO CONECTADO");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormLlenar llenar = new FormLlenar();
            llenar.ShowDialog();
            Cargar();
        }

        public int Busco()
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
            int id = Busco();

            if (id != null)
            {
                FormLlenar lleno = new FormLlenar(id);
                lleno.ShowDialog();
                Cargar();
            }
        }

        private void btnELiminar_Click(object sender, EventArgs e)
        {
            RepositorioSeries ser = new RepositorioSeries();
            ser.Eliminar(Busco());
            Cargar();
        }

        private void btnTemporadas_Click(object sender, EventArgs e)
        {
            FormTemporadas temp = new FormTemporadas();
            temp.ShowDialog();
        }

        private void btnEstreno_Click(object sender, EventArgs e)
        {
            FormFechaEstreno estreno = new FormFechaEstreno();
            estreno.ShowDialog();
        }
    }
}
