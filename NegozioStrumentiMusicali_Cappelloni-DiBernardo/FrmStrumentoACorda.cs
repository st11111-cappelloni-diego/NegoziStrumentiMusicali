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
        private ClsStrumentoACorda _strumentoACorda = new ClsStrumentoACorda();
        private Program.eMODALITA_ENTRATA_DETAIL _modalitaEntrata;

        #endregion
        #region Proprietà
        public ClsStrumentoACorda StrumentoACorda { get => _strumentoACorda; set => _strumentoACorda = value; }
        public Program.eMODALITA_ENTRATA_DETAIL ModalitaEntrata { get => _modalitaEntrata; set => _modalitaEntrata = value; }

        #endregion
        #region Metodi della form
        void CaricaDati(ClsStrumentoACorda strumentoACorda)
        {
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
            }
            cbMaterialeCorde.SelectedIndex = Convert.ToInt32(strumentoACorda.MaterialeCorde);
            cbMaterialeCorpo.SelectedIndex = Convert.ToInt32(strumentoACorda.MaterialeCorpo);
            cbMaterialeManico.SelectedIndex = Convert.ToInt32(strumentoACorda.MaterialeManico);
            cbMaterialeTastiera.SelectedIndex = Convert.ToInt32(strumentoACorda.MaterialeTastiera);
            nudCorde.Value = Convert.ToDecimal(strumentoACorda.NumeroCorde);
            cbPickup1.SelectedIndex = Convert.ToInt32(strumentoACorda.Pickup1);
            cbPickup2.SelectedIndex = Convert.ToInt32(strumentoACorda.Pickup2);
            cbPickup3.SelectedIndex = Convert.ToInt32(strumentoACorda.Pickup3);

            cbStrumento.SelectedIndex = Convert.ToInt32(strumentoACorda.Strumento);
        }

        #endregion
        public FrmStrumentoACorda()
        {
            InitializeComponent();

            //Popolo le varie combobox
            cbMaterialeCorde.DataSource = Enum.GetNames(typeof(ClsStrumentoACorda.eMATERIALE_CORDE));
            cbMaterialeCorpo.DataSource = Enum.GetNames(typeof(Program.eLEGNO));
            cbMaterialeManico.DataSource = Enum.GetNames(typeof(Program.eLEGNO));
            cbMaterialeTastiera.DataSource = Enum.GetNames(typeof(Program.eLEGNO));
            cbPickup1.DataSource = Enum.GetNames(typeof(ClsStrumentoACorda.ePICKUP));
            cbPickup2.DataSource = Enum.GetNames(typeof(ClsStrumentoACorda.ePICKUP));
            cbPickup3.DataSource = Enum.GetNames(typeof(ClsStrumentoACorda.ePICKUP));
            cbStrumento.DataSource = Enum.GetNames(typeof(ClsStrumentoACorda.eSTRUMENTI_A_CORDA));
        }

        private void FrmStrumentoACorda_Load(object sender, EventArgs e)
        {

        }

        private void cbStrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbStrumento.SelectedIndex != (int)ClsStrumentoACorda.eSTRUMENTI_A_CORDA.basso_elettrico
                && cbStrumento.SelectedIndex != (int)ClsStrumentoACorda.eSTRUMENTI_A_CORDA.chitarra_elettrica
                && cbStrumento.SelectedIndex != (int)ClsStrumentoACorda.eSTRUMENTI_A_CORDA.chitarra_semiacustica
                && cbStrumento.SelectedIndex != (int)ClsStrumentoACorda.eSTRUMENTI_A_CORDA.lap_steel_guitar)
            {
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
                pnlPickup.Enabled = true;
                cbPickup1.SelectedIndex = 0;
                cbPickup2.SelectedIndex = 0;
                cbPickup3.SelectedIndex = 0;
            }

            if(cbStrumento.SelectedIndex == (int)ClsStrumentoACorda.eSTRUMENTI_A_CORDA.contrabbasso
                || cbStrumento.SelectedIndex == (int)ClsStrumentoACorda.eSTRUMENTI_A_CORDA.viola
                || cbStrumento.SelectedIndex == (int)ClsStrumentoACorda.eSTRUMENTI_A_CORDA.violino
                || cbStrumento.SelectedIndex == (int)ClsStrumentoACorda.eSTRUMENTI_A_CORDA.violoncello)
            {
                //In questi strumenti l'attributo tasti non è previsto
                nudTasti.Value = nudTasti.Minimum;
                nudTasti.Enabled = false;
            }
            else
            {
                nudTasti.Enabled = true;
            }
        }
    }
}
