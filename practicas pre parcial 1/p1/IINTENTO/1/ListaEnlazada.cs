using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public class ListaEnlazada
    {
        public Nodo Inicio;

        public void AgregarPrincipio(Nodo nuevoNodo)
        {
            nuevoNodo.Siguiente = Inicio;
            Inicio = nuevoNodo;
        }

       /* public void AgregarPrincipio(string dato)
        {
            Nodo nuevoNodo = new1 Nodo();
            nuevoNodo.Siguiente = Inicio;
            Inicio = nuevoNodo;
        }*/

       public void Eliminar(string eliminar)
        {
            if(Inicio == null)
            {
                return;
            }

            if(Inicio.Dato == eliminar)
            {
                Inicio = Inicio.Siguiente;
            }

            Nodo actual = Inicio;
            while(actual.Siguiente != null && actual.Siguiente.Dato != eliminar)
            {
                actual = actual.Siguiente;
            }

            if(actual.Siguiente != null)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
            }

        }

        public void PonerDespues(string viejo,Nodo cambiar)
        {
            Nodo actual = Inicio;

            while(actual != null)
            {
                if(actual.Dato.StartsWith(viejo))
                {
                    cambiar.Siguiente = actual.Siguiente;
                    actual.Siguiente = cambiar;
                    return;
                }
                actual = actual.Siguiente;
            }

        }

        public void CambiarDato(string viejo, string nuevo)
        {
            Nodo actual = Inicio;

            while(actual != null)
            {
                if(actual.Dato.StartsWith(viejo))
                {
                    actual.Dato = nuevo;
                    return;
                }
                actual = actual.Siguiente;
            }
        }
    }
}
