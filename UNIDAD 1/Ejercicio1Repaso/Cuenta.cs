using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Repaso
{
    public abstract class Cuenta
    {
        private int codigo;
        public int Codigo { get; set; }

        protected decimal saldo;
        public decimal Saldo
        {
            get { return saldo; }
            protected set { saldo = value; }
        }

        public Cliente Titular { get; set; }

        public Cuenta(Cliente titular)
        {
            Titular = titular ?? throw new ArgumentNullException(nameof(titular));
            saldo = 0;
        }

        public virtual void Depositar(decimal monto)
        {
            if (monto <= 0)
                throw new Exception("El monto a depositar debe ser mayor a cero.");

            saldo += monto;
        }

        public abstract void Retirar(decimal monto);

        public virtual decimal ConsultarSaldo()
        {
            return saldo;
        }

        public abstract string ObtenerTipoCuenta();

    }
}
