using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioStrumentiMusicali
{
    public static class ClsArchivio
    {
        #region Attributi
        static private List<ClsNegozio> _negozi = new List<ClsNegozio>();
        static private List<ClsNotaMusicale> _noteMusicali = new List<ClsNotaMusicale>();
        static private List<ClsCasaProduttrice> _caseProduttrici = new List<ClsCasaProduttrice>();
        static private List<ClsVendere> _vendere = new List<ClsVendere>();
        static private List<ClsStrumentoMusicale> _strumentiMusicali = new List<ClsStrumentoMusicale>();
        static private List<ClsUtente> _utenti = new List<ClsUtente>();
        static private ClsUtente _utenteAttuale = new ClsUtente();
        static private List<ClsPiatto> _piatti = new List<ClsPiatto>();
        static private List<ClsTamburo> _tamburi = new List<ClsTamburo>();
        static private List<ClsBatteriaPiatto> _batteriaPiatto = new List<ClsBatteriaPiatto>();
        static private List<ClsBatteriaTamburo> _batteriaTamburo = new List<ClsBatteriaTamburo>();
        static private List<ClsOrdine> _ordini = new List<ClsOrdine>();
        static private List<ClsGestire> _gestire = new List<ClsGestire>();
        static private List<ClsIndirizzo> _indirizzi = new List<ClsIndirizzo>();


        #endregion

        #region Proprietà
        public static List<ClsNegozio> Negozi
        {
            get => _negozi;
            set
            {
                _negozi = value;
            }
        }
        public static List<ClsNotaMusicale> NoteMusicali { get => _noteMusicali; set => _noteMusicali = value; }
        public static List<ClsCasaProduttrice> CaseProduttrici { get => _caseProduttrici; set => _caseProduttrici = value; }
        public static List<ClsVendere> Vendere { get => _vendere; set => _vendere = value; }
        public static List<ClsStrumentoMusicale> StrumentiMusicali { get => _strumentiMusicali; set => _strumentiMusicali = value; }
        public static List<ClsUtente> Utenti { get => _utenti; set => _utenti = value; }
        public static ClsUtente UtenteAttuale { get => _utenteAttuale; set => _utenteAttuale = value; }
        public static List<ClsPiatto> Piatti { get => _piatti; set => _piatti = value; }
        public static List<ClsTamburo> Tamburi { get => _tamburi; set => _tamburi = value; }
        public static List<ClsBatteriaPiatto> BatteriaPiatto { get => _batteriaPiatto; set => _batteriaPiatto = value; }
        public static List<ClsBatteriaTamburo> BatteriaTamburo { get => _batteriaTamburo; set => _batteriaTamburo = value; }
        public static List<ClsOrdine> Ordini { get => _ordini; set => _ordini = value; }
        public static List<ClsGestire> Gestire { get => _gestire; set => _gestire = value; }
        public static List<ClsIndirizzo> Indirizzi { get => _indirizzi; set => _indirizzi = value; }

        #endregion
    }
}
