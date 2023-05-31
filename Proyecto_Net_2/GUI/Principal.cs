using System.Windows.Forms;

namespace Proyecto_Net_2.GUI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Btn_Adm_Marca_Click(object sender, System.EventArgs e)
        {
            Hide();
            Adm_Marcas admM = new Adm_Marcas();
            admM.Show();
        }

        private void Adm_Stock_Click(object sender, System.EventArgs e)
        {
            Hide();
            Adm_Stock admStock = new Adm_Stock();
            admStock.Show();
        }

        private void Btn_Ventas_Click(object sender, System.EventArgs e)
        {
            Hide();
            Ventas vent = new Ventas();
            vent.Show();
        }
    }
}
