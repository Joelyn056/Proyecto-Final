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
    public partial class ConsultaProductos : Form
    {
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
                case 0: //ProductoId
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = x => (x.ProductoId == id) && (x.FechaIngreso >= DesdedateTimePicker.Value.Date && x.FechaIngreso <= HastadateTimePicker.Value.Date);
                    break;

                case 1: //Descripcion
                    filtro = x => (x.Descripcion.Contains(CriterioTextBox.Text)) && (x.FechaIngreso >= DesdedateTimePicker.Value.Date && x.FechaIngreso <= HastadateTimePicker.Value.Date);
                    break;

                case 2: //Ganancia
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = x => (x.Ganancia == id) && (x.FechaIngreso >= DesdedateTimePicker.Value.Date && x.FechaIngreso <= HastadateTimePicker.Value.Date);
                    break;

                case 3: //Costo
                    filtro = x => (x.Costo.Equals(CriterioTextBox.Text)) && (x.FechaIngreso >= DesdedateTimePicker.Value.Date && x.FechaIngreso <= HastadateTimePicker.Value.Date);
                    break;

                case 4: //precio
                    filtro = x => (x.Precio.Equals(CriterioTextBox.Text)) && (x.FechaIngreso >= DesdedateTimePicker.Value.Date && x.FechaIngreso <= HastadateTimePicker.Value.Date); 
                    break;

                case 5: //Fecha ingreso
                    filtro = x => (x.FechaIngreso.Equals(CriterioTextBox.Text)) && (x.FechaIngreso >= DesdedateTimePicker.Value.Date && x.FechaIngreso <= HastadateTimePicker.Value.Date); 
                    break;

                case 6: //Inventario
                    filtro = x => (x.Inventario.Equals(CriterioTextBox.Text)) && (x.FechaIngreso >= DesdedateTimePicker.Value.Date && x.FechaIngreso <= HastadateTimePicker.Value.Date); 
                    break;

            }

            ConsultaDataGridView.DataSource = BLL.ProductosBLL.GetList(filtro);
        }
    }
}
