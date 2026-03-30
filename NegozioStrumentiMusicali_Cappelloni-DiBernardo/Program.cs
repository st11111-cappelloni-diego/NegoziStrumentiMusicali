using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegozioStrumentiMusicali
{
    public static class Program
    {
        //ENUMERATORI
        public enum eLEGNO
        {
            Abete,
            Acero,
            Cedro,
            Cipresso,
            Ebano,
            Faggio,
            Frassino,
            Koa,
            Mogano,
            Noce,
            Palissandro,
            Pioppo,
            Salice
        }

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmHome());
        }
    }
}
