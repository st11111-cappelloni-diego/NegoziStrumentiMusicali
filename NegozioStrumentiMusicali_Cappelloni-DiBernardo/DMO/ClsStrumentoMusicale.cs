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
        private int _id;
        private string _colori;
        private string _immagine;
        private string _modello;
        private int _notaMinimaID;
        private int _notaMassimaID;
        private float _pesoKG;

        #endregion

        #region Proprietà
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if(_id < 0)
                {
                    throw new Exception("ID minore di 0");
                }
                else
                {
                    _id = value;
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
        public int NotaMinimaID { get => _notaMinimaID; set => _notaMinimaID = value; }
        public int NotaMassimaID { get => _notaMassimaID; set => _notaMassimaID = value; }
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


        #endregion

        #region Costruttore
        public ClsStrumentoMusicale()
        {

        }

        public ClsStrumentoMusicale(int id)
        {
            ID = id;
        }

        #endregion
    }
}
