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
    public static class ClsGestireBL
    {
        /// <summary>
        /// Inserimento di un record in gestire
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="gestire">Record da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>L'ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertGestire(ref MySqlConnection connection, ClsGestire gestire, out string comunicazione)
        {
            //VARIABILI 
            long _ID = -1;
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Creo il comando DML
                string _dml =
                    "INSERT into gestire " +
                    "(negozioID, utenteUsername)" +
                    "VALUES(@negozioID, @utenteUsername)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@quantita", gestire.NegozioID);
                _cmd.Parameters.AddWithValue("@prezzo", gestire.UtenteUsername);

                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando è stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                comunicazione = "Relazione di tipo gestire inserita con successo nel DataBase";
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
        /// Update di un record di gestire
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="gestire">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateGestire(ref MySqlConnection connection, ClsGestire gestire, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando dml
                string _dml =
                   "UPDATE gestire SET " +
                    "negozioID = @negozioID, " +
                    "utenteUsername = @utenteUsername " +
                    "WHERE ID = @ID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@negozioID", gestire.NegozioID);
                _cmd.Parameters.AddWithValue("@utenteUsername", gestire.UtenteUsername);
                _cmd.Parameters.AddWithValue("@ID", gestire.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Relazione di tipo gestire aggiornata correttamente nel DataBase";
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
