using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
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


        private async void CaricaDati(bool ordinaPerPiuRecente, int limiteRecord)
        {
            string _comunicazioneNoteMusicali = String.Empty;
            string _comunicazioneTamburi = String.Empty;
            string _comunicazionePiatti = String.Empty;
            string _comunicazione = String.Empty;
            await Task.WhenAll
            (
                //Note musicali: Ordinate sempre dalla più bassa alla più alta. Le carico tutte
                Task.Run
                (() =>
                    ClsArchivio.NoteMusicali = ClsNotaMusicaleBL.GetAllNoteMusicali(Program._connectionString, false, out _comunicazioneNoteMusicali)
                ),
                Task.Run
                (() =>
                    ClsArchivio.Tamburi = ClsTamburoBL.GetAllTamburi(Program._connectionString, ordinaPerPiuRecente, out _comunicazioneTamburi, limiteRecord)
                ),
                Task.Run
                (() =>
                    ClsArchivio.Piatti = ClsPiattoBL.GetAllPiatti(Program._connectionString, ordinaPerPiuRecente, out _comunicazionePiatti, limiteRecord)
                ),
                Task.Run
                (() =>
                    ClsArchivio.Pianoforti = ClsPianoforteBL.GetAllPianoforti(Program._connectionString, ordinaPerPiuRecente, out _comunicazione, limiteRecord)
                ),
                Task.Run
                (() =>
                    ClsArchivio.Legni = ClsLegnoBL.GetAllLegni(Program._connectionString, ordinaPerPiuRecente, out _comunicazione, limiteRecord)
                ),
                Task.Run
                (() =>
                    ClsArchivio.Ottoni = ClsOttoneBL.GetAllOttoni(Program._connectionString, ordinaPerPiuRecente, out _comunicazione, limiteRecord)
                ),
                Task.Run
                (() =>
                    ClsArchivio.StrumentiACorda = ClsStrumentoACordaBL.GetAllStrumentiACorda(Program._connectionString, ordinaPerPiuRecente, out _comunicazione, limiteRecord)
                ),
                //Negozi: Li carico tutti ordinandoli in maniera crescente
                Task.Run
                (() =>
                    ClsArchivio.Negozi = ClsNegozioBL.GetAllNegozi(Program._connectionString, false, out _comunicazione)
                )
            );
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
                _password = Crittografia(_password);

                ClsArchivio.UtenteAttuale = ClsUtenteBL.GetOneUtente(ref Program._connessioneAlDB, _username, out _comunicazione);
                if (ClsArchivio.UtenteAttuale == null) //L'utente con l'username inserito non esiste o altro problema legato al DB
                    MessageBox.Show("Il tuo accesso non è stato consentito:\n" + _comunicazione, "Accesso Negato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if(ClsArchivio.UtenteAttuale.Password == _password) 
                    {
                        if(ClsArchivio.UtenteAttuale.Bandito == false)
                        {
                            //Utente esistente e password corretta e non è bandito
                            MessageBox.Show("Il tuo accesso è stato consentito", "Accesso Consentito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmHome _frmHome = new FrmHome();
                            _frmHome.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Il tuo accesso non è stato consentito:\nSei bandito da questa piattaforma.\nRichiedi la revoca del ban contattando uno degli admin del software",
                                "Accesso Negato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else //La password inserita non corrisponde a quella sul DB
                    {
                        MessageBox.Show("Il tuo accesso non è stato consentito:\nPassword non corretta", "Accesso Negato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                   
            }
        }

        private static string Crittografia(string input)
        {
            // converto la stringa in byte (UTF8)
            byte[] bytes = Encoding.UTF8.GetBytes(input);

            // creo l’istanza SHA256
            using (SHA256 sha = SHA256.Create())
            {
                byte[] hashBytes = sha.ComputeHash(bytes);

                // converto i byte in stringa esadecimale
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                    sb.Append(b.ToString("x2")); // "x2" = due cifre esadecimali

                return sb.ToString();
            }
        }

        private static bool CredenzialiGiuste(string password, string username)
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
            //Carico i record che servono a tutti i tipi di utenti su un processo separato mentre si svolge il login
            //Ogni tabella su un processo separato. Carico i 50 record più recenti per ogni tabella
            CaricaDati(true, 50);
        }

        private void btnVisualizzaPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
