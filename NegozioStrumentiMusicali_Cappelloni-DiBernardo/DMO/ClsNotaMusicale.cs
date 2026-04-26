using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioStrumentiMusicali
{
    /// <summary>
    /// Sviluppata da Diego Cappelloni
    /// </summary>
    public class ClsNotaMusicale
    {
        #region Enumeratori
        public enum eNOTA_BASE
        {
            Do,
            Re,
            Mi,
            Fa,
            Sol,
            La,
            Si
        }
        public enum eALTERAZIONE
        {
            Bemolle,
            Naturale,
            Diesis,
        }

        #endregion

        #region Attributi
        private int _id;
        private eNOTA_BASE _notaBase;
        private eALTERAZIONE _alterazione;
        private int _ottava;

        #endregion

        #region Proprietà
        public int ID { get => _id; set => _id = value; }
        public eNOTA_BASE NotaBase { get => _notaBase; set => _notaBase = value; }
        public eALTERAZIONE Alterazione { get => _alterazione; set => _alterazione = value; }
        public int Ottava
        { get => _ottava;
            set
            {
                if(value < 0 && value > 10)
                {
                    throw new Exception("Il valore dell'ottava può andare da 0 a 10");
                }
                else
                {
                    _ottava = value;
                }
            }
        }

        #endregion

        #region Costruttore
        public ClsNotaMusicale()
        {
            
        }

        public ClsNotaMusicale(int id)
        {
            ID = id;
        }

        public ClsNotaMusicale(eNOTA_BASE notaBase, eALTERAZIONE alterazione, int ottava)
        {
            NotaBase = notaBase;
            Alterazione = alterazione;
            Ottava = ottava;
        }

        #endregion
    }
}
