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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            string _username = tbUsername.Text;
            string _password = tbPassword.Text;
            string _comunicazione = String.Empty;

            bool _credenzialiGiuste = CredenzialiGiuste(_password, _username);

            if (_credenzialiGiuste)
            {
                //Criptare la password prima di fare il confronto

                ClsUtente _utente = ClsUtenteBL.GetOneUtente(ref Program._connessioneAlDB, _username, out _comunicazione);
                if (_utente == null || _utente.Password == _password)
                    MessageBox.Show("Il tuo accesso non è stato consentito:\n" + _comunicazione, "Accesso Negato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Il tuo accesso è stato consentito", "Accesso Consentito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FrmHome frmHome = new FrmHome();
                    frmHome.ShowDialog();                    
                }
                   
            }


        }

        private bool CredenzialiGiuste(string password, string username)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password non inserita o vuota", "Password Errata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username non inserito o vuoto", "Username Errato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
                return true;

        }

        private void btnRegistrazione_Click(object sender, EventArgs e)
        {
            FrmRegistrazione _frmRegistrazione = new FrmRegistrazione();
            _frmRegistrazione.ShowDialog();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
