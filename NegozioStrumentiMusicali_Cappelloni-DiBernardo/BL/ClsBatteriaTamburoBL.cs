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
    public static class ClsBatteriaTamburoBL
    {
        /// <summary>
        /// Inserimento di un record in batteriatamburo
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="batteriaTamburo">Record da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertBatteriaTamburo(ref MySqlConnection connection, ClsBatteriaTamburo batteriaTamburo, out string comunicazione)
        {
            //VARIABILI
            long _ID = -1;
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml =
                    "INSERT into batteriatamburo (batteriaID, tamburoID) " +
                    "VALUES(@batteriaID, @tamburoID)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@batteriaID", batteriaTamburo.BatteriaID);
                _cmd.Parameters.AddWithValue("@tamburoID", batteriaTamburo.TamburoID);

                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando è stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                comunicazione = "Relazione tra batteria e tamburo inserita con successo nel DataBase";
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
        /// Update di un record di batteriatamburo
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="batteriaTamburo">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateBatteriaTamburo(ref MySqlConnection connection, ClsBatteriaTamburo batteriaTamburo, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml =
                    "UPDATE batteriatamburo " +
                    "SET batteriaID = @batteriaID, " +
                    "piattoID = @tamburoID " +
                    "WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@batteriaID", batteriaTamburo.BatteriaID);
                _cmd.Parameters.AddWithValue("@tamburoID", batteriaTamburo.TamburoID);
                _cmd.Parameters.AddWithValue("@ID", batteriaTamburo.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Relazione tra batteria e tamburo aggiornata correttamente nel DataBase";
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
        /// Eliminazione di un record da batteriatamburo
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="batteriaTamburo">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void DeleteBatteriaTamburo(ref MySqlConnection connection, ClsBatteriaTamburo batteriaTamburo, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml =
                    "DELETE FROM batteriatamburo WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", batteriaTamburo.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Relazione tra batteria e tamburo eliminata correttamente dal DataBase";
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
        /// Caricamento di tutti i record di batteriatamburo 
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>La lista con tutti i record di batteriatamburo</returns>
        public static List<ClsBatteriaTamburo> GetAllBatteriaTamburo(ref MySqlConnection connection, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;
            List<ClsBatteriaTamburo> _listaBatteriaTamburo = new List<ClsBatteriaTamburo>();

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo la query
                string _query = "SELECT * FROM batteriatamburo";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, connection);

                //Eseguo il comando creando il DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if (_dataReader.HasRows) //Controllo se la tabella ha dei record
                {
                    while (_dataReader.Read()) //Se ce li ha la leggo tutta
                    {
                        //Carico i dati
                        ClsBatteriaTamburo _batteriaTamburo = new ClsBatteriaTamburo();
                        _batteriaTamburo.ID = (long)_dataReader["ID"];
                        _batteriaTamburo.BatteriaID = (long)_dataReader["batteriaID"];
                        _batteriaTamburo.TamburoID = (long)_dataReader["piattoID"];

                        _listaBatteriaTamburo.Add(_batteriaTamburo);
                    }
                }

                _dataReader.Close();

                comunicazione = "Relazioni tra batteria e tamburo caricate correttamente dal DataBase";
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

            return _listaBatteriaTamburo;
        }
    }
}

