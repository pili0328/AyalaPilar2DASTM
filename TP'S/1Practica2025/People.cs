using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _1Practica2025
{
    public class People
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public bool Mayor { get; set; }
        public bool Menor { get; set; }


    }
}
