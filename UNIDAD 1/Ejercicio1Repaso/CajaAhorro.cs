using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Repaso
{
    public class CajaAhorro : Cuenta
    {
      
        private decimal limiteCredito;
        private const decimal LIMITE_SOBREGIRO = 100000;

        public decimal LimiteCredito
        {
            get { return limiteCredito; }
            set { limiteCredito = value; }
        }

        public CajaAhorro(Cliente titular) : base(titular)
        {
            limiteCredito = LIMITE_SOBREGIRO;
        }

        public override void Retirar(decimal monto)
        {
            if (monto <= 0)
                throw new Exception("El monto a retirar debe ser mayor a cero.");

            decimal saldoDisponible = saldo + limiteCredito;

            if (monto > saldoDisponible)
                throw new Exception($"Fondos insuficientes. Saldo disponible: ${saldoDisponible:N2}");

            saldo -= monto;
        }

        public decimal ObtenerSaldoDisponible()
        {
            return saldo + limiteCredito;
        }

        public override string ObtenerTipoCuenta()
        {
            return "Caja Ahorro";
        }
    }
}
