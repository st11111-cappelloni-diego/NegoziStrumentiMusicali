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
    /// GUI: Leonardo di Bernardo
    /// Sviluppo: Diego Cappelloni
    /// </summary>
    public partial class FrmPianoforte : Form
    {
        #region Variabili
        private ClsPianoforte _pianoforte;
        private Program.eMODALITA_ENTRATA_DETAIL _modalitaEntrata;
        /// <summary>
        /// Variabile di backup del valore di cbMaterialeCorpoPFAcustico in caso di cambio del tipo di pianoforte
        /// </summary>
        private Program.eLEGNO _materialeCorpoPFAcustico;

        #endregion
        #region Proprietà
        public Program.eMODALITA_ENTRATA_DETAIL ModalitaEntrata { get => _modalitaEntrata; set => _modalitaEntrata = value; }

        #endregion
        #region Metodi della form
        private void CaricaDati(ClsPianoforte pianoforte)
        {
            cbTipo.SelectedIndex = Convert.ToInt32(pianoforte.Tipo);
            if(pianoforte.MaterialeCorpoPFAcustico == null)
            {
                cbMaterialeCorpoPFAcustico.SelectedIndex = 0;
                cbMaterialeCorpoPFAcustico.Enabled = false;
            }
            else
            {
                cbMaterialeCorpoPFAcustico.SelectedIndex = Convert.ToInt32(pianoforte.MaterialeCorpoPFAcustico);
                cbMaterialeCorpoPFAcustico.Enabled = true;
            }
            cbMaterialeTastiBianchi.SelectedIndex = Convert.ToInt32(pianoforte.MaterialeTastiBianchi);
            cbMaterialeTastiNeri.SelectedIndex = Convert.ToInt32(pianoforte.MaterialeTastiNeri);

            if(pianoforte.NumeroTasti < Convert.ToByte(nudNumeroTasti.Minimum))
            {
                nudNumeroTasti.Value = nudNumeroTasti.Minimum;
            }
            else
            {
                nudNumeroTasti.Value = pianoforte.NumeroTasti;
            }
            if(pianoforte.AltezzaCM < Convert.ToSingle(nudAltezza.Minimum))
            {
                nudAltezza.Value = nudAltezza.Minimum;
            }
            else
            {
                nudAltezza.Value = Convert.ToDecimal(pianoforte.AltezzaCM);
            }
            if(pianoforte.LarghezzaCM < Convert.ToSingle(nudLarghezza.Minimum))
            {
                nudLarghezza.Value = nudLarghezza.Minimum;
            }
            else
            {
                nudLarghezza.Value = Convert.ToDecimal(pianoforte.LarghezzaCM);
            }
            if(pianoforte.ProfonditaCM < Convert.ToSingle(nudProfondita.Minimum))
            {
                nudProfondita.Value = nudProfondita.Minimum;
            }
            else
            {
                nudProfondita.Value = Convert.ToDecimal(pianoforte.ProfonditaCM);
            }
            if(pianoforte.AltezzaGinocchioCM <= Convert.ToSingle(nudAltezzaGinocchio.Minimum))
            {
                nudAltezzaGinocchio.Value = nudAltezzaGinocchio.Minimum;
                if(pianoforte.AltezzaGinocchioCM <= -1)
                {
                    ckbAltezzaGinocchio.Checked = false;
                    nudAltezzaGinocchio.Enabled = false;
                }
            }
            else
            {
                nudAltezzaGinocchio.Value = Convert.ToDecimal(pianoforte.AltezzaGinocchioCM);
                ckbAltezzaGinocchio.Checked = true;
                nudAltezzaGinocchio.Enabled = true;
            }
        }
        private void AbilitaControlliGraficiDiInput(bool controlliAbilitati)
        {
            cbTipo.Enabled = controlliAbilitati;
            cbMaterialeCorpoPFAcustico.Enabled = controlliAbilitati;
            cbMaterialeTastiBianchi.Enabled = controlliAbilitati;
            cbMaterialeTastiNeri.Enabled = controlliAbilitati;

            nudAltezza.Enabled = controlliAbilitati;
            nudLarghezza.Enabled = controlliAbilitati;
            nudProfondita.Enabled = controlliAbilitati;
            nudAltezzaGinocchio.Enabled = controlliAbilitati;
            nudNumeroTasti.Enabled = controlliAbilitati;

            ckbAltezzaGinocchio.Enabled = controlliAbilitati;

            btnSalva.Enabled = controlliAbilitati;
        }

        #endregion
        public FrmPianoforte(Program.eMODALITA_ENTRATA_DETAIL modalitaEntrata, ClsPianoforte pianoforte)
        {
            InitializeComponent();

            //Popolo le combobox
            cbTipo.DataSource = Enum.GetNames(typeof(ClsPianoforte.eTIPO_PF));
            cbMaterialeCorpoPFAcustico.DataSource = Enum.GetNames(typeof(Program.eLEGNO));
            cbMaterialeTastiBianchi.DataSource = Enum.GetNames(typeof(ClsPianoforte.eMATERIALE_TASTI_PF));
            cbMaterialeTastiNeri.DataSource = Enum.GetNames(typeof(ClsPianoforte.eMATERIALE_TASTI_PF));

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            nudNumeroTasti.Minimum = 12;
            nudNumeroTasti.Maximum = 121;
            nudAltezza.Minimum = 0.01m;
            nudAltezza.Maximum = 999.99m;
            nudAltezzaGinocchio.Minimum = 0.01m;
            nudAltezzaGinocchio.Maximum = 999.99m;
            nudProfondita.Minimum = 0.01m;
            nudProfondita.Maximum = 999.99m;
            nudLarghezza.Minimum = 0.01m;
            nudLarghezza.Maximum = 999.99m;

            _pianoforte = pianoforte;
            ModalitaEntrata = modalitaEntrata;

            ckbAltezzaGinocchio.Checked = true;
        }

        private void FrmPianoforte_Load(object sender, EventArgs e)
        {
            //Se l'utente attuale è admin software e sono in modalità inserimento o modifica abilito i controlli grafici di input
            if(ClsArchivio.UtenteAttuale.AdminSoftware &&
                (ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento
                || ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica))
            {
                AbilitaControlliGraficiDiInput(true);
            }
            else //Sennò li disabilito
            {
                AbilitaControlliGraficiDiInput(false);
            }

            //Carico i dati se sono in modalità visualizzazione o modifica
            if (ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione
                || ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica)
            {
                CaricaDati(_pianoforte);
            }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTipo.SelectedIndex == Convert.ToInt32(ClsPianoforte.eTIPO_PF.elettrico))
            {
                //Se un pianoforte è elettrico l'attributo materialeCorpoPFAcustico non è previsto
                _materialeCorpoPFAcustico = (Program.eLEGNO)cbMaterialeCorpoPFAcustico.SelectedIndex; //Backup
                cbMaterialeCorpoPFAcustico.SelectedIndex = 0;
                cbMaterialeCorpoPFAcustico.Enabled = false;
                cbMaterialeCorpoPFAcustico.Visible = false;
                lblMaterialeCorpo.Visible = false;
            }
            else
            {
                cbMaterialeCorpoPFAcustico.Enabled = true;
                cbMaterialeCorpoPFAcustico.Visible = true;
                lblMaterialeCorpo.Visible = true;
                cbMaterialeCorpoPFAcustico.SelectedIndex = Convert.ToInt32(_materialeCorpoPFAcustico); //Ripristino backup
                ckbAltezzaGinocchio.Checked = true;
                nudAltezzaGinocchio.Enabled = true;
            }

            if (ClsArchivio.UtenteAttuale.AdminSoftware &&
            (ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento
            || ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica))
            {
                if (ckbAltezzaGinocchio.Checked == false && cbTipo.SelectedIndex == Convert.ToInt32(ClsPianoforte.eTIPO_PF.elettrico))
                {
                    nudAltezzaGinocchio.Enabled = false;
                }
                else
                {
                    nudAltezzaGinocchio.Enabled = true;
                }
            }
            else
            {
                nudAltezzaGinocchio.Enabled = false;
            }
        }

        private void ckbAltezzaGinocchio_CheckedChanged(object sender, EventArgs e)
        {
            if(ClsArchivio.UtenteAttuale.AdminSoftware &&
                (ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento
                || ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica))
            {
                if (ckbAltezzaGinocchio.Checked == false && cbTipo.SelectedIndex == Convert.ToInt32(ClsPianoforte.eTIPO_PF.elettrico))
                {
                    nudAltezzaGinocchio.Enabled = false;
                }
                else
                {
                    nudAltezzaGinocchio.Enabled = true;
                }
            }
            else
            {
                nudAltezzaGinocchio.Enabled = false;
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (ClsArchivio.UtenteAttuale.AdminSoftware)
            {
                DialogResult _dr =
                    MessageBox.Show("Sei sicur* di voler salvare ed uscire?", "SALVA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (_dr == DialogResult.Yes)
                {
                    //Salvo i dati se l'utente è admin software
                    try
                    {
                        _pianoforte.Tipo =
                            (ClsPianoforte.eTIPO_PF)cbTipo.SelectedIndex;
                        _pianoforte.AltezzaCM = Convert.ToSingle(nudAltezza.Value);
                        if(nudAltezzaGinocchio.Enabled)
                        {
                            _pianoforte.AltezzaGinocchioCM = Convert.ToSingle(nudAltezzaGinocchio.Value);
                        }
                        else
                        {
                            _pianoforte.AltezzaGinocchioCM = -1;
                        }
                        _pianoforte.LarghezzaCM = Convert.ToSingle(nudLarghezza.Value);
                        if(cbMaterialeCorpoPFAcustico.Enabled)
                        {
                            _pianoforte.MaterialeCorpoPFAcustico =
                                (Program.eLEGNO)cbMaterialeCorpoPFAcustico.SelectedIndex;
                        }
                        else
                        {
                            _pianoforte.MaterialeCorpoPFAcustico = null;
                        }
                        _pianoforte.MaterialeTastiBianchi =
                            (ClsPianoforte.eMATERIALE_TASTI_PF)cbMaterialeTastiBianchi.SelectedIndex;
                        _pianoforte.MaterialeTastiNeri =
                            (ClsPianoforte.eMATERIALE_TASTI_PF)cbMaterialeTastiNeri.SelectedIndex;
                        _pianoforte.NumeroTasti = Convert.ToByte(nudNumeroTasti.Value);
                        _pianoforte.ProfonditaCM = Convert.ToSingle(nudProfondita.Value);

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
