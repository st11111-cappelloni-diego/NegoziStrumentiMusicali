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
    public partial class FrmNegozi : Form
    {
        public enum ePARAMETRI_DI_ORDINAMENTO
        {
            Nome,
            ID
        }

        public FrmNegozi()
        {
            InitializeComponent();
        }

        private void FrmNegozi_Load(object sender, EventArgs e)
        {
            //Metto il testo di sfondo sulla textbox di ricerca
            tbRicerca.Text = "Cerca per id o per nome...";
            tbRicerca.ForeColor = Color.Gray;

            cbParametriDiOrdinamento.DataSource = Enum.GetNames(typeof(ePARAMETRI_DI_ORDINAMENTO));
        }

        private void tbRicerca_Enter(object sender, EventArgs e)
        {
            //L'utente mette il cursore sulla textbox
            //Rimuovo il testo di sfondo
            if(tbRicerca.Text == "Cerca per id o per nome...")
            {
                tbRicerca.Clear();
                tbRicerca.ForeColor = Color.Black;
            }
        }

        private void tbRicerca_Leave(object sender, EventArgs e)
        {
            //L'utente esce dall'inserimento su textbox e il testo inserito è vuoto
            //Metto il testo di sfondo sulla textbox di ricerca
            if(String.IsNullOrWhiteSpace(tbRicerca.Text))
            {
                tbRicerca.Text = "Cerca per id o per nome...";
                tbRicerca.ForeColor = Color.Gray;
            }
        }
    }
}
