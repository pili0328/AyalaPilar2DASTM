using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001
{
    public class Cola
    {
        public Nodo Inicio;

        public void Desencolar()
        {
            Inicio = Inicio.Siguiente;
        }

        public void Encolar(Nodo unNodo)
        {
            if(Inicio == null)
            {
                Inicio = unNodo;
            }
            else
            {
                Nodo aux = buscarUltimo(Inicio);
                aux.Siguiente = unNodo;
            }
        }

        private Nodo buscarUltimo(Nodo unNodo)
        {
            if(unNodo.Siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return buscarUltimo(unNodo.Siguiente);
            }
        }

        public bool Vacia()
        {
            return (Inicio == null) ;
        }

    }
}
