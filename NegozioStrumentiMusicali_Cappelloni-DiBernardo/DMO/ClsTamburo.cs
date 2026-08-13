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
    public class ClsTamburo
    {
        #region Enumeratori
        public enum eTIPO
        {
            timpano,
            tom,
            cassa,
            rullante
        }
        public enum eMATERIALE
        {
            fyberskin,
            mylar,
            pelle_di_capra,
            pelle_di_vitello
        }

        #endregion

        #region Attributi
        private long _id;
        private eTIPO _tipo;
        private byte _diametroIN;
        private eMATERIALE _materiale;
        private byte _strati;

        #endregion

        #region Proprietà
        public long ID { get => _id; set => _id = value; }
        public eTIPO Tipo { get => _tipo; set => _tipo = value; }
        /// <summary>
        /// IN sta per inches (ovvero pollici)
        /// </summary>
        public byte DiametroIN
        {
            get => _diametroIN;
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Diametro del tamburo minore o uguale a 0");
                }
                else
                {
                    _diametroIN = value;
                }
            }
        }
        public eMATERIALE Materiale { get => _materiale; set => _materiale = value; }
        public byte Strati
        {
            get => _strati;
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Numeri di strati del tamburo minore o uguale a 0");
                }
                else
                {
                    _strati = value;
                }
            }
        }

        #endregion

        #region Costruttore
        public ClsTamburo()
        {

        }

        public ClsTamburo(long id)
        {
            ID = id;
        }

        #endregion
    }
}
