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
            // TODO: esta línea de código carga datos en la tabla 'cAR_MANAGERDataSet3.Comunas' Puede moverla o quitarla según sea necesario.
            this.comunasTableAdapter1.Fill(this.cAR_MANAGERDataSet3.Comunas);
            // TODO: esta línea de código carga datos en la tabla 'cAR_MANAGERDataSet2.region' Puede moverla o quitarla según sea necesario.
            this.regionTableAdapter1.Fill(this.cAR_MANAGERDataSet2.region);
            // TODO: esta línea de código carga datos en la tabla 'cAR_MANAGERDataSet1.Comunas' Puede moverla o quitarla según sea necesario.
            this.comunasTableAdapter.Fill(this.cAR_MANAGERDataSet1.Comunas);
            // TODO: esta línea de código carga datos en la tabla 'cAR_MANAGERDataSet.region' Puede moverla o quitarla según sea necesario.
            this.regionTableAdapter.Fill(this.cAR_MANAGERDataSet.region);

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
                    
                };
                CNC cont = new CNC()
                {
                    Nom_CNC = Txt_Nombre_CNC.Text,
                    Apell_CNC = Txt_Ape_CNC.Text,
                    ident_CNC = int.Parse (Txt_Ident.Text),
                    dvf_CNC = int.Parse(Txt_Dig_verificador_CNC.Text),
                    direccion_CNC = Txt_Direccion_CNC.Text,
                    comuna = Cbox_Comuna_CNC.SelectedIndex,
                    region = Cbox_Region_CNC.SelectedIndex,
                };

                cm.MARCAS_vhs.Add(M_Vhs);
                cm.CNC.Add(cont);
                cm.SaveChanges();

                MessageBox.Show("Se han registrado con exito los datos");
            }
        }

        private void Txt_Ident_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se ingresan números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Txt_Ident_CNC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se ingresan números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void Txt_Nombre_CNC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se ingresan valores alfabeticos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Txt_Ape_CNC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se ingresan valores alfabeticos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void Txt_Rso_social_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se ingresan valores alfabeticos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }
    }
}
