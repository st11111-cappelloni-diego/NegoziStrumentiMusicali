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
    public class ClsLegno : ClsStrumentoMusicale
    {
        #region Enumeratori
        public enum eLEGNI
        {
            Clarinetto,
            Clarinetto_basso,
            Clarinetto_contralto,
            Clarinetto_contrabbasso,
            Clarinetto_piccolo,
            Flauto_dolce,
            Flauto_traverso,
            Ottavino,
            Sassofono_basso,
            Sassofono_baritono,
            Sassofono_contralto,
            Sassofono_sopranino,
            Sassofono_tenore
        }
        public enum eMATERIALE_CORPO_LEGNI
        {
            Acero,
            Argento,
            Bosso,
            Cocobolo,
            Grenadilla,
            Oro,
            Ottone,
            Ottone_argentato,
            Ottone_nichelato,
            Palissandro,
            Plastica,
            Quercia
        }
        public enum eMATERIALE_CHIAVI
        {
            Alpacca,
            Argento,
            Avorio,
            Ebano,
            Oro,
            Osso
        }

        #endregion

        #region Attributi
        private eLEGNI _strumento;
        private eMATERIALE_CORPO_LEGNI _materialeCorpo;
        private eMATERIALE_CHIAVI _materialeChiavi;
        private float _altezzaCM;

        #endregion

        #region Proprietà
        public eLEGNI Strumento { get => _strumento; set => _strumento = value; }
        public eMATERIALE_CORPO_LEGNI MaterialeCorpo
        {
            get => _materialeCorpo;
            set
            {
                if((Strumento == eLEGNI.Sassofono_baritono
                    || Strumento == eLEGNI.Sassofono_basso
                    || Strumento == eLEGNI.Sassofono_contralto
                    || Strumento == eLEGNI.Sassofono_sopranino
                    || Strumento == eLEGNI.Sassofono_tenore)
                    && !(value == eMATERIALE_CORPO_LEGNI.Ottone
                    || value == eMATERIALE_CORPO_LEGNI.Ottone_argentato
                    || value == eMATERIALE_CORPO_LEGNI.Ottone_nichelato))
                {
                    throw new Exception("L'unico materiale ammissibile per il corpo di un sassofono è l'ottone");
                }
                else
                {
                    _materialeCorpo = value;
                }
            }
        }
        public eMATERIALE_CHIAVI MaterialeChiavi { get => _materialeChiavi; set => _materialeChiavi = value; }
        public float AltezzaCM
        {
            get
            {
                return _altezzaCM;
            }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Altezza dello strumento minore o uguale a 0");
                }
                else
                {
                    _altezzaCM = value;
                }
            }
        }

        #endregion

        #region Costruttore
        public ClsLegno()
        {

        }

        #endregion
    }
}
