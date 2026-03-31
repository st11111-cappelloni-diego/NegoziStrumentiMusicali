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
    public partial class FrmStrumentoMusicale : Form
    {
        #region ENUMERATORI
        public enum eTIPO_STRUMENTO
        {
            Batteria,
            Legno,
            Ottone,
            Pianoforte,
            Strumento_a_corda
        }

        #endregion
        public FrmStrumentoMusicale()
        {
            InitializeComponent();
            //Carico sull'apposita combobox i tipi di strumento
            cbStrumento.DataSource = Enum.GetNames(typeof(eTIPO_STRUMENTO));
        }

        private void FrmStrumentoMusicale_Load(object sender, EventArgs e)
        {

        }
    }
}
