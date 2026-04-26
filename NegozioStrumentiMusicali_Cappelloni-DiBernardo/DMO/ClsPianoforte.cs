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
    public class ClsPianoforte : ClsStrumentoMusicale
    {
        #region Enumeratori
        public enum eTIPO_PF
        {
            Acustico,
            Elettrico
        }

        public enum eMATERIALE_TASTI_PF
        {
            Avorio,
            Galatite,
            Ivorite,
            Legno,
            Neotex,
            Plastica
        }

        #endregion

        #region Attributi
        private eTIPO_PF _tipo;
        private int _numeroTasti;
        private eMATERIALE_TASTI_PF _materialeTastiBianchi;
        private eMATERIALE_TASTI_PF _materialeTastiNeri;
        private Program.eLEGNO _materialeCorpoPFAcustico;
        private float _altezzaCM;
        private float _lunghezzaCM;
        private float _profonditaCM;
        private float _altezzaGinocchioCM;

        #endregion

        #region Proprietà
        public eTIPO_PF Tipo { get => _tipo; set => _tipo = value; }
        public int NumeroTasti
        {
            get
            {
                return _numeroTasti;
            }
            set
            {
                if(_numeroTasti <= 12 || _numeroTasti >= 121)
                {
                    throw new Exception("Il numero di tasti per un pianoforte o tastiera può andare da 12 ai 121");
                }
                else
                {
                    _numeroTasti = value;
                }
            }
        }
        public eMATERIALE_TASTI_PF MaterialeTastiBianchi { get => _materialeTastiBianchi; set => _materialeTastiBianchi = value; }
        public eMATERIALE_TASTI_PF MaterialeTastiNeri { get => _materialeTastiNeri; set => _materialeTastiNeri = value; }
        public Program.eLEGNO MaterialeCorpoPFAcustico { get => _materialeCorpoPFAcustico; set => _materialeCorpoPFAcustico = value; }
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
                    throw new Exception("Altezza minore o uguale a 0");
                }
                else
                {
                    _altezzaCM = value;
                }
            }
        }
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
                    throw new Exception("Lunghezza minore o uguale a 0");
                }
                else
                {
                    _lunghezzaCM = value;
                }
            }
        }
        public float ProfonditaCM
        {
            get
            {
                return _profonditaCM;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Profondità minore o uguale a 0");
                }
                else
                {
                    _profonditaCM = value;
                }
            }
        }
        public float AltezzaGinocchioCM
        {
            get
            {
                return _altezzaGinocchioCM;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Altezza ginocchio minore o uguale a 0");
                }
                else
                {
                    _altezzaGinocchioCM = value;
                }
            }
        }

        #endregion

        #region Costruttore
        public ClsPianoforte()
        {

        }
        //Costruttore ereditato dalla classe madre
        public ClsPianoforte(int id) : base(id)
        {

        }

        #endregion
    }
}
