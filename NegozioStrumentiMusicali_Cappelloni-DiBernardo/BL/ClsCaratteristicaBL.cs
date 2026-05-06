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
    public static class ClsCaratteristicaBL
    {
        /// <summary>
        /// Inserimento di un record in caratteristiche
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="caratteristica">Record da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertCaratteristica(ref MySqlConnection connection, ClsCaratteristica caratteristica, out string comunicazione)
        {
            //VARIABILI LOCALI
            long _ID = -1;
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml =
                    "INSERT into caratteristiche (titolo, testo, strumentomusicaleID) " +
                    "VALUES(@titolo, @testo, @strumentomusicaleID)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@titolo", caratteristica.Titolo);
                _cmd.Parameters.AddWithValue("@testo", caratteristica.Testo);
                _cmd.Parameters.AddWithValue("@strumentomusicaleID", caratteristica.StrumentoMusicaleID);

                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando è stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                comunicazione = "Caratteristica inserita con successo nel DataBase";
            }
            catch(Exception ex)
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
        /// Update di un record in caratteristiche
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="caratteristica">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateCaratteristica(ref MySqlConnection connection, ClsCaratteristica caratteristica, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml =
                    "UPDATE caratteristiche " +
                    "SET titolo = @titolo, " +
                    "testo = @testo, " +
                    "strumentomusicaleID = @strumentomusicaleID " +
                    "WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@titolo", caratteristica.Titolo);
                _cmd.Parameters.AddWithValue("@testo", caratteristica.Testo);
                _cmd.Parameters.AddWithValue("@strumentomusicaleID", caratteristica.StrumentoMusicaleID);
                _cmd.Parameters.AddWithValue("@ID", caratteristica.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Caratteristica aggiornata correttamente nel DataBase";
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
        /// Eliminazione di un record da caratteristiche
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="caratteristica">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void DeleteCaratteristica(ref MySqlConnection connection, ClsCaratteristica caratteristica, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml = "DELETE FROM caratteristiche WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", caratteristica.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Caratteristica eliminata correttamente dal DataBase";
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
