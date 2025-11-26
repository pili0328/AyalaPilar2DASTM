using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Controladora
{
    public class ControladoraCuentaYCliente
    {
        private RepositorioCuentas repo = new RepositorioCuentas();      

        private static ControladoraCuentaYCliente instancia;

        public static ControladoraCuentaYCliente Instancia
        {
            get
            {
                if (instancia == null) 
                {
                    return instancia = new ControladoraCuentaYCliente();
                }

                return instancia; 
            }
        }

        public IReadOnlyCollection<CuentaCorriente> Listar()
        {
            return repo.Listar();
        }

        public IReadOnlyCollection<Cliente> ListarCliente()
        {
            return repo.ListarCliente();
        }

        public string Agregar(Cliente cliente)
        {
            var identificacion = cliente.DNI;
            var nombre = cliente.Nombre;

            if(identificacion != null && nombre != null)
            {
                repo.Agregar(cliente);
                return "Cliente registrado correctamente";
            }

            return "Datos inexistente";
        }

        public string Modificar(Cliente cliente)
        {
            repo.Modificar(cliente);
            return "Cliente modificado";
        }

        public string Eliminar(Cliente cliente)
        {
            var id = cliente.ClienteId;

            // busca el id seleccionado si existe uno lo elimina con toda la fila que tiene
            if(id!= null)
            {
                repo.Eliminar(cliente);
                return "Cliente eliminado";
            }

            return "El cliente no se pudo eliminar";
        }

        public string EliminarCuenta(CuentaCorriente cuenta)
        {
            var id = cuenta.CuentaCorrienteId;

            // busca el id seleccionado si existe uno lo elimina con toda la fila que tiene
            if (id != null)
            {
                repo.EliminarCuenta(cuenta);
                return "Cuenta eliminada";
            }

            return "La cuenta no se pudo eliminar";
        }

        // asocio una cuenta a un cliente
        public string AsocioCuenta(CuentaCorriente cuenta, Cliente cliente)
         {
            return repo.AsocioCuenta(cuenta, cliente);
         } 

        public IReadOnlyCollection<CuentaCorriente> Estado(CuentaCorriente cuenta)
        {
            return repo.EstadoCuenta(cuenta);
        }

        
    }
}
