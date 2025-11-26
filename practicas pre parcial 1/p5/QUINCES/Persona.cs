using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QUINCES
{
    public class Persona
    {
        // id,nombre,apellido,fecha_nacimiento,num_invitado,invitado

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int NumInvitado { get; set; }
        public bool MeInvitaron { get; set; }

    }
}
