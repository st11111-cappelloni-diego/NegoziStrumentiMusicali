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
    /// GUI e Sviluppo: Leonardo Di Bernardo
    /// </summary>
    public partial class FrmNegozio : Form
    {
        Program.eMODALITA_ENTRATA_DETAIL _visualizzazione;
        public FrmNegozio(ClsNegozio negozio, Program.eMODALITA_ENTRATA_DETAIL entrataVisualizzazione)
        {
            _visualizzazione = entrataVisualizzazione;
            InitializeComponent();
            if (_visualizzazione == Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione)
            {
                //prendo l'indirizzo tramite l'ID del negozio
                string _comunicazione;
                ClsIndirizzo _indirizzoNegozio = ClsIndirizzoBL.GetOneIndirizzo(ref Program._connessioneAlDB, negozio.IndirizzoID, out _comunicazione);


                tbNome.Text = negozio.Nome;
                nudID.Value = negozio.ID;
                tbComune.Text = _indirizzoNegozio.Comune;
                tbVia.Text = _indirizzoNegozio.Via;
                tbCap.Text = _indirizzoNegozio.CodicePostale.ToString();
                if (negozio.Bandito == true)
                {
                    ckbBandito.Checked = true;
                }
                btnSalva.Text = "ESCI";
                pnlDetail.Enabled = false;

                this.MaximizeBox = false;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }

        private void FrmNegozio_Load(object sender, EventArgs e)
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
