using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaCorriente
    {
        public int CuentaCorrienteId { get; set; }
        public string EstadoCuenta { get; set; }

        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public List<Movimiento> Movimientos { get; set; } = new List<Movimiento>(); 

    }
}
