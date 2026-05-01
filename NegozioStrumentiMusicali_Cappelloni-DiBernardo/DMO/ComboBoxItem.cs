using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioStrumentiMusicali
{
    /// <summary>
    /// Sviluppata da Diego Cappelloni. 
    /// C# non ha nativamente un ComboBoxItem, bensì accetta qualsiasi object. 
    /// Serve il ComboBoxItem creato dal programmatore per avere il tag, che è una comodità in più
    /// </summary>
    public class ComboBoxItem
    {
        #region Attributi
        private string _testo;
        private object _tag;


        #endregion

        #region Proprietà
        public string Testo { get => _testo; set => _testo = value; }
        public object Tag { get => _tag; set => _tag = value; }

        #endregion

        #region Costruttore
        public ComboBoxItem()
        {

        }

        public ComboBoxItem(string testo)
        {
            Testo = testo;
        }

        #endregion
    }
}
