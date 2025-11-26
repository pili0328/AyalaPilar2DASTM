using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MUSIQUITA
{
    public class Musica
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Duracion_Minutos { get; set; }
        public bool Agrego { get; set; }
    }
}
