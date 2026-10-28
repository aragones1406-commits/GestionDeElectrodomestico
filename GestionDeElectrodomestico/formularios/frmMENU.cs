using Electrodomesticos.Formularios;
using Electrodomesticos.Controlador;
using Electrodomesticos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrodomesticos
{
    public partial class frmMENU : Form
    {
        public frmMENU()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            if (TListaProducto.listaProductos.Count == 0)
            {
                TListaProducto.listaProductos.Add(
                    new Producto("P001", "Laptop Lenovo", "Computadoras", 650.00, 10));

                TListaProducto.listaProductos.Add(
                    new Producto("P002", "Mouse Logitech", "Accesorios", 15.00, 30));

                TListaProducto.listaProductos.Add(
                    new Producto("P003", "Teclado mecánico", "Accesorios", 45.00, 20));

                TListaProducto.listaProductos.Add(
                    new Producto("P004", "Monitor Samsung 24 pulgadas", "Monitores", 180.00, 15));

                TListaProducto.listaProductos.Add(
                    new Producto("P005", "Audifonos inalambricos", "Audio", 35.00, 25));
            }

            if (TListaCliente.listaClientes.Count == 0)
            {
                TListaCliente.listaClientes.Add(
                    new Cliente("0709876543", "Luis Herrera", "0987654321"));

                TListaCliente.listaClientes.Add(
                    new Cliente("0708765432", "Sofia Vargas", "0993810703"));

                TListaCliente.listaClientes.Add(
                    new Cliente("0707654321", "Diego Paredes", "0123456789"));

                TListaCliente.listaClientes.Add(
                    new Cliente("0706543210", "Valeria Ortiz", "9876543210"));

                TListaCliente.listaClientes.Add(
                    new Cliente("0705432109", "Jorge Salazar", "0988888888"));
            }
        }

        private void BTNCLIENTES_Click(object sender, EventArgs e)
        {
            frmCLIENTES cli = new frmCLIENTES();
            cli.ShowDialog();
        }

        private void BTNPRODUCTOS_Click(object sender, EventArgs e)
        {
            frmPRODUCTO pro = new frmPRODUCTO();
            pro.ShowDialog();
        }

        private void BTNVENTAS_Click(object sender, EventArgs e)
        {
            frmVENTAS ven = new frmVENTAS();
            ven.ShowDialog();
        }

        private void BTNCONSULTAS_Click(object sender, EventArgs e)
        {
            frmCONSULTAS con = new frmCONSULTAS();
            con.ShowDialog();
        }

        private void BTNREPORTES_Click(object sender, EventArgs e)
        {
            frmREPORTES rep = new frmREPORTES();
            rep.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
