namespace _1Practica2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            GestorPeople p = new GestorPeople();
            if (p.OK())
                MessageBox.Show("Oficialmente conectada");
            else
                MessageBox.Show("No se conecto!!!");
        }

        public void Refrescar()
        {
            GestorPeople p = new GestorPeople();
            DGV.DataSource = p.ListadoP();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar agrego = new Agregar();
            agrego.ShowDialog();
            Refrescar();
        }

        // metodo oara buscar el id
        private int BuscaId()
        {
            try
            {
                return int.Parse(DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Error de funcion" + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? Id = BuscaId();
            if (Id != null)
            {
                Agregar gg = new Agregar(Id);
                gg.ShowDialog();
                Refrescar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = BuscaId();
            try
            {
                if(Id  != null)
                {
                    GestorPeople gp = new GestorPeople();
                    gp.Eliminar((int)Id);
                    Refrescar();
                }
            }
            catch(Exception ex) 
            {
                throw new Exception("Error de funcion" + ex.Message);
            }

        }
    }
}
