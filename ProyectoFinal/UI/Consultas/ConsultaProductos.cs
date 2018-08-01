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
    public partial class ConsultaProductos : Form
    {
        private List<Productos> productos = new List<Productos>();

        public ConsultaProductos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Expression<Func<Productos, bool>> filtro = x => true;

            int id;
            switch(FiltrarComboBox.SelectedIndex)
            {
                case 0://Todo
                    break;

                case 1: //ProductoId
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = x => (x.ProductoId == id) && (x.FechaIngreso >= DesdedateTimePicker.Value.Date && x.FechaIngreso <= HastadateTimePicker.Value.Date);
                    break;

                case 2: //Descripcion
                    filtro = x => (x.Descripcion.Contains(CriterioTextBox.Text)) && (x.FechaIngreso >= DesdedateTimePicker.Value.Date && x.FechaIngreso <= HastadateTimePicker.Value.Date);
                    break;

                case 3: //Ganancia
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = x => (x.Ganancia == id) && (x.FechaIngreso >= DesdedateTimePicker.Value.Date && x.FechaIngreso <= HastadateTimePicker.Value.Date);
                    break;
                    
                case 4: //Costo
                    filtro = x => (x.Costo.Equals(CriterioTextBox.Text)) && (x.FechaIngreso >= DesdedateTimePicker.Value.Date && x.FechaIngreso <= HastadateTimePicker.Value.Date);
                    break;

                case 5: //precio
                    filtro = x => (x.Precio.Equals(CriterioTextBox.Text)) && (x.FechaIngreso >= DesdedateTimePicker.Value.Date && x.FechaIngreso <= HastadateTimePicker.Value.Date); 
                    break;

                case 6: //Fecha ingreso
                    filtro = x => (x.FechaIngreso.Equals(CriterioTextBox.Text)) && (x.FechaIngreso >= DesdedateTimePicker.Value.Date && x.FechaIngreso <= HastadateTimePicker.Value.Date); 
                    break;

                case 7: //Inventario
                    filtro = x => (x.Inventario.Equals(CriterioTextBox.Text)) && (x.FechaIngreso >= DesdedateTimePicker.Value.Date && x.FechaIngreso <= HastadateTimePicker.Value.Date); 
                    break;

            }
            productos = BLL.ProductosBLL.GetList(filtro);
            ConsultaDataGridView.DataSource = productos;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if(productos.Count == 0)
            {
                MessageBox.Show("No Hay Datos");
                return;
            }

            ProductoReportForm productoReportForm = new ProductoReportForm(productos);
            productoReportForm.ShowDialog();
        }
    }
}
