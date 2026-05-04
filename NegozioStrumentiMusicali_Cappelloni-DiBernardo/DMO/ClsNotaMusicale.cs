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
            //Metto la chiocciola sennò il compilatore lo interpreta come parola chiave
            //Quando faccio .ToString() restituisce 'do'
            //Infatti il nome reale della costante è do
            @do, 
            re,
            mi,
            fa,
            sol,
            la,
            si
        }
        public enum eALTERAZIONE
        {
            bemolle,
            naturale,
            diesis,
        }

        #endregion

        #region Attributi
        private long _id;
        private eNOTA_BASE _notaBase;
        private eALTERAZIONE _alterazione;
        private byte _ottava;

        #endregion

        #region Proprietà
        public long ID { get => _id; set => _id = value; }
        public eNOTA_BASE NotaBase { get => _notaBase; set => _notaBase = value; }
        public eALTERAZIONE Alterazione { get => _alterazione; set => _alterazione = value; }
        public byte Ottava
        {
            get => _ottava;
            set
            {
                _ottava = value;
            }
        }

        #endregion

        #region Costruttore
        public ClsNotaMusicale()
        {
            
        }

        public ClsNotaMusicale(long id)
        {
            ID = id;
        }

        public ClsNotaMusicale(eNOTA_BASE notaBase, eALTERAZIONE alterazione, byte ottava)
        {
            NotaBase = notaBase;
            Alterazione = alterazione;
            Ottava = ottava;
        }

        #endregion
    }
}
