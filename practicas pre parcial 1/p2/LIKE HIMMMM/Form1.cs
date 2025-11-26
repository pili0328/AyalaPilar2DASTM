namespace LIKE_HIMMMM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            RepositorioPelicula rp = new RepositorioPelicula();
            if (rp.OK())
            {
                MessageBox.Show("CONECTADO!!");
            }
            else
            {
                MessageBox.Show("NOOOOOO CONECTADO!!");
            }
        }

        public void Actualizar()
        {
            RepositorioPelicula rp = new RepositorioPelicula();
            DGV.DataSource = rp.ListadoPeliculas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormRellenar relleno = new FormRellenar();
            relleno.ShowDialog();
            Actualizar();

        }

        public int BuscoId()
        {
            try
            {
                return int.Parse(DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Error! " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = BuscoId();
            if (id != null)
            {
                FormRellenar relleno = new FormRellenar(id);
                relleno.ShowDialog();
                Actualizar();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            RepositorioPelicula rp = new RepositorioPelicula();
            rp.Eliminar(BuscoId());
            Actualizar();
        }

        private void btnVista_Click(object sender, EventArgs e)
        {
            FormVistas vistas = new FormVistas();
            vistas.ShowDialog();
            
        }
    }
}
