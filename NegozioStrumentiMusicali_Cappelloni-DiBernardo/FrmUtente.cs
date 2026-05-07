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
    /// GUI: Diego Cappelloni
    /// Sviluppo: Leonardo di Bernardo
    /// </summary>
    public partial class FrmUtente : Form
    {
        public FrmUtente()
        {
            InitializeComponent();

            //Popolo le combobox
            cbGenere.DataSource = Enum.GetNames(typeof(ClsUtente.eGENERE));
        }

        private void FrmUtente_Load(object sender, EventArgs e)
        {

        }

        private void btnVisualizzaPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
