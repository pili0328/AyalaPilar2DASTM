using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Practica2025
{
    public partial class Agregar : Form
    {
        private int? Id;

        public Agregar(int? id = null)
        {
            InitializeComponent();
            Id = id;
            if (this.Id != null)
                LoadData();
        }

        private void LoadData()
        {
            GestorPeople pp = new GestorPeople();
            People p = pp.DevolverId((int)Id);
            txtNombre.Text = p.Nombre;
            txtEdad.Text = p.Edad.ToString();
            ckbMayor.Checked = p.Mayor;
            ckbMenor.Checked = p.Menor;
        }

        private void btnAgrego_Click(object sender, EventArgs e)
        {
            GestorPeople pp = new GestorPeople();

            try
            {
                if (Id == null)
                    pp.Agregar(txtNombre.Text, int.Parse(txtEdad.Text), ckbMayor.Checked, ckbMenor.Checked);
                else
                    pp.Modificar(txtNombre.Text, int.Parse(txtEdad.Text), (int)Id, ckbMayor.Checked, ckbMenor.Checked);
                this.Close();
            }
            catch(Exception ex) 
            {
                throw new Exception("Error al cargar " + ex.Message);
            }
        }
    }
}
