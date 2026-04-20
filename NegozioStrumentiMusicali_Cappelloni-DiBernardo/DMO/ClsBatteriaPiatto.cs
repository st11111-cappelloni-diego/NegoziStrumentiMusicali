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
        private int _id;
        private int _batteriaID;
        private int _piattoID;

        #endregion

        #region Proprietà
        public int ID { get => _id; set => _id = value; }
        public int BatteriaID { get => _batteriaID; set => _batteriaID = value; }
        public int PiattoID { get => _piattoID; set => _piattoID = value; }

        #endregion

        #region Costruttore
        public ClsBatteriaPiatto()
        {

        }

        public ClsBatteriaPiatto(int id)
        {
            ID = id;
        }

        #endregion
    }
}
