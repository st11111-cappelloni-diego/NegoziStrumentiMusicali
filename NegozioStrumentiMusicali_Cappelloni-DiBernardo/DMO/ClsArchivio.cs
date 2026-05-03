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

        #endregion
    }
}
