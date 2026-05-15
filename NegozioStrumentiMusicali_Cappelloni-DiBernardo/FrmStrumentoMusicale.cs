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
    public partial class FrmStrumentoMusicale : Form
    {
        #region Variabili
        ClsStrumentoMusicale _strumentoMusicale = new ClsStrumentoMusicale();
        ClsVendere _vendereStrumentoMusicale = new ClsVendere();
        Program.eMODALITA_ENTRATA_DETAIL _modalitaEntrata = Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione;

        #endregion
        #region Enumeratori
        public enum eTIPO_STRUMENTO
        {
            Batteria = 0,
            Legno = 1,
            Ottone = 2,
            Pianoforte = 3,
            Strumento_a_corda = 4
        }

        #endregion
        #region Metodi della form
        /// <summary>
        /// Popola una combobox con una lista di note musicali
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="listaNoteMusicali"></param>
        void PopolaComboBox(ComboBox comboBox, List<ClsNotaMusicale> listaNoteMusicali)
        {
            //Rimuovo tutti gli elementi della combobox
            comboBox.Items.Clear();

            //Scorro tutta la lista
            string _testoDaAggiungere = String.Empty;
            foreach(ClsNotaMusicale notaMusicale in listaNoteMusicali)
            {
                _testoDaAggiungere += notaMusicale.NotaBase.ToString();
                if(notaMusicale.Alterazione == ClsNotaMusicale.eALTERAZIONE.bemolle)
                {
                    _testoDaAggiungere += "b";
                }
                else if(notaMusicale.Alterazione == ClsNotaMusicale.eALTERAZIONE.diesis)
                {
                    _testoDaAggiungere += "#";
                }
                _testoDaAggiungere += notaMusicale.Ottava.ToString();
                comboBox.Items.Add(_testoDaAggiungere);
            }

            comboBox.SelectedIndex = 0;
        } 
        /// <summary>
        /// Popola una combobox con una lista di case produttrici
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="listaCaseProduttrici"></param>
        void PopolaComboBox(ComboBox comboBox, List<ClsCasaProduttrice> listaCaseProduttrici)
        {
            //Rimuovo tutti gli elementi della combobox
            comboBox.Items.Clear();

            //Scorro tutta la lista
            foreach(ClsCasaProduttrice casaProduttrice in listaCaseProduttrici)
            {
                comboBox.Items.Add(casaProduttrice.Nome);
            }

            comboBox.SelectedIndex = 0;
        }
        void CaricaDati(ClsStrumentoMusicale strumentoMusicale, ClsVendere vendereStrumento)
        {
            tbColori.Text = strumentoMusicale.Colori;

            tbModello.Text = strumentoMusicale.Modello;

            //Trovo la posizione nella lista su RAM della casa produttrice dello strumento
            int _posCasaProduttrice = ClsArchivio.CaseProduttrici.FindIndex(c => c.ID == strumentoMusicale.CasaProduttriceID);
            cbCasaProduttrice.SelectedIndex = _posCasaProduttrice;

            //Trovo la posizione nella lista su RAM della nota minima e massima dello strumento se non è batteria
            if(!(strumentoMusicale is ClsBatteria))
            {
                //Se le note sono nulle (ID <= -1) seleziono il primo indice, sennò trovo l'indice da selezionare
                if(strumentoMusicale.NotaMassimaID <= -1)
                {
                    cbNotaMassima.SelectedIndex = 0;
                }
                else
                {
                    //Trovo l'indice
                    int _posNotaMassima = ClsArchivio.NoteMusicali.FindIndex(n => n.ID == strumentoMusicale.NotaMassimaID);
                    cbNotaMassima.SelectedIndex = _posNotaMassima;
                }

                if (strumentoMusicale.NotaMinimaID <= -1)
                {
                    cbNotaMinima.SelectedIndex = 0;
                }
                else
                {
                    //Trovo l'indice
                    int _posNotaMinima = ClsArchivio.NoteMusicali.FindIndex(n => n.ID == strumentoMusicale.NotaMinimaID);
                    cbNotaMinima.SelectedIndex = _posNotaMinima;
                }
            }
            else
            {
                //Se è una batteria disabilito le combobox
                cbNotaMassima.Enabled = false;
                cbNotaMinima.Enabled = false;
            }

            nudID.Value = strumentoMusicale.ID;

            nudPeso.Value = Convert.ToDecimal(strumentoMusicale.PesoKG);

            nudPrezzo.Value = vendereStrumento.Prezzo;

            nudQuantita.Value = Convert.ToDecimal(vendereStrumento.Quantita);

            //cbStrumento: Carico la famiglia di strumenti in base a come è il tipo di strumento
            if(strumentoMusicale is ClsBatteria)
            {
                cbStrumento.SelectedIndex = Convert.ToInt32(eTIPO_STRUMENTO.Batteria);
            }
            else if(strumentoMusicale is ClsLegno)
            {
                cbStrumento.SelectedIndex = Convert.ToInt32(eTIPO_STRUMENTO.Legno);
            }
            else if(strumentoMusicale is ClsOttone)
            {
                cbStrumento.SelectedIndex = Convert.ToInt32(eTIPO_STRUMENTO.Ottone);
            }
            else if(strumentoMusicale is ClsPianoforte)
            {
                cbStrumento.SelectedIndex = Convert.ToInt32(eTIPO_STRUMENTO.Pianoforte);
            }
            else if(strumentoMusicale is ClsStrumentoACorda)
            {
                cbStrumento.SelectedIndex = Convert.ToInt32(eTIPO_STRUMENTO.Strumento_a_corda);
            }
            else
            {
                cbStrumento.SelectedIndex = 0;
            }
        }

        #endregion
        public FrmStrumentoMusicale()
        {
            InitializeComponent();
            //Popolo le combobox
            cbStrumento.DataSource = Enum.GetNames(typeof(eTIPO_STRUMENTO));
            PopolaComboBox(cbNotaMassima, ClsArchivio.NoteMusicali);
            PopolaComboBox(cbNotaMassima, ClsArchivio.NoteMusicali);
            PopolaComboBox(cbCasaProduttrice, ClsArchivio.CaseProduttrici);
        }

        private void FrmStrumentoMusicale_Load(object sender, EventArgs e)
        {

        }
    }
}
