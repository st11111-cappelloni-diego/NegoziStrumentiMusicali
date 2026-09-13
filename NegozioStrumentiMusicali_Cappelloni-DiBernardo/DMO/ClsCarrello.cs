using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioStrumentiMusicali
{
    class ClsCarrello
    {
        #region Attributi
        int _quantita;
        private ClsStrumentoMusicale _strumentoMusicale;
        private long _negozioID;
        private decimal _prezo;
        #endregion

        #region Proprietà
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
        public long NegozioID { get => _negozioID; set => _negozioID = value; }
        public ClsStrumentoMusicale StrumentoMusicale { get => _strumentoMusicale; set => _strumentoMusicale = value; }
        public decimal Prezo { get => _prezo; set => _prezo = value; }

        #endregion

        #region Costruttore
        public ClsCarrello()
        {

        }

        public ClsCarrello(ClsStrumentoMusicale strumentoMusicale, int quantita, long negozioID, decimal prezzo)
        {
            StrumentoMusicale = strumentoMusicale;
            NegozioID = negozioID;
            Quantita = quantita;
            Prezo = prezzo;
        }
        #endregion

    }
}
