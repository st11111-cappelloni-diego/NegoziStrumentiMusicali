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
    public partial class FrmLegno : Form
    {
        #region Variabili
        private ClsLegno _legno;
        private Program.eMODALITA_ENTRATA_DETAIL _modalitaEntrata;

        #endregion
        #region Proprietà
        public Program.eMODALITA_ENTRATA_DETAIL ModalitaEntrata { get => _modalitaEntrata; set => _modalitaEntrata = value; }

        #endregion
        #region Metodi della form
        private void CaricaDati(ClsLegno legno)
        {
            cbStrumento.SelectedIndex = Convert.ToInt32(legno.Strumento);
            cbMaterialeCorpo.SelectedIndex = Convert.ToInt32(legno.MaterialeCorpo);
            cbMaterialeChiavi.SelectedIndex = Convert.ToInt32(legno.MaterialeChiavi);

            if(legno.AltezzaCM < Convert.ToSingle(nudAltezza.Minimum))
            {
                nudAltezza.Value = nudAltezza.Minimum;
            }
            else
            {
                nudAltezza.Value = Convert.ToDecimal(legno.AltezzaCM);
            }
            if(legno.LarghezzaCM < Convert.ToSingle(nudLarghezza.Minimum))
            {
                nudLarghezza.Value = nudLarghezza.Minimum;
            }
            else
            {
                nudLarghezza.Value = Convert.ToDecimal(legno.LarghezzaCM);
            }
            if(legno.LunghezzaCM < Convert.ToSingle(nudLunghezza.Minimum))
            {
                nudLunghezza.Value = nudLunghezza.Minimum;
            }
            else
            {
                nudLunghezza.Value = Convert.ToDecimal(legno.LunghezzaCM);
            }
        }
        private void AbilitaControlliGraficiDiInput(bool controlliAbilitati)
        {
            cbMaterialeChiavi.Enabled = controlliAbilitati;
            cbMaterialeCorpo.Enabled = controlliAbilitati;
            cbStrumento.Enabled = controlliAbilitati;

            nudAltezza.Enabled = controlliAbilitati;
            nudLarghezza.Enabled = controlliAbilitati;
            nudLunghezza.Enabled = controlliAbilitati;

            btnSalva.Enabled = controlliAbilitati;
        }

        #endregion
        public FrmLegno(Program.eMODALITA_ENTRATA_DETAIL modalitaEntrata, ClsLegno legno)
        {
            InitializeComponent();

            //Popolo le combobox
            cbStrumento.DataSource = Enum.GetNames(typeof(ClsLegno.eLEGNI));
            cbMaterialeCorpo.DataSource = Enum.GetNames(typeof(ClsLegno.eMATERIALE_CORPO_LEGNI));
            cbMaterialeChiavi.DataSource = Enum.GetNames(typeof(ClsLegno.eMATERIALE_CHIAVI));

            nudAltezza.Minimum = 0.01m;
            nudAltezza.Maximum = 999.99m;
            nudLarghezza.Minimum = 0.01m;
            nudLarghezza.Maximum = 999.99m;
            nudLunghezza.Minimum = 0.01m;
            nudLunghezza.Maximum = 999.99m;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            ModalitaEntrata = modalitaEntrata;
            _legno = legno;
        }

 

        private void FrmLegno_Load(object sender, EventArgs e)
        {
            //Se sono in modalità inserimento o modifica e l'utente è admin software abilito i controlli grafici di input
            if (ClsArchivio.UtenteAttuale.AdminSoftware &&
                (ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Inserimento
                || ModalitaEntrata == Program.eMODALITA_ENTRATA_DETAIL.Modifica))
            {
                AbilitaControlliGraficiDiInput(true);
            }
            else
            {
                AbilitaControlliGraficiDiInput(false);
            }

            CaricaDati(_legno);
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
                        _legno.Strumento =
                            (ClsLegno.eLEGNI)cbStrumento.SelectedIndex;
                        _legno.AltezzaCM = Convert.ToSingle(nudAltezza.Value);
                        _legno.LarghezzaCM = Convert.ToSingle(nudLarghezza.Value);
                        _legno.LunghezzaCM = Convert.ToSingle(nudLunghezza.Value);
                        _legno.MaterialeChiavi =
                            (ClsLegno.eMATERIALE_CHIAVI)cbMaterialeChiavi.SelectedIndex;
                        _legno.MaterialeCorpo =
                            (ClsLegno.eMATERIALE_CORPO_LEGNI)cbMaterialeCorpo.SelectedIndex;

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
