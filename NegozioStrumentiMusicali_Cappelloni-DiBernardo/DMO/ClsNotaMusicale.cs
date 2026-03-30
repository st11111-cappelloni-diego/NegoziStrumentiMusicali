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
        public enum eOTTAVA
        {
            Zero,
            Uno,
            Due,
            Tre,
            Quattro,
            Cinque,
            Sei,
            Sette,
            Otto,
            Nove,
            Dieci
        }

        #endregion

        #region Attributi
        private eNOTA_BASE _notaBase;
        private eALTERAZIONE _alterazione;
        private eOTTAVA _ottava;

        #endregion

        #region Proprietà
        public eNOTA_BASE NotaBase { get => _notaBase; set => _notaBase = value; }
        public eALTERAZIONE Alterazione { get => _alterazione; set => _alterazione = value; }
        public eOTTAVA Ottava { get => _ottava; set => _ottava = value; }

        #endregion

        #region Costruttore
        public ClsNotaMusicale()
        {
            
        }

        public ClsNotaMusicale(eNOTA_BASE notaBase, eALTERAZIONE alterazione, eOTTAVA ottava)
        {
            NotaBase = notaBase;
            Alterazione = alterazione;
            Ottava = ottava;
        }

        #endregion
    }
}
