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
    class ClsOrdineStrumento
    {
        #region Attributi
        long _id;
        int _quantita;
        private long _strumentoMusicaleID;
        private long _ordineID;
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
                    throw new Exception("ID Ordine minore di 0");
                }
                else
                {
                    _id = value;
                }
            }
        }
        public int Quantita
        {
            get
            {
                return _quantita;
            }
            set
            {
                _quantita = value;
            }
        }
        public long StrumentoMusicaleID { get => _strumentoMusicaleID; set => _strumentoMusicaleID = value; }
        public long OrdineID { get => _ordineID; set => _ordineID = value; }

        #endregion

        #region Costruttore
        public ClsOrdineStrumento()
        {

        }

        public ClsOrdineStrumento(long id)
        {
            ID = id;
        }
        #endregion

    }
}
