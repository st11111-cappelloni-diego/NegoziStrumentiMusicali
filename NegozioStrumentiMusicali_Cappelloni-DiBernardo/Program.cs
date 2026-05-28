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
        public static string[] _nazioni = new[]
        {
            "Afghanistan", "Albania", "Algeria", "Andorra", "Angola",
            "Antigua e Barbuda", "Arabia Saudita", "Argentina", "Armenia", "Australia",
            "Austria", "Azerbaigian", "Bahamas", "Bahrein", "Bangladesh",
            "Barbados", "Belgio", "Belize", "Benin", "Bhutan",
            "Bielorussia", "Bolivia", "Bosnia ed Erzegovina", "Botswana", "Brasile",
            "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cambogia",
            "Camerun", "Canada", "Capo Verde", "Ciad", "Cile",
            "Cina", "Cipro", "Colombia", "Comore", "Corea del Nord",
            "Corea del Sud", "Costa d'Avorio", "Costa Rica", "Croazia", "Cuba",
            "Danimarca", "Dominica", "Ecuador", "Egitto", "El Salvador",
            "Emirati Arabi Uniti", "Eritrea", "Estonia", "Eswatini", "Etiopia",
            "Figi", "Filippine", "Finlandia", "Francia", "Gabon",
            "Gambia", "Georgia", "Germania", "Ghana", "Giamaica",
            "Giappone", "Gibuti", "Giordania", "Grecia", "Grenada",
            "Guatemala", "Guinea", "Guinea-Bissau", "Guinea Equatoriale", "Guyana",
            "Haiti", "Honduras", "India", "Indonesia", "Iran",
            "Iraq", "Irlanda", "Islanda", "Isole Marshall", "Isole Salomone",
            "Israele", "Italia", "Kazakistan", "Kenya", "Kiribati",
            "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Lesotho",
            "Lettonia", "Libano", "Liberia", "Libia", "Liechtenstein",
            "Lituania", "Lussemburgo", "Madagascar", "Malawi", "Maldive",
            "Malesia", "Mali", "Malta", "Marocco", "Mauritania",
            "Mauritius", "Messico", "Micronesia", "Moldavia", "Monaco",
            "Mongolia", "Montenegro", "Mozambico", "Myanmar", "Namibia",
            "Nauru", "Nepal", "Nicaragua", "Niger", "Nigeria",
            "Norvegia", "Nuova Zelanda", "Oman", "Paesi Bassi", "Pakistan",
            "Palau", "Palestina", "Panama", "Papua Nuova Guinea", "Paraguay",
            "Perù", "Polonia", "Portogallo", "Qatar", "Regno Unito",
            "Repubblica Centrafricana", "Repubblica Ceca", "Repubblica Democratica del Congo",
            "Repubblica Dominicana", "Romania", "Ruanda", "Russia", "Saint Kitts e Nevis",
            "Saint Lucia", "Saint Vincent e Grenadine", "Samoa", "San Marino", "Santa Sede",
            "São Tomé e Príncipe", "Senegal", "Serbia", "Seychelles", "Sierra Leone",
            "Singapore", "Siria", "Slovacchia", "Slovenia", "Somalia",
            "Spagna", "Sri Lanka", "Stati Uniti d'America", "Sudafrica", "Sudan",
            "Sudan del Sud", "Suriname", "Svezia", "Svizzera", "Sahara Occidentale",
            "Tagikistan", "Taiwan", "Tanzania", "Thailandia", "Timor Est",
            "Togo", "Tonga", "Trinidad e Tobago", "Tunisia", "Turchia",
            "Turkmenistan", "Tuvalu", "Ucraina", "Uganda", "Ungheria",
            "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam",
            "Yemen", "Zambia", "Zimbabwe"
        };


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
