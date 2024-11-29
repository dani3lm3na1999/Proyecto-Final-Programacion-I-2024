using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaApp.Autenticacion
{
    public partial class Login : Form
    {
        // Variable global
        public bool autorizado = false;

        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (txtUsuario.Text.Equals("frank") && txtContraseña.Text.Equals("123"))
                {
                    autorizado = true;
                    this.Close();
                }
                else
                {
                    // Mostrar un mensaje de que el usuario o la contraseña son incorrectos
                    MessageBox.Show("El usuario o la contraseña son incorrectos", "Tienda|App",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar un mensaje de que el usuario y la contraseña son requeridos
                // MessageBox -> Console.Writeline
                MessageBox.Show("El usuario y la contraseña son requeridos", "Tienda|App",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidarCampos()
        {
            bool resultado = false;

            if (!string.IsNullOrEmpty(txtUsuario.Text) || !string.IsNullOrEmpty(txtContraseña.Text))
            {
                resultado = true;
            }

            return resultado;
        }


    }
}
