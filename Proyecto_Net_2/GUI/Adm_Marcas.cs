using Proyecto_Net_2.Model;
using System.Windows.Forms;

namespace Proyecto_Net_2.GUI
{
    public partial class Adm_Marcas : Form
    {
        public Adm_Marcas()
        {
            InitializeComponent();
        }


        private void Adm_Marcas_Load(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Guardar_Click(object sender, System.EventArgs e)
        {
            using (CAR_MANAGER_Entities cm = new CAR_MANAGER_Entities()) 
            {
                MARCAS_vhs M_Vhs = new MARCAS_vhs()
                {
                    Nombre_MARCA = Txt_Rso_social.Text,
                    RUT_MARCA = int.Parse(Txt_Ident.Text),
                    Dv_marca = int.Parse(Txt_Dig_Veri.Text),
                    comuna = Cbox_Comuna.SelectedIndex,
                    region = Cbox_Region.SelectedIndex,
                    direccion = Txt_Direccion.Text,
                    tip_Vhs_Cam = ,


                };
            }
        }
    }
}
