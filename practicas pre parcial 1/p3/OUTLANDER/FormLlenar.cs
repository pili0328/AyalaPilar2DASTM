using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUTLANDER
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
            RepositorioSeries s = new RepositorioSeries();
            Serie ser = s.BuscarId((int)Id);

            txtNombre.Text = ser.Nombre;
            dtpFechaEstreno.Value = ser.Fecha_Estreno;
            txtTemporadas.Text = ser.Temporada.ToString();
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            RepositorioSeries ser = new RepositorioSeries();
            try
            {
                if (Id == null)
                    ser.Agregar(txtNombre.Text,dtpFechaEstreno.Value,int.Parse(txtTemporadas.Text));
                else
                    ser.Modificar((int)Id, txtNombre.Text, dtpFechaEstreno.Value, int.Parse(txtTemporadas.Text));

                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error!!" + ex.Message);
            }
        }
    }
}
