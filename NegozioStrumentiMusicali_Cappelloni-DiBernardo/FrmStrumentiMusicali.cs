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
        #region Variabili globali
        List<ClsVendere> _listaVendereNegozioSelezionato = new List<ClsVendere>();

        #endregion
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
            _casaProduttrice = ClsCasaProduttriceBL.GetOneCasaProduttrice
            (
                Program._connectionString,
                strumento.CasaProduttriceID,
                out _temp
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
        /// Crea una lista di ListViewItem da una lista di ClsStrumentoACorda di un certo negozio
        /// </summary>
        /// <param name="listaStrumentiACorda"></param>
        /// <param name="listaVendereNegozio"></param>       
        List<ListViewItem> CreaListViewItems(List<ClsStrumentoACorda> listaStrumentiACorda, List<ClsVendere> listaVendereNegozio)
        {
            List<ListViewItem> _lviList = new List<ListViewItem>();

            //Scorro tutta la lista se non è nulla
            if (listaStrumentiACorda != null)
            {
                foreach (ClsStrumentoACorda strumentoACorda in listaStrumentiACorda)
                {
                    //Aggiungo lo strumento alla listview solo se è venduto dal negozio specificato
                    ClsVendere _vendereStrumento = listaVendereNegozio.FirstOrDefault(v => v.StrumentoMusicaleID == strumentoACorda.ID);

                    if (_vendereStrumento != null)
                    {
                        //Se lo strumento è venduto dal negozio lo aggiungo alla listview
                        _lviList.Add(CreaListViewItem(strumentoACorda, _vendereStrumento));
                    }
                }
            }

            return _lviList;
        }
        /// <summary>
        /// Crea una lista di ListViewItem da una lista di ClsOttone di un certo negozio
        /// </summary>
        /// <param name="listaOttoni"></param>
        /// <param name="listaVendereNegozio"></param>       
        List<ListViewItem> CreaListViewItems(List<ClsOttone> listaOttoni, List<ClsVendere> listaVendereNegozio)
        {
            List<ListViewItem> _lviList = new List<ListViewItem>();

            //Scorro tutta la lista se non è nulla
            if (listaOttoni != null)
            {
                foreach (ClsOttone ottone in listaOttoni)
                {
                    //Aggiungo lo strumento alla listview solo se è venduto dal negozio specificato
                    ClsVendere _vendereStrumento = listaVendereNegozio.FirstOrDefault(v => v.StrumentoMusicaleID == ottone.ID);

                    if (_vendereStrumento != null)
                    {
                        //Se lo strumento è venduto dal negozio lo aggiungo alla listview
                        _lviList.Add(CreaListViewItem(ottone, _vendereStrumento));
                    }
                }
            }

            return _lviList;
        }
        /// <summary>
        /// Crea una lista di ListViewItem da una lista di ClsLegno di un certo negozio
        /// </summary>
        /// <param name="listaLegni"></param>
        /// <param name="listaVendereNegozio"></param>       
        List<ListViewItem> CreaListViewItems(List<ClsLegno> listaLegni, List<ClsVendere> listaVendereNegozio)
        {
            List<ListViewItem> _lviList = new List<ListViewItem>();

            //Scorro tutta la lista se non è nulla
            if (listaLegni != null)
            {
                foreach (ClsLegno legno in listaLegni)
                {
                    //Aggiungo lo strumento alla listview solo se è venduto dal negozio specificato
                    ClsVendere _vendereStrumento = listaVendereNegozio.FirstOrDefault(v => v.StrumentoMusicaleID == legno.ID);

                    if (_vendereStrumento != null)
                    {
                        //Se lo strumento è venduto dal negozio lo aggiungo alla listview
                        _lviList.Add(CreaListViewItem(legno, _vendereStrumento));
                    }
                }
            }

            return _lviList;
        }
        /// <summary>
        /// Crea una lista di ListViewItem da una lista di ClsPianoforte di un certo negozio
        /// </summary>
        /// <param name="listaLegni"></param>
        /// <param name="listaVendereNegozio"></param>       
        List<ListViewItem> CreaListViewItems(List<ClsPianoforte> listaPianoforti, List<ClsVendere> listaVendereNegozio)
        {
            List<ListViewItem> _lviList = new List<ListViewItem>();

            //Scorro tutta la lista se non è nulla
            if(listaPianoforti != null)
            {
                foreach (ClsPianoforte pianoforte in listaPianoforti)
                {
                    //Aggiungo lo strumento alla listview solo se è venduto dal negozio specificato
                    ClsVendere _vendereStrumento = listaVendereNegozio.FirstOrDefault(v => v.StrumentoMusicaleID == pianoforte.ID);

                    if (_vendereStrumento != null)
                    {
                        //Se lo strumento è venduto dal negozio lo aggiungo alla listview
                        _lviList.Add(CreaListViewItem(pianoforte, _vendereStrumento));
                    }
                }
            }

            return _lviList;
        }
        /// <summary>
        /// Crea una lista di ListViewItem da una lista di ClsBatterie di un certo negozio
        /// </summary>
        /// <param name="listaLegni"></param>
        /// <param name="listaVendereNegozio"></param>       
        List<ListViewItem> CreaListViewItems(List<ClsBatteria> listaBatterie, List<ClsVendere> listaVendereNegozio)
        {
            List<ListViewItem> _lviList = new List<ListViewItem>();

            //Scorro tutta la lista se non è nulla
            if (listaBatterie != null)
            {
                foreach (ClsBatteria batteria in listaBatterie)
                {
                    //Aggiungo lo strumento alla listview solo se è venduto dal negozio specificato
                    ClsVendere _vendereStrumento = listaVendereNegozio.FirstOrDefault(v => v.StrumentoMusicaleID == batteria.ID);

                    if (_vendereStrumento != null)
                    {
                        //Se lo strumento è venduto dal negozio lo aggiungo alla listview
                        _lviList.Add(CreaListViewItem(batteria, _vendereStrumento));
                    }
                }
            }

            return _lviList;
        }
        /// <summary>
        /// Popola la lvStrumenti ogni lista in un processo separato
        /// </summary>
        /// <param name="listView"></param>
        async void PopolaListView(ListView listView)
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
                        ClsArchivio.StrumentiACorda,
                        _listaVendereNegozioSelezionato
                    )
                ),
                Task.Run(()=>
                    _lviListPianoforti =
                    CreaListViewItems(
                        ClsArchivio.Pianoforti,
                        _listaVendereNegozioSelezionato
                    )
                ),
                Task.Run(()=>
                    _lviListOttoni =
                    CreaListViewItems(
                        ClsArchivio.Ottoni,
                        _listaVendereNegozioSelezionato
                    )
                ),
                Task.Run(() =>
                    _lviListLegni = 
                    CreaListViewItems(
                        ClsArchivio.Legni,
                        _listaVendereNegozioSelezionato
                    )
                ),
                Task.Run(() =>
                    _lviListBatterie =
                    CreaListViewItems(
                        ClsArchivio.Batterie,
                        _listaVendereNegozioSelezionato
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

        private async void cbNegozio_SelectedIndexChanged(object sender, EventArgs e)
        {
            long _idNegozio = ClsArchivio.Negozi[cbNegozio.SelectedIndex].ID;

            //Trovo le vendere del negozio selezionato
            string _temp = String.Empty;
            await Task.Run(() =>
            {
                _listaVendereNegozioSelezionato =
                    ClsVendereBL.GetSomeVendere(
                        ref Program._connessioneAlDB,
                        _idNegozio,
                        -1,
                        out _temp
                    );
            });

            //Popolo la listview degli strumenti
            PopolaListView(lvStrumenti);
        }
    }
}
