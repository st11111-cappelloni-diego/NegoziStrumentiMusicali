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
        void PopolaListView(ListView listView, List<ClsStrumentoMusicale> listaStrumenti, int IDNegozio)
        {
            //Rimuovo tutti gli elementi dalla listview
            listView.Clear();

            List<ClsVendere> _vendereNegozio = new List<ClsVendere>();
            ClsVendere _vendereStrumento = new ClsVendere();

            //Scorro tutti gli elementi della lista
            for (int i = 0; i < listaStrumenti.Count; i++)
            {
                //Creo il listViewItem
                ListViewItem _lvi = new ListViewItem(listaStrumenti[i].ID.ToString()); //Prima colonna: ID
                
                //Seconda colonna: casa produttrice --> trovo il la casa in base a CasaProduttriceID (cerco su RAM)
                ClsCasaProduttrice _casaProduttrice = ClsArchivio.CaseProduttrici.FirstOrDefault(cp => cp.ID == listaStrumenti[i].CasaProduttriceID);
                _lvi.SubItems.Add(_casaProduttrice.Nome); //Aggiungo il nome della casa
                
                //Terza colonna: modello
                _lvi.SubItems.Add(listaStrumenti[i].Modello);
                
                //Quarta colonna: colori
                _lvi.SubItems.Add(listaStrumenti[i].Colori);
                
                //Quinta colonna: prezzo --> cerco la relazione vendere con l'ID dello strumento e quello del negozio per ricavare il prezzo (cerco su RAM)
                //Prima trovo tutte le vendere del negozio
                _vendereNegozio = ClsArchivio.Vendere.FindAll(v => v.NegozioID == IDNegozio);
                //Poi trovo la vendere con l'ID dello strumento
                _vendereStrumento = _vendereNegozio.FirstOrDefault(v => v.StrumentoMusicaleID == listaStrumenti[i].ID);
                //Infine, aggiungo il prezzo nel lvi
                _lvi.SubItems.Add(_vendereStrumento.Prezzo.ToString());

                //Sesta colonna: quantità. Utilizzo l'oggetto ricavato dalla ricerca fatta sopra
                _lvi.SubItems.Add(_vendereStrumento.Quantita.ToString());

                //Tag
                _lvi.Tag = listaStrumenti[i];

                //Aggiungo l'item alla listview
                listView.Items.Add(_lvi);
            }
        }
        void PopolaCombobox(ComboBox comboBox, List<ClsNegozio> listaNegozi)
        {
            //Rimuovo tutti gli elementi dalla combobox
            comboBox.Items.Clear();

            //Scorro tutti gli elementi della lista
            {
                for (int i = 0; i < listaNegozi.Count; i++)
                { 
                    comboBox.Items.Add(listaNegozi[i].ID + ": " + listaNegozi[i].Nome);
                    comboBox.SelectedIndex = i;
                }
            }
        }

        #endregion

        #region Costruttore
        public FrmStrumentiMusicali()
        {
            InitializeComponent();

            //Popolo l'apposita combobox con i parametri di ricerca
            cbParametriDiOrdinamento.DataSource = Enum.GetNames(typeof(ePARAMETRO_DI_ORDINAMENTO));
        }

        #endregion

        #region Eventi
        private void FrmStrumentiMusicali_Load(object sender, EventArgs e)
        {
            //Popolo la combobox dei negozi 
            PopolaCombobox(cbNegozio, ClsArchivio.Negozi);

            if(cbNegozio.SelectedItem != null)
            {
                //Popolo la listview
                //Estraggo l'ID del negozio
                //Nella popolazione della cbNegozio, come primo carattere ho messo l'ID del negozio
                int _idNegozio = Convert.ToInt32(cbNegozio.SelectedItem.ToString()[0]);
                PopolaListView(lvStrumenti, ClsArchivio.StrumentiMusicali, _idNegozio);
            }
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
