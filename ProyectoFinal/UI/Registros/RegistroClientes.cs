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
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ClienteIdNumericUpDown.Value);
            Clientes clientes = BLL.ClientesBLL.Buscar(id);

            if (clientes != null)
            {
                ClienteIdNumericUpDown.Value = clientes.ClienteId;
                NombresTextBox.Text = clientes.Nombres;
                SexoComboBox.Text = clientes.Sexo;
                CedulaMaskedTextBox.Text = clientes.Cedula.ToString();
                FechaDateTimePicker.ResetText();
                DireccionTextBox.Text = clientes.Direccion;
                NumeroCelularMaskedTextBox.Text = clientes.NumeroCelular.ToString();

            }
            else
            {
                MessageBox.Show("no se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            GeneralErrorProvider.Clear();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            ClienteIdNumericUpDown.Value = 0;
            NombresTextBox.Clear();
            SexoComboBox.Text.ToString();
            CedulaMaskedTextBox.Clear();
            FechaDateTimePicker.ResetText();
            DireccionTextBox.Clear();
            NumeroCelularMaskedTextBox.Clear();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Clientes clientes = new Clientes();

            if(Validar())
            {
                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }

            GeneralErrorProvider.Clear();

            clientes = LlenarClase();

            if (ClienteIdNumericUpDown.Value == 0)
                paso = BLL.ClientesBLL.Guardar(clientes);
            else
            {
                int id = Convert.ToInt32(ClienteIdNumericUpDown.Value);
                Clientes clientesd = BLL.ClientesBLL.Buscar(id);

                //if(clientesd != null)
                //{
                    paso = BLL.ClientesBLL.Modificar(clientes);
                //}
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
            int id = Convert.ToInt32(ClienteIdNumericUpDown.Value);

            if (Validar())
            {
                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }

            if (BLL.ClientesBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("no se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private Clientes LlenarClase()
        {
            Clientes clientes = new Clientes();

            clientes.ClienteId = Convert.ToInt32(ClienteIdNumericUpDown.Value);
            clientes.Nombres = NombresTextBox.Text;
            clientes.Sexo = SexoComboBox.Text;
            clientes.Cedula = CedulaMaskedTextBox.Text;
            clientes.Fecha = DateTime.Now;// ojo
            clientes.Direccion = DireccionTextBox.Text;
            clientes.NumeroCelular = NumeroCelularMaskedTextBox.Text;

               return clientes;
               
        }

        private bool Validar()
        {
            bool Validar = false;

            if(string.IsNullOrWhiteSpace(NombresTextBox.Text))
            {
                GeneralErrorProvider.SetError(NombresTextBox, "Debes llenar este campo");
                Validar = true;
            }

            if(string.IsNullOrWhiteSpace(SexoComboBox.Text))// ojo cuando es combobox es .text preguntar
            {
                GeneralErrorProvider.SetError(SexoComboBox, "Debes llenar este campo");
                Validar = true;
            }

            if(string.IsNullOrWhiteSpace(CedulaMaskedTextBox.Text))
            {
                GeneralErrorProvider.SetError(CedulaMaskedTextBox, "Debes llenar este campo");
                Validar = true;
            }

            if(string.IsNullOrWhiteSpace(DireccionTextBox.Text))
            {
                GeneralErrorProvider.SetError(DireccionTextBox, "Debes llenar este campo");
                Validar = true;
            }

            if(string.IsNullOrWhiteSpace(NumeroCelularMaskedTextBox.Text))
            {
                GeneralErrorProvider.SetError(NumeroCelularMaskedTextBox, "Debes llenar este campo");
                Validar = true;
            }

            return Validar;
        }

        private void DireccionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
