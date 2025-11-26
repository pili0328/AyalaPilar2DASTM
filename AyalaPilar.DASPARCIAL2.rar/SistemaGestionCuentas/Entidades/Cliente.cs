using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public int Telefono { get; set; }

        public List<CuentaCorriente> CuentasCorriente { get; set; } = new List<CuentaCorriente>();


        // ME AYUDA A QUE APAREZCA EN MI DUD CLIENTE EL APELLIDO Y NOMBRE DEL CLENTE
        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }


    }
}
