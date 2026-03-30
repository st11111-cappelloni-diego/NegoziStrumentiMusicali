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
    public class ClsNegozio
    {
        #region Attributi
        int _id;
        string _nome;
        bool _bandito;
        string _immagine;
        ClsIndirizzo _indirizzo;
        List<ClsOrdine> _ordini;
       
        #endregion

        #region Proprietà
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id < 0)
                {
                    throw new Exception("ID minore di 0");
                }
                else
                {
                    _id = value;
                }
            }
        }
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Nome non inserito");
                }
                else
                {
                    _nome = value;
                }
            }
        }
        public bool Bandito { get => _bandito; set => _bandito = value; }
        public string Immagine
        {
            get
            {
                return _immagine;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Immagine non inserita");
                }
                else
                {
                    _immagine = value;
                }
            }
        }
        public ClsIndirizzo Indirizzo { get => _indirizzo; set => _indirizzo = value; }
        public List<ClsOrdine> Ordini { get => _ordini; set => _ordini = value; }

        #endregion

        #region Costruttore
        public ClsNegozio()
        {

        }

        public ClsNegozio(int id)
        {
            Id = id;
        }

        #endregion
    }
}
