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
    public class ClsOrdine
    {
        #region Enumeratori
        public enum eSTATO
        {
            non_visualizzato,
            visualizzato,
            spedito
        }
        #endregion

        #region Attributi
        long _id;
        DateTime _dataOra;
        private long _negozioID;
        private long _indirizzoID;
        private string _usernameCliente;
        private eSTATO stato;
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

        public DateTime DataOra { get => _dataOra; set => _dataOra = value; }
        public long NegozioID { get => _negozioID; set => _negozioID = value; }
        public long IndirizzoID { get => _indirizzoID; set => _indirizzoID = value; }
        public string UsernameCliente { get => _usernameCliente; set => _usernameCliente = value; }
        public eSTATO Stato { get => stato; set => stato = value; }

        #endregion

        #region Costruttore
        public ClsOrdine()
        {

        }

        public ClsOrdine(long idOrdine)
        {
            ID = idOrdine;
        }
        #endregion
    }
}
