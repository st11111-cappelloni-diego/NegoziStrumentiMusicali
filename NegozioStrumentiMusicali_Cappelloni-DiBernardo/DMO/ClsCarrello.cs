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
        private long _strumentoMusicaleID;
        private long _negozioID;
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
        public long StrumentoMusicaleID { get => _strumentoMusicaleID; set => _strumentoMusicaleID = value; }
        public long NegozioID { get => _negozioID; set => _negozioID = value; }

        #endregion

        #region Costruttore
        public ClsCarrello()
        {

        }

        public ClsCarrello(long strumentoMusicaleID, int quantita, long negozioID)
        {
            StrumentoMusicaleID = strumentoMusicaleID;
            NegozioID = negozioID;
            Quantita = quantita;
        }
        #endregion

    }
}
