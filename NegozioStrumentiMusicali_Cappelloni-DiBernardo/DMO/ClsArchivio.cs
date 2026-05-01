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

        #endregion

        #region Proprietà
        public static List<ClsNegozio> Negozi
        {
            get => _negozi;
            set
            {
                //TESTING
                value.Add(new ClsNegozio(0));
                value[value.Count - 1].Bandito = false;
                value[value.Count - 1].Nome = "NegozioTest";
                value[value.Count - 1].PathImmagine = null;
                value[value.Count - 1].IndirizzoID = 0;
            }
        }
        public static List<ClsNotaMusicale> NoteMusicali { get => _noteMusicali; set => _noteMusicali = value; }

        #endregion
    }
}
