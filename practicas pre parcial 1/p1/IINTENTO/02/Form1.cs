namespace _02
{
    public partial class Form1 : Form
    {

        Pila miPila = new Pila();
        public Form1()
        {
            InitializeComponent();
        }

        public void Mostrar2(Nodo unNodo)
        {
            if (unNodo != null)
            {
                listApilarIda.Items.Add(unNodo.Dato);
                Mostrar2(unNodo.Siguiente);
            }
        }

        public void MostrarPila()
        {
            listApilarIda.Items.Clear();
            if (miPila.Tope() != null)
            {
                Mostrar2(miPila.Tope());
            }

        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            string pueblos = txtPueblos.Text;
            Nodo unNuevoNodo = new Nodo();
            unNuevoNodo.Dato = pueblos;

            miPila.Apilar(unNuevoNodo);
            listApilarIda.Items.Add(pueblos);
            MostrarPila();
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            if (miPila.Tope() != null)
            {
                string desapilado = miPila.Tope().Dato;
                miPila.Desapilar();
                MostrarPila();
                listDesapilarVuelta.Items.Add(desapilado);
            }
        }

        
    }
}
