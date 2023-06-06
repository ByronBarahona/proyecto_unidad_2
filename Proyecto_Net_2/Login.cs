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

        private void IsvalidUser()
        {
            using (CAR_MANAGEREntities cm = new CAR_MANAGEREntities())
            {
                usr_sis us = new usr_sis();
                var q = from p in us.Login()
                        where p.log_usr = Txt_Usuario.Text
                        && p.pass_usr = Txt_Contraseña.Text
                        select p;
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

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por su preferencia");
            Application.Exit();
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Usuario.Text) || String.IsNullOrEmpty(Txt_Contraseña.Text))
            {
                MessageBox.Show("Los campos de usuario o contraseña se encuentran vacíos");

            }
            else
            {
                IsvalidUser();
            }

        }


    }

}

