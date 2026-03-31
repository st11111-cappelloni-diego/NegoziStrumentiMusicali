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
            cbNumeroCorde.DataSource = Enum.GetNames(typeof(ClsStrumentoACorda.eNUMERO_CORDE));
            cbPickup1.DataSource = Enum.GetNames(typeof(ClsStrumentoACorda.ePICKUP));
            cbPickup2.DataSource = Enum.GetNames(typeof(ClsStrumentoACorda.ePICKUP));
            cbPickup3.DataSource = Enum.GetNames(typeof(ClsStrumentoACorda.ePICKUP));
            cbStrumento.DataSource = Enum.GetNames(typeof(ClsStrumentoACorda.eSTRUMENTI_A_CORDA));
        }

        private void FrmStrumentoACorda_Load(object sender, EventArgs e)
        {

        }
    }
}
