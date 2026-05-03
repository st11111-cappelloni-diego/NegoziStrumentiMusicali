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
                cbPickup1.SelectedIndex = (int)ClsStrumentoACorda.ePICKUP.no;
                cbPickup2.SelectedIndex = (int)ClsStrumentoACorda.ePICKUP.no;
                cbPickup3.SelectedIndex = (int)ClsStrumentoACorda.ePICKUP.no;
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
                nudTasti.Value = 0;
                nudTasti.Enabled = false;
            }
            else
            {
                nudTasti.Enabled = true;
            }
        }
    }
}
