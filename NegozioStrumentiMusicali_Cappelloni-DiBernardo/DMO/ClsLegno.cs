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
            clarinetto,
            clarinetto_basso,
            clarinetto_contralto,
            clarinetto_contrabbasso,
            clarinetto_piccolo,
            flauto_dolce,
            flauto_traverso,
            ottavino,
            sassofono_basso,
            sassofono_baritono,
            sassofono_contralto,
            sassofono_sopranino,
            sassofono_tenore
        }
        public enum eMATERIALE_CORPO_LEGNI
        {
            acero,
            argento,
            bosso,
            cocobolo,
            grenadilla,
            oro,
            ottone,
            ottone_argentato,
            ottone_nichelato,
            palissandro,
            plastica,
            quercia
        }
        public enum eMATERIALE_CHIAVI
        {
            alpacca,
            argento,
            avorio,
            ebano,
            oro,
            osso
        }

        #endregion

        #region Attributi
        private eLEGNI _strumento;
        private eMATERIALE_CORPO_LEGNI _materialeCorpo;
        private eMATERIALE_CHIAVI _materialeChiavi;
        private float _lunghezzaCM;
        private float _larghezzaCM;
        private float _altezzaCM;

        #endregion

        #region Proprietà
        public eLEGNI Strumento { get => _strumento; set => _strumento = value; }
        public eMATERIALE_CORPO_LEGNI MaterialeCorpo
        {
            get => _materialeCorpo;
            set
            {
                if((Strumento == eLEGNI.sassofono_baritono
                    || Strumento == eLEGNI.sassofono_basso
                    || Strumento == eLEGNI.sassofono_contralto
                    || Strumento == eLEGNI.sassofono_sopranino
                    || Strumento == eLEGNI.sassofono_tenore)
                    && !(value == eMATERIALE_CORPO_LEGNI.ottone
                    || value == eMATERIALE_CORPO_LEGNI.ottone_argentato
                    || value == eMATERIALE_CORPO_LEGNI.ottone_nichelato))
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
        public float LunghezzaCM
        {
            get
            {
                return _lunghezzaCM;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("La lunghezza deve essere maggiore di 0");
                }
                else
                {
                    _lunghezzaCM = value;
                }
            }
        }
        public float LarghezzaCM
        {
            get
            {
                return _larghezzaCM;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("La larghezza deve essere maggiore di 0");
                }
                else
                {
                    _larghezzaCM = value;
                }
            }
        }
        public float AltezzaCM
        {
            get
            {
                return _altezzaCM;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("L'altezza deve essere maggiore di 0");
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
        //Costruttore ereditato dalla classe madre
        public ClsLegno(int id) : base(id)
        {

        }

        #endregion
    }
}
