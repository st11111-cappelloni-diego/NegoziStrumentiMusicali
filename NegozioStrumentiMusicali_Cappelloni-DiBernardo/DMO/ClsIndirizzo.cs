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
    public class ClsIndirizzo
    {
        #region Attributi
        string _comune;
        string _via;
        int _cap;
        string _nazione;

        
        #endregion

        #region Proprietà
        public string Comune
        {
            get
            {
                return _comune;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Comune non inserito");
                }
                else
                {
                    _comune = value;
                }
            }
        }
        public string Via
        {
            get
            {
                return _via;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Via non inserita");
                }
                else
                {
                    _via = value;
                }
            }
        }
        public int Cap
        {
            get => _cap;
            set
            {
                if(value < 0)
                {
                    throw new Exception("Il CAP non può essere un numero negativo");
                }
                else
                {
                    _cap = value;
                }
            }
        }
        public string Nazione
        {
            get
            {
                return _nazione;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Nazione non inserita");
                }
                else
                {
                    _nazione = value;
                }
            }
        }


        #endregion

        #region Costruttore
        public ClsIndirizzo()
        {

        }

        #endregion

    }
}
