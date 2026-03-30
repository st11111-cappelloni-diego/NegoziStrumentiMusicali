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
    /// </summary>
    public partial class FrmCaseProduttrici : Form
    {
        public enum ePARAMETRI_DI_ORDINAMENTO
        {
            Nome,
            ID
        }

        public FrmCaseProduttrici()
        {
            InitializeComponent();
        }

        private void FrmCaseProduttrici_Load(object sender, EventArgs e)
        {
            cbParametriDiOrdinamento.DataSource = Enum.GetNames(typeof(ePARAMETRI_DI_ORDINAMENTO));
        }
    }
}
