using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Repaso
{
    public class RepositorioCliente
    {
        public RepositorioCliente()
        {
            listaClientes = new List<Cliente>();
        }

        public List<Cliente> listaClientes;

        public string Agregar(Cliente cliente)
        {
            var clienteRepetido = listaClientes.FirstOrDefault(x => x.Dni ==
            cliente.Dni && x.NombreyApellido ==  cliente.NombreyApellido &&
            x.Tel == cliente.Tel && x.Email == cliente.Email
            && x.FechaNacimiento ==  cliente.FechaNacimiento);

            if (clienteRepetido == null)
            {
                listaClientes.Add(cliente);
                return "Cliente Agregado";
            }
            else
            {
                return "El cliente ya fue agregado anteriormente";
            }
        }

        public string Modificar(Cliente cliente)
        {
            var clienteRepetido = listaClientes.FirstOrDefault(x => x.Dni ==
            cliente.Dni && x.NombreyApellido == cliente.NombreyApellido &&
            x.Tel == cliente.Tel && x.Email == cliente.Email
            && x.FechaNacimiento == cliente.FechaNacimiento);

            if (clienteRepetido != null)
            {
                clienteRepetido = cliente;
                return "Cliente Modificado";
            }
            else
            {
                return "El cliente a modificar no fue encontrado";
            }
        }

        public string Borrar(Cliente cliente)
        {
            var clienteBorrado = listaClientes.FirstOrDefault(x => x.Dni ==
            cliente.Dni && x.NombreyApellido == cliente.NombreyApellido &&
            x.Tel == cliente.Tel && x.Email == cliente.Email
            && x.FechaNacimiento == cliente.FechaNacimiento);

            if (clienteBorrado != null)
            {
                listaClientes.Remove(clienteBorrado);
                return "El cliente fue eliminado correctamente";
            }
            return "No se encontro el cliente para borrar";
        }

        public IReadOnlyCollection<Cliente> Listar()
        {
            return listaClientes.AsReadOnly();
        }
    }
}
