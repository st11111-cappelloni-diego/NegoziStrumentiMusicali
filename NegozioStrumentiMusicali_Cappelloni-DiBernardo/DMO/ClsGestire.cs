using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioStrumentiMusicali
{
    public class ClsGestire
    {

        #region Attributi
        ClsNegozio _negozio;
        ClsAdminNegozio _admin;
        #endregion

        #region Proprietà
        public ClsNegozio Negozio { get => _negozio; set => _negozio = value; }
        public ClsAdminNegozio Admin { get => _admin; set => _admin = value; }
        #endregion

    }
}
