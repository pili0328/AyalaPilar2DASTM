using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Repaso
{
    public class RepositorioCuentas
    {

        public RepositorioCuentas()
        {
            listadoCuenta  = new List<Cuenta>();
            repoCliente = new RepositorioCliente();
        }
        public List<Cuenta> listadoCuenta;
        RepositorioCliente repoCliente;

        public string AgregarCuenta(int dniCliente, Cuenta cuenta)
        {
            var cliente = repoCliente.listaClientes.FirstOrDefault(c => c.Dni == dniCliente);

            if (cliente == null)
                return "El cliente no existe, no se puede asignar la cuenta.";

            cuenta.Titular = cliente;       
            cliente.AgregarCuenta(cuenta); 
            listadoCuenta.Add(cuenta);     

            return "Cuenta agregada al cliente.";
        }



        public Cuenta BuscarCuenta(int codigo)
        {
            return listadoCuenta.FirstOrDefault(c => c.Codigo == codigo);
        }

        public bool ExisteCuenta(int codigo)
        {
            return listadoCuenta.Any(c => c.Codigo == codigo);
        }

        public List<Cuenta> ObtenerTodasLasCuentas()
        {
            return listadoCuenta.ToList();
        }

        public void EliminarCuenta(int codigo)
        {
            var cuenta = BuscarCuenta(codigo);
            if (cuenta != null)
            {
                listadoCuenta.Remove(cuenta);
            }
        }

    }
}
