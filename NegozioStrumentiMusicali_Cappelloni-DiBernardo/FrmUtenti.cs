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
    public partial class FrmUtenti : Form
    {
        public enum ePARAMETRI_DI_ORDINAMENTO
        {
            Nome,
            Cognome,
            Username,
            Email
        }

        public FrmUtenti()
        {
            InitializeComponent();
        }

        private void FrmUtenti_Load(object sender, EventArgs e)
        {

            //Scrivo il testo di sfondo della textbox di ricerca
            tbRicerca.Text = "Cerca per nome, cognome, username o email...";
            tbRicerca.ForeColor = Color.Gray;

            cbParametriDiOrdinamento.DataSource = Enum.GetNames(typeof(ePARAMETRI_DI_ORDINAMENTO));
        }

        private void tbRicerca_Enter(object sender, EventArgs e)
        {
            //L'utente mette il cursore sulla textbox
            //Rimuovo il testo di sfondo
            if (tbRicerca.Text == "Cerca per nome, cognome, username o email...")
            {
                tbRicerca.Clear();
                tbRicerca.ForeColor = Color.Black;
            }
        }

        private void tbRicerca_Leave(object sender, EventArgs e)
        {
            //L'utente esce dalla digitazione sulla textbox e il testo è vuoto
            //Rimetto il testo di sfondo
            if(String.IsNullOrWhiteSpace(tbRicerca.Text))
            {
                tbRicerca.Text = "Cerca per nome, cognome, username o email...";
                tbRicerca.ForeColor = Color.Gray;
            }
        }
    }
}
