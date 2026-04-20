using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegoziStrumentiMusicali
{
    public class ClsPiatto
    {
        #region Enumeratori
        public enum eTIPO
        {
            Charleston,
            China,
            Crash,
            Ride
        }
        public enum eMATERIALE
        {
            Bronzo_B8,
            Bronzo_B20,
            Ottone
        }

        #endregion

        #region Attributi
        private int _id;
        private eTIPO _tipo;
        private ushort _diametroIN;
        private eMATERIALE _materiale;

        #endregion

        #region Proprietà
        public int ID { get => _id; set => _id = value; }
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
