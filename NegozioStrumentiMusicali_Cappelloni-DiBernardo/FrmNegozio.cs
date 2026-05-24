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
    public partial class FrmNegozio : Form
    {
        public FrmNegozio(ClsNegozio negozio)
        {
            string _comunicazione;
            ClsIndirizzo _indirizzoNegozio = ClsIndirizzoBL.GetOneIndirizzo(ref Program._connessioneAlDB, negozio.IndirizzoID, out _comunicazione);
            InitializeComponent();
            tbNome.Text = negozio.Nome;
            nudID.Value = negozio.ID;
            tbComune.Text = _indirizzoNegozio.Comune;
            tbVia.Text = _indirizzoNegozio.Via;
            nudCap.Text = _indirizzoNegozio.CodicePostale;
        }

        private void FrmNegozio_Load(object sender, EventArgs e)
        {

        }
    }
}
