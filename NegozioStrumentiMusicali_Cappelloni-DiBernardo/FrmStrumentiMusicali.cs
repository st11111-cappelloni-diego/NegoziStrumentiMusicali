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
    /// GUI e Sviluppo: Diego Cappelloni
    /// </summary>
    public partial class FrmStrumentiMusicali : Form
    {
        #region Enumeratori
        enum ePARAMETRO_DI_ORDINAMENTO
        {
            ID,
            Casa_produttrice,
            Modello,
            Prezzo,
            Quantita
        }

        #endregion

        #region Metodi della form
        /// <summary>
        /// Crea e popola un ListViewItem in base ad un istanza di ClsStrumentoMusicale
        /// </summary>
        /// <param name="strumento"></param>
        /// <param name="vendereStrumento">Per estrarre informazioni che cambiano in base al negozio</param>
        /// <returns></returns>
        private ListViewItem CreaListViewItem(ClsStrumentoMusicale strumento, ClsVendere vendereStrumento)
        {
            string _temp;

            ListViewItem _lvi = new ListViewItem(strumento.ID.ToString());
            //Casa produttrice: Prendo il nome dal DataBase in un processo separato
            ClsCasaProduttrice _casaProduttrice = new ClsCasaProduttrice();
            Task.Run
            (() =>            
                _casaProduttrice = ClsCasaProduttriceBL.GetOneCasaProduttrice
                (
                    ref Program._connessioneAlDB, 
                    strumento.CasaProduttriceID,
                    out _temp
                )
            );
            _lvi.SubItems.Add(_casaProduttrice.Nome);
            _lvi.SubItems.Add(strumento.Modello);
            _lvi.SubItems.Add(strumento.Colori);
            //Consulto la vendere per prezzo e quantità           
            _lvi.SubItems.Add(vendereStrumento.Prezzo.ToString());
            _lvi.SubItems.Add(vendereStrumento.Quantita.ToString());

            _lvi.Tag = strumento;

            return _lvi;
        }
        /// <summary>
        /// Popola una listview da una lista di ClsStrumentoACorda di un certo negozio
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="listaPianoforti"></param>
        /// <param name="negozioID"></param>
        /// <param name="clearInTesta">True = elimina tutti gli elementi della listview prima di aggiungerne dei nuovi</param>
        void PopolaListView(ListView listView, List<ClsStrumentoACorda> listaStrumentiACorda, long negozioID, bool clearInTesta)
        {
            if(clearInTesta)
            {
                listView.Items.Clear();
            }

            //Trovo tutte le vendere del negozio in un processo separato
            List<ClsVendere> _vendereNegozio = new List<ClsVendere>();
            string _temp = String.Empty;
            Task.Run
            (() =>
                _vendereNegozio = ClsVendereBL.GetSomeVendere(ref Program._connessioneAlDB, negozioID, -1, out _temp)
            );

            //Scorro tutta la lista non è nulla
            if(listaStrumentiACorda != null)
            {
                foreach (ClsStrumentoACorda strumentoACorda in listaStrumentiACorda)
                {
                    //Aggiungo lo strumento alla listview solo se è venduto dal negozio specificato
                    ClsVendere _vendereStrumento = _vendereNegozio.FirstOrDefault(v => v.StrumentoMusicaleID == strumentoACorda.ID);

                    if (_vendereStrumento != null)
                    {
                        //Se lo strumento è venduto dal negozio lo aggiungo alla listview
                        listView.Items.Add(CreaListViewItem(strumentoACorda, _vendereStrumento));
                    }
                }
            }
        }
        /// <summary>
        /// Popola una listview da una lista di ClsOttone di un certo negozio
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="listaOttoni"></param>
        /// <param name="negozioID"></param>
        /// <param name="clearInTesta">True = elimina tutti gli elementi della listview prima di aggiungerne dei nuovi</param>
        void PopolaListView(ListView listView, List<ClsOttone> listaOttoni, long negozioID, bool clearInTesta)
        {
            if (clearInTesta)
            {
                listView.Items.Clear();
            }

            //Trovo tutte le vendere del negozio in un processo separato
            List<ClsVendere> _vendereNegozio = new List<ClsVendere>();
            string _temp = String.Empty;
            Task.Run
            (() =>
                _vendereNegozio = ClsVendereBL.GetSomeVendere(ref Program._connessioneAlDB, negozioID, -1, out _temp)
            );

            //Scorro tutta la lista se non è nulla
            if(listaOttoni != null)
            {
                foreach (ClsOttone ottone in listaOttoni)
                {
                    //Aggiungo lo strumento alla listview solo se è venduto dal negozio specificato
                    ClsVendere _vendereStrumento = _vendereNegozio.FirstOrDefault(v => v.StrumentoMusicaleID == ottone.ID);

                    if (_vendereStrumento != null)
                    {
                        //Se lo strumento è venduto dal negozio lo aggiungo alla listview
                        listView.Items.Add(CreaListViewItem(ottone, _vendereStrumento));
                    }
                }
            }
        }
        /// <summary>
        /// Popola una listview da una lista di ClsLegno di un certo negozio
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="listaLegni"></param>
        /// <param name="negozioID"></param>
        /// <param name="clearInTesta">True = elimina tutti gli elementi della listview prima di aggiungerne dei nuovi</param>
        void PopolaListView(ListView listView, List<ClsLegno> listaLegni, long negozioID, bool clearInTesta)
        {
            if (clearInTesta)
            {
                listView.Items.Clear();
            }

            //Trovo tutte le vendere del negozio in un processo separato
            List<ClsVendere> _vendereNegozio = new List<ClsVendere>();
            string _temp = String.Empty;
            Task.Run
            (() =>
                _vendereNegozio = ClsVendereBL.GetSomeVendere(ref Program._connessioneAlDB, negozioID, -1, out _temp)
            );

            //Scorro tutta la lista se non è nulla
            if(listaLegni.Count != null)
            {
                foreach (ClsLegno legno in listaLegni)
                {
                    //Aggiungo lo strumento alla listview solo se è venduto dal negozio specificato
                    ClsVendere _vendereStrumento = _vendereNegozio.FirstOrDefault(v => v.StrumentoMusicaleID == legno.ID);

                    if (_vendereStrumento != null)
                    {
                        //Se lo strumento è venduto dal negozio lo aggiungo alla listview
                        listView.Items.Add(CreaListViewItem(legno, _vendereStrumento));
                    }
                }
            }
        }
        /// <summary>
        /// Popola una listview da una lista di ClsPianoforte di un certo negozio
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="listaPianoforti"></param>
        /// <param name="negozioID"></param>
        /// <param name="clearInTesta">True = elimina tutti gli elementi della listview prima di aggiungerne dei nuovi</param>
        void PopolaListView(ListView listView, List<ClsPianoforte> listaPianoforti, long negozioID, bool clearInTesta)
        {
            if (clearInTesta)
            {
                listView.Items.Clear();
            }

            //Trovo tutte le vendere del negozio in un processo separato
            List<ClsVendere> _vendereNegozio = new List<ClsVendere>();
            string _temp = String.Empty;
            Task.Run
            (() =>
                _vendereNegozio = ClsVendereBL.GetSomeVendere(ref Program._connessioneAlDB, negozioID, -1, out _temp)
            );

            //Scorro tutta la lista se non è nulla
            if(listaPianoforti != null)
            {
                foreach (ClsPianoforte pianoforte in listaPianoforti)
                {
                    //Aggiungo lo strumento alla listview solo se è venduto dal negozio specificato
                    ClsVendere _vendereStrumento = _vendereNegozio.FirstOrDefault(v => v.StrumentoMusicaleID == pianoforte.ID);

                    if (_vendereStrumento != null)
                    {
                        //Se lo strumento è venduto dal negozio lo aggiungo alla listview
                        listView.Items.Add(CreaListViewItem(pianoforte, _vendereStrumento));
                    }
                }
            }
        }
        void PopolaCombobox(ComboBox comboBox, List<ClsNegozio> listaNegozi)
        {
            //Rimuovo tutti gli elementi dalla combobox
            comboBox.Items.Clear();

            for (int i = 0; i < listaNegozi.Count; i++)
            { 
                comboBox.Items.Add(listaNegozi[i].Nome);
            }

            comboBox.SelectedIndex = 0;
        }

        #endregion

        #region Costruttore
        public FrmStrumentiMusicali()
        {
            InitializeComponent();

            //Popolo l'apposita combobox con i parametri di ricerca
            cbParametriDiOrdinamento.DataSource = Enum.GetNames(typeof(ePARAMETRO_DI_ORDINAMENTO));

            //Popolo la combobox dei negozi 
            PopolaCombobox(cbNegozio, ClsArchivio.Negozi);

            //Popolo la listview accodando le varie liste
            PopolaListView(lvStrumenti, ClsArchivio.StrumentiACorda, ClsArchivio.Negozi[cbNegozio.SelectedIndex].ID, true);
            PopolaListView(lvStrumenti, ClsArchivio.Pianoforti, ClsArchivio.Negozi[cbNegozio.SelectedIndex].ID, false);
            PopolaListView(lvStrumenti, ClsArchivio.Ottoni, ClsArchivio.Negozi[cbNegozio.SelectedIndex].ID, false);
            PopolaListView(lvStrumenti, ClsArchivio.Legni, ClsArchivio.Negozi[cbNegozio.SelectedIndex].ID, false);
        }

        #endregion

        #region Eventi
        private void FrmStrumentiMusicali_Load(object sender, EventArgs e)
        {

        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void cbNegozio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
