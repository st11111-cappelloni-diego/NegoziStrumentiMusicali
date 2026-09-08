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
    public partial class FrmBatteria : Form
    {
        #region Variabili
        private ClsBatteria _batteria = new ClsBatteria();
        private Program.eMODALITA_ENTRATA_DETAIL _modalitaEntrata;
        private List<ClsPiatto> _piatti = new List<ClsPiatto>();
        private List<ClsTamburo> _tamburi = new List<ClsTamburo>();
        private ClsPiatto _charleston = new ClsPiatto();
        private ClsTamburo _cassa = new ClsTamburo();
        private ClsTamburo _rullante = new ClsTamburo();

        #endregion
        #region Proprietà
        public ClsBatteria Batteria { get => _batteria; set => _batteria = value; }
        public Program.eMODALITA_ENTRATA_DETAIL ModalitaEntrata { get => _modalitaEntrata; set => _modalitaEntrata = value; }

        #endregion
        #region Metodi della form
        /// <summary>
        /// Trova tutti i tamburi di una batteria
        /// </summary>
        /// <param name="IDbatteria"></param>
        /// <returns></returns>
        private List<ClsTamburo> TrovaTamburi(long IDbatteria, out string comunicazione)
        {
            comunicazione = String.Empty;
            List<ClsTamburo> _tamburi = new List<ClsTamburo>();

            string _temp = String.Empty;

            //Trovo prima tutte le batteriatamburo con l'ID della batteria
            List<ClsBatteriaTamburo> _listaBatteriaTamburo =
                ClsBatteriaTamburoBL.GetSomeBatteriaTamburo
                (
                    Program._connectionString,
                    out _temp,
                    IDbatteria,
                    -1
                );

            //Aggiungo alla lista, tamburo per tamburo dal DB, i tamburi della batteria
            ClsTamburo _tamburoTemp = new ClsTamburo();
            for (int i = 0; i < _listaBatteriaTamburo.Count(); i++)
            {
                _tamburoTemp = ClsTamburoBL.GetOneTamburo
                    (
                        Program._connectionString,
                        _listaBatteriaTamburo[i].TamburoID,
                        out _temp
                    );

                //Se il piatto non è null posso aggiungerlo alla lista
                if (_tamburoTemp != null)
                {
                    _tamburi.Add(_tamburoTemp);
                }
                else //Se è nullo aggiungo alla lista degli errori del caricamento la comunicazione in uscita del GetOne
                {
                    comunicazione += "Errore nel caricamento del tamburo con ID = "
                                     + _listaBatteriaTamburo[i].TamburoID.ToString() +
                                     ":\r\n";
                    comunicazione += _temp + "\r\n";
                }
            }

            //Se la stringa di comunicazione non è vuota aggiungo all'inizio un messaggio
            if (!String.IsNullOrWhiteSpace(comunicazione))
            {
                comunicazione = "Ci sono stati degli errori nel caricamento dei tamburi:\r\n" + comunicazione;
            }

            return _tamburi;
        }
        /// <summary>
        /// Trova tutti i piatti di una batteria
        /// </summary>
        /// <param name="IDbatteria"></param>
        /// <returns></returns>
        private List<ClsPiatto> TrovaPiatti(long IDbatteria, out string comunicazione)
        {
            comunicazione = String.Empty;
            List<ClsPiatto> _piatti = new List<ClsPiatto>();

            string _temp = String.Empty;

            //Trovo prima tutte le batteriapiatto con l'ID della batteria
            List<ClsBatteriaPiatto> _listaBatteriaPiatto =
                ClsBatteriaPiattoBL.GetSomeBatteriaPiatto
                (
                    Program._connectionString,
                    out _temp,
                    IDbatteria,
                    -1
                );

            //Aggiungo alla lista, piatto per piatto dal DB, i piatti della batteria
            ClsPiatto _piattoTemp = new ClsPiatto();
            for (int i = 0; i < _listaBatteriaPiatto.Count(); i++)
            {
                _piattoTemp = ClsPiattoBL.GetOnePiatto
                    (
                        Program._connectionString,
                        _listaBatteriaPiatto[i].PiattoID,
                        out _temp
                    );

                //Se il piatto non è null posso aggiungerlo alla lista
                if (_piattoTemp != null)
                {
                    _piatti.Add(_piattoTemp);
                }
                else //Se è nullo aggiungo alla lista degli errori del caricamento la comunicazione in uscita del GetOne
                {
                    comunicazione += "Errore nel caricamento del piatto con ID = "
                                     + _listaBatteriaPiatto[i].PiattoID.ToString() +
                                     ":\r\n";
                    comunicazione += _temp + "\r\n";
                }
            }

            //Se la stringa di comunicazione non è vuota aggiungo all'inizio un messaggio
            if (!String.IsNullOrWhiteSpace(comunicazione))
            {
                comunicazione = "Ci sono stati degli errori nel caricamento dei piatti:\r\n" + comunicazione;
            }

            return _piatti;
        }
        private void PopolaListView(ListView listView, List<ClsPiatto> listaPiatti, bool includiCharleston)
        {
            //Svuoto la listview
            listView.Items.Clear();

            //La ripopolo
            //Scorro tutta la lista dei piatti
            ListViewItem _lvi = new ListViewItem();
            for (int i = 0; i < listaPiatti.Count(); i++)
            {
                //Escludo i charleston se è richiesto
                if (!(listaPiatti[i].Tipo == ClsPiatto.eTIPO.charleston && includiCharleston == false))
                {
                    //Popolo il litview item
                    //Prima colonna: tipo
                    _lvi = new ListViewItem(listaPiatti[i].Tipo.ToString());
                    //Seconda colonna: diametro
                    _lvi.SubItems.Add(listaPiatti[i].DiametroIN.ToString());
                    //Terza colonna: materiale
                    _lvi.SubItems.Add(listaPiatti[i].Materiale.ToString());

                    //Tag
                    _lvi.Tag = listaPiatti[i];

                    //Aggiungo l'item alla listview
                    listView.Items.Add(_lvi);
                }
            }
        }
        private void PopolaListView(ListView listView, List<ClsTamburo> listaTamburi, bool includiCassa, bool includiRullante)
        {
            //Svuoto la listview
            listView.Items.Clear();

            //La ripopolo
            //Scorro tutta la lista dei piatti
            ListViewItem _lvi = new ListViewItem();
            for (int i = 0; i < listaTamburi.Count(); i++)
            {
                //Escludo il rullante e/o la cassa se richiesto
                if ((listaTamburi[i].Tipo != ClsTamburo.eTIPO.cassa || includiCassa)
                    &&
                    (listaTamburi[i].Tipo != ClsTamburo.eTIPO.rullante || includiRullante))
                {
                    //Popolo il litview item
                    //Prima colonna: tipo
                    _lvi = new ListViewItem(listaTamburi[i].Tipo.ToString());
                    //Seconda colonna: diametro
                    _lvi.SubItems.Add(listaTamburi[i].DiametroIN.ToString());
                    //Terza colonna: strati
                    _lvi.SubItems.Add(listaTamburi[i].Strati.ToString());
                    //Quarta colonna: materiale
                    _lvi.SubItems.Add(listaTamburi[i].Materiale.ToString());

                    //Tag
                    _lvi.Tag = listaTamburi[i];

                    //Aggiungo l'item alla listview
                    listView.Items.Add(_lvi);
                }
            }
        }
        private void AbilitaControlliGraficiDiInput(bool controlliAbilitati)
        {
            btnEliminaPiatto.Enabled = controlliAbilitati;
            btnModificaPiatto.Enabled = controlliAbilitati;
            btnNuovoPiatto.Enabled = controlliAbilitati;
            lvAltriPiatti.Enabled = true; //Le listview sono sempre abilitate in modo che si possono scorrere i suoi elementi
            pnlCassa.Enabled = controlliAbilitati;
            pnlCharleston.Enabled = controlliAbilitati;
            pnlRullante.Enabled = controlliAbilitati;
            btnNuovoTom.Enabled = controlliAbilitati;
            btnModificaTom.Enabled = controlliAbilitati;
            btnEliminaTom.Enabled = controlliAbilitati;
            lvToms.Enabled = true;

            btnSalva.Enabled = controlliAbilitati;
        }
        private async Task CaricaDati(ClsBatteria batteria)
        {
            //Trovo, in due processi paralleli, tamburi e piatti della batteria
            string _comunicazionePiatti = String.Empty;
            string _comunicazioneTamburi = String.Empty;
            await Task.WhenAll
            (
                Task.Run(() =>
                    _piatti = TrovaPiatti(batteria.ID, out _comunicazionePiatti)
                ),
                Task.Run(() =>
                    _tamburi = TrovaTamburi(batteria.ID, out _comunicazioneTamburi)
                )
            );

            //Se le comunicazioni non sono vuote le metto a schermo
            if (!String.IsNullOrWhiteSpace(_comunicazionePiatti))
            {
                MessageBox.Show(_comunicazionePiatti, "CARICAMENTO PIATTI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!String.IsNullOrWhiteSpace(_comunicazioneTamburi))
            {
                MessageBox.Show(_comunicazioneTamburi, "CARICAMENTO TAMBURI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Popolo le listview escludendo cassa, rullante e charleston
            PopolaListView(lvAltriPiatti, _piatti, false);
            PopolaListView(lvToms, _tamburi, false, false);

            //Trovo la cassa, il rullante ed il charleston
            //(solo la prima occorrenza perchè per ogni batteria ci può essere solo uno per componente tra queste 3)
            _cassa = _tamburi.FirstOrDefault(t => t.Tipo == ClsTamburo.eTIPO.cassa);
            _rullante = _tamburi.FirstOrDefault(t => t.Tipo == ClsTamburo.eTIPO.rullante);
            _charleston = _piatti.FirstOrDefault(c => c.Tipo == ClsPiatto.eTIPO.charleston);

            //Carico i dati della cassa
            cbMaterialeCassa.SelectedIndex = Convert.ToInt32(_cassa.Materiale);
            nudDiametroCassa.Value = Convert.ToInt32(_cassa.DiametroIN);
            nudStratiCassa.Value = Convert.ToInt32(_cassa.Strati);

            //Carico i dati del rullante
            cbMaterialeRullante.SelectedIndex = Convert.ToInt32(_rullante.Materiale);
            nudDiametroRullante.Value = Convert.ToInt32(_rullante.DiametroIN);
            nudStratiRullante.Value = Convert.ToInt32(_rullante.Strati);

            //Carico i dati del charleston
            cbMaterialeCharleston.SelectedIndex = Convert.ToInt32(_charleston.Materiale);
            nudDiametroCharleston.Value = Convert.ToInt32(_charleston.DiametroIN);
        }
        #endregion
        public FrmBatteria(Program.eMODALITA_ENTRATA_DETAIL modalitaEntrata, ClsBatteria batteria)
        {
            InitializeComponent();

            //Popolo le combobox
            cbMaterialeCassa.DataSource = Enum.GetNames(typeof(ClsTamburo.eMATERIALE));
            cbMaterialeRullante.DataSource = Enum.GetNames(typeof(ClsTamburo.eMATERIALE));
            cbMaterialeCharleston.DataSource = Enum.GetNames(typeof(ClsPiatto.eMATERIALE));

            nudDiametroCassa.Minimum = 1;
            nudDiametroCassa.Maximum = byte.MaxValue;
            nudDiametroCharleston.Minimum = 1;
            nudDiametroCharleston.Maximum = byte.MaxValue;
            nudDiametroRullante.Minimum = 1;
            nudDiametroRullante.Maximum = byte.MaxValue;
            nudStratiCassa.Minimum = 1;
            nudStratiCassa.Maximum = byte.MaxValue;
            nudStratiRullante.Minimum = 1;
            nudStratiRullante.Maximum = byte.MaxValue;

            lvToms.MultiSelect = false;
            lvToms.FullRowSelect = true;
            lvAltriPiatti.MultiSelect = false;
            lvAltriPiatti.FullRowSelect = true;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            ModalitaEntrata = modalitaEntrata;
            Batteria = batteria;
        }

        private void FrmBatteria_Load(object sender, EventArgs e)
        {
            CaricaDati(Batteria);

            //Se l'utente attuale è admin software e sono in modalità modifica o inserimento
            //Abilito i controlli grafici di input
            if (ClsArchivio.UtenteAttuale.AdminSoftware &&
                (ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica
                || ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento))
            {
                AbilitaControlliGraficiDiInput(true);
            }
            else
            {
                AbilitaControlliGraficiDiInput(false);
            }
        }

        private void btnModificaTom_Click(object sender, EventArgs e)
        {
            if (lvToms.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Selezionare un elemento", "MODIFICA TAMBURO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (lvToms.SelectedItems.Count == 1)
            {
                //Istanzio la form detail
                FrmTamburo _frmTamburo = new FrmTamburo();

                //Gli passo il tamburo selezionato
                string _com = String.Empty;
                ClsTamburo _tamburo = (ClsTamburo)lvToms.SelectedItems[0].Tag;
                _frmTamburo._tamburo = _tamburo;
                _frmTamburo._batteriaTamburo = ClsBatteriaTamburoBL.GetOneBatteriaTamburo(Program._connectionString, _batteria.ID, _tamburo.ID, out _com);

                //Specifico la modalità di entrata
                _frmTamburo._modalitaEntrataDetail = Program.eMODALITA_ENTRATA_DETAIL.Modifica;

                //Apro la form
                _frmTamburo.ShowDialog(this);

                //Alla chiusura ripopolo la ListView
                PopolaListView(lvToms, _tamburi, false, false);
            }
        }

        private void btnModificaPiatto_Click(object sender, EventArgs e)
        {
            if (lvAltriPiatti.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Selezionare un elemento", "MODIFICA PIATTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (lvAltriPiatti.SelectedItems.Count == 1)
            {
                //Istanzio la form detail
                FrmPiatto _frmPiatto = new FrmPiatto();

                //Gli passo il tamburo selezionato
                string _com = String.Empty;
                ClsPiatto _piatto = (ClsPiatto)lvAltriPiatti.SelectedItems[0].Tag;
                _frmPiatto._piatto = _piatto;
                _frmPiatto._batteriaPiatto = ClsBatteriaPiattoBL.GetOneBatteriaPiatto(Program._connectionString, _batteria.ID, _piatto.ID, out _com);

                //Specifico la modalità di entrata
                _frmPiatto._modalitaEntrataDetail = Program.eMODALITA_ENTRATA_DETAIL.Modifica;

                //Apro la form
                _frmPiatto.ShowDialog(this);

                //Alla chiusura ripopolo la ListView
                PopolaListView(lvAltriPiatti, _piatti, false);
            }
        }

        private void btnNuovoTom_Click(object sender, EventArgs e)
        {
            //Istanzio la form detail
            FrmTamburo _frmTamburo = new FrmTamburo();

            ClsTamburo _tamburo = new ClsTamburo();
            _frmTamburo._tamburo = _tamburo;
            _frmTamburo._batteriaTamburo = new ClsBatteriaTamburo();
            _frmTamburo._batteriaTamburo.BatteriaID = _batteria.ID;

            //Specifico la modalità di entrata
            _frmTamburo._modalitaEntrataDetail = Program.eMODALITA_ENTRATA_DETAIL.Inserimento;

            //Apro la form
            DialogResult _dr = _frmTamburo.ShowDialog(this);

            if(_modalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica)
            {
                string _comunicazione = String.Empty;
                _tamburi = TrovaTamburi(_batteria.ID, out _comunicazione);
            }
            else if(_dr == DialogResult.OK && _modalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento)
            {
                _tamburi.Add(_tamburo);
            }

            //Alla chiusura ripopolo la ListView
            PopolaListView(lvToms, _tamburi, false, false);
        }

        private void btnNuovoPiatto_Click(object sender, EventArgs e)
        {
            //Istanzio la form detail
            FrmPiatto _frmPiatto = new FrmPiatto();

            ClsPiatto _piatto = new ClsPiatto();
            _frmPiatto._piatto = _piatto;
            _frmPiatto._batteriaPiatto = new ClsBatteriaPiatto();
            _frmPiatto._batteriaPiatto.BatteriaID = _batteria.ID;

            //Specifico la modalità di entrata
            _frmPiatto._modalitaEntrataDetail = Program.eMODALITA_ENTRATA_DETAIL.Inserimento;

            //Apro la form
            DialogResult _dr = _frmPiatto.ShowDialog(this);

            if(_modalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica)
            {
                string _comunicazione = String.Empty;
                _piatti = TrovaPiatti(_batteria.ID, out _comunicazione);
            }
            else if(_dr == DialogResult.OK && _modalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento)
            {
                _piatti.Add(_piatto);
            }

            //Alla chiusura ripopolo la ListView
            PopolaListView(lvAltriPiatti, _piatti, false);
        }

        private void btnEliminaTom_Click(object sender, EventArgs e)
        {
            if (lvToms.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Selezionare un elemento", "RIMUOVI TAMBURO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult _dr = MessageBox.Show("Sei sicur* di voler rimuovere il tamburo dalla batteria?", "RIMUOVI TAMBURO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (_dr == DialogResult.Yes)
                {
                    string _comunicazione = String.Empty;

                    //Tamburo da rimuovere
                    ClsTamburo _tamburoDaRimuovere = (ClsTamburo)lvToms.SelectedItems[0].Tag;

                    //Trovo il batteriatamburo
                    ClsBatteriaTamburo _batteriaTamburo = ClsBatteriaTamburoBL.GetOneBatteriaTamburo(Program._connectionString, _batteria.ID, _tamburoDaRimuovere.ID, out _comunicazione);

                    if (_batteriaTamburo == null)
                    {
                        MessageBox.Show(_comunicazione, "RIMUOVI TAMBURO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        ClsBatteriaTamburoBL.DeleteBatteriaTamburo(Program._connectionString, _batteriaTamburo, out _comunicazione);

                        MessageBox.Show(_comunicazione, "RIMUOVI TAMBURO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _tamburi = TrovaTamburi(_batteria.ID, out _comunicazione);

                        PopolaListView(lvToms, _tamburi, false, false);
                    }
                }
            }
        }

        private void btnEliminaPiatto_Click(object sender, EventArgs e)
        {
            if (lvAltriPiatti.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Selezionare un elemento", "RIMUOVI PIATTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult _dr = MessageBox.Show("Sei sicur* di voler rimuovere il piatto dalla batteria?", "RIMUOVI PIATTO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (_dr == DialogResult.Yes)
                {
                    string _comunicazione = String.Empty;

                    //Tamburo da rimuovere
                    ClsPiatto _piattoDaRimuovere = (ClsPiatto)lvAltriPiatti.SelectedItems[0].Tag;

                    //Trovo il batteriatamburo
                    ClsBatteriaPiatto _batteriaPiatto = ClsBatteriaPiattoBL.GetOneBatteriaPiatto(Program._connectionString, _batteria.ID, _piattoDaRimuovere.ID, out _comunicazione);

                    if (_batteriaPiatto == null)
                    {
                        MessageBox.Show(_comunicazione, "RIMUOVI PIATTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        ClsBatteriaPiattoBL.DeleteBatteriaPiatto(Program._connectionString, _batteriaPiatto, out _comunicazione);

                        MessageBox.Show(_comunicazione, "RIMUOVI PIATTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _piatti = TrovaPiatti(_batteria.ID, out _comunicazione);

                        PopolaListView(lvAltriPiatti, _piatti, false);
                    }
                }
            }

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            DialogResult _dr = MessageBox.Show("Sei sicur* di voler salvare ed uscire?", "SALVA ED ESCI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(_dr == DialogResult.Yes)
            {
                try
                {
                    string _comunicazione = String.Empty;

                    //Salvo i dati della cassa
                    _cassa.DiametroIN = Convert.ToByte(nudDiametroCassa.Value);
                    _cassa.Tipo = ClsTamburo.eTIPO.cassa;
                    _cassa.Strati = Convert.ToByte(nudStratiCassa.Value);
                    _cassa.Materiale = (ClsTamburo.eMATERIALE)cbMaterialeCassa.SelectedIndex;

                    //Salvo i dati del rullante
                    _rullante.DiametroIN = Convert.ToByte(nudDiametroRullante.Value);
                    _rullante.Tipo = ClsTamburo.eTIPO.rullante;
                    _rullante.Strati = Convert.ToByte(nudDiametroRullante.Value);
                    _rullante.Materiale = (ClsTamburo.eMATERIALE)cbMaterialeRullante.SelectedIndex;

                    //Salvo i dati del charleston
                    _charleston.DiametroIN = Convert.ToByte(nudDiametroCharleston.Value);
                    _charleston.Tipo = ClsPiatto.eTIPO.charleston;
                    _charleston.Materiale = (ClsPiatto.eMATERIALE)cbMaterialeCharleston.SelectedIndex;

                    if(_modalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento)
                    {
                        //Inserisco la batteria
                        _batteria.ID = ClsBatteriaBL.InsertBatteria(Program._connectionString, _batteria, out _comunicazione);


                        //Controllo se già esiste la cassa
                        ClsTamburo _ricercaCassa = new ClsTamburo();
                        _ricercaCassa = ClsTamburoBL.GetOneTamburo(Program._connectionString, _cassa.Tipo, _cassa.DiametroIN, _cassa.Materiale, _cassa.Strati, out _comunicazione);

                        if (_ricercaCassa == null)
                        {
                            //Non esiste: creo il nuovo tamburo
                            _cassa.ID = ClsTamburoBL.InsertTamburo(Program._connectionString, _cassa, out _comunicazione);
                        }
                        else
                        {
                            //Esiste
                            _cassa.ID = _ricercaCassa.ID;
                        }

                        //Creo la relazione tra batteria e cassa
                        ClsBatteriaTamburo _batteriaCassa = new ClsBatteriaTamburo();
                        _batteriaCassa.BatteriaID = _batteria.ID;
                        _batteriaCassa.TamburoID = _cassa.ID;

                        _batteriaCassa.ID = ClsBatteriaTamburoBL.InsertBatteriaTamburo(Program._connectionString, _batteriaCassa, out _comunicazione);


                        //Controllo se esiste già il rullante

                        //Controllo se già esiste la cassa
                        ClsTamburo _ricercaRullante = new ClsTamburo();
                        _ricercaRullante = ClsTamburoBL.GetOneTamburo(Program._connectionString, _rullante.Tipo, _rullante.DiametroIN, _rullante.Materiale, _rullante.Strati, out _comunicazione);

                        if (_ricercaRullante == null)
                        {
                            //Non esiste: creo il nuovo tamburo
                            _rullante.ID = ClsTamburoBL.InsertTamburo(Program._connectionString, _rullante, out _comunicazione);
                        }
                        else
                        {
                            //Esiste
                            _rullante.ID = _ricercaRullante.ID;
                        }

                        //Creo la relazione tra batteria e rullante
                        ClsBatteriaTamburo _batteriaRullante = new ClsBatteriaTamburo();
                        _batteriaRullante.BatteriaID = _batteria.ID;
                        _batteriaRullante.TamburoID = _rullante.ID;

                        _batteriaRullante.ID = ClsBatteriaTamburoBL.InsertBatteriaTamburo(Program._connectionString, _batteriaRullante, out _comunicazione);


                        //Controllo se già esiste il charleston
                        ClsPiatto _ricercaCharleston = new ClsPiatto();
                        _ricercaCharleston = ClsPiattoBL.GetOnePiatto(Program._connectionString, _charleston.Tipo, _charleston.DiametroIN, _charleston.Materiale, out _comunicazione);

                        if (_ricercaCharleston == null)
                        {
                            //Non esiste: creo il nuovo tamburo
                            _charleston.ID = ClsPiattoBL.InsertPiatto(Program._connectionString, _charleston, out _comunicazione);
                        }
                        else
                        {
                            //Esiste
                            _charleston.ID = _ricercaCharleston.ID;
                        }

                        //Creo la relazione tra batteria e charleston
                        ClsBatteriaPiatto _batteriaCharleston = new ClsBatteriaPiatto();
                        _batteriaCharleston.BatteriaID = _batteria.ID;
                        _batteriaCharleston.PiattoID = _charleston.ID;

                        _batteriaCharleston.ID = ClsBatteriaPiattoBL.InsertBatteriaPiatto(Program._connectionString, _batteriaCharleston, out _comunicazione);
                    }
                }
                catch(Exception ex)
                {

                }
            }
        }
    }
}
