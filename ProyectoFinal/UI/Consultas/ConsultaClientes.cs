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
    public partial class ConsultaClientes : Form
    {
        private List<Clientes> clientes = new List<Clientes>();

        public ConsultaClientes()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Expression<Func<Clientes, bool>> filtro = x => true;

            int id;
            switch (FiltrarComboBox.SelectedIndex)
            {
                case 0://Todo
                    break;

                case 1: //ClienteId
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = x => (x.ClienteId == id) && (x.Fecha >= DesdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                    break;

                case 2: //Nombres
                    filtro = x => (x.Nombres.Contains(CriterioTextBox.Text)) && (x.Fecha >= DesdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                    break;

                case 3: //Sexo
                    filtro = x => (x.Sexo.Contains(CriterioTextBox.Text)) && (x.Fecha >= DesdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                    break;

                case 4: //Cedula
                    filtro = x => (x.Cedula.Equals(CriterioTextBox.Text)) && (x.Fecha >= DesdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                    break;

                case 5: //Direccion
                    filtro = x => (x.Direccion.Contains(CriterioTextBox.Text)) && (x.Fecha >= DesdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                    break;

                case 6: //Numero Celular
                    filtro = x => (x.NumeroCelular.Equals(CriterioTextBox.Text)) && (x.Fecha >= DesdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                    break;
            }
            clientes = BLL.ClientesBLL.GetList(filtro);
            ConsultaDataGridView.DataSource = clientes;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if(clientes.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClienteReportForm clienteReportForm = new ClienteReportForm(clientes);
            clienteReportForm.ShowDialog();

        }
    }
}


