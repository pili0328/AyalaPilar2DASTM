using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LIKE_HIMMMM
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Estreno { get; set; }
        public int PuestoTOP { get; set; }
        public bool Vista { get; set; }
    }
}
