using Proyecto_Net_2.Model;
using System;
using System.Drawing.Text;
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

        }
        private bool IsvalidUser(string log_usr, string pass_usr)
        {
            CAR_MANAGER_Entities cm = new CAR_MANAGER_Entities();
            var q = from x in cm.usr_sis
                    where x.log_usr == Txt_Usuario.Text
                    && x.pass_usr == Txt_Contraseña.Text
                    select  x;
            if (q.Any())
            {
                return true;
            }
            else
            {
                return false;   
            }
        }

    }
}
