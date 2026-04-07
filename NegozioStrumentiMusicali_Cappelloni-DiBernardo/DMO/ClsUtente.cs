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
    
    public abstract class ClsUtente
    {
        #region Enumeratori
        public enum eGENERE { Uomo, Donna, Non_dichiarato }
        #endregion

        #region Attributi
        string _username;
        string _password;
        string _nome;
        string _cognome;
        string _email;
        DateTime _dataDiNascita;
        eGENERE _genere;
        string _immagineProfilo;

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
        public string ImmagineProfilo
        {
            get
            {
                return _immagineProfilo;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Immagine profilo non inserita");
                }
                else
                {
                    _immagineProfilo = value;
                }
            }
        }
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
