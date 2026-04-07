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
    class ClsStrumentoACorda : ClsStrumentoMusicale
    {
        #region Enumeratori
        /// <summary>
        /// Contiene gli strumenti principali delle sottofamiglie di archi e liuti
        /// </summary>
        public enum eSTRUMENTI_A_CORDA
        {
            Balalaika,
            Banjo,
            Basso_acustico,
            Basso_elettrico,
            Chitarra_acustica,
            Chitarra_elettrica,
	        Chitarra_resofonica,
            Chitarra_semiacustica,
            Contrabbasso,
            Guitalele,
	        Lap_steel_guitar,
            Ukulele,
            Viola,
            Violino,
            Violoncello
        }
        public enum eNUMERO_CORDE
        {
            Uno,
            Due,
            Tre,
            Quattro,
            Cinque,
            Sei,
            Sette,
            Otto,
            Nove,
            Dieci,
            Undici,
            Dodici
        }
        public enum eMATERIALE_CORDE
        {
            Acciaio,
            Budello,
            Dacron,
            Dyneema,
            Kevlar,
            Nylon,
            Oro,
            Spectra

        }
	    public enum ePICKUP
	    {
		    No,
		    Humbucker,
		    P90,
		    Single_coil
	    }

        #endregion

        #region Attributi
        private eSTRUMENTI_A_CORDA _strumento;
        private eNUMERO_CORDE _numeroCorde;
        private eMATERIALE_CORDE _materialeCorde;
        private float _lunghezzaCorpoCM;
        private float _ampiezzaCorpoCM;
        private float _spessoreCorpoCM;
        private Program.eLEGNO _materialeCorpo;
	    private float _lunghezzaManicoCM;
        private float _ampiezzaManicoCM;
        private float _spessoreManicoCM;
        private Program.eLEGNO _materialeManico;
        private Program.eLEGNO _materialeTastiera;
        private int _tasti;
	    private ePICKUP _pickup1;
	    private ePICKUP _pickup2;
	    private ePICKUP _pickup3;

        #endregion

        #region Proprietà
        public eSTRUMENTI_A_CORDA Strumento { get => _strumento; set => _strumento = value; }
        public eNUMERO_CORDE NumeroCorde { get => _numeroCorde; set => _numeroCorde = value; }
        public eMATERIALE_CORDE MaterialeCorde { get => _materialeCorde; set => _materialeCorde = value; }
        public float LunghezzaCorpoCM
        {
            get
            {
                return _lunghezzaCorpoCM;
            }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Lunghezza del corpo minore o uguale a 0");
                }
                else
                {
                    value = _lunghezzaCorpoCM;
                }
            }
        }
        public float AmpiezzaCorpoCM
        {
            get
            {
                return _ampiezzaCorpoCM;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Ampiezza del corpo minore o uguale a 0");
                }
                else
                {
                    value = _ampiezzaCorpoCM;
                }
            }
        }
        public float SpessoreCorpoCM
        {
            get
            {
                return _spessoreCorpoCM;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Spessore del corpo minore o uguale a 0");
                }
                else
                {
                    value = _spessoreCorpoCM;
                }
            }
        }
        public Program.eLEGNO MaterialeCorpo { get => _materialeCorpo; set => _materialeCorpo = value; }
        public float LunghezzaManicoCM
        {
            get
            {
                return _lunghezzaManicoCM;
            }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Lunghezza manico minore o uguale a 0");
                }
                else
                {
                    _lunghezzaManicoCM = value;
                }
            }
        }
        public float AmpiezzaManicoCM
        {
            get
            {
                return _ampiezzaManicoCM;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Ampiezza" +
                        " manico minore o uguale a 0");
                }
                else
                {
                    _ampiezzaManicoCM = value;
                }
            }
        }
        public float SpessoreManicoCM
        {
            get
            {
                return _spessoreManicoCM;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Spessore manico minore o uguale a 0");
                }
                else
                {
                    _spessoreManicoCM = value;
                }
            }
        }
        public Program.eLEGNO MaterialeManico { get => _materialeManico; set => _materialeManico = value; }
        public Program.eLEGNO MaterialeTastiera { get => _materialeTastiera; set => _materialeTastiera = value; }
	    ///<summary>
	    ///Proprietà NON utilizzata per: Contrabbasso, Viola, Violino, Violoncello. In istanze di questo tipo l'attr. tasti è -1
	    ///</summary>
	    public int Tasti
	    {
		    get
		    {
			    return _tasti;
		    }
		    set
		    {              
                if(Strumento == eSTRUMENTI_A_CORDA.Contrabbasso
                    || Strumento == eSTRUMENTI_A_CORDA.Viola
                    || Strumento == eSTRUMENTI_A_CORDA.Violino
                    || Strumento == eSTRUMENTI_A_CORDA.Violoncello)
                {
                    _tasti = 0;
                }
                //Min tasti: 3; Max tasti: 32
                else if (value >= 3 && value <= 32)
                {
                    _tasti = value;
                }
                else
                {
                    throw new Exception("Il numero di tasti deve essere compreso tra 1 e 32");
                }
		    }
	    }
        /// <summary>
        /// Proprietà usata solo per: chitarra elettrica, semiacustica o lap_steel o basso elettrico
        /// </summary>
        public ePICKUP Pickup1 { get => _pickup1; set => _pickup1 = value; }
        /// <summary>
        /// Proprietà usata solo per: chitarra elettrica, semiacustica o lap_steel o basso elettrico
        /// </summary>
        public ePICKUP Pickup2 { get => _pickup2; set => _pickup2 = value; }
        /// <summary>
        /// Proprietà usata solo per: chitarra elettrica, semiacustica o lap_steel o basso elettrico
        /// </summary>
        public ePICKUP Pickup3 { get => _pickup3; set => _pickup3 = value; }
        /// <summary>
        /// Proprietà calcolata
        /// </summary>
        public float LunghezzaTotaleCM
        {
            set
            {
                value = LunghezzaCorpoCM + LunghezzaManicoCM; 
            }
        }
       
        #endregion

        #region Costruttore
        public ClsStrumentoACorda()
	    {
	        
	    }
        //Costruttore ereditato dalla classe madre
        public ClsStrumentoACorda(int id) : base(id)
        {

        }

        #endregion
    }
}
