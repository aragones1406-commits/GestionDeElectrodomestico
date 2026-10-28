using Electrodomesticos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos.Controlador
{
    public class TListaCliente
    {
        public static List<Cliente> listaClientes =
            new List<Cliente>();

        public void AgregarCliente(Cliente c)
        {
            listaClientes.Add(c);
        }

        public void EliminarCliente(Cliente c)
        {
            listaClientes.Remove(c);
        }
    }
}
