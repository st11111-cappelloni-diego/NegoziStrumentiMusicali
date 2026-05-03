using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioStrumentiMusicali
{
    /// <summary>
    /// Sviluppata da Leonardo Di Bernardo
    /// </summary>
    
    public class ClsUtente
    {
        #region Enumeratori
        public enum eGENERE { uomo, donna, nondichiarato }
        #endregion

        #region Attributi
        private string _username;
        private string _password;
        private string _nome;
        private string _cognome;
        private string _email;
        private DateTime _dataDiNascita;
        private eGENERE _genere;
        private string _pathImmagine;
        private bool _adminSoftware;
        private bool _adminNegozio;
        private bool _bandito;

        #endregion

        #region Proprietà
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Username non inserito");
                }
                else
                {
                    _username = value;
                }
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Password non inserita");
                }
                else
                {
                    _password = value;
                }
            }
        }
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Nome non inserito");
                }
                else
                {
                    _nome = value;
                }
            }
        }
        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Cognome non inserito");
                }
                else
                {
                    _cognome = value;
                }
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Email non inserita");
                }
                else
                {
                    _email = value;
                }
            }
        }
        public DateTime DataDiNascita { get => _dataDiNascita; set => _dataDiNascita = value; }
        public eGENERE Genere { get => _genere; set => _genere = value; }
        public string PathImmagine
        {
            get
            {
                return _pathImmagine;
            }
            set
            {
                _pathImmagine = value;
            }
        }
        public bool AdminSoftware { get => _adminSoftware; set => _adminSoftware = value; }
        public bool AdminNegozio { get => _adminNegozio; set => _adminNegozio = value; }
        public bool Bandito { get => _bandito; set => _bandito = value; }
        #endregion

        #region Costruttore
        public ClsUtente()
        {

        }
        public ClsUtente(string username)
        {
            Username = username;
        }

        #endregion
    }
}
