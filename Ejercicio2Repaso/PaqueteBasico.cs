using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Repaso
{
    public class PaqueteBasico : Paquete
    {
        public PaqueteBasico(double precio) : base("Básico", precio) { }
        public override double CalcularPrecio() => PrecioBase;
    }
}
