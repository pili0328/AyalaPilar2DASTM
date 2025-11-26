using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class ListaEnlazada
    {
        public Nodo Inicio;

        public void Agregar(Nodo agregado)
        {
            agregado.Siguiente = Inicio;
            Inicio = agregado;
            
            return;
        }

        public void Cambiar(string anterior, string nuevo)
        {
            Nodo actual = Inicio;

            while (actual != null)
            {
                if (actual.Dato.StartsWith(anterior))
                {
                    actual.Dato = nuevo;
                    return;

                }
                actual = actual.Siguiente;
            }
        }

        public void AgregarFinal(Nodo agregado)
        {
            if(Inicio == null)
            {
                Inicio = null;
            }
            else
            {
                Nodo actual = Inicio;

                while(actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }

                actual.Siguiente = agregado;
            }
        }

    }
}
