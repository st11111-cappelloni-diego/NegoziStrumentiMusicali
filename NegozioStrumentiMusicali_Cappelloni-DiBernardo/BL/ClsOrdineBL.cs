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
    public static class ClsOrdineBL
    {
        /// <summary>
        /// Inserimento di record in ordini
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="ordine">Record da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertOrdine(ref MySqlConnection connection, ClsOrdine ordine, out string comunicazione)
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
                    "INSERT into ordini " +
                    "(quantita, dataora, indirizzoID, negozioID, strumentoMusicaleID, utenteUsername)" +
                    "VALUES(@quantita, @dataora, @indirizzoID, @negozioID, @strumentoMusicaleID, @utenteUsername)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@quantita", ordine.Quantita);
                _cmd.Parameters.AddWithValue("@dataora", ordine.DataOra);
                _cmd.Parameters.AddWithValue("@indirizzoID", ordine.IndirizzoID);
                _cmd.Parameters.AddWithValue("@negozioID", ordine.NegozioID);
                _cmd.Parameters.AddWithValue("@strumentoMusicaleID", ordine.StrumentoMusicaleID);
                _cmd.Parameters.AddWithValue("@utenteUsername", ordine.UsernameCliente);


                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando è stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                comunicazione = "Ordine inserito con successo nel DataBase";
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
        /// Update di record di ordini
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="ordine">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateOrdine(ref MySqlConnection connection, ClsOrdine ordine, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando dml
                string _dml =
                    "UPDATE ordini SET " +
                    "quantita = @quantita, " +
                    "dataora = @dataora, " +
                    "indirizzoID = @indirizzoID, " +
                    "negozioID = @negozioID, " +
                    "strumentoMusicaleID = @strumentoMusicaleID, " +
                    "utenteUsername = @utenteUsername " +
                    "WHERE ID = @ID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@quantita", ordine.Quantita);
                _cmd.Parameters.AddWithValue("@dataora", ordine.DataOra);
                _cmd.Parameters.AddWithValue("@indirizzoID", ordine.IndirizzoID);
                _cmd.Parameters.AddWithValue("@negozioID", ordine.NegozioID);
                _cmd.Parameters.AddWithValue("@strumentoMusicaleID", ordine.StrumentoMusicaleID);
                _cmd.Parameters.AddWithValue("@utenteUsername", ordine.UsernameCliente);
                _cmd.Parameters.AddWithValue("@ID", ordine.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Ordine aggiornato correttamente nel DataBase";
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
        /// Eliminazione di un record da strumentimusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="ordine">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        
        public static void DeleteOrdine(ref MySqlConnection connection, ClsOrdine ordine, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml = "DELETE FROM ordini WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", ordine.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Ordine eliminato correttamente dal DataBase";
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
}
