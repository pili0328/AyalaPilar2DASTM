using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Repaso
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Paquete PaqueteContratado { get; set; }

        public Cliente(int codigo, string nombre, string apellido, string dni, DateTime fechaNacimiento)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            FechaNacimiento = fechaNacimiento;
        }

        // Constructor sobrecargado
        public Cliente(int codigo, string nombre, string apellido) : this(codigo, nombre, apellido, "00000000", DateTime.Now) { }

        public override string ToString()
        {
            return $"{Codigo} - {Nombre} {Apellido} (DNI: {DNI})";
        }
    }
}
