using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Repaso
{
    public abstract class Paquete
    {
        public enum TipoPaquete
        {
            Basico,
            Silver,
            Premium
        }

        public string Nombre { get; set; }
        public double PrecioBase { get; set; }
        public List<Serie> Series { get; set; }

        public Paquete(string nombre, double precio)
        {
            Nombre = nombre;
            PrecioBase = precio;
            Series = new List<Serie>();
        }

        public void AgregarSerie(Serie serie)
        {
            Series.Add(serie);
        }

        public abstract double CalcularPrecio();
    }

}
