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
    public class ClsBatteriaTamburo
    {
        #region Attributi
        private long _id;
        private long _batteriaID;
        private long _tamburoID;

        #endregion

        #region Proprietà
        public long ID { get => _id; set => _id = value; }
        public long BatteriaID { get => _batteriaID; set => _batteriaID = value; }
        public long TamburoID { get => _tamburoID; set => _tamburoID = value; }

        #endregion

        #region Costruttore
        public ClsBatteriaTamburo()
        {

        }

        public ClsBatteriaTamburo(long id)
        {
            ID = id;
        }

        #endregion
    }
}
