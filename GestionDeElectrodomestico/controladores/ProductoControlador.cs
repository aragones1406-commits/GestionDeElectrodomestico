using Electrodomesticos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos.Controlador
{
    public class ProductoControlador
    {
        public static List<Producto> listaProductos =
            new List<Producto>();

        public void AgregarProducto(Producto p)
        {
            listaProductos.Add(p);
        }

        public void EliminarProducto(Producto p)
        {
            listaProductos.Remove(p);
        }
    }
}
