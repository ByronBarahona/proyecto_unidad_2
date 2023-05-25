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
            // TODO: esta línea de código carga datos en la tabla 'cAR_MANAGERDataSet3.Comunas' Puede moverla o quitarla según sea necesario.
            this.comunasTableAdapter.Fill(this.cAR_MANAGERDataSet3.Comunas);
            // TODO: esta línea de código carga datos en la tabla 'cAR_MANAGERDataSet2.region' Puede moverla o quitarla según sea necesario.
            this.regionTableAdapter.Fill(this.cAR_MANAGERDataSet2.region);
            // TODO: esta línea de código carga datos en la tabla 'cAR_MANAGERDataSet1.Comunas' Puede moverla o quitarla según sea necesario.
            

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
