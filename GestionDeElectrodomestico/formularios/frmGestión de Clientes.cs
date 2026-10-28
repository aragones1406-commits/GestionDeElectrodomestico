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

namespace Electrodomesticos.Formularios
{
    public partial class frmCLIENTES : Form
    {
        Sistema_de_Gestion_de_Farmacia.Controlador.TListaCliente cc = new Sistema_de_Gestion_de_Farmacia.Controlador.TListaCliente();

        int indice = -1;

        bool editar = false;
        public frmCLIENTES()
        {
            InitializeComponent();
        }

        private void frmCLIENTES_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        // Prueba de rama
        // Prueba de rama
        public void MostrarClientes()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource =
                Cliente.listaClientes.ToList();
        }
        public void Limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();

            txtCedula.Focus();

            indice = -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Sistema_de_Gestion_de_Farmacia.Entidades.Cliente c = new Sistema_de_Gestion_de_Farmacia.Entidades.Cliente();

            c.Cedula = txtCedula.Text;
            c.Nombre = txtNombre.Text;
            c.Telefono = txtTelefono.Text;

            cc.AgregarCliente(c);

            MostrarClientes();

            Limpiar();

            MessageBox.Show("Cliente registrado correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                if (dgvClientes.CurrentRow != null)
                {
                    indice = dgvClientes.CurrentRow.Index;

                    txtCedula.Text =
                        dgvClientes.Rows[indice].Cells[0].Value.ToString();

                    txtNombre.Text =
                        dgvClientes.Rows[indice].Cells[1].Value.ToString();

                    txtTelefono.Text =
                        dgvClientes.Rows[indice].Cells[2].Value.ToString();

                    editar = true;

                    MessageBox.Show("Modifique los datos y presione nuevamente MODIFICAR");
                }
            }

            // SEGUNDO CLICK
            // GUARDA CAMBIOS

            else
            {
                Sistema_de_Gestion_de_Farmacia.Controlador.TListaCliente.listaClientes[indice].Cedula =
                    txtCedula.Text;

                Sistema_de_Gestion_de_Farmacia.Controlador.TListaCliente.listaClientes[indice].Nombre =
                    txtNombre.Text;

                Sistema_de_Gestion_de_Farmacia.Controlador.TListaCliente.listaClientes[indice].Telefono =
                    txtTelefono.Text;

                MostrarClientes();

                Limpiar();

                editar = false;

                MessageBox.Show("Cliente modificado correctamente");
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                Sistema_de_Gestion_de_Farmacia.Entidades.Cliente c =
                    (Sistema_de_Gestion_de_Farmacia.Entidades.Cliente)dgvClientes.CurrentRow.DataBoundItem;

                Cliente.listaClientes.Remove(c);

                MostrarClientes();

                Limpiar();

                MessageBox.Show("Cliente eliminado");
            }
        }
    }
}
