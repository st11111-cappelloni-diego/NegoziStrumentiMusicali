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
    public class ClsCasaProduttrice
    {
        #region Attributi
        long _id;
        string _nome;
        string _email;
        string _pathLogo;
        string _sito;

        #endregion

        #region Proprietà
        public long ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id < 0)
                {
                    throw new Exception("ID minore di 0");
                }
                else
                {
                    _id = value;
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
        public string PathLogo
        {
            get
            {
                return _pathLogo;
            }
            set
            {           
                _pathLogo = value;
            }
        }

        public string Sito { get => _sito; set => _sito = value; }

        #endregion

        #region Costruttore
        public ClsCasaProduttrice()
        {

        }

        public ClsCasaProduttrice(long id)
        {
            ID = id;
        }

        #endregion
    }
}
