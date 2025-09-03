using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Repaso
{
    public class Banco
    {
        private RepositorioCuentas repositorio;
        public RepositorioCliente repositorioCliente;
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Banco()
        {
            repositorioCliente = new RepositorioCliente();
            repositorio = new RepositorioCuentas();
            nombre = "Banco Nacional";
        }

        public void CrearCajaAhorros(int codigo, Cliente cliente)
        {
            try
            {
                var cuenta = new CajaAhorro(cliente);
                cuenta.Codigo = codigo;
                repositorio.AgregarCuenta(cliente.Dni, cuenta); 
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al crear caja de ahorros: {ex.Message}");
            }
        }

        public void CrearCuentaCorriente(int codigo, Cliente cliente)
        {
            try
            {
                var cuenta = new CuentaCorriente(cliente);
                cuenta.Codigo = codigo;
                repositorio.AgregarCuenta(cliente.Dni, cuenta); 
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al crear cuenta corriente: {ex.Message}");
            }
        }


        public void RealizarDeposito(int codigo, decimal monto)
        {
            var cuenta = repositorio.BuscarCuenta(codigo);
            if (cuenta == null)
                throw new Exception("Cuenta no encontrada.");

            cuenta.Depositar(monto);
        }

        public void RealizarRetiro(int codigo, decimal monto)
        {
            var cuenta = repositorio.BuscarCuenta(codigo);
            if (cuenta == null)
                throw new Exception("Cuenta no encontrada.");

            cuenta.Retirar(monto);
        }

        public decimal ConsultarSaldo(int codigo)
        {
            var cuenta = repositorio.BuscarCuenta(codigo);
            if (cuenta == null)
                throw new Exception("Cuenta no encontrada.");

            return cuenta.ConsultarSaldo();
        }

        public Cuenta ObtenerCuenta(int codigo)
        {
            return repositorio.BuscarCuenta(codigo);
        }

        public List<Cuenta> ObtenerTodasLasCuentas()
        {
            return repositorio.ObtenerTodasLasCuentas();
        }
    }
}
