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
using ProyectoFinal.UI;

namespace ProyectoFinal.UI.Login
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }

        
        private void IniciarSesionbutton_Click(object sender, EventArgs e)
        {

            //foreach(Usuarios usu in UsuariosBLL.GetList())
            //{
            //    if(usu.NombreUsuario.Equals(UsuariotextBox.Text)) &&
            //            usu.Clave.Equals(ClavetextBox.Text))
            //    {

            //        Menu inicio = new Menu();
            //        inicio.Show();
            //        this.Hide();
            //    }
            //}

            //MessageBox.Show("Este usuario no existe");

            if ((UsuariotextBox.Text != "") && (ClavetextBox.Text != ""))
            {
                if ((UsuariotextBox.Text == "Admin") && (ClavetextBox.Text == "123"))
                {
                    Menu inicio = new Menu();
                    inicio.Show();
                    this.Hide();
                }
            }


            if (Validar())
            {
                MessageBox.Show("llenar los campos");
                return;
            }


        }

        private bool Validar()
        {
            bool Validar = false;

            if (string.IsNullOrWhiteSpace(UsuariotextBox.Text))
            {
                UsuarioerrorProvider.SetError(UsuariotextBox, "Debes ingresar el Usuario");
                Validar = true;
            }

            if (string.IsNullOrWhiteSpace(ClavetextBox.Text))
            {
                ClaveerrorProvider.SetError(ClavetextBox, "Debes ingresar la contrasena");
                Validar = true;
            }

            return Validar;
        }

        private void Salirbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
