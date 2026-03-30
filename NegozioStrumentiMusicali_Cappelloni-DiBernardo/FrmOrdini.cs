using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegozioStrumentiMusicali
{
    /// <summary>
    /// GUI: Diego Cappelloni
    /// </summary>
    public partial class FrmOrdini : Form
    {
        public enum ePARAMETRI_DI_ORDINAMENTO
        {
            Username_cliente,
            Data,
            ID_ordine,
            ID_articolo,
            Quantità
        }

        public FrmOrdini()
        {
            InitializeComponent();
        }

        private void FrmOrdini_Load(object sender, EventArgs e)
        {
            cbParametriDiOrdinamento.DataSource = Enum.GetNames(typeof(ePARAMETRI_DI_ORDINAMENTO));
        }
    }
}
