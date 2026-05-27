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
    public partial class FrmOttone : Form
    {
        #region Variabili
        private ClsOttone _ottone = new ClsOttone();
        private Program.eMODALITA_ENTRATA_DETAIL _modalitaEntrata;

        #endregion
        #region Proprietà
        public ClsOttone Ottone { get => _ottone; set => _ottone = value; }
        public Program.eMODALITA_ENTRATA_DETAIL ModalitaEntrata { get => _modalitaEntrata; set => _modalitaEntrata = value; }

        #endregion
        #region Metodi della form
        private void CaricaDati(ClsOttone ottone)
        {
            cbStrumento.SelectedIndex = Convert.ToInt32(ottone.Strumento);

            nudAltezza.Value = Convert.ToDecimal(ottone.AltezzaCM);
            nudLarghezza.Value = Convert.ToDecimal(ottone.LarghezzaCM);
            nudLunghezza.Value = Convert.ToDecimal(ottone.LunghezzaCM);

            cbLaccatura.SelectedIndex = Convert.ToInt32(ottone.Laccatura);
            cbMaterialeBocchino.SelectedIndex = Convert.ToInt32(ottone.MaterialeBocchino);
            cbMaterialeCorpo.SelectedIndex = Convert.ToInt32(ottone.MaterialeCorpo);
            cbRivestimentoBocchino.SelectedIndex = Convert.ToInt32(ottone.RivestimentoBocchino);
            cbPlaccatura.SelectedIndex = Convert.ToInt32(ottone.Placcatura);
        }
        private void AbilitaControlliGraficiDiInput(bool controlliAbilitati)
        {
            cbLaccatura.Enabled = controlliAbilitati;
            cbMaterialeBocchino.Enabled = controlliAbilitati;
            cbMaterialeCorpo.Enabled = controlliAbilitati;
            cbPlaccatura.Enabled = controlliAbilitati;
            cbRivestimentoBocchino.Enabled = controlliAbilitati;
            cbStrumento.Enabled = controlliAbilitati;

            nudAltezza.Enabled = controlliAbilitati;
            nudLarghezza.Enabled = controlliAbilitati;
            nudLunghezza.Enabled = controlliAbilitati;

            btnSalva.Enabled = controlliAbilitati;
        }
        #endregion
        public FrmOttone(Program.eMODALITA_ENTRATA_DETAIL modalitaEntrata, ClsOttone ottone)
        {
            InitializeComponent();

            //Popolo le combobox
            cbStrumento.DataSource = Enum.GetNames(typeof(ClsOttone.eOTTONI));
            cbRivestimentoBocchino.DataSource = Enum.GetNames(typeof(ClsOttone.eRIVESTIMENTO_BOCCHINO));
            cbPlaccatura.DataSource = Enum.GetNames(typeof(ClsOttone.eTIPO_PLACCATURA));
            cbMaterialeCorpo.DataSource = Enum.GetNames(typeof(ClsOttone.eTIPO_OTTONE));
            cbMaterialeBocchino.DataSource = Enum.GetNames(typeof(ClsOttone.eMATERIALE_BOCCHINO));
            cbLaccatura.DataSource = Enum.GetNames(typeof(ClsOttone.eTIPO_LACCATURA));

            nudAltezza.Minimum = 0.01m;
            nudAltezza.Maximum = 999.99m;
            nudLarghezza.Minimum = 0.01m;
            nudLarghezza.Maximum = 999.99m;
            nudLunghezza.Minimum = 0.01m;
            nudLunghezza.Maximum = 999.99m;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            Ottone = ottone;
            ModalitaEntrata = modalitaEntrata;
        }

        private void FrmOttone_Load(object sender, EventArgs e)
        {
            //Se sono in modalità inserimento o modifica e l'utente è admin software abilito i controlli grafici di input
            if(ClsArchivio.UtenteAttuale.AdminSoftware &&
                (ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento
                || ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica))
            {
                AbilitaControlliGraficiDiInput(true);
            }
            else
            {
                AbilitaControlliGraficiDiInput(false);
            }

            //Carico i dati se sono in modalità modifica o visualizzazione
            if(ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica
                || ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione)
            {
                CaricaDati(Ottone);
            }
        }

        private void cbStrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
