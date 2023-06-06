using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Net_2.GUI
{
    public partial class Adm_Stock : Form
    {
        public Adm_Stock()
        {
            InitializeComponent();
        }

        private void Adm_Stock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'carga_Grilla_Stock.STOCK' Puede moverla o quitarla según sea necesario.
            this.sTOCKTableAdapter.Fill(this.carga_Grilla_Stock.STOCK);
            // TODO: esta línea de código carga datos en la tabla 'cAR_MANAGERDataSet.STOCK' Puede moverla o quitarla según sea necesario.


        }
    }
}
