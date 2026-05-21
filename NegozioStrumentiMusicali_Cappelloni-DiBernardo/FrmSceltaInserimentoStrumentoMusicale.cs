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
    /// GUI e Sviluppo: Diego Cappelloni. Questa form esiste perchè un gestore del negozio potrebbe voler aggiungere uno strumento già esistente al negozio. Inoltre solo gli admin software possono creare un nuovo strumento
    /// </summary>
    public partial class FrmSceltaInserimentoStrumentoMusicale : Form
    {
        #region Variabili
        private ClsStrumentoMusicale _strumentoMusicale = new ClsStrumentoMusicale();
        private ClsVendere _vendereStrumentoMusicale = new ClsVendere();
        private long _idNegozioSelezionato;
        private bool _utenteGestisceNegozio = false;

        #endregion
        #region Proprietà
        public ClsStrumentoMusicale StrumentoMusicale { get => _strumentoMusicale; set => _strumentoMusicale = value; }
        public ClsVendere VendereStrumentoMusicale { get => _vendereStrumentoMusicale; set => _vendereStrumentoMusicale = value; }
        public long IDNegozioSelezionato { get => _idNegozioSelezionato; set => _idNegozioSelezionato = value; }
        public bool UtenteGestisceNegozio { get => _utenteGestisceNegozio; set => _utenteGestisceNegozio = value; }

        #endregion
        #region Metodi della form
        /// <summary>
        /// Crea e popola un ListViewItem in base ad un istanza di ClsStrumentoMusicale
        /// </summary>
        /// <param name="strumento"></param>      
        /// <returns></returns>
        private ListViewItem CreaListViewItem(ClsStrumentoMusicale strumento)
        {
            string _temp;

            //Tipo dello strumento
            string _tipoStrumento = String.Empty;
            switch (strumento)
            {
                case ClsBatteria b:
                    _tipoStrumento = "Batteria";
                    break;
                case ClsLegno l:
                    _tipoStrumento = "Legno";
                    break;
                case ClsOttone o:
                    _tipoStrumento = "Ottone";
                    break;
                case ClsPianoforte p:
                    _tipoStrumento = "Pianoforte";
                    break;
                case ClsStrumentoACorda c:
                    _tipoStrumento = "Strumento a corda";
                    break;
                default:
                    _tipoStrumento = "Strumento musicale";
                    break;
            }
            ListViewItem _lvi = new ListViewItem(_tipoStrumento);

            _lvi.SubItems.Add(strumento.ID.ToString());

            //Casa produttrice: Prendo il nome dal DataBase in un processo separato
            ClsCasaProduttrice _casaProduttrice = new ClsCasaProduttrice();
            _casaProduttrice = ClsCasaProduttriceBL.GetOneCasaProduttrice
            (
                Program._connectionString,
                strumento.CasaProduttriceID,
                out _temp
            );

            _lvi.SubItems.Add(_casaProduttrice.Nome);
            _lvi.SubItems.Add(strumento.Modello);
            _lvi.SubItems.Add(strumento.Colori);

            _lvi.Tag = strumento;

            return _lvi;
        }
        /// <summary>
        /// Crea una lista di ListViewItem da una lista di ClsStrumentoACorda
        /// </summary>
        /// <param name="listaStrumentiACorda"></param>  
        List<ListViewItem> CreaListViewItems(List<ClsStrumentoACorda> listaStrumentiACorda)
        {
            List<ListViewItem> _lviList = new List<ListViewItem>();

            //Scorro tutta la lista se non è nulla
            if (listaStrumentiACorda != null)
            {
                foreach (ClsStrumentoACorda strumentoACorda in listaStrumentiACorda)
                {
                    _lviList.Add(CreaListViewItem(strumentoACorda));
                }
            }

            return _lviList;
        }
        /// <summary>
        /// Crea una lista di ListViewItem da una lista di ClsOttone
        /// </summary>
        /// <param name="listaOttoni"></param>    
        List<ListViewItem> CreaListViewItems(List<ClsOttone> listaOttoni)
        {
            List<ListViewItem> _lviList = new List<ListViewItem>();

            //Scorro tutta la lista se non è nulla
            if (listaOttoni != null)
            {
                foreach (ClsOttone ottone in listaOttoni)
                {
                    _lviList.Add(CreaListViewItem(ottone));
                }
            }

            return _lviList;
        }
        /// <summary>
        /// Crea una lista di ListViewItem da una lista di ClsLegno
        /// </summary>
        /// <param name="listaLegni"></param>
        List<ListViewItem> CreaListViewItems(List<ClsLegno> listaLegni)
        {
            List<ListViewItem> _lviList = new List<ListViewItem>();

            //Scorro tutta la lista se non è nulla
            if (listaLegni != null)
            {
                foreach (ClsLegno legno in listaLegni)
                {
                    _lviList.Add(CreaListViewItem(legno));
                }
            }

            return _lviList;
        }
        /// <summary>
        /// Crea una lista di ListViewItem da una lista di ClsPianoforte
        /// </summary>
        /// <param name="listaPianoforti"></param>    
        List<ListViewItem> CreaListViewItems(List<ClsPianoforte> listaPianoforti)
        {
            List<ListViewItem> _lviList = new List<ListViewItem>();

            //Scorro tutta la lista se non è nulla
            if (listaPianoforti != null)
            {
                foreach (ClsPianoforte pianoforte in listaPianoforti)
                {
                    _lviList.Add(CreaListViewItem(pianoforte));
                }
            }

            return _lviList;
        }
        /// <summary>
        /// Crea una lista di ListViewItem da una lista di ClsBatterie
        /// </summary>
        /// <param name="listaLegni"></param>  
        List<ListViewItem> CreaListViewItems(List<ClsBatteria> listaBatterie)
        {
            List<ListViewItem> _lviList = new List<ListViewItem>();

            //Scorro tutta la lista se non è nulla
            if (listaBatterie != null)
            {
                foreach (ClsBatteria batteria in listaBatterie)
                {
                    _lviList.Add(CreaListViewItem(batteria));
                }
            }

            return _lviList;
        }
        /// <summary>
        /// Popola una listview con le liste degli strumenti, ogni lista in un processo separato
        /// </summary>
        /// <param name="listView"></param>
        async void PopolaListView(ListView listView, List<ClsStrumentoACorda> listaStrumentiACorda,
            List<ClsPianoforte> listaPianoforti, List<ClsOttone> listaOttoni, List<ClsLegno> listaLegni, List<ClsBatteria> listaBatterie)
        {
            listView.Items.Clear();
            List<ListViewItem> _lviListStrumentiACorda = new List<ListViewItem>();
            List<ListViewItem> _lviListPianoforti = new List<ListViewItem>();
            List<ListViewItem> _lviListOttoni = new List<ListViewItem>();
            List<ListViewItem> _lviListLegni = new List<ListViewItem>();
            List<ListViewItem> _lviListBatterie = new List<ListViewItem>();

            //Trovo le liste di lvi di ogni tipo di strumento su dei processi separati
            await Task.WhenAll
            (
                Task.Run(() =>
                    _lviListStrumentiACorda =
                    CreaListViewItems(
                        listaStrumentiACorda
                    )
                ),
                Task.Run(() =>
                    _lviListPianoforti =
                    CreaListViewItems(
                        listaPianoforti
                    )
                ),
                Task.Run(() =>
                    _lviListOttoni =
                    CreaListViewItems(
                        listaOttoni
                    )
                ),
                Task.Run(() =>
                    _lviListLegni =
                    CreaListViewItems(
                        listaLegni
                    )
                ),
                Task.Run(() =>
                    _lviListBatterie =
                    CreaListViewItems(
                        listaBatterie
                    )
                )
            );

            //Li aggiungo alla listview
            listView.Items.AddRange(_lviListStrumentiACorda.ToArray());
            listView.Items.AddRange(_lviListPianoforti.ToArray());
            listView.Items.AddRange(_lviListOttoni.ToArray());
            listView.Items.AddRange(_lviListLegni.ToArray());
            listView.Items.AddRange(_lviListBatterie.ToArray());
        }

        #endregion
        public FrmSceltaInserimentoStrumentoMusicale()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            nudPrezzo.Maximum = 9999999999.00m;
            nudPrezzo.Minimum = 0.01m;
            nudQuantita.Minimum = 0;
            nudQuantita.Maximum = 9999999999;
        }


        private void FrmSceltaInserimentoStrumentoMusicale_Load(object sender, EventArgs e)
        {
            //Popolo la listview con gli strumenti caricati all'avvio dell'applicazione
            PopolaListView(lvStrumentiMusicali, ClsArchivio.StrumentiACorda,
                ClsArchivio.Pianoforti, ClsArchivio.Ottoni, ClsArchivio.Legni, ClsArchivio.Batterie);

            //Oscuro delle scelte in base a se l'utente gestisce o no il negozio selezionato
            if(UtenteGestisceNegozio)
            {
                pnlAggiungiStrumentoEsistente.Enabled = true;
            }
            else
            {
                pnlAggiungiStrumentoEsistente.Enabled = false;
            }

            //Oscuro delle scelte in base a se l'utente è admin software o no
            if(ClsArchivio.UtenteAttuale.AdminSoftware)
            {
                btnNuovoStrumento.Enabled = true;
            }
            else
            {
                btnNuovoStrumento.Enabled = false;
            }
        }

        private void btnNuovoStrumento_Click(object sender, EventArgs e)
        {
            //Istanzio la form detail di strumenti musicali
            FrmStrumentoMusicale _frmStrumentoMusicale = new FrmStrumentoMusicale();

            //Istanzio ClsStrumentoMusicale e ClsVendere nelle form
            StrumentoMusicale = new ClsStrumentoMusicale();
            _frmStrumentoMusicale.StrumentoMusicale = StrumentoMusicale;
            VendereStrumentoMusicale = new ClsVendere();
            VendereStrumentoMusicale.NegozioID = IDNegozioSelezionato;
            _frmStrumentoMusicale.VendereStrumentoMusicale = VendereStrumentoMusicale;

            //Disabilito prezzo e quantità se l'utente non gestisce il negozio selezionato
            if(UtenteGestisceNegozio == false)
            {
                _frmStrumentoMusicale.NudPrezzo.Enabled = false;
                _frmStrumentoMusicale.NudQuantita.Enabled = false;
            }
            else
            {
                _frmStrumentoMusicale.NudPrezzo.Enabled = true;
                _frmStrumentoMusicale.NudQuantita.Enabled = true;
            }

            //Apro la form in modalità inserimento
            _frmStrumentoMusicale.ModalitaEntrata = Program.eMODALITA_ENTRATA_DETAIL.Inserimento;
            _frmStrumentoMusicale.ShowDialog(this);
        }
    }
}
