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
    public class ClsOttone : ClsStrumentoMusicale
    {
        #region Enumeratori
        /// <summary>
        /// Contiene i principali strumenti della famiglia degli ottoni
        /// </summary>
        public enum eOTTONI
        {
            Bombardino,
            Cornetta,
            Corno_francese,
            Eufonio,
            Flicorno_contralto,
            Flicorno_sopranino,
            Flicorno_soprano,
            Tromba,
            Trombone,
            Tuba
        }
        public enum eMATERIALE_BOCCHINO
        {
            Acciaio_inossidabile,
            Acrilico,
            Derlin,
            Lexan,
            Ottone,
            Titanio
        }
        /// <summary>
        /// Contiene i tipi di ottone (materiale) usati per il corpo degli strumenti della famiglia degli ottoni
        /// </summary>
        public enum eTIPO_OTTONE
        {
            Ottone_giallo,
            Ottone_oro,
            Ottone_rosso
        }
        public enum eRIVESTIMENTO_BOCCHINO
        {
            No,
            Argentatura,
            Doratura
        }
        public enum eTIPO_PLACCATURA
        {
            No,
            Argento,
            Oro
        }

        #endregion

        #region Attributi
        private eOTTONI _strumento;
        private eTIPO_OTTONE _materialeCorpo;
        private bool _laccatura;
        private eTIPO_PLACCATURA _placcatura;
        private eMATERIALE_BOCCHINO _materialeBocchino;
        private eRIVESTIMENTO_BOCCHINO _rivestimentoBocchino;
        private float _lunghezzaCM;
        private float _larghezzaCM;
        private float _altezzaCM;

        #endregion

        #region Proprietà
        public eOTTONI Strumento { get => _strumento; set => _strumento = value; }
        public eTIPO_OTTONE MaterialeCorpo { get => _materialeCorpo; set => _materialeCorpo = value; }
        public bool Laccatura { get => _laccatura; set => _laccatura = value; }
        public eTIPO_PLACCATURA Placcatura { get => _placcatura; set => _placcatura = value; }
        public eMATERIALE_BOCCHINO MaterialeBocchino { get => _materialeBocchino; set => _materialeBocchino = value; }
        public eRIVESTIMENTO_BOCCHINO RivestimentoBocchino { get => _rivestimentoBocchino; set => _rivestimentoBocchino = value; }
        public float LunghezzaCM
        {
            get
            {
                return _lunghezzaCM;
            }
            set
            {
                if(value <= 0)
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
        public ClsOttone()
        {

        }
        //Costruttore ereditato dalla classe madre
        public ClsOttone(int id) : base(id)
        {

        }

        #endregion
    }
}
