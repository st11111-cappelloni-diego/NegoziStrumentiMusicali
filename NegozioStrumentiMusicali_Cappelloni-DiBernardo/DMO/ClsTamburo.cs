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
            cassa,
            rullante,
            timpano,
            tom
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
        private int _diametroIN;
        private eMATERIALE _materiale;
        private int _strati;

        #endregion

        #region Proprietà
        public long ID { get => _id; set => _id = value; }
        public eTIPO Tipo { get => _tipo; set => _tipo = value; }
        /// <summary>
        /// IN sta per inches (ovvero pollici)
        /// </summary>
        public int DiametroIN { get => _diametroIN; set => _diametroIN = value; }
        public eMATERIALE Materiale { get => _materiale; set => _materiale = value; }
        public int Strati { get => _strati; set => _strati = value; }

        #endregion

        #region Costruttore
        public ClsTamburo()
        {

        }

        public ClsTamburo(int id)
        {
            ID = id;
        }

        #endregion
    }
}
