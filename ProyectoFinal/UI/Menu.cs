using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyectoFinal.UI.Consultas;
using ProyectoFinal.UI.Registros;


namespace ProyectoFinal.UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new RegistroUsuario().Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistroClientes().Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistroProductos().Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ConsultaUsuario().Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultaClientes().Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ConsultaProductos().Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultaFacturas().Show();
        }

        private void facturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FacturasForm().Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
