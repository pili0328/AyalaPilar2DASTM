using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Repaso
{
    public class PaqueteSilver : Paquete
    {
        public PaqueteSilver(double precio) : base("Silver", precio) { }
        public override double CalcularPrecio() => PrecioBase * 1.15;
    }
}
