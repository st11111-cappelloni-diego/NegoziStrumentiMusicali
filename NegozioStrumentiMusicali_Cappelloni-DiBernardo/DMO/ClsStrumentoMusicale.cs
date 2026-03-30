using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioStrumentiMusicali
{
    /// <summary>
    /// Sviluppata da Diego Cappelloni
    /// </summary>
    public class ClsStrumentoMusicale
    {
        #region Attributi
        private int _idArticolo;
        private int _quantita;
        private string _colori;
        private string _immagine;
        private decimal _prezzo;
        private string _modello;
        private ClsNotaMusicale _notaMinima;
        private ClsNotaMusicale _notaMassima;
        private float _pesoKG;
        private List<string> _altreCaratteristiche = new List<string>();

        #endregion

        #region Proprietà
        public int IDArticolo
        {
            get
            {
                return _idArticolo;
            }
            set
            {
                if(_idArticolo < 0)
                {
                    throw new Exception("ID Articolo minore di 0");
                }
                /*else if() //Oggetto con id inserito già presente nel negozio o oggetto con stessa casa produttrice, modello e colori già presente nel negozio
                {
                    throw new Exception("Articolo già esistente");
                }*/
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
                if(_quantita < 0)
                {
                    throw new Exception("Quantita è un numero negativo");
                }
                else
                {
                    _quantita = value;

                }
            }
        }
        public string Colori
        {
            get
            {
                return _colori;
            }
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Colori non inseriti");
                }
                else
                {
                    _colori = value;
                }
            }
        }
        public decimal Prezzo
        {
            get
            {
                return _prezzo;
            }
            set
            {
                if (_prezzo <= 0)
                {
                    throw new Exception("Prezzo minore o uguale a 0");
                }
                else
                {
                    _prezzo = value;
                }
            }

        }
        public string Modello
        {
            get
            {
                return _modello;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Modello non inserito");
                }
                else
                {
                    _modello = value;
                }
            }
        }
        public string Immagine { get => _immagine; set => _immagine = value; }
        public ClsNotaMusicale NotaMinima { get => _notaMinima; set => _notaMinima = value; }
        public ClsNotaMusicale NotaMassima { get => _notaMassima; set => _notaMassima = value; }
        public float PesoKG
        {
            get
            {
                return _pesoKG;
            }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Peso minore o uguale a 0");
                }
                else
                {
                    _pesoKG = value;
                }
            }
        }
        public List<string> AltreCaratteristiche { get => _altreCaratteristiche; set => _altreCaratteristiche = value; }


        #endregion

        #region Costruttore
        public ClsStrumentoMusicale()
        {

        }

        public ClsStrumentoMusicale(int idArticolo)
        {
            IDArticolo = idArticolo;
        }

        #endregion
    }
}
