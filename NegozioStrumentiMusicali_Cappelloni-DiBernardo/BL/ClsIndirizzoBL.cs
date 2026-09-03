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
    public static class ClsIndirizzoBL
    {
        /// <summary>
        /// Inserimento di un record in indirizzi
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="indirizzo">Record da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertIndirizzo(string stringaDiConnessione, ClsIndirizzo indirizzo, out string comunicazione)
        {
            //VARIABILI 
            long _ID = -1;
            comunicazione = String.Empty;
            MySqlConnection connection = new MySqlConnection(stringaDiConnessione);

            try
            {
                //Apro la connessione
                connection.Open();

                //Creo il comando DML
                string _dml =
                    "INSERT into indirizzi " +
                    "(codicepostale, comune, via, nazione, numerocivico, letteracivico, essereSede, casaProduttriceID)" +
                    "VALUES(@codicepostale, @comune, @via, @nazione, @numerocivico, @letteracivico, @essereSede, @casaProduttriceID)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@codicepostale", indirizzo.CodicePostale);
                _cmd.Parameters.AddWithValue("@comune", indirizzo.Comune);
                _cmd.Parameters.AddWithValue("@via", indirizzo.Via);
                _cmd.Parameters.AddWithValue("@nazione", indirizzo.Nazione);
                _cmd.Parameters.AddWithValue("@essereSede", indirizzo.EssereSede);
                if(indirizzo.CasaProduttriceID <= -1)
                {
                    _cmd.Parameters.AddWithValue("@casaProduttriceID", DBNull.Value);
                }
                else
                {
                    _cmd.Parameters.AddWithValue("@casaProduttriceID", indirizzo.CasaProduttriceID);
                }
                _cmd.Parameters.AddWithValue("@numerocivico", indirizzo.NumeroCivico);
                _cmd.Parameters.AddWithValue("@letteracivico", indirizzo.LetteraCivico);


                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando è stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                comunicazione = "Indirizzo inserito con successo nel DataBase";

            }
            catch (Exception ex)
            {
                comunicazione = ex.Message;
                _ID = -1;
            }
            finally
            {
                //Chiudo la connessione
                connection.Close();
            }

            return _ID;
        }
        /// <summary>
        /// Update di un record di indirizzi
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="indirizzo">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateIndirizzo(ref MySqlConnection connection, ClsIndirizzo indirizzo, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando dml
                string _dml =
                    "UPDATE indirizzi SET " +
                    "codicepostale = @codicepostale, " +
                    "comune = @comune, " +
                    "numerocivico = @numerocivico, " +
                    "letteracivico = @letteracivico, " +
                    "via = @via, " +
                    "nazione = @nazione, " +
                    "essereSede = @essereSede, " +
                    "casaProdruttriceID = @casaProdruttriceID " +
                    "WHERE ID = @ID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@codicepostale", indirizzo.CodicePostale);
                _cmd.Parameters.AddWithValue("@comune", indirizzo.Comune);
                _cmd.Parameters.AddWithValue("@via", indirizzo.Via);
                _cmd.Parameters.AddWithValue("@nazione", indirizzo.Nazione);
                _cmd.Parameters.AddWithValue("@essereSede", indirizzo.EssereSede);
                if(indirizzo.CasaProduttriceID <= -1)
                {
                    _cmd.Parameters.AddWithValue("@casaproduttriceID", null);
                }
                else
                {
                    _cmd.Parameters.AddWithValue("@casaproduttriceID", indirizzo.CasaProduttriceID);
                }
                _cmd.Parameters.AddWithValue("@ID", indirizzo.ID);
                _cmd.Parameters.AddWithValue("@numerocivico", indirizzo.NumeroCivico);
                _cmd.Parameters.AddWithValue("@letteracivico", indirizzo.LetteraCivico);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Indirizzo aggiornato correttamente nel DataBase";
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
        /// Eliminazione di un record da indirizzi
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="indirizzi">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void DeleteIndirizzo(ref MySqlConnection connection, ClsIndirizzo indirizzo, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml = "DELETE FROM indirizzi WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", indirizzo.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Indirizzo eliminato correttamente dal DataBase";
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
        /// Caricamento di tutti i record di indirizzi
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>La lista di tutti i record di indirizzi</returns>
        public static List<ClsIndirizzo> GetAllIndirizzi(ref MySqlConnection connection, out string comunicazione)
        {
            //VARIABILI
            List<ClsIndirizzo> _indirizzi = new List<ClsIndirizzo>();
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo la query
                string _query = "SELECT * FROM indirizzi";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, connection);

                //Eseguo il comando creando l'oggetto DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if (_dataReader.HasRows) //Controllo se la tabella contiene dei record
                {
                    while (_dataReader.Read()) //Se ce li ha li leggo tutti
                    {
                        //Carico i dati dal DB
                        ClsIndirizzo _indirizzo = new ClsIndirizzo();

                        _indirizzo = CaricaSingoloIndirizzo(ref _dataReader);
                        
                        _indirizzi.Add(_indirizzo);
                    }
                }

                _dataReader.Close();

                comunicazione = "Indirizzi caricati correttamente dal DataBase";
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

            return _indirizzi;
        }

        /// <summary>
        /// Prende un record da indirizzi in base alla chiave primaria ID
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="ID"></param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>Il record ottenuto. Se è null la query non è andata a buon fine</returns>
        public static ClsIndirizzo GetOneIndirizzo(ref MySqlConnection connection, long ID, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;
            ClsIndirizzo _indirizzo = new ClsIndirizzo();

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo la query
                string _query = "SELECT * FROM indirizzi WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", ID);

                //Eseguo il comando creando il DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if (_dataReader.HasRows) //Controllo se la tabella ha dei record
                {
                    while (_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        _indirizzo = CaricaSingoloIndirizzo(ref _dataReader);
                    }
                }

                _dataReader.Close();

                comunicazione = "Strumento musicale caricato correttamente dal DataBase";
            }
            catch (Exception ex)
            {
                comunicazione = ex.Message;
                _indirizzo = null;
            }
            finally
            {
                //Chiudo la connessione
                connection.Close();
            }

            return _indirizzo;  
        }
        public static ClsIndirizzo GetOneIndirizzo(string stringaDiConnessione, string codicePostale,
            string comune, string via, ushort numeroCivico, char? letteraCivico, string nazione, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;
            ClsIndirizzo _indirizzo = null;
            MySqlConnection _connection = new MySqlConnection(stringaDiConnessione);

            try
            {
                //Apro la connessione
                _connection.Open();

                //Compongo la query
                string _query = "SELECT * FROM indirizzi WHERE " +
                    "codicepostale = @codicepostale AND " +
                    "comune = @comune AND " +
                    "via = @via AND " +
                    "numerocivico = @numerocivico AND (" +
                    "letteracivico = @letteracivico OR (letteracivico IS NULL AND @letteracivico IS NULL)) AND " +
                    "nazione = @nazione";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, _connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@codicepostale", codicePostale);
                _cmd.Parameters.AddWithValue("@comune", comune);
                _cmd.Parameters.AddWithValue("@via", via);
                _cmd.Parameters.AddWithValue("@nazione", nazione); 
                _cmd.Parameters.AddWithValue("@numerocivico", numeroCivico);
                _cmd.Parameters.AddWithValue("@letteracivico", letteraCivico);



                //Eseguo il comando creando il DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if (_dataReader.HasRows) //Controllo se la tabella ha dei record
                {
                    while (_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        _indirizzo = CaricaSingoloIndirizzo(ref _dataReader);
                    }
                }

                _dataReader.Close();

                comunicazione = "Indirizzo caricato correttamente dal DataBase";
            }
            catch (Exception ex)
            {
                comunicazione = ex.Message;
                _indirizzo = null;
            }
            finally
            {
                //Chiudo la connessione
                _connection.Close();
            }

            return _indirizzo;
        }

        public static ClsIndirizzo CaricaSingoloIndirizzo(ref MySqlDataReader dataReader)
        {
            ClsIndirizzo _indirizzo = new ClsIndirizzo();

            _indirizzo.ID = Convert.ToInt64(dataReader["ID"]);

            _indirizzo.CodicePostale = dataReader["codicepostale"].ToString();

            _indirizzo.Comune = dataReader["comune"].ToString();

            _indirizzo.Via = dataReader["via"].ToString();

            _indirizzo.NumeroCivico = Convert.ToUInt16(dataReader["numerocivico"]);

            _indirizzo.Nazione = dataReader["nazione"].ToString();


            if (dataReader["letteracivico"] == DBNull.Value)
                _indirizzo.LetteraCivico = null;
            else
                _indirizzo.LetteraCivico = Convert.ToChar(dataReader["letteracivico"]);


            if (dataReader["esseresede"] == DBNull.Value)
                _indirizzo.EssereSede = null;
            else
                _indirizzo.EssereSede = Convert.ToBoolean(dataReader["esseresede"]);


            if (dataReader["casaproduttriceID"] == DBNull.Value)
                _indirizzo.CasaProduttriceID = -1;
            else
                _indirizzo.CasaProduttriceID = Convert.ToInt64(dataReader["casaproduttriceID"]);


            return _indirizzo;
        }


    }
}
