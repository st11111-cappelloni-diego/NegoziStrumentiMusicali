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
    public class ClsOrdine
    {
        #region Attributi
        int _idOrdine;
        int _idArticolo;
        int _quantita;
        DateTime _data;
        ClsIndirizzo _indirizzo;
        ClsCliente _cliente;

        #endregion

        #region Proprietà
        public int IDOrdine
        {
            get
            {
                return _idOrdine;
            }
            set
            {
                if (_idOrdine < 0)
                {
                    throw new Exception("ID Ordine minore di 0");
                }
                else
                {
                    _idOrdine = value;
                }
            }
        }
        public int IDArticolo
        {
            get
            {
                return _idArticolo;
            }
            set
            {
                if (_idArticolo < 0)
                {
                    throw new Exception("ID Articolo minore di 0");
                }
                else
                {
                    _idArticolo = value;
                }
            }
        }
        public int Quantita
        {
            get
            {
                return _quantita;
            }
            set
            {
                if (_quantita < 0)
                {
                    throw new Exception("Quantità minore di 0");
                }
                else
                {
                    _quantita = value;
                }
            }
        }
        public DateTime Data { get => _data; set => _data = value; }

        public ClsIndirizzo Indirizzo { get => _indirizzo; set => _indirizzo = value; }
        public ClsCliente Cliente { get => _cliente; set => _cliente = value; }

        #endregion

        #region Costruttore
        public ClsOrdine()
        {

        }

        public ClsOrdine(int idOrdine)
        {
            IDOrdine = idOrdine;
        }
        #endregion
    }
}
