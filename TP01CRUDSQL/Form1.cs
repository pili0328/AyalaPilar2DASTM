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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void conectadoBTN_Click(object sender, EventArgs e)
        {
            PersonaDB persona = new PersonaDB();
            if (persona.OK())
                MessageBox.Show("Oficialmente conectada");
            else
                MessageBox.Show("No se conecto lol");
        }

        public void Actualizar()
        {
            PersonaDB per = new PersonaDB();
            DGV1.DataSource = per.Obtener();
        }

        private void AgregarBTN_Click(object sender, EventArgs e)
        {
            FormAgregar agrego = new FormAgregar();
            agrego.ShowDialog();
            Actualizar();
        }

        // iba antes pero se me generaba error asi que lo dejo asi.
        // carga mis datos en el data grid view
        private void Form1_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        // ayudante/metodo para buscar el ID
        #region HELPER
        private int? GetId()
        {
            try
            {
                return int.Parse(DGV1.Rows[DGV1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void EditarBTN_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if(Id != null)
            {
                FormAgregar x = new FormAgregar(Id);
                x.ShowDialog();
                Actualizar();
            }
        }

        private void BorrarBTN_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            try
            {
                if (Id != null)
                {
                    PersonaDB db = new PersonaDB();
                    db.Eliminar((int)Id);
                    Actualizar();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error en la base" + ex.Message);
            }        
        }
    }
}
