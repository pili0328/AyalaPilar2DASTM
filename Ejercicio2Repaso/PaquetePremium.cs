using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Repaso
{
    public class PaquetePremium : Paquete
    {
        public PaquetePremium(double precio) : base("Premium", precio) { }
        public override double CalcularPrecio() => PrecioBase * 1.20;
    }
}
