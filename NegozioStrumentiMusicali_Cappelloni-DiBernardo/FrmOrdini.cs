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
    /// Sviluppo: Di Bernardo Leonardo
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

        
        List<ClsNegozio> _negozi = new List<ClsNegozio>();  //creo la lista di negozio dove verranno inseriti tutti quelli correlati al username dell'utente che ha fatto l'accesso
        List<ClsOrdine> _listOrdini = new List<ClsOrdine>();
        long _negozioID = 0;

        public FrmOrdini()
        {
            InitializeComponent();
            List<ClsGestire> _listGestire = new List<ClsGestire>(); //creo una lista di gestire dove metto tutti i gestire presi in base al userneme di chi ha fatto l'accesso
            _listGestire = ClsArchivio.ListaGestireUtenteAttuale; //carico la lista di gestire dell'utente attuale che si trova su clsArchivio
            string _comunicazioneNegozi;
            foreach (ClsGestire gestire in _listGestire)   //foreach per inseire con un get one i negozi chi dell'utente che ha fatto l'accesso 
            {   
                _negozi.Add(ClsNegozioBL.GetOneNegozio(ref Program._connessioneAlDB, gestire.NegozioID, out _comunicazioneNegozi));
            }

            PopolaCombobox(cbNegozio, _negozi);

            




        }

        void PopolaCombobox(ComboBox comboBox, List<ClsNegozio> listaNegozi)
        {
            //Rimuovo tutti gli elementi dalla combobox
            comboBox.Items.Clear();

            //Scorro tutti gli elementi della lista
            {
                for (int i = 0; i < listaNegozi.Count; i++)
                {
                    comboBox.Items.Add(listaNegozi[i].Nome);
                    comboBox.SelectedIndex = i;
                }
            }
        }

        /// <summary>
        /// Popola una listview da una lista di ClsOrdini di un certo negozio
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="listaOrdini"></param>
        /// <param name="negozioID"></param>
        void PopolaListView(ListView listView, List<ClsOrdine> lista, long negozioID)
        {
            listView.Items.Clear();  //svuoto la listView

            if (lista != null)
            {
                foreach (ClsOrdine _ordine in lista)
                {
                    //Se l'ordine è presente nel negozio negozio lo aggiungo alla listview
                    listView.Items.Add(CreaListViewItem(_ordine));
                }
            }
        }

        /// <summary>
        /// Crea e popola un ListViewItem in base ad un istanza di ClsOrdini
        /// </summary>
        /// <param name="ordine"></param>
        /// <returns></returns>
        private ListViewItem CreaListViewItem(ClsOrdine ordine)
        {
            ListViewItem _lvi = new ListViewItem(ordine.UsernameCliente);
            
            _lvi.SubItems.Add(ordine.UsernameCliente);
            _lvi.SubItems.Add(ordine.DataOra.ToString());
            _lvi.SubItems.Add(ordine.ID.ToString());        
            _lvi.SubItems.Add(ordine.StrumentoMusicaleID.ToString());
            _lvi.SubItems.Add(ordine.Quantita.ToString());

            _lvi.Tag = ordine;

            return _lvi;
        }

        private void FrmOrdini_Load(object sender, EventArgs e)
        {
            string _comunicazioneOrdine;
            _listOrdini = ClsOrdineBL.GetSomeOrdini(Program._connectionString, _negozioID, -1, out _comunicazioneOrdine);
            PopolaListView(lvOrdini, _listOrdini, _negozioID);

            cbParametriDiOrdinamento.DataSource = Enum.GetNames(typeof(ePARAMETRI_DI_ORDINAMENTO));
            pnlDetail.Enabled = false;
        }

        private void cbNegozio_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbNegozio.SelectedIndex >= 0 && cbNegozio.SelectedIndex < _negozi.Count)
            {
                _negozioID = _negozi[cbNegozio.SelectedIndex].ID;

                // Recupera dal database solo gli ordini del negozio attualmente selezionato
                string _comunicazioneOrdine;
                _listOrdini = ClsOrdineBL.GetSomeOrdini(Program._connectionString, _negozioID, -1, out _comunicazioneOrdine);

                // Aggiorna la ListView con i nuovi dati
                PopolaListView(lvOrdini, _listOrdini, _negozioID);
            }
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
        }

        private void lvOrdini_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = lvOrdini.SelectedItems[0];

            // Recupero l’oggetto dal Tag
            ClsOrdine _ordine = (ClsOrdine)item.Tag;

            pnlDetail.Enabled = false;

            tbUsernameCliente.Text = _ordine.UsernameCliente;
            dtpDataOrdine.Value = _ordine.DataOra;
            nudIDOrdine.Value = _ordine.ID;
            nudIDArticolo.Value = _ordine.StrumentoMusicaleID;

            pnlDetail.Enabled = true;

        }
    }
}
