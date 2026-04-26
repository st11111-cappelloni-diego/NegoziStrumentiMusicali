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
    public class ClsCaratteristica
    {
        #region Attributi
        private int _id;
        private string _titolo;
        private string _testo;
        private int _strumentoMusicaleID;

        #endregion

        #region Proprietà
        public int ID { get => _id; set => _id = value; }
        public string Titolo
        {
            get => _titolo;
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Titolo della caratteristica vuoto");
                }
                else
                {
                    _titolo = value;
                }
            }
        }
        public string Testo
        {
            get => _testo;
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Testo della caratteristica vuoto");
                }
                else
                {
                    _testo = value;
                }
            }
        }
        public int StrumentoMusicaleID { get => _strumentoMusicaleID; set => _strumentoMusicaleID = value; }

        #endregion

        #region Costruttore
        public ClsCaratteristica()
        {

        }

        public ClsCaratteristica(int id)
        {
            ID = id;
        }

        #endregion
    }
}
