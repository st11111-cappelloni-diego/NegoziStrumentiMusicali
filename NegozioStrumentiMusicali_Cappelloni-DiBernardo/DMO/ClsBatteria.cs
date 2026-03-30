using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioStrumentiMusicali
{
    /// <summary>
    /// Sviluppata da: Diego Cappelloni
    /// </summary>
    public class ClsBatteria : ClsStrumentoMusicale
    {
        #region Enumeratori
        public enum eMATERIALE_TAMBURO
        {
            Fyberskin,
            Mylar,
            Pelle_di_capra,
            Pelle_di_vitello
        }
        public enum eMATERIALE_PIATTO
        {
            Bronzo_B8,
            Bronzo_B20,
            Ottone
        }

        #endregion

        #region Attributi
        private int _diametroCassaIN; //IN = Inches (Pollici)
        private eMATERIALE_TAMBURO _materialeCassa;
        private int _stratiCassa;
        private int _diametroRullanteIN;
        private eMATERIALE_TAMBURO _materialeRullante;
        private int _stratiRullante;
        private bool _timpanoIncluso;
        private int _diametroTimpanoIN;
        private eMATERIALE_TAMBURO _materialeTimpano;
        private int _stratiTimpano;
        private bool _tomsInclusi;
        private List<int> _diametriTomsIN;
        private List<eMATERIALE_TAMBURO> _materialiToms;
        private List<int> _stratiTomsIN;
        private int _diametroCharlestonIN;
        private eMATERIALE_PIATTO _materialeCharleston;
        private bool _rideIncluso;
        private int _diametroRideIN;
        private eMATERIALE_PIATTO _materialeRide;
        private bool _crashIncluso;
        private int _diametroCrashIN;
        private eMATERIALE_PIATTO _materialeCrash;

        #endregion

        #region Proprietà
        public int DiametroCassaIN
        {
            get => _diametroCassaIN;
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Diametro cassa minore o uguale a 0");
                }
                else
                {
                    _diametroCassaIN = value;
                }
            }
        }
        public eMATERIALE_TAMBURO MaterialeCassa { get => _materialeCassa; set => _materialeCassa = value; }
        public int StratiCassa
        {
            get => _stratiCassa;
            set
            {
                if(value < 1 || value > 100)
                {
                    throw new Exception("Il numero di strati di un tamburo può andare da 1 a 100");
                }
                else
                {
                    _stratiCassa = value;
                }
            }
        }
        public int DiametroRullanteIN
        {
            get => _diametroRullanteIN;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Diametro rullante minore o uguale a 0");
                }
                else
                {
                    _diametroRullanteIN = value;
                }
            }
        }
        public eMATERIALE_TAMBURO MaterialeRullante { get => _materialeRullante; set => _materialeRullante = value; }
        public int StratiRullante
        {
            get => _stratiRullante;
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new Exception("Il numero di strati di un tamburo può andare da 1 a 100");
                }
                else
                {
                    _stratiRullante = value;
                }
            }
        }
        public bool TimpanoIncluso { get => _timpanoIncluso; set => _timpanoIncluso = value; }
        public int DiametroTimpanoIN
        {
            get => _diametroTimpanoIN;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Diametro timpano minore o uguale a 0");
                }
                else
                {
                    _diametroTimpanoIN = value;
                }
            }
        }
        public eMATERIALE_TAMBURO MaterialeTimpano { get => _materialeTimpano; set => _materialeTimpano = value; }
        public int StratiTimpano
        {
            get => _stratiTimpano;
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new Exception("Il numero di strati di un tamburo può andare da 1 a 100");
                }
                else
                {
                    _stratiTimpano = value;
                }
            }
        }
        public bool TomsInclusi { get => _tomsInclusi; set => _tomsInclusi = value; }
        public List<int> DiametriTomsIN { get => _diametriTomsIN; set => _diametriTomsIN = value; }
        public List<eMATERIALE_TAMBURO> MaterialiToms { get => _materialiToms; set => _materialiToms = value; }
        public List<int> StratiTomsIN { get => _stratiTomsIN; set => _stratiTomsIN = value; }
        public int DiametroCharlestonIN
        {
            get => _diametroCharlestonIN;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Diametro charleston minore o uguale a 0");
                }
                else
                {
                    _diametroCharlestonIN = value;
                }
            }
        }
        public eMATERIALE_PIATTO MaterialeCharleston { get => _materialeCharleston; set => _materialeCharleston = value; }
        public bool RideIncluso { get => _rideIncluso; set => _rideIncluso = value; }
        public int DiametroRideIN
        {
            get => _diametroRideIN;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Diametro ride minore o uguale a 0");
                }
                else
                {
                    _diametroRideIN = value;
                }
            }
        }
        public eMATERIALE_PIATTO MaterialeRide { get => _materialeRide; set => _materialeRide = value; }
        public bool CrashIncluso { get => _crashIncluso; set => _crashIncluso = value; }
        public int DiametroCrashIN
        {
            get => _diametroCrashIN;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Diametro crash minore o uguale a 0");
                }
                else
                {
                    _diametroCrashIN = value;
                }
            }
        }
        public eMATERIALE_PIATTO MaterialeCrash { get => _materialeCrash; set => _materialeCrash = value; }

        #endregion

        #region Costruttore
        public ClsBatteria()
        {

        }

        #endregion

    }
}
