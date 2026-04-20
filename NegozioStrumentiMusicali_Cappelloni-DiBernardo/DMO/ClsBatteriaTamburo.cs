using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegoziStrumentiMusicali
{
    /// <summary>
    /// Sviluppata da: Diego Cappelloni
    /// </summary>
    public class ClsBatteriaTamburo
    {
        #region Attributi
        private int _id;
        private int _batteriaID;
        private int _tamburoID;

        #endregion

        #region Proprietà
        public int ID { get => _id; set => _id = value; }
        public int BatteriaID { get => _batteriaID; set => _batteriaID = value; }
        public int TamburoID { get => _tamburoID; set => _tamburoID = value; }

        #endregion

        #region Costruttore
        public ClsBatteriaTamburo()
        {

        }

        public ClsBatteriaTamburo(int id)
        {
            ID = id;
        }

        #endregion
    }
}
