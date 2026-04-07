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
    public class ClsCliente : ClsUtente
    {
        #region Attributi

        bool _bandito;

        #endregion

        #region Proprietà

        public bool Bandito { get => _bandito; set => _bandito = value; }

        #endregion

        #region Costruttore

        public ClsCliente()
        {
        }

        public ClsCliente(bool bandito)
        {
            Bandito = bandito;
        }

        //Costruttore ereditato dalla classe madre
        public ClsCliente(string username) : base(username)
        {

        }

        #endregion
    }
}
