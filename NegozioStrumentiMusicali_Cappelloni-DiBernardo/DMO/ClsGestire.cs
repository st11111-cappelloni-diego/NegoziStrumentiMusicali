using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioStrumentiMusicali
{
    /// <summary>
    /// Sviluppata da Leonardo Di Bernardo
    /// </summary>
    public class ClsGestire
    {
        #region Attributi
        private int _id;
        private int _negozioID;
        private string _utenteUsername;

        #endregion

        #region Proprietà
        public int ID { get => _id; set => _id = value; }
        public int NegozioID { get => _negozioID; set => _negozioID = value; }
        public string UtenteUsername { get => _utenteUsername; set => _utenteUsername = value; }

        #endregion

        #region Costruttore
        public ClsGestire()
        {

        }

        public ClsGestire(int id)
        {
            ID = id;
        }

        #endregion
    }
}
