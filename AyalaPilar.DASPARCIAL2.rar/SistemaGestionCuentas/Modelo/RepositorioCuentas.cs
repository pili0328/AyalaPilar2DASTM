using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioCuentas
    {
        // este repositorio contiene la funcionalidad de cliente y sus cuentas correspondientes
        // tales como: asociar una cuenta,agregar,modificar,eliminar y listar.

        private Context context;

        public RepositorioCuentas()
        {
            context = new Context();
        }

        public IReadOnlyCollection<CuentaCorriente> Listar()
        {
            // return context.CuentasCorrientes.ToList().AsReadOnly();
            return context.CuentasCorrientes
                 .Include(c => c.Clientes)
                 .Include(c => c.Movimientos)
                 .ToList()
                 .AsReadOnly();
        }

        public IReadOnlyCollection<Cliente> ListarCliente()
        {
            //return context.Clientes.ToList().AsReadOnly();
            return context.Clientes
               .Include(c => c.CuentasCorriente)
               .ToList()
               .AsReadOnly();
        }

        public void Agregar(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }
        public void Modificar(Cliente cliente)
        {
            context.Clientes.Update(cliente);
            context.SaveChanges();
        }
        public void Eliminar(Cliente cliente)
        {
            context.Clientes.Remove(cliente);
            context.SaveChanges();
        }
        
        public void AgregarCuenta(CuentaCorriente cuenta)
        {
            context.CuentasCorrientes.Add(cuenta);
            context.SaveChanges();
        }

        public void EliminarCuenta(CuentaCorriente cuenta)
        {
            context.CuentasCorrientes.Remove(cuenta);
            context.SaveChanges();
        }

        public string AsocioCuenta(CuentaCorriente cuenta, Cliente cliente)
        {
            var buscaCliente = context.Clientes.FirstOrDefault(x => x.ClienteId == cliente.ClienteId);

            if (buscaCliente == null)
            {
                return "El cliente no existe";
            }

            var cuentaExistente = context.CuentasCorrientes.Include(c => c.Clientes).FirstOrDefault(c => c.CuentaCorrienteId == cuenta.CuentaCorrienteId);

            if (cuentaExistente == null)
            {            
                cuenta.Clientes.Add(buscaCliente);
                context.CuentasCorrientes.Add(cuenta);
            }
            else
            {
                if (!cuentaExistente.Clientes.Any(c => c.ClienteId == buscaCliente.ClienteId))
                {
                    cuentaExistente.Clientes.Add(buscaCliente);
                }         
            }

            context.SaveChanges();
            return "Cuenta asociada correctamente al cliente.";
        }


        //Consultar estado de cuenta (saldo actual)
        public IReadOnlyCollection<CuentaCorriente> EstadoCuenta(CuentaCorriente cuenta)
        {
            var cuentas = context.CuentasCorrientes.Where(x => x.EstadoCuenta == cuenta.EstadoCuenta).ToList();
            return cuentas;
        }


    }
}
