using Electrodomesticos.Formularios;
using Sistema_de_Gestion_de_Farmacia.Controlador;
using Sistema_de_Gestion_de_Farmacia.Entidades;
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
            if (ProductoControlador.listaProductos.Count == 0)
            {
                ProductoControlador.listaProductos.Add(
                    new Producto("P001", "Laptop Lenovo", "Computadoras", 650.00, 10));

                ProductoControlador.listaProductos.Add(
                    new Producto("P002", "Mouse Logitech", "Accesorios", 15.00, 30));

                ProductoControlador.listaProductos.Add(
                    new Producto("P003", "Teclado mecánico", "Accesorios", 45.00, 20));

                ProductoControlador.listaProductos.Add(
                    new Producto("P004", "Monitor Samsung 24 pulgadas", "Monitores", 180.00, 15));

                ProductoControlador.listaProductos.Add(
                    new Producto("P005", "Audífonos inalámbricos", "Audio", 35.00, 25));
            }

            if (ClienteControlador.listaClientes.Count == 0)
            {
                ClienteControlador.listaClientes.Add(
                    new Cliente("0701234567", "Andres Rivera", "0991111111"));

                ClienteControlador.listaClientes.Add(
                    new Cliente("0702345678", "Maria Torres", "0992222222"));

                ClienteControlador.listaClientes.Add(
                    new Cliente("0703456789", "Carlos Mendoza", "0993333333"));

                ClienteControlador.listaClientes.Add(
                    new Cliente("0704567890", "Ana Rodriguez", "0994444444"));

                ClienteControlador.listaClientes.Add(
                    new Cliente("0705678901", "Pedro Castro", "0995555555"));
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
    }
}
