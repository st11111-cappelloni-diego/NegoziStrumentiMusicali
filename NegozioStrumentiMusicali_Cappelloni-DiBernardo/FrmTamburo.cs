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
    public partial class FrmTamburo : Form
    {
        #region Variabili globali
        public ClsTamburo _tamburo;
        public Program.eMODALITA_ENTRATA_DETAIL _modalitaEntrataDetail;
        public ClsBatteriaTamburo _batteriaTamburo;

        #endregion

        #region Metodi della form
        private void CaricaDati(ClsTamburo tamburo)
        {
            cbMateriale.SelectedIndex = Convert.ToInt32(tamburo.Materiale);
            nudDiametro.Value = Convert.ToDecimal(tamburo.DiametroIN);
            nudStrati.Value = Convert.ToDecimal(tamburo.Strati);
            cbTipo.SelectedIndex = Convert.ToInt32(tamburo.Tipo);
        }

        private void AbilitaControlliGraficiInput(bool controlliAbilitati)
        {
            cbMateriale.Enabled = controlliAbilitati;
            nudDiametro.Enabled = controlliAbilitati;
            nudStrati.Enabled = controlliAbilitati;
            btnSalva.Enabled = controlliAbilitati;
        }

        #endregion

        public FrmTamburo()
        {
            InitializeComponent();

            cbMateriale.DataSource = Enum.GetNames(typeof(ClsTamburo.eMATERIALE));
            //Escludo cassa e rullante perchè si inseriscono dalla FrmBatteria
            cbTipo.DataSource = new List<ClsTamburo.eTIPO>
            {
                ClsTamburo.eTIPO.timpano,
                ClsTamburo.eTIPO.tom
            };
        }

        private void FrmTamburo_Load(object sender, EventArgs e)
        {
            if(_modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Modifica
                || _modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione)
            {
                CaricaDati(_tamburo);
            }

            if((_modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Inserimento
                || _modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Modifica))
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

            if(_drMessageBox == DialogResult.Yes)
            {
                try
                {
                    string _comunicazione = String.Empty;

                    _tamburo.Tipo = (ClsTamburo.eTIPO)cbTipo.SelectedIndex;
                    _tamburo.DiametroIN = Convert.ToByte(nudDiametro.Value);
                    _tamburo.Materiale = (ClsTamburo.eMATERIALE)cbMateriale.SelectedIndex;
                    _tamburo.Strati = Convert.ToByte(nudStrati.Value);

                    ClsTamburo _ricercaTamburo = new ClsTamburo();

                        //Controllo se già esiste il tamburo coi nuovi dati
                        _ricercaTamburo = ClsTamburoBL.GetOneTamburo(Program._connectionString, _tamburo.Tipo, _tamburo.DiametroIN, _tamburo.Materiale, _tamburo.Strati, out _comunicazione);

                        if(_ricercaTamburo == null)
                        {
                            //Non esiste: creo il nuovo tamburo
                            _tamburo.ID = ClsTamburoBL.InsertTamburo(Program._connectionString, _tamburo, out _comunicazione);
                        }
                        else
                        {
                            //Esiste
                            _tamburo.ID = _ricercaTamburo.ID;
                        }

                        //Associo il tamburo alla batteria in caso non ci sia già l'associazione
                        ClsBatteriaTamburo _ricercaBT = new ClsBatteriaTamburo();
                        _ricercaBT = ClsBatteriaTamburoBL.GetOneBatteriaTamburo(Program._connectionString, _batteriaTamburo.BatteriaID, _tamburo.ID, out _comunicazione);

                        //Se non esiste l'associazione la creo ed elimino quella vecchia
                        if(_ricercaBT == null)
                        {
                            if(_modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Modifica)
                            {
                                ClsBatteriaTamburoBL.DeleteBatteriaTamburo(Program._connectionString, _batteriaTamburo, out _comunicazione);
                            }

                            ClsBatteriaTamburo _batteriaTamburoNew = new ClsBatteriaTamburo();
                            _batteriaTamburoNew.BatteriaID = _batteriaTamburo.BatteriaID;
                            _batteriaTamburoNew.TamburoID = _tamburo.ID;
                            _batteriaTamburoNew.ID = ClsBatteriaTamburoBL.InsertBatteriaTamburo(Program._connectionString, _batteriaTamburoNew, out _comunicazione);
                            _batteriaTamburo = _batteriaTamburoNew;
                        }


                    

                    MessageBox.Show(_comunicazione, "SALVATAGGIO DATI TAMBURO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Errore nel salvataggio del tamburo:\r\n" + ex, "SALVA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
