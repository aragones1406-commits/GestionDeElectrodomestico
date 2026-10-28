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
        public static List<TListaCliente> listaClientes =
            new List<TListaCliente>();

        public void AgregarCliente(TListaCliente c)
        {
            listaClientes.Add(c);
        }

        public void EliminarCliente(TListaCliente c)
        {
            listaClientes.Remove(c);
        }
    }
}
