using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace ProyectoFinal.UI.Registros
{
    public partial class RegistroProductos : Form
    {
        public RegistroProductos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ProductoIdNumericUpDown.Value);
            Productos productos = BLL.ProductosBLL.Buscar(id);

            if(productos !=null)
            {
                ProductoIdNumericUpDown.Value = productos.ProductoId;
                DescripcionTextBox.Text = productos.Descripcion;
                GananciaNumericUpDown.Value = Convert.ToDecimal(productos.Ganancia);
                CostoNumericUpDown.Value = Convert.ToDecimal(productos.Costo);
                PrecioNumericUpDown.Value = Convert.ToDecimal(productos.Precio);
                FechaIngresoDateTimePicker.ResetText();
                InventarioNumericUpDown.Value = Convert.ToDecimal(productos.Inventario);
            }
            else
            {
                MessageBox.Show("no se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            GeneralErrorProvider1.Clear();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            ProductoIdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
            GananciaNumericUpDown.Value = 0;
            CostoNumericUpDown.Value = 0;
            PrecioNumericUpDown.Value = 0;
            FechaIngresoDateTimePicker.ResetText();
            InventarioNumericUpDown.Value = 0;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Productos productos = new Productos();

            if(Validar())
            {
                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }

            GeneralErrorProvider1.Clear();

            productos = LlenarClase();

            if (ProductoIdNumericUpDown.Value == 0)
                paso = BLL.ProductosBLL.Guardar(productos);
            else
            {
                int id = Convert.ToInt32(ProductoIdNumericUpDown.Value);
                Productos productosd = BLL.ProductosBLL.Buscar(id);

                if (productosd != null)
                {
                    paso = BLL.ProductosBLL.Modificar(productos);
                }
                //else
                //    MessageBox.Show("No se pudo encontrar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (paso)
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ProductoIdNumericUpDown.Value);

            if(BLL.ProductosBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("no se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Productos LlenarClase()
        {
            Productos productos = new Productos();

            productos.ProductoId = Convert.ToInt32(ProductoIdNumericUpDown.Value);
            productos.Descripcion = DescripcionTextBox.Text;
            productos.Ganancia = Convert.ToInt32(GananciaNumericUpDown.Value);
            productos.Costo = Convert.ToInt32(CostoNumericUpDown.Value);
            productos.Precio = Convert.ToInt32(PrecioNumericUpDown.Value);
            productos.FechaIngreso = DateTime.Now;
            productos.Inventario = Convert.ToInt32(InventarioNumericUpDown.Value);

            return productos;
        }

        private bool Validar()
        {
            bool Validar = false;

            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                GeneralErrorProvider.SetError(DescripcionTextBox, "Debes llenar este campo");
                Validar = true;
            }

            return Validar;
        }

        private void GananciaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if(GananciaNumericUpDown.Value != 0)
            {
                PrecioNumericUpDown.Value = CostoNumericUpDown.Value + GananciaNumericUpDown.Value;
            }
        }
    }
}
