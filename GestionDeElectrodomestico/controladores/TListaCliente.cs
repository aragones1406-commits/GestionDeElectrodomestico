using Sistema_de_Gestion_de_Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestion_de_Farmacia.Controlador
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
