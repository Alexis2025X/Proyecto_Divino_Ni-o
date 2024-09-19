using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "Admin" && textContraseña.Text == "123")
            {

                textUsuario.Text = "";
                textContraseña.Text = "";
                //this.Hide();
                //this.Close();

                FormMenu form2 = new FormMenu();
                // Cierra el formulario de inicio de sesión
                form2.Show();

            }
            else
            {

                //Por ahora no hay nada
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
