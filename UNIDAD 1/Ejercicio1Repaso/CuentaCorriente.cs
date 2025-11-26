using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Repaso
{
    public class CuentaCorriente : Cuenta
    {

        private int retirosRealizados;
        private const int LIMITE_RETIROS = 3;


        public int RetirosRealizados
        {
            get { return retirosRealizados; }
            set { retirosRealizados = value; }
        }

        public CuentaCorriente(Cliente titular) : base(titular)
        {
            retirosRealizados = 0;
        }

        public override void Retirar(decimal monto)
        {
            if (monto <= 0)
                throw new Exception("El monto a retirar debe ser mayor a cero.");

            if (retirosRealizados >= LIMITE_RETIROS)
                throw new Exception($"Ha excedido el límite de {LIMITE_RETIROS} retiros por mes.");

            if (monto > saldo)
                throw new Exception("Fondos insuficientes para realizar el retiro.");

            saldo -= monto;
            retirosRealizados++;
        }

        public void ReiniciarContadorRetiros()
        {
            retirosRealizados = 0;
        }

        public override string ObtenerTipoCuenta()
        {
            return "Cuenta de Corriente";
        }


    }
}
