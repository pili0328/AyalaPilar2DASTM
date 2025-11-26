namespace _01
{
    public partial class Form1 : Form
    {

        Pila miPila = new Pila();
        public Form1()
        {
            InitializeComponent();
        }

        public void mostrar2(Nodo unNodo)
        {
            if (unNodo != null)
            {
                lsApilar.Items.Add(unNodo.Dato);

                mostrar2(unNodo.Siguiente);
            }
        }

        public void mostarPila()
        {
            lsApilar.Items.Clear();

            if (miPila.Tope() != null)
            {
                mostrar2(miPila.Tope());
            }
        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            string dato = txtDato.Text;
            Nodo nuevoDato = new Nodo();
            nuevoDato.Dato = dato;

            miPila.Apilar(nuevoDato);
            lsApilar.Items.Add(dato);
            mostarPila();

            txtDato.Clear();
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            if(miPila.Tope() != null)
            {
                string desapilado = miPila.Tope().Dato;

                miPila.Desapilar();
                mostarPila();
                lsDesapilar.Items.Add(desapilado);
            }

        }
    }
}
