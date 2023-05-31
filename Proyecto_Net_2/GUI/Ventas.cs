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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cAR_MANAGERDataSet4.STOCK' Puede moverla o quitarla según sea necesario.
            this.sTOCKTableAdapter.Fill(this.cAR_MANAGERDataSet4.STOCK);
            // TODO: esta línea de código carga datos en la tabla 'cAR_MANAGERDataSet.region' Puede moverla o quitarla según sea necesario.
            //this.regionTableAdapter.Fill(this.cAR_MANAGERDataSet.region);

        }
    }
}
