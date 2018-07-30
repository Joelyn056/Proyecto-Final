using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using Entidades;

namespace ProyectoFinal.Reportes
{
    
    public partial class FacturaReportForm : Form
    {
        private List<Facturas> datos;

        public FacturaReportForm(List<Facturas> log)
        {
            InitializeComponent();
            datos = log;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ListadoProducto listadoProducto = new ListadoProducto();
            listadoProducto.SetDataSource(datos);

            ProductosCrystalReportViewer.ReportSource = listadoProducto;
            ProductosCrystalReportViewer.Refresh();
        }
    }
}
