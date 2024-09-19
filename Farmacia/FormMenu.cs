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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            FormLogin formlong = new FormLogin();
            formlong.Show();
            this.Close();
        }

        private void btnCuentasMenu_Click(object sender, EventArgs e)
        {
            FormCuentas formCuent = new FormCuentas();
            formCuent.Show();
            this.Close();
        }
    }
}
