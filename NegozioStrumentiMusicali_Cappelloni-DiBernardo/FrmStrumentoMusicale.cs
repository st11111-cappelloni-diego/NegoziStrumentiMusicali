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
        public ClsStrumentoMusicale _strumentoMusicale;
        public ClsVendere _vendereStrumentoMusicale;
        private bool _bottoneAnnullaPremuto = false;
        private ClsBatteria _dettagliBatteria = new ClsBatteria();
        private ClsLegno _dettagliLegno = new ClsLegno();
        private ClsOttone _dettagliOttone = new ClsOttone();
        private ClsPianoforte _dettagliPianoforte = new ClsPianoforte();
        private ClsStrumentoACorda _dettagliStrumentoACorda = new ClsStrumentoACorda();
        private Program.eMODALITA_ENTRATA_DETAIL _modalitaEntrata = Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione;
        private List<ClsCaratteristica> _altreCaratteristicheStrumento = new List<ClsCaratteristica>();
        private bool _utenteGestisceNegozioAttuale;
        /// <summary>
        /// Variabile di backup di cbNotaMinima in caso di cambio di tipo strumento
        /// </summary>
        private int _indiceNotaMinima;
        /// <summary>
        /// Variabile di backup di cbNotaMassima in caso di cambio di tipo strumento
        /// </summary>
        private int _indiceNotaMassima;

        #endregion
        #region Proprietà
        public Program.eMODALITA_ENTRATA_DETAIL ModalitaEntrata { get => _modalitaEntrata; set => _modalitaEntrata = value; }
        public List<ClsCaratteristica> AltreCaratteristicheStrumento { get => _altreCaratteristicheStrumento; set => _altreCaratteristicheStrumento = value; }
        /// <summary>
        /// Per l'ID del negozio vedi sulla vendere
        /// </summary>
        public bool UtenteGestisceNegozioAttuale { get => _utenteGestisceNegozioAttuale; set => _utenteGestisceNegozioAttuale = value; }        

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
            //cbStrumento: Carico la famiglia di strumenti in base a come è il tipo di strumento
            if (strumentoMusicale is ClsBatteria)
            {
                cbStrumento.SelectedIndex = Convert.ToInt32(Program.eTIPO_STRUMENTO.Batteria);
            }
            else if (strumentoMusicale is ClsLegno)
            {
                cbStrumento.SelectedIndex = Convert.ToInt32(Program.eTIPO_STRUMENTO.Legno);
            }
            else if (strumentoMusicale is ClsOttone)
            {
                cbStrumento.SelectedIndex = Convert.ToInt32(Program.eTIPO_STRUMENTO.Ottone);
            }
            else if (strumentoMusicale is ClsPianoforte)
            {
                cbStrumento.SelectedIndex = Convert.ToInt32(Program.eTIPO_STRUMENTO.Pianoforte);
            }
            else if (strumentoMusicale is ClsStrumentoACorda)
            {
                cbStrumento.SelectedIndex = Convert.ToInt32(Program.eTIPO_STRUMENTO.Strumento_a_corda);
            }
            else
            {
                cbStrumento.SelectedIndex = 0;
            }

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

            nudID.Value = strumentoMusicale.ID;
            nudID.Enabled = false; //L'ID non è modificabile ne inseribile

            nudPeso.Value = Convert.ToDecimal(strumentoMusicale.PesoKG);

            if(vendereStrumento != null)
            {
                nudPrezzo.Value = vendereStrumento.Prezzo;
                nudQuantita.Value = Convert.ToDecimal(vendereStrumento.Quantita);
            }
            else
            {
                nudPrezzo.Value = nudPrezzo.Minimum;
                nudQuantita.Value = nudQuantita.Minimum;
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
            btnAnnulla.Enabled = controlliAbilitati;
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

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            nudID.Enabled = false;
            nudID.Minimum = 0;
            nudID.Maximum = Convert.ToDecimal(long.MaxValue);

            nudPrezzo.Maximum = 9999999999.99m;
            nudPrezzo.Minimum = 0.01m;
            nudPeso.Minimum = 0.01m;
            nudPeso.Maximum = 9999.99m;
            nudQuantita.Minimum = 0;
            nudQuantita.Maximum = Convert.ToDecimal(uint.MaxValue);
        }

        private void FrmStrumentoMusicale_Load(object sender, EventArgs e)
        {
            //Se la modalità è modifica o visualizzazione, carico i dati dello strumento
            if(ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica ||
                ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione)
            {
                CaricaDati(_strumentoMusicale, _vendereStrumentoMusicale);
            }

            //Se sono in modalità visualizzazione disabilito tutti i controlli di input
            //Altrimenti li abilito
            if(ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione)
            {
                AbilitaControlliGraficiInput(false);

                //Se la vendere è null rendo invisibili prezzo e quantità
                if(_vendereStrumentoMusicale == null)
                {
                    nudPrezzo.Visible = false;
                    lblPrezzo.Visible = false;
                    nudQuantita.Visible = false;
                    lblQuantita.Visible = false;
                }
                else
                {
                    nudPrezzo.Visible = true;
                    lblPrezzo.Visible = true;
                    nudQuantita.Visible = true;
                    lblQuantita.Visible = true;
                }
            }
            else
            {
                //Modalità modifica o inserimento                
                if(UtenteGestisceNegozioAttuale && ClsArchivio.UtenteAttuale.AdminSoftware == false)
                {
                    //L'utente gestisce il negozio ma non è admin software: abilito solo nudPrezzo e nudQuantità (se non sono in modalità inserimento)
                    AbilitaControlliGraficiInput(false);
                    if(ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica)
                    {
                        nudPrezzo.Enabled = true;
                        nudQuantita.Enabled = true;
                        btnSalva.Enabled = true;
                        btnAnnulla.Enabled = true;
                    }
                    else
                    {
                        nudPrezzo.Enabled = false;
                        nudQuantita.Enabled = false;
                        btnSalva.Enabled = false;
                        btnAnnulla.Enabled = false;
                    }
                }
                else if(UtenteGestisceNegozioAttuale == false && ClsArchivio.UtenteAttuale.AdminSoftware)
                {
                    //L'utente non gestisce il negozio ma è admin software: abilito tutti i controlli apparte nudPrezzo e nudQuantita
                    AbilitaControlliGraficiInput(true);
                    nudPrezzo.Enabled = false;
                    nudQuantita.Enabled = false;
                }
                else if(UtenteGestisceNegozioAttuale && ClsArchivio.UtenteAttuale.AdminSoftware)
                {
                    //L'utente è sia admin software sia gestore del negozio: abilito tutti i controlli grafici di input
                    AbilitaControlliGraficiInput(true);
                }
                else
                {
                    //L'utente non è ne gestore ne admin software: disabilito tutti i controlli grafici di input
                    AbilitaControlliGraficiInput(false);
                }
            }

            //Se sono in modalità modifica disabilito la combobox per la scelta del tipo di strumento
            //Una volta inserito lo strumento con quella specializzazione, non si può cambiare
            if(ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica)
            {
                cbStrumento.Enabled = false;
            }

            if (cbStrumento.SelectedIndex == Convert.ToInt32(Program.eTIPO_STRUMENTO.Batteria))
            {
                cbNotaMassima.SelectedIndex = 0;
                cbNotaMinima.SelectedIndex = 0;
                cbNotaMassima.Enabled = false;
                cbNotaMassima.Visible = false;
                lblNotaMassima.Visible = false;
                cbNotaMinima.Enabled = false;
                cbNotaMinima.Visible = false;
                lblNotaMinima.Visible = false;
            }
        }

        private void cbStrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Nota minima e nota massima non sono previste nelle batterie
            if (cbStrumento.SelectedIndex == Convert.ToInt32(Program.eTIPO_STRUMENTO.Batteria))
            {
                _indiceNotaMinima = cbNotaMinima.SelectedIndex; //Backup
                _indiceNotaMassima = cbNotaMassima.SelectedIndex;
                cbNotaMassima.SelectedIndex = 0;
                cbNotaMinima.SelectedIndex = 0;
                cbNotaMassima.Enabled = false;
                cbNotaMassima.Visible = false;
                lblNotaMassima.Visible = false;
                cbNotaMinima.Enabled = false;
                cbNotaMinima.Visible = false;
                lblNotaMinima.Visible = false;
            }
            else
            {
                //Ripristino backup
                if (_indiceNotaMinima >= 0)
                {
                    cbNotaMinima.SelectedIndex = _indiceNotaMinima; 
                }
                else
                {
                    cbNotaMinima.SelectedIndex = 0;
                }
                if (_indiceNotaMassima >= 0)
                {
                    cbNotaMassima.SelectedIndex = _indiceNotaMassima;
                }
                else
                {
                    cbNotaMassima.SelectedIndex = 0;
                }
                cbNotaMassima.Enabled = true;
                cbNotaMassima.Visible = true;
                lblNotaMassima.Visible = true;
                cbNotaMinima.Enabled = true;
                cbNotaMinima.Visible = true;
                lblNotaMinima.Visible = true;
            }
        }

        private void btnInfoSpecifiche_Click(object sender, EventArgs e)
        {
            Form _formDaAprire = new Form();

            //Modalità inserimento:
            if (ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento)
            {
                //Controllo di che famiglia di strumenti deve essere lo strumento
                if(cbStrumento.SelectedIndex ==
                    Convert.ToInt32(Program.eTIPO_STRUMENTO.Batteria))
                {
                    //Gli passo la variabile di dettagli per evitare che quando si riapre la form delle info specifiche perdo i dati
                    _formDaAprire = new FrmBatteria(ModalitaEntrata, _dettagliBatteria);
                }
                else if(cbStrumento.SelectedIndex ==
                    Convert.ToInt32(Program.eTIPO_STRUMENTO.Legno))
                {
                    _formDaAprire = new FrmLegno(ModalitaEntrata, _dettagliLegno);
                }
                else if(cbStrumento.SelectedIndex ==
                    Convert.ToInt32(Program.eTIPO_STRUMENTO.Ottone))
                {
                    _formDaAprire = new FrmOttone(ModalitaEntrata, _dettagliOttone);
                }
                else if(cbStrumento.SelectedIndex ==
                    Convert.ToInt32(Program.eTIPO_STRUMENTO.Pianoforte))
                {
                    _formDaAprire = new FrmPianoforte(ModalitaEntrata, _dettagliPianoforte);
                }
                else if(cbStrumento.SelectedIndex ==
                    Convert.ToInt32(Program.eTIPO_STRUMENTO.Strumento_a_corda))
                {
                    _formDaAprire = new FrmStrumentoACorda(ModalitaEntrata, _dettagliStrumentoACorda);
                }
            }
            else if(ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica
                || ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione)
            {
                //Controllo di che tipo è lo strumento passato a questa form
                if(_strumentoMusicale is ClsBatteria)
                {
                    //Passo alla form la variabile di dettaglio, copiando i dati (senza mantenere la stessa area di memoria)
                    ClsBatteriaBL.Clona((ClsBatteria)_strumentoMusicale, ref _dettagliBatteria, true);
                    _formDaAprire = new FrmBatteria(ModalitaEntrata, (ClsBatteria)_strumentoMusicale);
                }
                else if(_strumentoMusicale is ClsLegno)
                {
                    ClsLegnoBL.Clona((ClsLegno)_strumentoMusicale, ref _dettagliLegno, true);
                    _formDaAprire = new FrmLegno(ModalitaEntrata, _dettagliLegno);
                }
                else if(_strumentoMusicale is ClsOttone)
                {
                    ClsOttoneBL.Clona((ClsOttone)_strumentoMusicale, ref _dettagliOttone, true);
                    _formDaAprire = new FrmOttone(ModalitaEntrata, (ClsOttone)_strumentoMusicale);
                }
                else if(_strumentoMusicale is ClsPianoforte)
                {
                    ClsPianoforteBL.Clona((ClsPianoforte)_strumentoMusicale, ref _dettagliPianoforte, true);
                    _formDaAprire = new FrmPianoforte(ModalitaEntrata, (ClsPianoforte)_strumentoMusicale);
                }
                else if(_strumentoMusicale is ClsStrumentoACorda)
                {
                    ClsStrumentoACordaBL.Clona((ClsStrumentoACorda)_strumentoMusicale, ref _dettagliStrumentoACorda, true);
                    _formDaAprire = new FrmStrumentoACorda(ModalitaEntrata, (ClsStrumentoACorda)_strumentoMusicale);
                }
            }

            _formDaAprire.ShowDialog(this);
        }

        private void FrmStrumentoMusicale_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione)
            {
                //In modalità visualizzazione procedo sempre con la chiusura della form
                e.Cancel = false;
            }
            else
            {
                //DR = OK quando è premuto 'Salva'
                if (_bottoneAnnullaPremuto || this.DialogResult == DialogResult.OK)
                {
                    e.Cancel = false; //Procedo con la chiusura della form
                }
                else
                {
                    DialogResult _drMessageBox =
                        MessageBox.Show("Sei sicur* di voler uscire senza salvare?", "ESCI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (_drMessageBox == DialogResult.Yes)
                    {
                        e.Cancel = false; //Procedo con la chiusura della form
                        this.DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        e.Cancel = true; //Annullo la chiusuro della form
                    }
                }
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            DialogResult _drMessageBox =
                MessageBox.Show("Sei sicur* di voler salvare ed uscire?", "SALVA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(_drMessageBox == DialogResult.Yes)
            {
                bool _erroriNelSalvataggio = false;

                //Salvataggio dei dati dello strumento: Solo se l'utente è admin software
                if(ClsArchivio.UtenteAttuale.AdminSoftware)
                {
                    try
                    {
                        if (ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento)
                        {
                            //Modalità inserimento: istanzio '_strumentoMusicale' come nuova istanza in base al tipo
                            if (cbStrumento.SelectedIndex ==
                                Convert.ToInt32(Program.eTIPO_STRUMENTO.Batteria))
                            {
                                _strumentoMusicale = new ClsBatteria();
                            }
                            else if (cbStrumento.SelectedIndex ==
                                Convert.ToInt32(Program.eTIPO_STRUMENTO.Legno))
                            {
                                _strumentoMusicale = new ClsLegno();
                            }
                            else if (cbStrumento.SelectedIndex ==
                                Convert.ToInt32(Program.eTIPO_STRUMENTO.Ottone))
                            {
                                _strumentoMusicale = new ClsOttone();
                            }
                            else if (cbStrumento.SelectedIndex ==
                                Convert.ToInt32(Program.eTIPO_STRUMENTO.Pianoforte))
                            {
                                _strumentoMusicale = new ClsPianoforte();
                            }
                            else if (cbStrumento.SelectedIndex ==
                                Convert.ToInt32(Program.eTIPO_STRUMENTO.Strumento_a_corda))
                            {
                                _strumentoMusicale = new ClsStrumentoACorda();
                            }
                        }

                        //Salvo i dati generali
                        _strumentoMusicale.CasaProduttriceID =
                            ClsArchivio.CaseProduttrici[cbCasaProduttrice.SelectedIndex].ID;
                        _strumentoMusicale.Colori = tbColori.Text;
                        _strumentoMusicale.Immagine = null; //Gestione immagini ancora da implementare
                        _strumentoMusicale.Modello = tbModello.Text;
                        if (cbNotaMassima.Enabled)
                        {
                            _strumentoMusicale.NotaMassimaID =
                                ClsArchivio.NoteMusicali[cbNotaMassima.SelectedIndex].ID;
                        }
                        else
                        {
                            _strumentoMusicale.NotaMassimaID = -1;
                        }
                        if (cbNotaMinima.Enabled)
                        {
                            _strumentoMusicale.NotaMinimaID =
                                ClsArchivio.NoteMusicali[cbNotaMinima.SelectedIndex].ID;
                        }
                        _strumentoMusicale.PesoKG = Convert.ToSingle(nudPeso.Value);

                        //Controllo il tipo di strumento creando un alias per copiare correttamente i dati mantenendo l'area di memoria di _strumentoMusicale
                        //Poi, in base alla modalità di entrata, inserisco o aggiorno nel DataBase
                        string _comunicazione = String.Empty;
                        if (_strumentoMusicale is ClsBatteria batteria) //batteria = alias
                        {
                            //Metto in _strumentoMusicale i dati di _dettagliBatteria, lasciando invariati i dati di generalizzazione
                            ClsBatteriaBL.Clona(_dettagliBatteria, ref batteria, false);
                            if(ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento)
                            {
                                batteria.ID = ClsBatteriaBL.InsertBatteria(Program._connectionString, batteria, out _comunicazione);
                            }
                            else if(ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica)
                            {
                                ClsBatteriaBL.UpdateBatteria(Program._connectionString, batteria, out _comunicazione);
                            }
                        }
                        else if (_strumentoMusicale is ClsLegno legno)
                        {
                            ClsLegnoBL.Clona(_dettagliLegno, ref legno, false);
                            if(ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento)
                            {
                                legno.ID = ClsLegnoBL.InsertLegno(Program._connectionString, legno, out _comunicazione);
                            }
                            else if(ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica)
                            {
                                ClsLegnoBL.UpdateLegno(Program._connectionString, legno, out _comunicazione);
                            }
                        }
                        else if (_strumentoMusicale is ClsOttone ottone)
                        {
                            ClsOttoneBL.Clona(_dettagliOttone, ref ottone, false);
                            if(ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento)
                            {
                                ottone.ID = ClsOttoneBL.InsertOttone(Program._connectionString, ottone, out _comunicazione);
                            }
                            else if(ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica)
                            {
                                ClsOttoneBL.UpdateOttone(Program._connectionString, ottone, out _comunicazione);
                            }
                        }
                        else if (_strumentoMusicale is ClsPianoforte pianoforte)
                        {
                            ClsPianoforteBL.Clona(_dettagliPianoforte, ref pianoforte, false);
                            if(ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento)
                            {
                                pianoforte.ID = ClsPianoforteBL.InsertPianoforte(Program._connectionString, pianoforte, out _comunicazione);
                            }
                            else if(ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica)
                            {
                                ClsPianoforteBL.UpdatePianoforte(Program._connectionString, pianoforte, out _comunicazione);
                            }
                        }
                        else if (_strumentoMusicale is ClsStrumentoACorda strumentoACorda)
                        {
                            ClsStrumentoACordaBL.Clona(_dettagliStrumentoACorda, ref strumentoACorda, false);
                            if (ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento)
                            {
                                strumentoACorda.ID = ClsStrumentoACordaBL.InsertStrumentoACorda(Program._connectionString, strumentoACorda, out _comunicazione);
                            }
                            else
                            {
                                ClsStrumentoACordaBL.UpdateStrumentoACorda(Program._connectionString, strumentoACorda, out _comunicazione);
                            }
                        }

                        MessageBox.Show(_comunicazione, "SALVA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _erroriNelSalvataggio = false;
                    }
                    catch(Exception ex)
                    {
                        _erroriNelSalvataggio = true;
                        MessageBox.Show("Errore nel salvataggio delle specifiche dello strumento:\r\n" + ex, "SALVA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //Salvataggio dei dati della vendere: solo se l'utente gestisce il negozio attuale
                //Si può solo modificare. Per aggiungerla devi fare da FrmSceltaInserimentoStrumentoMusicale
                if(UtenteGestisceNegozioAttuale && ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica)
                {
                    try
                    {
                        string _comunicazione2 = String.Empty;

                        _vendereStrumentoMusicale.Prezzo = nudPrezzo.Value;
                        _vendereStrumentoMusicale.Quantita = Convert.ToUInt16(nudQuantita.Value);

                        ClsVendereBL.UpdateVendere(Program._connectionString, _vendereStrumentoMusicale, out _comunicazione2);

                        MessageBox.Show(_comunicazione2, "SALVA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _erroriNelSalvataggio = false;
                    }
                    catch(Exception ex)
                    {
                        _erroriNelSalvataggio = true;
                        MessageBox.Show("Errore nel salvataggio del prezzo e/o della quantità:\r\n" + ex, "SALVA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if(_erroriNelSalvataggio == false)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            DialogResult _drMessageBox =
                MessageBox.Show("Sei sicur* di voler uscire senza salvare?", "ANNULLA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(_drMessageBox == DialogResult.Yes)
            {
                _bottoneAnnullaPremuto = true;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else
            {
                _bottoneAnnullaPremuto = false;
            }
        }
    }
    
}
