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
    public partial class FrmStrumentoACorda : Form
    {
        #region Variabili
        public ClsStrumentoACorda _strumentoACorda;
        private Program.eMODALITA_ENTRATA_DETAIL _modalitaEntrata;
        /// <summary>
        /// Backup del dato di cbPickup1 in caso di cambio strumento
        /// </summary>
        private ClsStrumentoACorda.ePICKUP _pickup1;
        /// <summary>
        /// Backup del dato di cbPickup2 in caso di cambio strumento
        /// </summary>
        private ClsStrumentoACorda.ePICKUP _pickup2;
        /// <summary>
        /// Backup del dato di cbPickup3 in caso di cambio strumento
        /// </summary>
        private ClsStrumentoACorda.ePICKUP _pickup3;
        /// <summary>
        /// Backup del dato di nudTasti in caso di cambio strumento
        /// </summary>
        private sbyte _tasti;

        #endregion
        #region Proprietà
        public Program.eMODALITA_ENTRATA_DETAIL ModalitaEntrata { get => _modalitaEntrata; set => _modalitaEntrata = value; }

        #endregion
        #region Metodi della form
        void CaricaDati(ClsStrumentoACorda strumentoACorda)
        {
            cbStrumento.SelectedIndex = Convert.ToInt32(strumentoACorda.Strumento);
            nudAmpiezzaCorpo.Value = Convert.ToDecimal(strumentoACorda.AmpiezzaCorpoCM);
            nudAmpiezzaManico.Value = Convert.ToDecimal(strumentoACorda.AmpiezzaManicoCM);
            nudLunghezzaCorpo.Value = Convert.ToDecimal(strumentoACorda.LunghezzaCorpoCM);
            nudLunghezzaManico.Value = Convert.ToDecimal(strumentoACorda.LunghezzaManicoCM);
            nudSpessoreCorpo.Value = Convert.ToDecimal(strumentoACorda.SpessoreCorpoCM);
            nudSpessoreManico.Value = Convert.ToDecimal(strumentoACorda.SpessoreManicoCM);
            if(strumentoACorda.Tasti <= -1)
            {
                nudTasti.Value = nudTasti.Minimum;
                nudTasti.Enabled = false;
                nudTasti.Visible = false;
                lblTasti.Visible = false;
            }
            else
            {
                nudTasti.Value = Convert.ToDecimal(strumentoACorda.Tasti);
                nudTasti.Visible = true;
                lblTasti.Visible = true;
            }
            cbMaterialeCorde.SelectedIndex = Convert.ToInt32(strumentoACorda.MaterialeCorde);
            cbMaterialeCorpo.SelectedIndex = Convert.ToInt32(strumentoACorda.MaterialeCorpo);
            cbMaterialeManico.SelectedIndex = Convert.ToInt32(strumentoACorda.MaterialeManico);
            cbMaterialeTastiera.SelectedIndex = Convert.ToInt32(strumentoACorda.MaterialeTastiera);
            nudCorde.Value = Convert.ToDecimal(strumentoACorda.NumeroCorde);
            cbPickup1.SelectedIndex = Convert.ToInt32(strumentoACorda.Pickup1);
            cbPickup2.SelectedIndex = Convert.ToInt32(strumentoACorda.Pickup2);
            cbPickup3.SelectedIndex = Convert.ToInt32(strumentoACorda.Pickup3);
            _pickup1 = (ClsStrumentoACorda.ePICKUP)cbPickup1.SelectedIndex;
            _pickup2 = (ClsStrumentoACorda.ePICKUP)cbPickup2.SelectedIndex;
            _pickup3 = (ClsStrumentoACorda.ePICKUP)cbPickup3.SelectedIndex;
            _tasti = Convert.ToSByte(nudTasti.Value);
        }

        void AbilitaControlliGraficiInput(bool controlliAbilitati)
        {
            nudAmpiezzaCorpo.Enabled = controlliAbilitati;
            nudAmpiezzaManico.Enabled = controlliAbilitati;
            nudCorde.Enabled = controlliAbilitati;
            nudLunghezzaCorpo.Enabled = controlliAbilitati;
            nudLunghezzaManico.Enabled = controlliAbilitati;
            nudSpessoreCorpo.Enabled = controlliAbilitati;
            nudSpessoreManico.Enabled = controlliAbilitati;
            nudTasti.Enabled = controlliAbilitati;

            cbMaterialeCorde.Enabled = controlliAbilitati;
            cbMaterialeCorpo.Enabled = controlliAbilitati;
            cbMaterialeManico.Enabled = controlliAbilitati;
            cbMaterialeTastiera.Enabled = controlliAbilitati;
            cbPickup1.Enabled = controlliAbilitati;
            cbPickup2.Enabled = controlliAbilitati;
            cbPickup3.Enabled = controlliAbilitati;
            cbStrumento.Enabled = controlliAbilitati;

            btnSalva.Enabled = controlliAbilitati;
        }

        #endregion
        public FrmStrumentoACorda(Program.eMODALITA_ENTRATA_DETAIL modalitaEntrata, ClsStrumentoACorda strumentoACorda)
        {
            InitializeComponent();

            ModalitaEntrata = modalitaEntrata;
            _strumentoACorda = strumentoACorda;

            //Popolo le varie combobox
            cbMaterialeCorde.DataSource = Enum.GetNames(typeof(ClsStrumentoACorda.eMATERIALE_CORDE));
            cbMaterialeCorpo.DataSource = Enum.GetNames(typeof(Program.eLEGNO));
            cbMaterialeManico.DataSource = Enum.GetNames(typeof(Program.eLEGNO));
            cbMaterialeTastiera.DataSource = Enum.GetNames(typeof(Program.eLEGNO));
            cbPickup1.DataSource = Enum.GetNames(typeof(ClsStrumentoACorda.ePICKUP));
            cbPickup2.DataSource = Enum.GetNames(typeof(ClsStrumentoACorda.ePICKUP));
            cbPickup3.DataSource = Enum.GetNames(typeof(ClsStrumentoACorda.ePICKUP));
            cbStrumento.DataSource = Enum.GetNames(typeof(ClsStrumentoACorda.eSTRUMENTI_A_CORDA));

            tbLunghezzaTotale.Enabled = false; //Sempre disabilitato perchè lunghezzaTotale è un campo calcolato
        }


        private void FrmStrumentoACorda_Load(object sender, EventArgs e)
        {
            //Se sono admin software e sono in modalità modifica o inserimento
            //Abilito i controlli grafici di input
            if(ClsArchivio.UtenteAttuale.AdminSoftware
                && (ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento
                || ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica))
            {
                AbilitaControlliGraficiInput(true);
            }
            else //Sennò li disabilito
            {
                AbilitaControlliGraficiInput(false);
            }

            CaricaDati(_strumentoACorda);
        }

        private void cbStrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStrumento.SelectedIndex != Convert.ToInt32(ClsStrumentoACorda.eSTRUMENTI_A_CORDA.basso_elettrico)
                && cbStrumento.SelectedIndex != Convert.ToInt32(ClsStrumentoACorda.eSTRUMENTI_A_CORDA.chitarra_elettrica)
                && cbStrumento.SelectedIndex != Convert.ToInt32(ClsStrumentoACorda.eSTRUMENTI_A_CORDA.chitarra_semiacustica)
                && cbStrumento.SelectedIndex != Convert.ToInt32(ClsStrumentoACorda.eSTRUMENTI_A_CORDA.lap_steel_guitar))
            {
                //Faccio il backup dei dati che possono cambiare da codice sui controlli grafici
                _pickup1 = (ClsStrumentoACorda.ePICKUP)cbPickup1.SelectedIndex;
                _pickup2 = (ClsStrumentoACorda.ePICKUP)cbPickup2.SelectedIndex;
                _pickup3 = (ClsStrumentoACorda.ePICKUP)cbPickup3.SelectedIndex;

                /*
                Se lo strumento non è uno dei seguenti:
                -Chitarra elettrica
                -Basso elettrico
                -Chitarra lap steel
                -Chitarra semiacustica
                Allora ha tutti gli attributi di tipo ePICKUP a 'No'
                */
                cbPickup1.SelectedIndex = Convert.ToInt32(ClsStrumentoACorda.ePICKUP.no);
                cbPickup2.SelectedIndex = Convert.ToInt32(ClsStrumentoACorda.ePICKUP.no);
                cbPickup3.SelectedIndex = Convert.ToInt32(ClsStrumentoACorda.ePICKUP.no);
                pnlPickup.Enabled = false;
            }
            else
            {
                if (ClsArchivio.UtenteAttuale.AdminSoftware
                && (ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento
                || ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica))
                {
                    pnlPickup.Enabled = true;
                }
                else
                {
                    pnlPickup.Enabled = false;
                }
                cbPickup1.SelectedIndex = Convert.ToInt32(_pickup1);
                cbPickup2.SelectedIndex = Convert.ToInt32(_pickup2);
                cbPickup3.SelectedIndex = Convert.ToInt32(_pickup3);
            }

            if(cbStrumento.SelectedIndex == Convert.ToInt32(ClsStrumentoACorda.eSTRUMENTI_A_CORDA.contrabbasso)
                || cbStrumento.SelectedIndex == Convert.ToInt32(ClsStrumentoACorda.eSTRUMENTI_A_CORDA.viola)
                || cbStrumento.SelectedIndex == Convert.ToInt32(ClsStrumentoACorda.eSTRUMENTI_A_CORDA.violino)
                || cbStrumento.SelectedIndex == Convert.ToInt32(ClsStrumentoACorda.eSTRUMENTI_A_CORDA.violoncello))
            {
                //Faccio il backup dei dati che possono cambiare da codice sui controlli grafici
                _tasti = Convert.ToSByte(nudTasti.Value);

                //In questi strumenti l'attributo tasti non è previsto
                nudTasti.Value = nudTasti.Minimum;
                nudTasti.Enabled = false;
                nudTasti.Visible = false;
                lblTasti.Visible = false;
            }
            else
            {
                if (ClsArchivio.UtenteAttuale.AdminSoftware
                && (ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento
                || ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica))
                {
                    nudTasti.Enabled = true;
                    nudTasti.Visible = true;
                    lblTasti.Visible = true;
                }
                else
                {
                    nudTasti.Enabled = false;
                    nudTasti.Visible = false;
                    lblTasti.Visible = false;
                }
                nudTasti.Value = Convert.ToDecimal(_tasti);
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if(ClsArchivio.UtenteAttuale.AdminSoftware)
            {
                DialogResult _dr =
                    MessageBox.Show("Sei sicur* di voler salvare ed uscire?", "SALVA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if(_dr == DialogResult.Yes)
                {
                    //Salvo i dati se l'utente è admin software
                    try
                    {
                        _strumentoACorda.Strumento =
                            (ClsStrumentoACorda.eSTRUMENTI_A_CORDA)cbStrumento.SelectedIndex;
                        _strumentoACorda.AmpiezzaCorpoCM = Convert.ToSingle(nudAmpiezzaCorpo.Value);
                        _strumentoACorda.AmpiezzaManicoCM = Convert.ToSingle(nudAmpiezzaManico.Value);
                        _strumentoACorda.LunghezzaCorpoCM = Convert.ToSingle(nudLunghezzaCorpo.Value);
                        _strumentoACorda.LunghezzaManicoCM = Convert.ToSingle(nudLunghezzaManico.Value);
                        _strumentoACorda.MaterialeCorde =
                            (ClsStrumentoACorda.eMATERIALE_CORDE)cbMaterialeCorde.SelectedIndex;
                        _strumentoACorda.MaterialeCorpo =
                            (Program.eLEGNO)cbMaterialeCorpo.SelectedIndex;
                        _strumentoACorda.MaterialeManico =
                            (Program.eLEGNO)cbMaterialeManico.SelectedIndex;
                        _strumentoACorda.MaterialeTastiera =
                            (Program.eLEGNO)cbMaterialeTastiera.SelectedIndex;
                        _strumentoACorda.NumeroCorde = Convert.ToUInt16(nudCorde.Value);
                        _strumentoACorda.Pickup1 =
                            (ClsStrumentoACorda.ePICKUP)cbPickup1.SelectedIndex;
                        _strumentoACorda.Pickup2 =
                            (ClsStrumentoACorda.ePICKUP)cbPickup2.SelectedIndex;
                        _strumentoACorda.Pickup3 =
                            (ClsStrumentoACorda.ePICKUP)cbPickup3.SelectedIndex;
                        _strumentoACorda.SpessoreCorpoCM = Convert.ToSingle(nudSpessoreCorpo.Value);
                        _strumentoACorda.SpessoreManicoCM = Convert.ToSingle(nudSpessoreManico.Value);
                        if (nudTasti.Enabled == false)
                        {
                            //Tasti null
                            _strumentoACorda.Tasti = -1;
                        }
                        else
                        {
                            _strumentoACorda.Tasti = Convert.ToSByte(nudTasti.Value);
                        }

                        MessageBox.Show("Dati salvati con successo", "SALVA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Errore nel salvataggio dei dati:\r\n" + ex, "SALVA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Solo gli amministratori del software possono modificare le specifiche degli strumenti musicali",
                    "SALVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
