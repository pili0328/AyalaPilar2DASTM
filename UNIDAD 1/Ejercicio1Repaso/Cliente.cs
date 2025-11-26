using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Repaso
{
    public class Cliente
    {
        private int dni;
        public int Dni { get { return dni; } }

        private string nombreyApellido;
        public string NombreyApellido { get; set; }

        private int tel;
        public int Tel { get; set; }

        private string email;
        public string Email { get; set; }

        private DateTime fechaNacimiento;
        public DateTime FechaNacimiento { get; set; }

        private List<Cuenta> cuentas;
        public IReadOnlyCollection<Cuenta> Cuentas { get { return cuentas.AsReadOnly(); } }

        public Cliente(int dni, string nombreyApellido, int tel, string email, DateTime fechaNacimiento)
        {
            this.dni = dni;
            this.nombreyApellido = nombreyApellido;
            this.tel = tel;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            cuentas = new List<Cuenta>();
        }

        public void AgregarCuenta(Cuenta cuenta)
        {
            cuentas.Add(cuenta);
        }
    }
}
