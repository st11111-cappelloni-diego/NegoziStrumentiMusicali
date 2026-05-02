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
        private long _id;
        private long _negozioID;
        private string _utenteUsername;

        #endregion

        #region Proprietà
        public long ID { get => _id; set => _id = value; }
        public long NegozioID { get => _negozioID; set => _negozioID = value; }
        public string UtenteUsername { get => _utenteUsername; set => _utenteUsername = value; }

        #endregion

        #region Costruttore
        public ClsGestire()
        {

        }

        public ClsGestire(long id)
        {
            ID = id;
        }

        #endregion
    }
}
