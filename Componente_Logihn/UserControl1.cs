using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componente_Logihn
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if ((txb_usuario.Text == "") && (txb_contraseña.Text == ""))
            {
                MessageBox.Show("Ingrese un usuario y/o contraseña valida");
            }
            else
            {
                if ((txb_usuario.Text == "Admin") && (txb_contraseña.Text == "root"))
            {
                    MessageBox.Show("Bienvenido");
                }
            else
                {
                    MessageBox.Show("Ingrese un usuario y/o contraseña valida");
                }
            }
            
        }
    }
}
