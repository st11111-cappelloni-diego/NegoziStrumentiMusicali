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
    /// Sviluppata da Leonardo Di Bernardo
    /// </summary>
    public partial class FrmRegistrazione : Form
    {
        public FrmRegistrazione()
        {
            InitializeComponent();
            cbGenere.DataSource = Enum.GetValues(typeof(ClsUtente.eGENERE));
        }

        private void btnRegistrazione_Click(object sender, EventArgs e)
        {
            if (Controllo())
            {
                //creo un nuovo utente e inserisco tutti i campi impostati nella form 
                ClsUtente _utente = new ClsUtente();
                _utente.Nome = tbNome.Text;
                _utente.Cognome = tbcognome.Text;
                _utente.Username = tbusername.Text;
                _utente.Email = tbEmail.Text;
                _utente.Password = tbpassword.Text;
                _utente.DataDiNascita = (DateTime)dtpDataDiNascita.Value;
                _utente.Genere = (ClsUtente.eGENERE)cbGenere.SelectedItem;
                _utente.PathImmagine = "";
                _utente.AdminSoftware = false;
                _utente.AdminNegozio = false;
                _utente.Bandito = false;


                //faccio l'insert del nuovo utente all'interno del db 
                string _comunicazione;
                ClsUtenteBL.InsertUtente(ref Program._connessioneAlDB, _utente, out _comunicazione);

                this.Close();
            }
        }

        private bool Controllo()
        {
            bool _controllo = true;
            // Nome
            if (string.IsNullOrWhiteSpace(tbNome.Text))
            {
                MessageBox.Show("Il nome non è stato inserito", "Campo non inserito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _controllo = false;
            }

            // Cognome
            if (string.IsNullOrWhiteSpace(tbcognome.Text))
            {
                MessageBox.Show("Il cognome non è stato inserito", "Campo non inserito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _controllo = false;
            }

            // Username
            if (string.IsNullOrWhiteSpace(tbusername.Text))
            {
                MessageBox.Show("L'username non è stato inserito", "Campo non inserito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _controllo = false;
            }

            // Password
            if (string.IsNullOrWhiteSpace(tbpassword.Text))
            {
                MessageBox.Show("La password non è stata inserita", "Campo non inserito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _controllo = false;
            }

            // Email
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("L'email non è stata inserita", "Campo non inserito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _controllo = false;
            }

            return _controllo;
        }


        private void FrmRegistrazione_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
