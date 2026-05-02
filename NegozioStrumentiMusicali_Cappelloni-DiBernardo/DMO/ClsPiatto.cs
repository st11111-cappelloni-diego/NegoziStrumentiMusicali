using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioStrumentiMusicali
{
    public class ClsPiatto
    {
        #region Enumeratori
        public enum eTIPO
        {
            charleston,
            china,
            crash,
            ride
        }
        public enum eMATERIALE
        {
            bronzo_B8,
            bronzo_B20,
            ottone
        }

        #endregion

        #region Attributi
        private long _id;
        private eTIPO _tipo;
        private ushort _diametroIN;
        private eMATERIALE _materiale;

        #endregion

        #region Proprietà
        public long ID { get => _id; set => _id = value; }
        public eTIPO Tipo { get => _tipo; set => _tipo = value; }
        /// <summary>
        /// IN sta per inches (ovvero pollici)
        /// </summary>
        public ushort DiametroIN { get => _diametroIN; set => _diametroIN = value; }
        public eMATERIALE Materiale { get => _materiale; set => _materiale = value; }

        #endregion

        #region Costruttore
        public ClsPiatto()
        {

        }

        public ClsPiatto(int id)
        {
            ID = id;
        }

        #endregion
    }
}
