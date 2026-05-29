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
        public ClsUtente _utente; //creo una variabile per l'utente il quale si vuole vedere i dettagli 
        public bool _frmMioUtente;
        private Program.eMODALITA_ENTRATA_DETAIL _modalitaEntrata;

        public Program.eMODALITA_ENTRATA_DETAIL ModaliatEntrata { get => _modalitaEntrata; set => _modalitaEntrata = value; }

        public FrmUtente(ClsUtente utente, Program.eMODALITA_ENTRATA_DETAIL modalitaEntrata)
        {
            InitializeComponent();

            _utente = utente;
            ModaliatEntrata = modalitaEntrata;

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

            if (ModaliatEntrata == Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione)
            {
                panel1.Enabled = false;
                btnCambiaUtente.Enabled = false;
                btnCambiaUtente.Visible = false;
                btnCancellaUtente.Enabled = false;
                btnCancellaUtente.Visible = false;
                btnEsci.Enabled = false;
                btnEsci.Visible = false;
            }
            else
            {
                if (_frmMioUtente)
                {
                    btnCambiaUtente.Enabled = true;
                    btnCambiaUtente.Visible = true;
                    btnCancellaUtente.Enabled = true;
                    btnCancellaUtente.Visible = true;
                    btnEsci.Enabled = true;
                    btnEsci.Visible = true;
                }
                else
                {
                    btnCambiaUtente.Enabled = false;
                    btnCambiaUtente.Visible = false;
                    btnCancellaUtente.Enabled = false;
                    btnCancellaUtente.Visible = false;
                    btnEsci.Enabled = false;
                    btnEsci.Visible = false;
                }
            }
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            //Uscire dal'utente
        }

        private void btnCancellaUtente_Click(object sender, EventArgs e)
        {
            DialogResult _risultato = MessageBox.Show("Sei sicur* di voler cancellare questo utente?", "Cancellazione utente", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (_risultato == DialogResult.Yes)
            {
                string _comunicazione;
                ClsUtenteBL.DeleteUtente(ref Program._connessioneAlDB, _utente, out _comunicazione);
                MessageBox.Show(_comunicazione, "Andamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                FrmLogin _login = new FrmLogin();
                _login.ShowDialog();
            }

        }
    }
}
    