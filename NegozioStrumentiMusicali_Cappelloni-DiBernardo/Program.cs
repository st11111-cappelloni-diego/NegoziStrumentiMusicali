using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;

namespace NegozioStrumentiMusicali
{
    public static class Program
    {
        //ENUMERATORI
        public enum eLEGNO
        {
            abete = 0,
            acero,
            cedro,
            cipresso,
            ebano,
            faggio,
            frassino,
            koa,
            mogano,
            noce,
            palissandro,
            pioppo,
            salice
        }
        /// <summary>
        /// Serve solo per il funzionamento del software ed indica il tipo di specializzazione di ClsStrumentoMusicale. Non presente nel DB
        /// </summary>
        public enum eTIPO_STRUMENTO
        {
            Batteria = 0,
            Legno = 1,
            Ottone = 2,
            Pianoforte = 3,
            Strumento_a_corda = 4
        }

        /// <summary>
        /// Serve solo per il funzionamento del software. Non presente nel DB
        /// </summary>
        public enum eMODALITA_ENTRATA_DETAIL
        {
            Inserimento = 0,
            Modifica,
            Visualizzazione
        }

        //VARIABILI GLOBALI
        public static string _connectionString = "server=localhost;user=root;database=negozistrumentimusicali;port=3306;password=root;SslMode=None";
        public static MySqlConnection _connessioneAlDB = new MySqlConnection(_connectionString);

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
