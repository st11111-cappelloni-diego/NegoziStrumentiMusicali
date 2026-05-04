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
        private long _id;
        private string _comune;
        private string _via;
        private string _codicePostale;
        private string _nazione;
        private ushort _numeroCivico;
        private char _letteraCivico;
        private bool _essereSede;
        private long _casaProduttriceID;

        #endregion

        #region Proprietà
        public long ID { get => _id; set => _id = value; }
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
        public string CodicePostale
        {
            get => _codicePostale;
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Codice postale non inserito");
                }
                else
                {
                    _codicePostale = value;
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

        public bool EssereSede { get => _essereSede; set => _essereSede = value; }
        public long CasaProduttriceID { get => _casaProduttriceID; set => _casaProduttriceID = value; }
        public ushort NumeroCivico { get => _numeroCivico; set => _numeroCivico = value; }
        public char LetteraCivico { get => _letteraCivico; set => _letteraCivico = value; }


        #endregion

        #region Costruttore
        public ClsIndirizzo()
        {

        }

        public ClsIndirizzo(long id)
        {
            ID = id;
        }

        #endregion

    }
}
