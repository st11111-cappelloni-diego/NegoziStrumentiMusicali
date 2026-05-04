using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioStrumentiMusicali
{
    /// <summary>
    /// Sviluppata da Diego Cappelloni
    /// </summary>
    public static class ClsNotaMusicaleBL
    {
        /// <summary>
        /// Inserimento di un record in notemusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="notaMusicale">Oggetto da inserire</param>
        /// <param name="comunicazione">Stringa di comunicazione in uscita</param>
        /// <returns>ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertNotaMusicale(MySqlConnection connection, ClsNotaMusicale notaMusicale, out string comunicazione)
        {
            //VARIABILI
            long _ID = -1;
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando in DML
                string _dml =
                    "INSERT into notemusicali (notabase, alterazione, ottava) " +
                    "VALUES(@notabase, @alterazione, @ottava)";

                //Creo il command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@notabase", notaMusicale.NotaBase.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@alterazione", notaMusicale.Alterazione.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@ottava", notaMusicale.Ottava);

                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando è stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                comunicazione = "Nota musicale inserita con successo nel DataBase";
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

            return _ID;
        }
        /// <summary>
        /// Update di un record di notemusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="notaMusicale">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateNotaMusicale(ref MySqlConnection connection, ClsNotaMusicale notaMusicale, out string comunicazione)
        {
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml =
                    "UPDATE notemusicali " +
                    "SET notabase = @notabase, " +
                    "alterazione = @alterazione, " +
                    "ottava = @ottava, " +
                    "WHERE ID = @ID";

                //Creo il command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@notabase", notaMusicale.NotaBase.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@alterazione", notaMusicale.NotaBase.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@ottava", notaMusicale.Ottava);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Nota musicale aggiornata correttamente nel DataBase";
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
        /// <summary>
        /// Eliminazione di un record da notemusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="notamusicale">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void DeleteNotaMusicale(ref MySqlConnection connection, ClsNotaMusicale notamusicale, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml = "DELETE FROM notemusicali WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", notamusicale.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Nota musicale eliminata correttamente dal DataBase";
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
    }
}
