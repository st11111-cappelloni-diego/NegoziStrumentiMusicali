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

            int _controllo = Controllo(_password, _username);

            if (_controllo == 0)
            {
                ClsUtente _utente = ClsUtenteBL.GetOneUtente(ref Program._connessioneAlDB, _username, out string cominucazione);
                if (_utente == null)
                    MessageBox.Show("Il tuo accesso non è stato consentito", "Accesso Negato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (_utente.Password == _password)
                {
                    MessageBox.Show("Il tuo accesso è stato consentito", "Accesso Consentito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FrmHome frmHome = new FrmHome();
                    frmHome.ShowDialog();
                    
                }
                   
            }


        }

        private int Controllo(string password, string username)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("password non inserita o sono presenti spazi", "Password Errata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Nome utente non inserito o sono presenti spazi", "Nome Utente Errato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            else
                return 0;

        }

        private void btnRegistrazione_Click(object sender, EventArgs e)
        {
            FrmRegistrazione _frmRegistrazione = new FrmRegistrazione();
            _frmRegistrazione.ShowDialog();
        }
    }
}
