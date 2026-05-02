using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioStrumentiMusicali
{
    public class ClsBatteriaPiatto
    {
        #region Attributi
        private long _id;
        private long _batteriaID;
        private long _piattoID;

        #endregion

        #region Proprietà
        public long ID { get => _id; set => _id = value; }
        public long BatteriaID { get => _batteriaID; set => _batteriaID = value; }
        public long PiattoID { get => _piattoID; set => _piattoID = value; }

        #endregion

        #region Costruttore
        public ClsBatteriaPiatto()
        {

        }

        public ClsBatteriaPiatto(long id)
        {
            ID = id;
        }

        #endregion
    }
}
