using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Modelo;
using Entidades;

namespace Controladora
{
    public class ControladoraMovimientos
    {

        private static ControladoraMovimientos instancia;

        public static ControladoraMovimientos Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ControladoraMovimientos();

                return instancia;
            }
        }

        public List<Movimiento> ListarMovimientosDeCliente(Cliente cliente)
        {
            var cuentasCliente = ControladoraCuentaYCliente.Instancia.Listar()
                .Where(c => c.Clientes.Any(cl => cl.ClienteId == cliente.ClienteId))
                .ToList();

            return cuentasCliente.SelectMany(c => c.Movimientos).ToList();
        }
    }

}
