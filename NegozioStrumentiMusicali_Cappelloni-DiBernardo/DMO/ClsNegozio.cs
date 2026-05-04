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
    public class ClsNegozio
    {
        #region Attributi
        private long _id;
        private string _nome;
        private bool _bandito;
        private string _pathImmagine;
        private long _indirizzoID;
        private string _sito;
        private string _email;
        private string _telefono;
       
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
        public bool Bandito { get => _bandito; set => _bandito = value; }
        public string PathImmagine { get => _pathImmagine; set => _pathImmagine = value; }
        public long IndirizzoID { get => _indirizzoID; set => _indirizzoID = value; }
        public string Sito { get => _sito; set => _sito = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }

        #endregion

        #region Costruttore
        public ClsNegozio()
        {

        }

        public ClsNegozio(long id)
        {
            ID = id;
        }

        #endregion
    }
}
