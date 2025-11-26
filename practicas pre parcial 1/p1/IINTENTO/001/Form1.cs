using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001
{
    public partial class Form1 : Form
    {
        Cola miCola = new Cola();

        public Form1()
        {
            InitializeComponent();
        }

        public void Mostrar2(Nodo unNodo)
        {
            if(unNodo != null)
            {
                listColas.Items.Add(unNodo.Dato);
                Mostrar2(unNodo.Siguiente);
            }
        }

        public void MostrarCola()
        {
            listColas.Items.Clear();
            if(miCola.Inicio != null)
            {
                Mostrar2(miCola.Inicio);
            }

        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text != "")
            {
                string nombre = txtNombre.Text;
                Nodo nuevo = new Nodo();
                nuevo.Dato = nombre;

                miCola.Encolar(nuevo);
                listColas.Items.Add(nombre);
                MostrarCola();
            }


        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            if (miCola.Vacia())
            {
                MessageBox.Show("Debe ingresar un valor");

            }
            else
            {
                miCola.Desencolar();
                MostrarCola();
            }
        }
    }
}
