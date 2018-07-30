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


namespace ProyectoFinal.UI.Consultas
{
    public partial class ConsultaUsuario : Form
    {
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
                case 0://UsuarioId
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = x => (x.UsuarioId == id);
                    break;
                case 1://Nombres
                    filtro = x => x.Nombres.Contains(CriterioTextBox.Text);
                    break;
                case 2://NombreUsuario
                    filtro = x => x.NombreUsuario.Contains(CriterioTextBox.Text);
                    break;
                case 3://Cargo
                    filtro = x => x.Cargo.Contains(CriterioTextBox.Text);
                    break;
            }

            ConsultaDataGridView.DataSource = BLL.UsuariosBLL.GetList(filtro);
        }
    }
}
