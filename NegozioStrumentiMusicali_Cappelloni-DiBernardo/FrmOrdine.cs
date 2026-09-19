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
    /// Sviluppo e GUI: Leonardo Di Bernardo
    /// </summary>
    public partial class FrmOrdine : Form
    {
        private ClsStrumentoMusicale _strumento;
        long _negozioID = 0;
        public FrmOrdine(long idNegozio, ClsStrumentoMusicale strumento = null)
        {
            InitializeComponent();
            cbNazione.DataSource = Program._nazioni;
            if (strumento != null)
                _strumento = strumento;
            _negozioID = idNegozio;
            dtpDataOrdine.Value = DateTime.Now;
            dtpDataOrdine.Enabled = false;

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
            if (String.IsNullOrWhiteSpace(tbComune.Text) || String.IsNullOrWhiteSpace(tbVia.Text) || String.IsNullOrWhiteSpace(tbCodicePostale.Text) || String.IsNullOrWhiteSpace(cbNazione.Text))
                MessageBox.Show("Non tutti i campi dell'indirizzo sono inseriti", "CAMPI MANCANTI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ClsIndirizzo _indirizzo = new ClsIndirizzo();
                _indirizzo.ID = 0;
                _indirizzo.Comune = tbComune.Text;
                _indirizzo.Via = tbVia.Text;
                _indirizzo.CodicePostale = tbCodicePostale.Text;
                _indirizzo.Nazione = cbNazione.SelectedItem.ToString();
                _indirizzo.NumeroCivico = Convert.ToUInt16(nudCivico.Value);
                if (String.IsNullOrWhiteSpace(tbLetteraCivico.Text))
                    _indirizzo.LetteraCivico = null;
                else
                    _indirizzo.LetteraCivico = Convert.ToChar(tbLetteraCivico.Text);
                _indirizzo.EssereSede = null;
                _indirizzo.CasaProduttriceID = -1;

                string _comunicazione;

                ClsIndirizzo _ricercaIndirizzo = ClsIndirizzoBL.GetOneIndirizzo(Program._connectionString, _indirizzo.CodicePostale, _indirizzo.Comune, _indirizzo.Via, _indirizzo.NumeroCivico, _indirizzo.LetteraCivico, _indirizzo.Nazione, out _comunicazione);

                if (_ricercaIndirizzo == null)
                {
                    _indirizzo.ID = ClsIndirizzoBL.InsertIndirizzo(Program._connectionString, _indirizzo, out _comunicazione);
                    MessageBox.Show(_comunicazione, "INSERIMENTO INDIRIZZO NEL DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _indirizzo.ID = _ricercaIndirizzo.ID;
                }

                ClsOrdine _ordine = new ClsOrdine();
                _ordine.DataOra = DateTime.Now;
                _ordine.NegozioID = _negozioID;
                _ordine.IndirizzoID = _indirizzo.ID;
                _ordine.UsernameCliente = ClsArchivio.UtenteAttuale.Username;
                _ordine.Stato = ClsOrdine.eSTATO.non_visualizzato;

                _ordine.ID = ClsOrdineBL.InsertOrdine(Program._connectionString, _ordine, out _comunicazione);
                MessageBox.Show(_comunicazione, "INSERIMENTO ORDINE NEL DB", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (_strumento != null)
                {
                    ClsOrdineStrumento _ordineStrumento = new ClsOrdineStrumento();
                    _ordineStrumento.Quantita = 1;
                    _ordineStrumento.StrumentoMusicaleID = _strumento.ID;
                    _ordineStrumento.OrdineID = _ordine.ID;

                    _ordineStrumento.ID = ClsOrdineStrumentoBL.InsertOrdineStrumento(Program._connectionString, _ordineStrumento, out _comunicazione);
                }
                else
                {
                    foreach (ClsCarrello _elementoCarrello in FrmCarrello._listaElementiCarrello)
                    {
                        if (_elementoCarrello.Quantita > 0)
                        {
                            ClsOrdineStrumento _ordineStrumento = new ClsOrdineStrumento();
                            _ordineStrumento.Quantita = _elementoCarrello.Quantita;
                            _ordineStrumento.StrumentoMusicaleID = _elementoCarrello.StrumentoMusicale.ID;
                            _ordineStrumento.OrdineID = _ordine.ID;

                            _ordineStrumento.ID = ClsOrdineStrumentoBL.InsertOrdineStrumento(Program._connectionString, _ordineStrumento, out _comunicazione);
                        }
                    }
                    for (int i = ClsArchivio.ListCarrello.Count - 1; i >= 0; i--)      //foreach (ClsCarrello _carrello in ClsArchivio.ListCarrello)            
                    {                
                        if (ClsArchivio.ListCarrello[i].NegozioID == FrmCarrello._listaElementiCarrello[0].NegozioID)
                        {
                            ClsArchivio.ListCarrello.RemoveAt(i);
                        }
                    }
                }

                this.Close();
            }

        }
    }
}
