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
        /// <summary>
        /// Carica i dati dal DataReader ad un'istanza di ClsNegozio
        /// </summary>
        /// <param name="dataReader"></param>
        /// <returns></returns>
        private static ClsNegozio CaricaSingoloNegozio(ref MySqlDataReader dataReader)
        {
            ClsNegozio _negozio = new ClsNegozio();

            _negozio.ID = Convert.ToInt64(dataReader["ID"]);
            _negozio.Nome = dataReader["nome"].ToString();
            _negozio.IndirizzoID = Convert.ToInt64(dataReader["indirizzoID"]);
            _negozio.Bandito = Convert.ToBoolean(dataReader["bandito"]);
            if(dataReader["pathimmagine"] == DBNull.Value)
            {
                _negozio.PathImmagine = null;
            }
            else
            {
                _negozio.PathImmagine = dataReader["pathimmagine"].ToString();
            }
            if(dataReader["email"] ==  DBNull.Value)
            {
                _negozio.Email = null;
            }
            else
            {
                _negozio.Email = dataReader["email"].ToString();
            }
            if(dataReader["sito"] ==  DBNull.Value)
            {
                _negozio.Sito = null; 
            }
            else
            {
                _negozio.Sito = dataReader["sito"].ToString();
            }

            return _negozio;
        }
        /// <summary>
        /// Prende tutti i record di negozi
        /// </summary>
        /// <param name="stringaDiConnessione">Stringa per la connessione al DB</param>
        /// <param name="ordinaPerPiuRecente">Se true, ordina per ID in maniera decrescente. Se false ordina per ID in maniera crescente</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <param name="limiteRecord">Numero massimo di record da caricare. Accetta valori da 2 in su</param>
        /// <returns>La lista con tutti i record. Se è nulla il caricamento non è andato a buon fine</returns>
        public static List<ClsNegozio> GetAllNegozi(string stringaDiConnessione, bool ordinaPerPiuRecente, out string comunicazione, int limiteRecord = 0)
        {
            //VARIABILI
            comunicazione = String.Empty;
            List<ClsNegozio> _negozi = new List<ClsNegozio>();
            MySqlConnection _connection = new MySqlConnection(stringaDiConnessione);

            try
            {
                //Apro la connessione
                _connection.Open();

                //Compongo la query
                string _query = "SELECT * FROM negozi ORDER BY ID ";

                if (ordinaPerPiuRecente)
                {
                    _query += "DESC";
                }
                else
                {
                    _query += "ASC";
                }

                //Metto limite se richiesto
                if (limiteRecord >= 2)
                {
                    _query += " LIMIT @limite";
                }

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, _connection);

                //Inserisco il limite se richiesto
                if (limiteRecord >= 2)
                {
                    _cmd.Parameters.AddWithValue("@limite", limiteRecord);
                }

                //Eseguo il comando creando il DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if(_dataReader.HasRows) //Controllo se la tabella ha record
                {
                    while(_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        _negozi.Add(CaricaSingoloNegozio(ref _dataReader));
                    }
                }

                _dataReader.Close();

                comunicazione = "Negozi caricati correttamente dal DataBase";
            }
            catch(Exception ex)
            {
                comunicazione = ex.Message;
                _negozi = null;
            }
            finally
            {
                //Chiudo la connessione
                _connection.Close();
            }

            return _negozi;
        }
    }
}
