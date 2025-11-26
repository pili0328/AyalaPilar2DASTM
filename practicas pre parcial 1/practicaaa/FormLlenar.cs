using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeguimosPracticando
{
    public partial class FormLlenar : Form
    {

        private int? Id;
        public FormLlenar(int? id = null)
        {
            InitializeComponent();
            Id = id;
            if (this.Id != null)
                LoadData();
        }

        private void LoadData()
        {
            RepositorioAdolescentes ra = new RepositorioAdolescentes();
            Adolescente dol = ra.BuscoId((int)Id);

            txtNombre.Text = dol.Nombre;
            txtApellido.Text = dol.Apellido;
            ndEdad.Value = dol.Edad;
            dtpFecha.Value = dol.FechaNacimiento;

        }

        private void btnLLenar_Click(object sender, EventArgs e)
        {
            RepositorioAdolescentes ra = new RepositorioAdolescentes();

            try
            {
                if (Id == null)
                    ra.Agregar(txtNombre.Text, txtApellido.Text, (int)ndEdad.Value, dtpFecha.Value);
                else
                    ra.Modificar((int)Id,txtNombre.Text, txtApellido.Text, (int)ndEdad.Value, dtpFecha.Value);
                
                this.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error!!" + ex.Message);
            }
           
        }
    }
}
