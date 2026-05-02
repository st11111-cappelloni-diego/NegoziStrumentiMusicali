using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace NegozioStrumentiMusicali
{
    /// <summary>
    /// Sviluppata da Diego Cappelloni
    /// </summary>
    public static class ClsPiattoBL
    {
        /// <summary>
        /// Inserimento di un record in piatti
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="piatto">Record da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertPiatto(ref MySqlConnection connection, ClsPiatto piatto, out string comunicazione)
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
                    "INSERT into piatti (tipo, diametroin, materiale) " +
                    "VALUES(@tipo, @diametroin, @materiale)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@tipo", piatto.Tipo.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@diametroin", piatto.DiametroIN);
                _cmd.Parameters.AddWithValue("@materiale", piatto.Materiale.ToString().ToLower());

                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando è stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                comunicazione = "Piatto inserito con successo nel DataBase";
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
        /// Update di un record in piatti
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="piatto">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdatePiatto(ref MySqlConnection connection, ClsPiatto piatto, out string comunicazione)
        {
            //VARIABILI GLOBALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml =
                    "UPDATE piatti " +
                    "SET tipo = @tipo, " +
                    "diametroin = @diametroin, " +
                    "materiale = @materiale " +
                    "WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@tipo", piatto.Tipo.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@diametroin", piatto.DiametroIN);
                _cmd.Parameters.AddWithValue("@materiale", piatto.Materiale.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@ID", piatto.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Piatto aggiornato correttamente nel DataBase";
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
        }
        /// <summary>
        /// Eliminazione di un record da piatti
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="piatto">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void DeleteTamburo(ref MySqlConnection connection, ClsPiatto piatto, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml = "DELETE FROM piatti WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", piatto.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Piatto eliminato correttamente dal DataBase";
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
        public static List<ClsPiatto> SelectAllPiatti(ref MySqlConnection connection, out string comunicazione)
        {
            //VARIABILI
            DataTable _dataTable = new DataTable();
            List<ClsPiatto> _piatti = new List<ClsPiatto>();
            comunicazione = String.Empty;
        }
    }
}
