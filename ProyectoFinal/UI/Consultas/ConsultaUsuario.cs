using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq.Expressions;
using BLL;
using Entidades;
using System.Threading.Tasks;
using ProyectoFinal.Reportes;

namespace ProyectoFinal.UI.Consultas
{
    public partial class ConsultaUsuario : Form
    {
        List<Usuarios> usuarios = new List<Usuarios>();

        public ConsultaUsuario()
        {
           
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Expression<Func<Usuarios, bool>> filtro = x => true;

            int id;
            switch (FiltrarComboBox.SelectedIndex)
            {
                case 0://Todo
                    break;
                case 1://UsuarioId
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = x => (x.UsuarioId == id);
                    break;
                case 2://Nombres
                    filtro = x => x.Nombres.Contains(CriterioTextBox.Text);
                    break;
                case 3://NombreUsuario
                    filtro = x => x.NombreUsuario.Contains(CriterioTextBox.Text);
                    break;
                case 4://Cargo
                    filtro = x => x.Cargo.Contains(CriterioTextBox.Text);
                    break;
            }
            usuarios = BLL.UsuariosBLL.GetList(filtro);
            ConsultaDataGridView.DataSource = usuarios;
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            if(usuarios.Count == 0)
            {
                MessageBox.Show("No hay datos");
                return;
            }

            UsuariosReportForm usuariosReportForm = new UsuariosReportForm(usuarios);
            usuariosReportForm.ShowDialog();
        }
    }
}
