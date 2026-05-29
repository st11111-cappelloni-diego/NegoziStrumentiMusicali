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
        ClsUtente _utente; //creo una variabile per l'utente il quale si vuole vedere i dettagli 
        public FrmUtente(ClsUtente utente, Program.eMODALITA_ENTRATA_DETAIL visualizzazione)
        {
            InitializeComponent();

            _utente = utente;

            if (visualizzazione == Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione)
            {
                panel1.Enabled = false;
            }
            //Popolo le combobox
            cbGenere.DataSource = Enum.GetNames(typeof(ClsUtente.eGENERE));
        }

        private void FrmUtente_Load(object sender, EventArgs e)
        {
            tbNome.Text = _utente.Nome;
            tbUsername.Text = _utente.Username;
            tbEmail.Text = _utente.Email;
            tbNome.Text = _utente.Nome;
            dtpDataDiNascita.Value = _utente.DataDiNascita;
            tbCognome.Text = _utente.Cognome;
        }

        private void btnVisualizzaPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancellaUtente_Click(object sender, EventArgs e)
        {
            DialogResult _risultato = MessageBox.Show("Sei sicuro di voler cancellare questo utente?", "Cancellazoione utente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_risultato == DialogResult.Yes)
            {
                string _cominucazione;
                ClsUtenteBL.DeleteUtente(ref Program._connessioneAlDB, _utente, out _cominucazione);
                MessageBox.Show(_cominucazione, "andamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                FrmLogin _login = new FrmLogin();
                _login.ShowDialog();
            }

        }
    }
}
    