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
    public class ClsBatteria : ClsStrumentoMusicale
    {
        #region Costruttore
        public ClsBatteria()
        {

        }
        //Costruttore ereditato dalla classe madre
        public ClsBatteria(int id) : base(id)
        {

        }

        #endregion

    }
}
