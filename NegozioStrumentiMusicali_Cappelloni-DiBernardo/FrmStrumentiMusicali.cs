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
    public partial class FrmStrumentiMusicali : Form
    {
        enum ePARAMETRO_DI_ORDINAMENTO
        {
            ID,
            Casa_produttrice,
            Modello,
            Prezzo,
            Quantita
        }

        public FrmStrumentiMusicali()
        {
            InitializeComponent();
        }

        private void FrmStrumentiMusicali_Load(object sender, EventArgs e)
        {
            cbParametriDiOrdinamento.DataSource = Enum.GetNames(typeof(ePARAMETRO_DI_ORDINAMENTO));
        }
    }
}
