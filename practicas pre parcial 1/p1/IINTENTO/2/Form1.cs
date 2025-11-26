using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
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

            if(lista.Inicio != null)
            {
                Mostrar2(lista.Inicio);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dato = txtDato.Text;

            string texto = "Mi dato es: " + " - " + dato;

            Nodo agregado = new Nodo();
            agregado.Dato = texto;

            lista.Agregar(agregado);
            MostrarLista();
        }

        bool dato = true;
        private void btnCAMBIAR_Click(object sender, EventArgs e)
        {
            string anterior = "";

            if (dato)
            {
                anterior = txtDato.Text;
            }

            if(anterior != "")
            {
                string dato = txtDato.Text;
                string texto = "Mi dato es: " + " - " + dato;

                lista.Cambiar(anterior, texto);
                MostrarLista();


            }
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            string dato = txtDato.Text;

            string texto = "Mi dato es: " + " - " + dato;

            Nodo final = new Nodo();
            final.Dato = texto;

            lista.AgregarFinal(final);
            MostrarLista();
        }
    }
}
