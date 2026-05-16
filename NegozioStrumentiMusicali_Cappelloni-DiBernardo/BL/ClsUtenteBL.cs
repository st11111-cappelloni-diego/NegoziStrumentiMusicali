using System;
using System.Collections.Generic;
using System.Linq;
using MySqlConnector;
using System.Text;
using System.Threading.Tasks;

namespace NegozioStrumentiMusicali
{
    /// <summary>
    /// Sviluppata da Leonardo Di Bernardo
    /// </summary>
    public static class ClsUtenteBL
    {
        /// <summary>
        /// Inserimento di record in utenti
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="utente">Record da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static bool InsertUtente(ref MySqlConnection connection, ClsUtente utente, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;
            bool _buonFine = true;

            try
            {
                //Apro la connessione
                connection.Open();

                //Creo il comando DML
                string _dml =
                    "INSERT into utenti " +
                    "(username, password, nome, cognome, email, datadinascita, genere, pathimmagine, adminsoftware, adminnegozio, bandito)" +
                    "VALUES(@username, SHA2(@password, 256), @nome, @cognome, @email, @datadinascita, @genere, @pathimmagine, @adminsoftware, @adminnegozio, @bandito)";
                //Password criptata con algoritmo SHA2

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@username", utente.Username);
                _cmd.Parameters.AddWithValue("@password", utente.Password);
                _cmd.Parameters.AddWithValue("@nome", utente.Nome);
                _cmd.Parameters.AddWithValue("@cognome", utente.Cognome);
                _cmd.Parameters.AddWithValue("@email", utente.Email);
                _cmd.Parameters.AddWithValue("@datadinascita", utente.DataDiNascita);
                _cmd.Parameters.AddWithValue("@genere", utente.Genere.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@pathimmagine", utente.PathImmagine);
                _cmd.Parameters.AddWithValue("@adminsoftware", utente.AdminSoftware);
                _cmd.Parameters.AddWithValue("@adminnegozio", utente.AdminNegozio);
                _cmd.Parameters.AddWithValue("@bandito", utente.Bandito);


                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Utente inserito con successo nel DataBase";
            }
            catch (Exception ex)
            {
                comunicazione = ex.Message;
                _buonFine = false;
            }
            finally
            {
                //Chiudo la connessione
                connection.Close();
            }
            return _buonFine;
        }
        /// <summary>
        /// Update di record in utenti
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="utente">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateUtente(ref MySqlConnection connection, ClsUtente utente, bool criptarePassword ,out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando dml
                string _dml =
                    "UPDATE utenti SET " +
                    "nome = @nome, " +
                    "cognome = @cognome, " +
                    "email = @email, " +
                    "dataDiNascita = @dataDiNascita, " +
                    "genere = @genere, " +
                    "pathImmagine = @pathImmagine, " +
                    "adminSoftware = @adminSoftware, " +
                    "adminNegozio = @adminNegozio, " +
                    "bandito = @bandito, ";

                if(criptarePassword)
                {
                    _dml += "password = SHA2(@password, 256) ";
                }
                else
                {
                    _dml += "password = @password ";
                }

                _dml += "WHERE username = @username";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@username", utente.Username);
                _cmd.Parameters.AddWithValue("@password", utente.Password);
                _cmd.Parameters.AddWithValue("@nome", utente.Nome);
                _cmd.Parameters.AddWithValue("@cognome", utente.Cognome);
                _cmd.Parameters.AddWithValue("@email", utente.Email);
                _cmd.Parameters.AddWithValue("@dataDiNascita", utente.DataDiNascita);
                _cmd.Parameters.AddWithValue("@genere", utente.Genere);
                _cmd.Parameters.AddWithValue("@pathImmagine", utente.PathImmagine);
                _cmd.Parameters.AddWithValue("@adminSoftware", utente.AdminSoftware);
                _cmd.Parameters.AddWithValue("@adminNegozio", utente.AdminNegozio);
                _cmd.Parameters.AddWithValue("@bandito", utente.Bandito);


                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Utente aggiornato correttamente nel DataBase";
            }
            catch (Exception ex)
            {
                comunicazione = ex.Message;
            }
            finally
            {
                //Chiudo la connessione
                connection.Close();
            }
        }

        public static ClsUtente GetOneUtente(ref MySqlConnection connection, string username, out string comunicazione)
        {
            //VARIABILI GLOBALI
            comunicazione = String.Empty;
            ClsUtente _utente = null;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo la query
                string _query = "SELECT * FROM utenti WHERE username = @username";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, connection);

                //Inserisco il valore
                _cmd.Parameters.AddWithValue("@username", username);

                //Eseguo il comando creando il DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if (_dataReader.HasRows) //Controllo se la tabella ha dei record
                {
                    _utente = new ClsUtente();
                    while (_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        _utente = CaricaSingoloUtente(ref _dataReader);
                    }
                }

                _dataReader.Close();

                comunicazione = "Utemte caricato correttamente dal DataBase";
            }
            catch (Exception ex)
            {
                comunicazione = ex.Message;
                _utente = null;
            }
            finally
            {
                //Chiudo la connessione
                connection.Close();
            }

            return _utente;
        }

        private static ClsUtente CaricaSingoloUtente(ref MySqlDataReader dataReader)
        {
            ClsUtente _casaProduttrice = new ClsUtente();
            _casaProduttrice.Username = dataReader["username"].ToString();
            _casaProduttrice.Password = dataReader["password"].ToString();
            _casaProduttrice.Nome = dataReader["nome"].ToString();
            _casaProduttrice.Cognome = dataReader["cognome"].ToString();
            _casaProduttrice.Email = dataReader["email"].ToString();
            _casaProduttrice.DataDiNascita = Convert.ToDateTime(dataReader["datadinascita"]);
            _casaProduttrice.Genere = (ClsUtente.eGENERE)Enum.Parse(typeof(ClsUtente.eGENERE),dataReader["genere"].ToString());
            _casaProduttrice.PathImmagine = dataReader["pathImmagine"].ToString();
            _casaProduttrice.AdminNegozio = Convert.ToBoolean(dataReader["adminnegozio"].ToString());
            _casaProduttrice.AdminSoftware = Convert.ToBoolean(dataReader["adminsoftware"].ToString());
            _casaProduttrice.Bandito = Convert.ToBoolean(dataReader["bandito"].ToString());

            return _casaProduttrice;
        }
    /// <summary>
    /// Caricamento di tutti i record di utenti
    /// </summary>
    /// <param name="connection">Connessione al DB</param>
    /// <param name="comunicazione">Comunicazione in uscita</param>
    /// <returns>La lista di tutti i record di strumentimusicali</returns>
    public static List<ClsUtente> GetAllUtenti(string stringaDiConnessione, out string comunicazione)
    {
        //VARIABILI
        List<ClsUtente> _listUtenti = new List<ClsUtente>();
            comunicazione = String.Empty;
            MySqlConnection _connection = new MySqlConnection(stringaDiConnessione);

        try
        {
            //Apro la connessione
            _connection.Open();

            //Compongo la query
            string _query = "SELECT * FROM utenti";

            //Creo l'oggetto command
            MySqlCommand _cmd = new MySqlCommand(_query, _connection);

            //Eseguo il comando creando l'oggetto DataReader
            MySqlDataReader _dataReader = _cmd.ExecuteReader();

            if (_dataReader.HasRows) //Controllo se la tabella contiene dei record
            {
                while (_dataReader.Read()) //Se ce li ha li leggo tutti
                {
                    //Carico i dati dal DB
                    //_strumentiMusicali.Add(CaricaSingoloStrumento(ref _dataReader));
                }
            }

            _dataReader.Close();

            comunicazione = "Utenti caricati correttamente dal DataBase";
        }
        catch (Exception ex)
        {
            comunicazione = ex.Message;
        }
        finally
        {
            //Chiudo la connessione
            _connection.Close();
        }

        return _listUtenti;
    }

}
}
