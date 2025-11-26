using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01CRUDSQL
{
    public partial class FormAgregar : Form
    {
        // tambien lo uso para editar aparte de agregar
        // sirve si va a editarse o poner uno nuevo?
        private int? Id;
        public FormAgregar(int? id = null)
        {
            InitializeComponent();
            this.Id = id;
            if(this.Id != null)
                LoadData();
        }

        private void LoadData()
        {
            PersonaDB pp = new PersonaDB();
            Persona pepe = pp.RegresaId((int)Id);
            txtNombre.Text = pepe.Nombre;
            txtEdad.Text = pepe.Edad.ToString();
            txtGenero.Text = pepe.Genero;
        }

        private void AgregarBTN_Click(object sender, EventArgs e)
        {
            PersonaDB persona = new PersonaDB();

            try
            {
                if(Id==null)
                    persona.Agregar(txtNombre.Text, int.Parse(txtEdad.Text), txtGenero.Text);
                else
                    persona.Editar(txtNombre.Text, int.Parse(txtEdad.Text),txtGenero.Text, (int)Id);
                this.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error al agregar" + ex.Message);
            }
        }
    }
}
