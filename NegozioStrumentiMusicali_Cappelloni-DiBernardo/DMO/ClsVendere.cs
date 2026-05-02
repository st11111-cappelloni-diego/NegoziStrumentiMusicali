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
    public class ClsVendere
    {
        #region Attributi
        private long _id;
        private int _quantita;
        private decimal _prezzo;
        private long _strumentoMusicaleID;
        private long _negozioID;

        #endregion

        #region Proprietà
        public long ID { get => _id; set => _id = value; }
        public int Quantita
        {
            get => _quantita;
            set
            {
                if(value < 0)
                {
                    throw new Exception("La quantità non può essere un numero negativo");
                }
                else
                {
                    _quantita = value;
                }
            }
        }
        public decimal Prezzo
        {
            get => _prezzo;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Prezzo minore o uguale a 0");
                }
                else
                {
                    _prezzo = value;
                }
            }
        }
        public long StrumentoMusicaleID { get => _strumentoMusicaleID; set => _strumentoMusicaleID = value; }
        public long NegozioID { get => _negozioID; set => _negozioID = value; }

        #endregion

        #region Costruttore
        public ClsVendere()
        {

        }

        public ClsVendere(long id)
        {
            ID = id;
        }

        #endregion
    }
}
