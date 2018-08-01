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
    public partial class UsuariosReportForm : Form
    {
        private List<Usuarios> usuarios = null;

        public UsuariosReportForm(List<Usuarios> Datos)
        {
            InitializeComponent();
            this.usuarios = Datos;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ListadoUsuarios listadoUsuarios = new ListadoUsuarios();
            listadoUsuarios.SetDataSource(usuarios);

            UsuariosCrystalReportViewer.ReportSource = listadoUsuarios;
            UsuariosCrystalReportViewer.Refresh();

        }
    }
}
