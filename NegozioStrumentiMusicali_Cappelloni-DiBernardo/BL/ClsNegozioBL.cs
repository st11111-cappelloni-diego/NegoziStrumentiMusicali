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
    public static class ClsNegozioBL
    {
        /// <summary>
        /// Inserimento di un record in negozi
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="negozio">Record da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertNegozio(ref MySqlConnection connection, ClsNegozio negozio, out string comunicazione)
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
                    "INSERT into negozi " +
                    "(nome, bandito, pathimmagine, sito, telefono, email, indirizzoID)" +
                    "VALUES(@nome, @bandito, @pathimmagine, @sito, @telefono, @email, @indirizzoID)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@nome", negozio.Nome);
                _cmd.Parameters.AddWithValue("@bandito", negozio.Bandito);
                _cmd.Parameters.AddWithValue("@pathimmagine", negozio.PathImmagine);
                _cmd.Parameters.AddWithValue("@telefono", negozio.Telefono);
                _cmd.Parameters.AddWithValue("@email", negozio.Email);
                _cmd.Parameters.AddWithValue("@indirizzoID", negozio.IndirizzoID);
                _cmd.Parameters.AddWithValue("@sito", negozio.Sito);


                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando è stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                comunicazione = "Negozio inserito con successo nel DataBase";
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
        /// Update di un record di negozi
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="negozio">Dati record da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateNegozio(ref MySqlConnection connection, ClsNegozio negozio, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando dml
                string _dml =
                    "UPDATE negozi " +
                    "SET nome = @nome, " +
                    "bandito = @bandito, " +
                    "pathimmagine = @pathimmagine, " +
                    "sito = @sito, " +
                    "email = @email, " +
                    "telefono = @telefono, " +
                    "indirizzoID = @indirizzoID " +
                    "WHERE ID = @ID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@nome", negozio.Nome);
                _cmd.Parameters.AddWithValue("@bandito", negozio.Bandito);
                _cmd.Parameters.AddWithValue("@pathimmagine", negozio.PathImmagine);
                _cmd.Parameters.AddWithValue("@sito", negozio.Sito);
                _cmd.Parameters.AddWithValue("@indirizzoID", negozio.IndirizzoID);
                _cmd.Parameters.AddWithValue("@ID", negozio.ID);
                _cmd.Parameters.AddWithValue("@telefono", negozio.Telefono);
                _cmd.Parameters.AddWithValue("@email", negozio.Email);


                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Negozio aggiornato correttamente nel DataBase";
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
        public static List<ClsNegozio> GetAllNegozi(ref MySqlConnection connection, bool ordinaPerPiuRecente, out string comunicazione, int limiteRecord = 0)
        {
            //VARIABILI
            comunicazione = String.Empty;
            List<ClsNegozio> _negozi = new List<ClsNegozio>();
        }
    }
}
