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
    public partial class FrmOrdine : Form
    {
        private ClsStrumentoMusicale _strumento;
        long _negozioID = 0;
        public FrmOrdine(ClsStrumentoMusicale strumento, long idNegozio)
        {
            InitializeComponent();
            cbNazione.DataSource = Program._nazioni;
            _strumento = strumento;
            _negozioID = idNegozio;
            dtpDataOrdine.Value = DateTime.Now;
            dtpDataOrdine.Enabled = false;
            nudIDArticolo.Value = _strumento.ID;
            nudIDArticolo.Enabled = false;

        }

        private void FrmOrdine_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _comunicazione;
            FrmNegozio _negozio = new FrmNegozio(ClsNegozioBL.GetOneNegozio(ref Program._connessioneAlDB, _negozioID, out _comunicazione), Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione);
            _negozio.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {

            /*
            ClsIndirizzo _indirizzo = new ClsIndirizzo();
            _indirizzo.ID = 0;
            _indirizzo.Comune = tbComune.Text;
            _indirizzo.Via = tbVia.Text;
            _indirizzo.CodicePostale = tbCodicePostale.Text;
            _indirizzo.Nazione = cbNazione.SelectedItem.ToString();
            _indirizzo.NumeroCivico = Convert.ToUInt16(nudCivico.Value);
            _indirizzo.LetteraCivico = Convert.ToChar(tbLetteraCivico.Text);
            _indirizzo.EssereSede = false;
            _indirizzo.CasaProduttriceID = 0;

            string _comunicazione;
            ClsIndirizzoBL.InsertIndirizzo(ref Program._connessioneAlDB, _indirizzo, out _comunicazione);
            */
        }
    }
}
