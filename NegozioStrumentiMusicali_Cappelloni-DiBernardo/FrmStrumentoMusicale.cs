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
    public partial class FrmStrumentoMusicale : Form
    {
        #region Variabili
        private ClsStrumentoMusicale _strumentoMusicale = new ClsStrumentoMusicale();
        private ClsVendere _vendereStrumentoMusicale = new ClsVendere();
        private Program.eMODALITA_ENTRATA_DETAIL _modalitaEntrata = Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione;
        private List<ClsCaratteristica> _altreCaratteristicheStrumento = new List<ClsCaratteristica>();

        #endregion
        #region Proprietà
        public ClsStrumentoMusicale StrumentoMusicale { get => _strumentoMusicale; set => _strumentoMusicale = value; }
        public ClsVendere VendereStrumentoMusicale { get => _vendereStrumentoMusicale; set => _vendereStrumentoMusicale = value; }
        public Program.eMODALITA_ENTRATA_DETAIL ModalitaEntrata { get => _modalitaEntrata; set => _modalitaEntrata = value; }
        public List<ClsCaratteristica> AltreCaratteristicheStrumento { get => _altreCaratteristicheStrumento; set => _altreCaratteristicheStrumento = value; }
        public NumericUpDown NudQuantita
        {
            get
            {
                return nudQuantita;
            }
            set
            {
                value = nudQuantita;
            }
        }
        public NumericUpDown NudPrezzo
        {
            get
            {
                return nudPrezzo;
            }
            set
            {
                value = nudPrezzo;
            }
        }

        #endregion
        #region Metodi della form
        /// <summary>
        /// Popola una combobox con una lista di note musicali
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="listaNoteMusicali"></param>
        private void PopolaComboBox(ComboBox comboBox, List<ClsNotaMusicale> listaNoteMusicali)
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

                _testoDaAggiungere = String.Empty;
            }

            comboBox.SelectedIndex = 0;
        } 
        /// <summary>
        /// Popola una combobox con una lista di case produttrici
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="listaCaseProduttrici"></param>
        private void PopolaComboBox(ComboBox comboBox, List<ClsCasaProduttrice> listaCaseProduttrici)
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
        private void CaricaDati(ClsStrumentoMusicale strumentoMusicale, ClsVendere vendereStrumento)
        {
            tbColori.Text = strumentoMusicale.Colori;

            tbModello.Text = strumentoMusicale.Modello;

            //Trovo la posizione nella lista su RAM della casa produttrice dello strumento
            int _posCasaProduttrice = ClsArchivio.CaseProduttrici.FindIndex(c => c.ID == strumentoMusicale.CasaProduttriceID);
            cbCasaProduttrice.SelectedIndex = _posCasaProduttrice;

            //Trovo la posizione nella lista su RAM della nota minima e massima dello strumento se non è batteria
            if(!(strumentoMusicale is ClsBatteria))
            {
                cbNotaMassima.Enabled = true;
                cbNotaMinima.Enabled = true;
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

            nudID.Enabled = true;
            nudID.Value = strumentoMusicale.ID;
            nudID.Enabled = false; //L'ID non è modificabile ne inseribile

            nudPeso.Value = Convert.ToDecimal(strumentoMusicale.PesoKG);

            nudPrezzo.Value = vendereStrumento.Prezzo;

            nudQuantita.Value = Convert.ToDecimal(vendereStrumento.Quantita);

            //cbStrumento: Carico la famiglia di strumenti in base a come è il tipo di strumento
            if(strumentoMusicale is ClsBatteria)
            {
                cbStrumento.SelectedIndex = Convert.ToInt32(Program.eTIPO_STRUMENTO.Batteria);                
            }
            else if(strumentoMusicale is ClsLegno)
            {
                cbStrumento.SelectedIndex = Convert.ToInt32(Program.eTIPO_STRUMENTO.Legno);
            }
            else if(strumentoMusicale is ClsOttone)
            {
                cbStrumento.SelectedIndex = Convert.ToInt32(Program.eTIPO_STRUMENTO.Ottone);
            }
            else if(strumentoMusicale is ClsPianoforte)
            {
                cbStrumento.SelectedIndex = Convert.ToInt32(Program.eTIPO_STRUMENTO.Pianoforte);
            }
            else if(strumentoMusicale is ClsStrumentoACorda)
            {
                cbStrumento.SelectedIndex = Convert.ToInt32(Program.eTIPO_STRUMENTO.Strumento_a_corda);
            }
            else
            {
                cbStrumento.SelectedIndex = 0;
            }
        }
        private void AbilitaControlliGraficiInput(bool controlliAbilitati)
        {
            tbColori.Enabled = controlliAbilitati;
            tbModello.Enabled = controlliAbilitati;
            cbCasaProduttrice.Enabled = controlliAbilitati;
            cbNotaMassima.Enabled = controlliAbilitati;
            cbNotaMinima.Enabled = controlliAbilitati;
            cbStrumento.Enabled = controlliAbilitati;
            nudPeso.Enabled = controlliAbilitati;
            nudPrezzo.Enabled = controlliAbilitati;
            nudQuantita.Enabled = controlliAbilitati;
            btnEliminaCaratteristica.Enabled = controlliAbilitati;
            btnModificaCaratteristica.Enabled = controlliAbilitati;
            btnNuovaCaratteristica.Enabled = controlliAbilitati;
            btnSalva.Enabled = controlliAbilitati;
        }
        #endregion
        public FrmStrumentoMusicale()
        {
            InitializeComponent();
            //Popolo le combobox
            cbStrumento.DataSource = Enum.GetNames(typeof(Program.eTIPO_STRUMENTO));
            PopolaComboBox(cbNotaMassima, ClsArchivio.NoteMusicali);
            PopolaComboBox(cbNotaMinima, ClsArchivio.NoteMusicali);
            PopolaComboBox(cbCasaProduttrice, ClsArchivio.CaseProduttrici);

            nudID.Enabled = false;

            nudPrezzo.Maximum = 9999999999.00m;
            nudPrezzo.Minimum = 0.01m;
            nudPeso.Minimum = 0.01m;
            nudPeso.Maximum = 9999.0m;
            nudQuantita.Minimum = 0;
            nudQuantita.Maximum = 9999999999;
        }

        private void FrmStrumentoMusicale_Load(object sender, EventArgs e)
        {
            //Se la modalità è modifica o visualizzazione, carico i dati dello strumento
            if(ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica ||
                ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione)
            {
                CaricaDati(StrumentoMusicale, VendereStrumentoMusicale);
            }

            //Se sono in modalità visualizzazione disabilito tutti i controlli di input
            //Altrimenti li abilito
            if(ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione)
            {
                AbilitaControlliGraficiInput(false);
            }
            else
            {
                //Modalità modifica o inserimento
            }

            if (cbStrumento.SelectedIndex == Convert.ToInt32(Program.eTIPO_STRUMENTO.Batteria))
            {
                cbNotaMassima.Enabled = true;
                cbNotaMinima.Enabled = true;
                cbNotaMassima.SelectedIndex = 0;
                cbNotaMinima.SelectedIndex = 0;
                cbNotaMassima.Enabled = false;
                cbNotaMinima.Enabled = false;
            }


        }

        private void cbStrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNotaMassima.Enabled = true;
            cbNotaMinima.Enabled = true;
            if (cbStrumento.SelectedIndex == Convert.ToInt32(Program.eTIPO_STRUMENTO.Batteria))
            {
                cbNotaMassima.SelectedIndex = 0;
                cbNotaMinima.SelectedIndex = 0;
                cbNotaMassima.Enabled = false;
                cbNotaMinima.Enabled = false;
            }
        }
    }
}
