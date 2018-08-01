using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.Reportes
{
    public partial class ProductoReportForm : Form
    {
        private List<Productos> productos = null;

        public ProductoReportForm(List<Productos> datos)
        {
            InitializeComponent();
            this.productos = datos;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ListadoProducto listadoProducto = new ListadoProducto();
            listadoProducto.SetDataSource(productos);

            ProductosCrystalReportViewer.ReportSource = listadoProducto;
            ProductosCrystalReportViewer.Refresh();
        }
    }
}
