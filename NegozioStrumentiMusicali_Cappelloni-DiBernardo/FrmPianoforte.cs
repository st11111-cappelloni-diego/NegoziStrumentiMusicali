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
        private ClsPianoforte _pianoforte = new ClsPianoforte();
        private Program.eMODALITA_ENTRATA_DETAIL _modalitaEntrata;
        /// <summary>
        /// Variabile di backup del valore di cbMaterialeCorpoPFAcustico in caso di cambio del tipo di pianoforte
        /// </summary>
        private Program.eLEGNO _materialeCorpoPFAcustico;
        /// <summary>
        /// Variabile di backup del valore di nudAltezzaGinocchio in caso di cambio del tipo di pianoforte
        /// </summary>
        private float _altezzaGinocchio;

        #endregion
        #region Proprietà
        public ClsPianoforte Pianoforte { get => _pianoforte; set => _pianoforte = value; }
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

            nudAltezza.Value = Convert.ToDecimal(pianoforte.AltezzaCM);
            nudLarghezza.Value = Convert.ToDecimal(pianoforte.LarghezzaCM);
            nudProfondita.Value = Convert.ToDecimal(pianoforte.ProfonditaCM);
            if(pianoforte.AltezzaGinocchioCM <= -1)
            {
                nudAltezzaGinocchio.Value = nudAltezzaGinocchio.Minimum;
                ckbAltezzaGinocchio.Checked = false;
                nudAltezzaGinocchio.Enabled = false;
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

            Pianoforte = pianoforte;
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
                CaricaDati(Pianoforte);
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
            }
            else
            {
                cbMaterialeCorpoPFAcustico.Enabled = true;
                cbMaterialeCorpoPFAcustico.SelectedIndex = Convert.ToInt32(_materialeCorpoPFAcustico); //Ripristino backup
                ckbAltezzaGinocchio.Checked = true;
                nudAltezzaGinocchio.Enabled = true;
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
    }
}
