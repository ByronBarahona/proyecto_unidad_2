using System;
using System.Windows.Forms;

namespace Proyecto_Net_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por su preferencia");
            Application.Exit();
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Usuario.Text) || String.IsNullOrEmpty(Txt_Contraseña.Text))
            {
                MessageBox.Show("Los campos de usuario o contraseña se encuentran vacios");
                
            }
            else
            {



            }
        }

    }
}
