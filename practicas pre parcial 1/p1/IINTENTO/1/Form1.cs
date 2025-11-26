using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        ListaEnlazada lista = new ListaEnlazada();

        public Form1()
        {
            InitializeComponent();
        }

        public void Mostrar2(Nodo unNodo)
        {
            if(unNodo != null)
            {
                listBox.Items.Add(unNodo.Dato);
                Mostrar2(unNodo.Siguiente);
            }
        }

        public void MostrarLista()
        {
            listBox.Items.Clear();

            if(lista.Inicio != null )
            {
                Mostrar2(lista.Inicio);

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string edad = txtEdad.Text;
            string algo = "El nombre es: " + nombre + " - " + "La edad es: " + edad;

            Nodo nuevo = new Nodo();
            nuevo.Dato = algo;

            lista.AgregarPrincipio(nuevo);
            MostrarLista();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string edad = txtEdad.Text;

            string ambos = "El nombre es: " + nombre + " - " + "La edad es: " + edad;
            lista.Eliminar(ambos);
            MostrarLista();
        }

        private void btnDespues_Click(object sender, EventArgs e)
        {
            string viejo = listBox.SelectedItem?.ToString();

            string nombre = txtNombre.Text;
            string edad = txtEdad.Text;
            string nuevo = "El nombre es: " + nombre + " - " + "La edad es: " + edad;

            Nodo cambio = new Nodo();
            cambio.Dato = nuevo;

            lista.PonerDespues(viejo,cambio);
            MostrarLista();
        }

        bool nombre = true;
        bool edad = false;

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            string cambiar = "";

            if (nombre)
            {
                cambiar = txtNombre.Text;
            }
            else if (edad)
            {
                cambiar = txtEdad.Text;
            }

            if(cambiar != "")
            {
                string nombre = txtNombre.Text;
                string edad = txtEdad.Text;
                string dato = "El nombre es: " + nombre + " - " + "La edad es: " + edad;

                lista.CambiarDato(cambiar, dato);
                MostrarLista();
            }

        }
    }
}
