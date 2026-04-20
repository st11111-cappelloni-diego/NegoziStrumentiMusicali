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
        private int _id;
        private int _quantita;
        private decimal _prezzo;
        private int _strumentoMusicaleID;
        private int _negozioID;

        #endregion

        #region Proprietà
        public int ID { get => _id; set => _id = value; }
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
        public int StrumentoMusicaleID { get => _strumentoMusicaleID; set => _strumentoMusicaleID = value; }
        public int NegozioID { get => _negozioID; set => _negozioID = value; }

        #endregion

        #region Costruttore
        public ClsVendere()
        {

        }

        public ClsVendere(int id)
        {
            ID = id;
        }

        #endregion
    }
}
