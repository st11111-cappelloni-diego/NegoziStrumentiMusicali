using System;
using System.Collections.Generic;
using System.Linq;
using MySqlConnector;
using System.Text;
using System.Threading.Tasks;

namespace NegozioStrumentiMusicali
{
    class ClsOrdineStrumentoBL
    {
        public static long InsertOrdineStrumento(string stringaDiConnessione, ClsOrdineStrumento ordineStrumento, out string comunicazione)
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
                    "INSERT into ordinestrumento " +
                    "(ordineID, strumentomusicaleID, quantita)" +
                    "VALUES(@ordineID, @strumentomusicaleID, @quantita)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ordineID", ordineStrumento.OrdineID.ToString());
                _cmd.Parameters.AddWithValue("@strumentomusicaleID", ordineStrumento.StrumentoMusicaleID);
                _cmd.Parameters.AddWithValue("@quantita", ordineStrumento.Quantita);


                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando è stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                comunicazione = "OrdineStrumento inserito con successo nel DataBase";
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
        /// Update di record di ordinestrumento
        /// </summary>
        /// <param name="stringaDiConnessione"></param>
        /// <param name="ordineStrumento">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateOrdineStrumento(string stringaDiConnessione, ClsOrdineStrumento ordineStrumento, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;
            MySqlConnection _connection = new MySqlConnection(stringaDiConnessione);

            try
            {
                //Apro la connessione
                _connection.Open();

                //Compongo il comando dml
                string _dml =
                    "UPDATE ordinestrumento SET " +
                    "ordineID = @ordineID, " +
                    "strumentomusicaleID = @strumentomusicaleID, " +
                    "quantita = @quantita, " +
                    "WHERE ID = @ID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, _connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ordineID", ordineStrumento.OrdineID.ToString());
                _cmd.Parameters.AddWithValue("@strumentomusicaleID", ordineStrumento.StrumentoMusicaleID);
                _cmd.Parameters.AddWithValue("@quantita", ordineStrumento.Quantita);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "OrdineStrumento aggiornato correttamente nel DataBase";
            }
            catch (Exception ex)
            {
                comunicazione = ex.Message;
            }
            finally
            {
                //Chiudo la connessione
                _connection.Close();
            }

        }

        /// <summary>
        /// Eliminazione di un record da ordinestrumento
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="ordineStrumento">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>

        public static void DeleteOrdineStrumento(ref MySqlConnection connection, ClsOrdineStrumento ordineStrumento, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml = "DELETE FROM ordinestrumento WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", ordineStrumento.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "OrdineStrumento eliminato correttamente dal DataBase";
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
        /// Caricamento di alcuni record di ordinistrumento in base a ordineID o strumentoMusicaleID.
        /// Escludi negozioID passando come valore -1, escludi strumentoMusicaleID passando come valore -1
        /// </summary>
        /// <param name="stringDiConnessione"></param>
        /// <param name="ordineID"></param>
        /// <param name="strumentoMusicaleID"></param>
        /// <param name="comunicazione"></param>
        /// <returns></returns>
        public static List<ClsOrdineStrumento> GetSomeOrdiniStrumento(string stringDiConnessione, long ordineID, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;
            List<ClsOrdineStrumento> _listaOrdiniStrumenti = new List<ClsOrdineStrumento>();
            MySqlConnection connection = new MySqlConnection(stringDiConnessione);

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo la query
                string _query = "SELECT * FROM ordinestrumento WHERE ordineID = @ordineID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ordineID", ordineID);

                //Eseguo il comando creando il DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if (_dataReader.HasRows) //Controllo se la tabella ha record
                {
                    while (_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        _listaOrdiniStrumenti.Add(CaricaSingoloOrdineStrumento(ref _dataReader));
                    }
                }

                _dataReader.Close();

                comunicazione = "Ordini caricati correttamente dal DataBase";
            }
            catch (Exception ex)
            {
                comunicazione = ex.Message;
                _listaOrdiniStrumenti = null;
            }
            finally
            {
                //Chiudo la connessione
                connection.Close();
            }

            return _listaOrdiniStrumenti;
        }

        /// <summary>
        /// Carica i dati dal DataReader ad un'istanza di ClsOrdine
        /// </summary>
        /// <param name="dataReader"></param>
        /// <returns></returns>
        private static ClsOrdineStrumento CaricaSingoloOrdineStrumento(ref MySqlDataReader dataReader)
        {
            ClsOrdineStrumento _ordineStrumento = new ClsOrdineStrumento();

            _ordineStrumento.ID = Convert.ToInt64(dataReader["ID"]);
            _ordineStrumento.OrdineID = Convert.ToInt64(dataReader["ordineID"]);
            _ordineStrumento.StrumentoMusicaleID = Convert.ToInt64(dataReader["strumentomusicaleID"]);
            _ordineStrumento.Quantita = Convert.ToInt32(dataReader["quantita"]);

            return _ordineStrumento;
        }
    }
}
