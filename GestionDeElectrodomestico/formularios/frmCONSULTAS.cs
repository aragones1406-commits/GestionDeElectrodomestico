using Sistema_de_Gestion_de_Farmacia.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrodomesticos.Formularios
{
    public partial class frmCONSULTAS : Form
    {
        public frmCONSULTAS()
        {
            InitializeComponent();
        }

        private void productoConMayorPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta =
                ProductoControlador.listaProductos
                .OrderByDescending(p => p.Precio)
                .ToList();

            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = consulta;
        }

        private void clientesOrdenadosAlfabeticamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta =
                TListaCliente.listaClientes
                .OrderBy(c => c.Nombre)
                .ToList();

            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = consulta;
        }

        private void productosOrdenadosAlfabeticamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta =
                ProductoControlador.listaProductos
                .OrderBy(p => p.Nombre)
                .ToList();

            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = consulta;
        }

        private void ventasMayoresA100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta =
                VentaControlador.listaVentas
                .Where(v => v.Total > 100)
                .ToList();

            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = consulta;
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta =
               VentaControlador.listaVentas
               .OrderByDescending(v => v.Total)
               .Take(1)
               .ToList();

            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = consulta;
        }

        private void ventasDeMenorValorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consulta =
              VentaControlador.listaVentas
              .OrderBy(v => v.Total)
              .Take(1)
              .ToList();

            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = consulta;
        }

        // Prueba para crear el Pull RequestT
        private void frmCONSULTAS_Load(object sender, EventArgs e)
        {

        }
    }
}
