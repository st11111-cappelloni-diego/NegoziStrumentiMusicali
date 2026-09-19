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
    /// Sviluppo e GUI: Diego Cappelloni
    /// </summary>
    public partial class FrmPiatto : Form
    {
        #region Variabili Globali
        public ClsPiatto _piatto;
        public ClsBatteriaPiatto _batteriaPiatto;
        public Program.eMODALITA_ENTRATA_DETAIL _modalitaEntrataDetail;
        private Program.eMODALITA_ENTRATA_DETAIL _modalitaEntrataMaster;

        #endregion

        #region Metodi della form
        private void CaricaDati(ClsPiatto piatto)
        {
            cbMateriale.SelectedIndex = Convert.ToInt32(piatto.Materiale);
            cbTipo.SelectedIndex = Convert.ToInt32(piatto.Tipo);
            nudDiametro.Value = Convert.ToDecimal(piatto.DiametroIN);
        }

        private void AbilitaControlliGraficiInput(bool controlliAbilitati)
        {
            cbMateriale.Enabled = controlliAbilitati;
            cbTipo.Enabled = controlliAbilitati;
            nudDiametro.Enabled = controlliAbilitati;
            btnSalva.Enabled = controlliAbilitati;
        }

        #endregion

        public FrmPiatto(Program.eMODALITA_ENTRATA_DETAIL modalitaEntrataMaster)
        {
            InitializeComponent();

            nudDiametro.Minimum = 1;
            nudDiametro.Maximum = byte.MaxValue;

            cbMateriale.DataSource = Enum.GetNames(typeof(ClsPiatto.eMATERIALE));
            //Non metto il charleston perchè viene inserito su FrmBatteria
            cbTipo.DataSource = new List<ClsPiatto.eTIPO>()
            {
                ClsPiatto.eTIPO.china,
                ClsPiatto.eTIPO.crash,
                ClsPiatto.eTIPO.ride
            };

            this.DialogResult = DialogResult.Cancel;

            _modalitaEntrataMaster = modalitaEntrataMaster;
        }

        private void FrmPiatto_Load(object sender, EventArgs e)
        {
            if(_modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Modifica
                || _modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione)
            {
                CaricaDati(_piatto);
            }

            if(_modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Inserimento
                || _modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Modifica)
            {
                AbilitaControlliGraficiInput(true);
                btnSalva.Visible = true;
            }
            else
            {
                AbilitaControlliGraficiInput(false);
                btnSalva.Visible = false;
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            DialogResult _drMessageBox =
            MessageBox.Show("Sei sicur* di voler salvare ed uscire?", "SALVA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (_drMessageBox == DialogResult.Yes)
            {
                try
                {                   
                    _piatto.Tipo = (ClsPiatto.eTIPO)cbTipo.SelectedIndex;
                    _piatto.DiametroIN = Convert.ToByte(nudDiametro.Value);
                    _piatto.Materiale = (ClsPiatto.eMATERIALE)cbMateriale.SelectedIndex;

                    if(_modalitaEntrataMaster == Program.eMODALITA_ENTRATA_DETAIL.Modifica)
                    {
                        string _comunicazione = String.Empty;

                        ClsPiatto _ricercaPiatto = new ClsPiatto();

                        //Controllo se già esiste il piatto coi nuovi dati
                        _ricercaPiatto = ClsPiattoBL.GetOnePiatto(Program._connectionString, _piatto.Tipo, _piatto.DiametroIN, _piatto.Materiale, out _comunicazione);

                        if (_ricercaPiatto == null)
                        {
                            //Non esiste: creo il nuovo tamburo
                            _piatto.ID = ClsPiattoBL.InsertPiatto(Program._connectionString, _piatto, out _comunicazione);
                        }
                        else
                        {
                            //Esiste
                            _piatto.ID = _ricercaPiatto.ID;
                        }

                        //Associo il piatto alla batteria in caso non ci sia già l'associazione
                        ClsBatteriaPiatto _ricercaBP = new ClsBatteriaPiatto();
                        _ricercaBP = ClsBatteriaPiattoBL.GetOneBatteriaPiatto(Program._connectionString, _batteriaPiatto.BatteriaID, _piatto.ID, out _comunicazione, true);

                        //Se non esiste l'associazione la creo ed elimino quella vecchia
                        if (_ricercaBP == null)
                        {
                            ClsBatteriaPiattoBL.DeleteBatteriaPiatto(Program._connectionString, _batteriaPiatto, out _comunicazione, true);

                            ClsBatteriaPiatto _batteriaPiattoNew = new ClsBatteriaPiatto();
                            _batteriaPiattoNew.BatteriaID = _batteriaPiatto.BatteriaID;
                            _batteriaPiattoNew.PiattoID = _piatto.ID;
                            _batteriaPiattoNew.ID = ClsBatteriaPiattoBL.InsertBatteriaPiatto(Program._connectionString, _batteriaPiattoNew, out _comunicazione, true);
                            _batteriaPiatto = _batteriaPiattoNew;
                        }

                        MessageBox.Show(_comunicazione, "SALVATAGGIO DATI PIATTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.DialogResult = DialogResult.OK;
                 
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore nel salvataggio del piatto:\r\n" + ex.Message, "SALVA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
}
