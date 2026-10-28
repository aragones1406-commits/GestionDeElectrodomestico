using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos.Entidades
{
    public class Cliente
    {
        private string cedula;
        private string nombre;
        private string telefono;

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public Cliente()
        {

        }

        //Prueba Prueba
        public Cliente(string cedula, string nombre,
                        string telefono)
        {
            Cedula = cedula;
            Nombre = nombre;
            Telefono = telefono;
        }
    }
}
