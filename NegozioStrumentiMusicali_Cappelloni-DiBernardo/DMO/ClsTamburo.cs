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
            Cassa,
            Rullante,
            Timpano,
            Tom
        }
        public enum eMATERIALE
        {
            Fyberskin,
            Mylar,
            Pelle_di_capra,
            Pelle_di_vitello
        }

        #endregion

        #region Attributi
        private long _id;
        private eTIPO _tipo;
        private ushort _diametroIN;
        private eMATERIALE _materiale;
        private ushort _strati;

        #endregion

        #region Proprietà
        public long ID { get => _id; set => _id = value; }
        public eTIPO Tipo { get => _tipo; set => _tipo = value; }
        /// <summary>
        /// IN sta per inches (ovvero pollici)
        /// </summary>
        public ushort DiametroIN { get => _diametroIN; set => _diametroIN = value; }
        public eMATERIALE Materiale { get => _materiale; set => _materiale = value; }
        public ushort Strati { get => _strati; set => _strati = value; }

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
