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
    public partial class frmREPORTES : Form
    {
        public frmREPORTES()
        {
            InitializeComponent();
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvReportes.DataSource = null;
            dgvReportes.DataSource =
                ProductoControlador.listaProductos.ToList();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvReportes.DataSource = null;
            dgvReportes.DataSource =
                TListaCliente.listaClientes.ToList();
        }

        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvReportes.DataSource = null;
            dgvReportes.DataSource =
                VentaControlador.listaVentas.ToList();
        }
    }
}
