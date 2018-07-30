using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DAL;
using Entidades;
using System.Windows.Forms;

namespace ProyectoFinal.Reportes
{
    public partial class ClienteReportForm : Form
    {
        private List<Clientes> datos;
        public ClienteReportForm(List<Clientes> log)
        {
            InitializeComponent();
            datos = log;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ListadoClientes listadoClientes = new ListadoClientes();
            listadoClientes.SetDataSource(datos);

            ClientesCrystalReportViewer.ReportSource = listadoClientes;
            ClientesCrystalReportViewer.Refresh();

        }
    }
}
