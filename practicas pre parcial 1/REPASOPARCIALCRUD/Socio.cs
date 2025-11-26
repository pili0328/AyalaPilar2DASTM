using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASOPARCIALCRUD
{
    public class Socio
    {
        // nombre, apellido, DNI, fecha de nacimiento, número de socio y cuota al día(sí/no).

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int NumSocio { get; set; }
        public bool CuotaAlDia {  get; set; }    

    }
}
