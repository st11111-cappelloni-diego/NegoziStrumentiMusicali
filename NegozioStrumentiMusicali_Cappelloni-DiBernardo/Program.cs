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
            abete,
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
            Application.Run(new FrmHome());
        }
    }
}
