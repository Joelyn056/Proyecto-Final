using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Entidades;
using System.Threading.Tasks;
using System.Linq.Expressions;
using ProyectoFinal.Reportes;

namespace ProyectoFinal.UI.Consultas
{
    public partial class ConsultaFacturas : Form
    {
        private List<Facturas> facturas = new List<Facturas>();

        public ConsultaFacturas()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Expression<Func<Facturas, bool>> filtro = x => true;

            int id;
            switch(FiltrarComboBox.SelectedIndex)
            {
                case 0://Todo
                    break;

                case 1: // FacturaId
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = x => (x.FacturaId == id) && (x.Fecha >= DesdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                    break;

                //case 1: //Nombre cliente
                //    filtro = x => (x.NombreCliente.Contains(CriterioTextBox.Text)) && (x.Fecha >= DesdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                //    break;

                //case 2: //comentario
                //    filtro = x => (x.Comentario.Contains(CriterioTextBox.Text)) && (x.Fecha >= DesdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                //    break;

                case 2: //Fecha
                    filtro = x => (x.Fecha.Equals(CriterioTextBox.Text)) && (x.Fecha >= DesdedateTimePicker.Value.Date && x.Fecha <= HastadateTimePicker.Value.Date);
                    break;

            }

            facturas = BLL.FacturasBLL.GetList(filtro);
            ConsultaDataGridView.DataSource = facturas;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (facturas.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FacturaReportForm  facturaReportForm = new FacturaReportForm(facturas);
            facturaReportForm.ShowDialog();

        }
    }
}
