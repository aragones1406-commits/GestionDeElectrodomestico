using Electrodomesticos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos.Controlador
{
    public class TListaVenta
    {
        public static List<Venta> listaVentas =
            new List<Venta>();

        public void AgregarVenta(Venta v)
        {
            listaVentas.Add(v);
        }
    }
}
