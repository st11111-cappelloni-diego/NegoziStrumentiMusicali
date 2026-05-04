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
    public static class ClsBatteriaPiattoBL
    {
        /// <summary>
        /// Inserimento di un record in batteriapiatto
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="batteriaPiatto">Record da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertBatteriaPiatto(ref MySqlConnection connection, ClsBatteriaPiatto batteriaPiatto, out string comunicazione)
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
                    "INSERT into batteriapiatto (batteriaID, piattoID) " +
                    "VALUES(@batteriaID, @piattoID)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@batteriaID", batteriaPiatto.BatteriaID);
                _cmd.Parameters.AddWithValue("@piattoID", batteriaPiatto.PiattoID);

                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando è stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                comunicazione = "Relazione tra batteria e piatto inserita con successo nel DataBase";
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
        /// Update di un record di batteriapiatto
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="batteriaPiatto">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateBatteriaPiatto(ref MySqlConnection connection, ClsBatteriaPiatto batteriaPiatto, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml =
                    "UPDATE batteriapiatto " +
                    "SET batteriaID = @batteriaID, " +
                    "piattoID = @piattoID " +
                    "WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@batteriaID", batteriaPiatto.BatteriaID);
                _cmd.Parameters.AddWithValue("@piattoID", batteriaPiatto.PiattoID);
                _cmd.Parameters.AddWithValue("@ID", batteriaPiatto.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Relazione tra batteria e piatto aggiornata correttamente nel DataBase";
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
        /// Eliminazione di un record da batteriapiatto
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="batteriaPiatto">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void DeleteBatteriaPiatto(ref MySqlConnection connection, ClsBatteriaPiatto batteriaPiatto, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml =
                    "DELETE FROM batteriapiatto WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", batteriaPiatto.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Relazione tra batteria e piatto eliminata correttamente dal DataBase";
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
        /// Caricamento dei dati del DataReader ad un'istanza di ClsBatteriaPiatto
        /// </summary>
        /// <param name="dataReader"></param>
        /// <returns></returns>
        private static ClsBatteriaPiatto CaricaSingoloBatteriaPiatto(ref MySqlDataReader dataReader)
        {
            ClsBatteriaPiatto _batteriaPiatto = new ClsBatteriaPiatto();
            _batteriaPiatto.ID = Convert.ToInt64(dataReader["ID"]);
            _batteriaPiatto.BatteriaID = Convert.ToInt64(dataReader["batteriaID"]);
            _batteriaPiatto.PiattoID = Convert.ToInt64(dataReader["piattoID"]);

            return _batteriaPiatto;
        }
        /// <summary>
        /// Caricamento di tutti i record di batteriapiatto
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>La lista con tutti i record di batteriapiatto</returns>
        public static List<ClsBatteriaPiatto> GetAllBatteriaPiatto(ref MySqlConnection connection, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;
            List<ClsBatteriaPiatto> _listaBatteriaPiatto = new List<ClsBatteriaPiatto>();

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo la query
                string _query = "SELECT * FROM batteriapiatto";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, connection);

                //Eseguo il comando creando il DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if(_dataReader.HasRows) //Controllo se la tabella ha dei record
                {
                    while(_dataReader.Read()) //Se ce li ha la leggo tutta
                    {
                        //Carico i dati dal DB
                        _listaBatteriaPiatto.Add(CaricaSingoloBatteriaPiatto(ref _dataReader));
                    }
                }

                _dataReader.Close();

                comunicazione = "Relazioni tra batteria e piatto caricate correttamente dal DataBase";
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

            return _listaBatteriaPiatto;
        }
        /// <summary>
        /// Caricamento di alcuni record di batteriapiatto in base a batteriaID o piattoID.
        /// Escludi batteriaID passando come valore -1, escludi piattoID passando come valore -1
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="comunicazione"></param>
        /// <param name="batteriaID"></param>
        /// <param name="piattoID"></param>
        /// <returns></returns>
        public static List<ClsBatteriaPiatto> GetSomeBatteriaPiatto(ref MySqlConnection connection, out string comunicazione, long batteriaID = -1, long piattoID = -1)
        {
            //VARIABILI
            comunicazione = String.Empty;
            List<ClsBatteriaPiatto> _listaBatteriaPiatto = new List<ClsBatteriaPiatto>();

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo la query
                string _query = "SELECT * FROM batteriapiatto WHERE ";
                //Posso cercare per solo un campo alla volta perciò controllo in questo ordine: batteriaID, piattoID
                if(batteriaID > -1)
                {
                    //BatteriaID è il campo di ricerca
                    _query += "batteriaID = @batteriaID";

                }
                else
                {
                    //PiattoID è il campo di ricerca
                    _query += "piattoID = @piattoID";
                }

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, connection);

                //Inserisco i valori
                //Posso cercare per solo un campo alla volta perciò controllo in questo ordine: batteriaID, piattoID
                if (batteriaID > -1)
                {
                    //BatteriaID è il campo di ricerca
                    _cmd.Parameters.AddWithValue("@batteriaID", batteriaID);

                }
                else
                {
                    //PiattoID è il campo di ricerca
                    _cmd.Parameters.AddWithValue("@piattoID", piattoID);
                }

                //Eseguo il comando creando il DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if(_dataReader.HasRows) //Controllo se la tabella ha dei record
                {
                    while(_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        //Carico i dati dal DB
                        _listaBatteriaPiatto.Add(CaricaSingoloBatteriaPiatto(ref _dataReader));
                    }
                }

                _dataReader.Close();

                comunicazione = "Relazioni tra batteria e piatto caricate correttamente dal DataBase";
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

            return _listaBatteriaPiatto;
        }
    }
}
