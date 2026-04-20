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
        #region Attributi
        int _id;
        int _quantita;
        DateTime _dataOra;
        private int _strumentoMusicaleID;
        private int _negozioID;
        private int _indirizzoID;
        private string _usernameCliente;

        #endregion

        #region Proprietà
        public int ID
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
                if (_quantita <= 0)
                {
                    throw new Exception("Quantità minore uguale a 0");
                }
                else
                {
                    _quantita = value;
                }
            }
        }
        public DateTime DataOra { get => _dataOra; set => _dataOra = value; }
        public int StrumentoMusicaleID { get => _strumentoMusicaleID; set => _strumentoMusicaleID = value; }
        public int NegozioID { get => _negozioID; set => _negozioID = value; }
        public int IndirizzoID { get => _indirizzoID; set => _indirizzoID = value; }
        public string UsernameCliente { get => _usernameCliente; set => _usernameCliente = value; }

        #endregion

        #region Costruttore
        public ClsOrdine()
        {

        }

        public ClsOrdine(int idOrdine)
        {
            ID = idOrdine;
        }
        #endregion
    }
}
