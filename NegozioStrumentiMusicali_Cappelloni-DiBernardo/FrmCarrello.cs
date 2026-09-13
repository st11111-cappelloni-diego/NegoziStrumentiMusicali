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


        public List<ClsVendere> ListaVendereNegozioSelezionato = new List<ClsVendere>();

        public FrmCarrello()
        {
            InitializeComponent();
            btnAggiunta.Visible = false;
            btnRimossa.Visible = false;
            PopolaCombobox(cbNegozio, ClsArchivio.Negozi);
            PopolaListView(lvStrumenti, ClsArchivio.ListCarrello, ClsArchivio.Negozi[cbNegozio.SelectedIndex].ID);
        }

        private void lvStrumenti_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (lvStrumenti.SelectedItems.Count > 0)
            {
                btnAggiunta.Visible = true;
                ClsCarrello _itemCarrelloAttuale = (ClsCarrello)lvStrumenti.SelectedItems[0].Tag;
                if (_itemCarrelloAttuale.Quantita > 0)
                 btnRimossa.Visible = true;
            }
            else
            {
                btnAggiunta.Visible = false;
                btnRimossa.Visible = false;
            }
        }

        void PopolaCombobox(ComboBox comboBox, List<ClsNegozio> listaNegozi)
        {
            //Rimuovo tutti gli elementi dalla combobox
            comboBox.Items.Clear();

            //Scorro tutti gli elementi della lista
            for (int i = 0; i < listaNegozi.Count; i++)
            {
                comboBox.Items.Add(listaNegozi[i].Nome);
            }
            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }

        void PopolaListView(ListView listView, List<ClsCarrello> lista, long negozioID)
        {
            listView.Items.Clear();  //svuoto la listView

            foreach (ClsCarrello carrello in lista)
            {
                if (negozioID == carrello.NegozioID)
                {
                    string _temp;
                    ClsCasaProduttrice _casaProduttrice = new ClsCasaProduttrice();
                    _casaProduttrice = ClsCasaProduttriceBL.GetOneCasaProduttrice
                    (
                        Program._connectionString,
                        carrello.StrumentoMusicale.CasaProduttriceID,
                        out _temp
                    );
                    ListViewItem _lvi = new ListViewItem(_casaProduttrice.Nome);
                    _lvi.SubItems.Add(carrello.StrumentoMusicale.Modello);
                    _lvi.SubItems.Add(carrello.StrumentoMusicale.Colori);
                    _lvi.SubItems.Add(carrello.Quantita.ToString());
                    _lvi.SubItems.Add((carrello.Quantita * carrello.Prezo).ToString());
                    _lvi.Tag = carrello;

                    lvStrumenti.Items.Add(_lvi);
                }
            }
        }

        private void btnAggiunta_Click(object sender, EventArgs e)
        {
            if (lvStrumenti.SelectedItems.Count > 0)
            {
                ClsCarrello tag = (ClsCarrello)lvStrumenti.SelectedItems[0].Tag;
                tag.Quantita++;
                PopolaListView(lvStrumenti, ClsArchivio.ListCarrello, ClsArchivio.Negozi[cbNegozio.SelectedIndex].ID);
                btnRimossa.Visible = false;
                btnAggiunta.Visible = false;
            }
        }
            

        private void btnInfoNegozio_Click(object sender, EventArgs e)
        {

        }

        private void FrmCarrello_Load(object sender, EventArgs e)
        {

        }

        private void btnRimossa_Click(object sender, EventArgs e)
        {
            if (lvStrumenti.SelectedItems.Count > 0)
            {
                ClsCarrello tag = (ClsCarrello)lvStrumenti.SelectedItems[0].Tag;
                tag.Quantita--;
                PopolaListView(lvStrumenti, ClsArchivio.ListCarrello, ClsArchivio.Negozi[cbNegozio.SelectedIndex].ID);
                btnRimossa.Visible = false;
                btnAggiunta.Visible = false;
            }
        }

        private void cbNegozio_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopolaListView(lvStrumenti, ClsArchivio.ListCarrello, ClsArchivio.Negozi[cbNegozio.SelectedIndex].ID);
        }
    }
}
