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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            Usuarios usuarios = BLL.UsuariosBLL.Buscar(id);

            if(usuarios != null)
            {
                UsuarioIdNumericUpDown.Value = usuarios.UsuarioId;
                NombresTextBox.Text = usuarios.Nombres;
                NombreUsuarioTextBox.Text = usuarios.NombreUsuario;
                ClaveTextBox.Text = usuarios.Clave;
                CargosComboBox.Text = usuarios.Cargo;
            }
            else
            {
                MessageBox.Show("no se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            GeneralErrorProvider1.Clear();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            UsuarioIdNumericUpDown.Value = 0;
            NombresTextBox.Clear();
            NombreUsuarioTextBox.Clear();
            ClaveTextBox.Clear();
            CargosComboBox.Text.ToString();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Usuarios usuarios = new Usuarios();

            if (Validar())
            {
                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }

            GeneralErrorProvider1.Clear();

            usuarios = LlenarClase();

            if (UsuarioIdNumericUpDown.Value == 0)
                paso = BLL.UsuariosBLL.Guardar(usuarios);
            else
            {
                int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
                Usuarios usuariosd = BLL.UsuariosBLL.Buscar(id);

                if(usuariosd != null)
                {
                    paso = BLL.UsuariosBLL.Modificar(usuarios);
                }
                else
                    MessageBox.Show("No se pudo encontrar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (paso)
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);

            if (Validar())
            {
                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }

            if (BLL.UsuariosBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("no se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Usuarios LlenarClase()
        {
            Usuarios usuarios = new Usuarios();

            usuarios.UsuarioId = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            usuarios.Nombres = NombresTextBox.Text;
            usuarios.NombreUsuario = NombreUsuarioTextBox.Text;
            usuarios.Clave = ClaveTextBox.Text;
            usuarios.Cargo = CargosComboBox.Text;

            return usuarios;
        }

        private bool Validar()
        {
            bool Validar = false;

            if (string.IsNullOrWhiteSpace(NombresTextBox.Text))
            {
                GeneralErrorProvider.SetError(NombresTextBox, "Debes llenar este campo");
                Validar = true;
            }

            if (string.IsNullOrWhiteSpace(NombreUsuarioTextBox.Text))
            {
                GeneralErrorProvider.SetError(NombreUsuarioTextBox, "Debes llenar este campo");
                Validar = true;
            }

            if (string.IsNullOrWhiteSpace(ClaveTextBox.Text))
            {
                GeneralErrorProvider.SetError(ClaveTextBox, "Debes llenar este campo");
                Validar = true;
            }

            if (string.IsNullOrWhiteSpace(CargosComboBox.Text))
            {
                GeneralErrorProvider.SetError(CargosComboBox, "Debes Elegir una opcion");
                Validar = true;
            }

            return Validar;
        }

    }
}
