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
    public partial class FrmCarrello : Form
    {
        ClsStrumentoMusicale _strumentoAttuale = new ClsStrumentoMusicale();


        public List<ClsVendere> ListaVendereNegozioSelezionato { get => _listaVendereNegozioSelezionato; set => _listaVendereNegozioSelezionato = value; }

        public FrmCarrello()
        {
            InitializeComponent();
            btnAggiunta.Visible = false;
            btnRimossa.Visible = false;
        }

        private void lvStrumenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAggiunta.Visible = true;
            btnRimossa.Visible = true;
        }

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
                        listaStrumentiACorda,
                        ListaVendereNegozioSelezionato
                    )
                ),
                Task.Run(() =>
                    _lviListPianoforti =
                    CreaListViewItems(
                        listaPianoforti,
                        ListaVendereNegozioSelezionato
                    )
                ),
                Task.Run(() =>
                    _lviListOttoni =
                    CreaListViewItems(
                        listaOttoni,
                        ListaVendereNegozioSelezionato
                    )
                ),
                Task.Run(() =>
                    _lviListLegni =
                    CreaListViewItems(
                        listaLegni,
                        ListaVendereNegozioSelezionato
                    )
                ),
                Task.Run(() =>
                    _lviListBatterie =
                    CreaListViewItems(
                        listaBatterie,
                        ListaVendereNegozioSelezionato
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

        /// <summary>
        /// Crea e popola un ListViewItem in base ad un istanza di ClsStrumentoMusicale
        /// </summary>
        /// <param name="strumento"></param>
        /// <param name="vendereStrumento">Per estrarre informazioni che cambiano in base al negozio</param>
        /// <returns></returns>
        private ListViewItem CreaListViewItem(ClsStrumentoMusicale strumento, ClsVendere vendereStrumento)
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
            if (listaPianoforti != null)
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


        private void btnAggiunta_Click(object sender, EventArgs e)
        {

        }
    }
}
