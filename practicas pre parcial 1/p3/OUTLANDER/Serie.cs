using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OUTLANDER
{
    public class Serie
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha_Estreno { get; set; }
        public int Temporada { get; set; }

    }
}
