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

        /// <summary>
        /// Caricamento di alcuni record di ordini in base a negozioID o strumentoMusicaleID.
        /// Escludi negozioID passando come valore -1, escludi strumentoMusicaleID passando come valore -1
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="negozioID"></param>
        /// <param name="strumentoMusicaleID"></param>
        /// <param name="comunicazione"></param>
        /// <returns></returns>
        public static List<ClsOrdine> GetSomeOrdini(ref MySqlConnection connection, long negozioID, long strumentoMusicaleID, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;
            List<ClsOrdine> _listaOrdini = new List<ClsOrdine>();

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo la query
                string _query = "SELECT * FROM ordini WHERE ";

                if (negozioID > -1 && strumentoMusicaleID > -1)
                {
                    _query += "negozioID = @negozioID AND strumentomusicaleID = @strumentomusicaleID";
                }
                else if (negozioID > -1 && strumentoMusicaleID <= -1)
                {
                    _query += "negozioID = @negozioID";
                }
                else if (negozioID <= -1 && strumentoMusicaleID > -1)
                {
                    _query += "strumentomusicaleID = @strumentomusicaleID";
                }
                else
                {
                    //WHERE 1 prende tutti i record
                    //Questa casistica simula un GetAll senza limite ed ordinamento
                    //E' inserita solo per evitare bugs in caso vengono esclusi entrambi i parametri
                    _query += "1";
                }

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, connection);

                //Inserisco i valori
                if (negozioID > -1 && strumentoMusicaleID > -1)
                {
                    _cmd.Parameters.AddWithValue("@negozioID", negozioID);
                    _cmd.Parameters.AddWithValue("@strumentomusicaleID", strumentoMusicaleID);
                }
                else if (negozioID > -1 && strumentoMusicaleID <= -1)
                {
                    _cmd.Parameters.AddWithValue("@negozioID", negozioID);
                }
                else if (negozioID <= -1 && strumentoMusicaleID > -1)
                {
                    _cmd.Parameters.AddWithValue("@strumentomusicaleID", strumentoMusicaleID);
                }

                //Eseguo il comando creando il DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if (_dataReader.HasRows) //Controllo se la tabella ha record
                {
                    while (_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        _listaOrdini.Add(CaricaSingoloOrdine(ref _dataReader));
                    }
                }

                _dataReader.Close();

                comunicazione = "Relazioni di tipo vendere caricate correttamente dal DataBase";
            }
            catch (Exception ex)
            {
                comunicazione = ex.Message;
                _listaOrdini = null;
            }
            finally
            {
                //Chiudo la connessione
                connection.Close();
            }

            return _listaOrdini;
        }

        /// <summary>
        /// Carica i dati dal DataReader ad un'istanza di ClsOrdine
        /// </summary>
        /// <param name="dataReader"></param>
        /// <returns></returns>
        private static ClsOrdine CaricaSingoloOrdine(ref MySqlDataReader dataReader)
        {
            ClsOrdine _ordine = new ClsOrdine();

            _ordine.ID = Convert.ToInt64(dataReader["ID"]);
            _ordine.Quantita = Convert.ToInt16(dataReader["quantita"].ToString());
            _ordine.DataOra = Convert.ToDateTime(dataReader["data"]);
            _ordine.IndirizzoID = Convert.ToInt64(dataReader["indirizzoID"]);
            _ordine.NegozioID = Convert.ToInt64(dataReader["negozioID"]);
            _ordine.StrumentoMusicaleID = Convert.ToInt64(dataReader["strumentomusicaleID"]);
            _ordine.UsernameCliente = Convert.ToString(dataReader["usernameutente"]);
            
            return _ordine;
        }

    }
}
