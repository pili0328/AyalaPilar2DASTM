using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Repaso
{
    public class Serie
    {
        private string nombre;
        private int temporadas;
        private int episodios;
        private double duracionPromedio;
        private double ranking;
        private string genero;
        private string director;

        public string Nombre { get; set; }
        public int Temporadas { get; set; }
        public int Episodios { get; set; }
        public double DuracionPromedio { get; set; }
        public double Ranking { get; set; }
        public string Genero { get; set; }
        public string Director { get; set; }

        public Serie(string nombre, int temporadas, int episodios, double duracion, double ranking, string genero, string director)
        {
            Nombre = nombre;
            Temporadas = temporadas;
            Episodios = episodios;
            DuracionPromedio = duracion;
            Ranking = ranking;
            Genero = genero;
            Director = director;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Temporadas} temporadas, {Episodios} episodios, Ranking: {Ranking}";
        }
    }
}
