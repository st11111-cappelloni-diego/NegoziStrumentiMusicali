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
    public class ClsCasaProdruttrice
    {
        #region Attributi
        int _id;
        string _nome;
        string _email;
        string _logo;

        #endregion

        #region Proprietà
        public int Id
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
        public string Logo
        {
            get
            {
                return _logo;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Logo non inserito");
                }
                else
                {
                    _logo = value;
                }
            }
        }

        #endregion

        #region Costruttore
        public ClsCasaProdruttrice()
        {

        }

        public ClsCasaProdruttrice(int id)
        {
            Id = id;
        }

        #endregion
    }
}
