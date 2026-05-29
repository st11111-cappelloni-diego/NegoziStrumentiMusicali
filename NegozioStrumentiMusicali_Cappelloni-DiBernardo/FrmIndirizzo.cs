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
    public partial class FrmIndirizzo : Form
    {
        Program.eMODALITA_ENTRATA_DETAIL _visualizzazione;
        public FrmIndirizzo(ClsIndirizzo indirizzo, Program.eMODALITA_ENTRATA_DETAIL modalitaVisualizzazione)
        {

            InitializeComponent();
            _visualizzazione = modalitaVisualizzazione;
            if(_visualizzazione == Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione)
            {
                pnlIndirizzo.Enabled = false;
                btnSalva.Text = "ESCI";

                tbCodicePostale.Text = indirizzo.CodicePostale;
                tbComune.Text = indirizzo.Comune;
                tbVia.Text = indirizzo.Via;
                tbNumeroCivico.Text = indirizzo.NumeroCivico.ToString();
                tbLetteraCivico.Text = indirizzo.LetteraCivico.ToString();
                cbNazione.SelectedItem = indirizzo.Nazione;
            }

        }

        private void FrmIndirizzo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (_visualizzazione == Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione)
            {
                
                this.Close();
            }
        }
    }
}
