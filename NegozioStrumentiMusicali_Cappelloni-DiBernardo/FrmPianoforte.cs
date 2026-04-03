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
        public FrmPianoforte()
        {
            InitializeComponent();

            //Popolo le combobox
            cbTipo.DataSource = Enum.GetNames(typeof(ClsPianoforte.eTIPO_PF));
            cbMaterialeCorpoPFAcustico.DataSource = Enum.GetNames(typeof(Program.eLEGNO));
            cbMaterialeTastiBianchi.DataSource = Enum.GetNames(typeof(ClsPianoforte.eMATERIALE_TASTI_PF));
            cbMaterialeTastiNeri.DataSource = Enum.GetNames(typeof(ClsPianoforte.eMATERIALE_TASTI_PF)); 
        }

        private void FrmPianoforte_Load(object sender, EventArgs e)
        {

        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTipo.SelectedIndex == (int)ClsPianoforte.eTIPO_PF.Elettrico)
            {
                //Se un pianoforte è elettrico l'attributo materialeCorpoPFAcustico non è previsto
                cbMaterialeCorpoPFAcustico.SelectedIndex = 0;
                cbMaterialeCorpoPFAcustico.Enabled = false;
            }
            else
            {
                cbMaterialeCorpoPFAcustico.Enabled = true;
            }
        }
    }
}
