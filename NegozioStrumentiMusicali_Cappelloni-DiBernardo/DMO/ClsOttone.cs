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
            bombardino,
            cornetta,
            corno_francese,
            eufonio,
            flicorno_contralto,
            flicorno_sopranino,
            flicorno_soprano,
            tromba,
            trombone,
            tuba
        }
        public enum eMATERIALE_BOCCHINO
        {
            acciaio_inossidabile,
            acrilico,
            derlin,
            lexan,
            ottone,
            titanio
        }
        /// <summary>
        /// Contiene i tipi di ottone (materiale) usati per il corpo degli strumenti della famiglia degli ottoni
        /// </summary>
        public enum eTIPO_OTTONE
        {
            ottone_giallo,
            ottone_oro,
            ottone_rosso
        }
        public enum eRIVESTIMENTO_BOCCHINO
        {
            no,
            argentatura,
            doratura
        }
        public enum eTIPO_PLACCATURA
        {
            no, argento, oro, nickel, rodio, rame, palladio, platino, titanio
        }
        public enum eTIPO_LACCATURA
        {
            no, trasparente, oro, ambra, miele, satinata, spazzolata, nera, colorata, vintage, antique, raw_brass
        }

        #endregion

        #region Attributi
        private eOTTONI _strumento;
        private eTIPO_OTTONE _materialeCorpo;
        private eTIPO_LACCATURA _laccatura;
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
        public eTIPO_LACCATURA Laccatura { get => _laccatura; set => _laccatura = value; }
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
        public ClsOttone(long id) : base(id)
        {

        }

        #endregion
    }
}
