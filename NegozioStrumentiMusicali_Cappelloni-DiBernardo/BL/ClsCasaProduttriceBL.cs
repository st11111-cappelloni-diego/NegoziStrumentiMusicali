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
    public static class ClsCasaProduttriceBL
    {
        /// <summary>
        /// Inserimento di record in caseproduttrici
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="casaProduttrice">Record da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns></returns>
        public static long InsertCasaProduttrice(ref MySqlConnection connection, ClsCasaProduttrice casaProduttrice, out string comunicazione)
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
                    "INSERT into caseproduttrici " +
                    "(nome, email, pathlogo, sito)" +
                    "VALUES(@nome, @email, @pathlogo, @sito)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@nome", casaProduttrice.Nome);
                _cmd.Parameters.AddWithValue("@email", casaProduttrice.Email);
                _cmd.Parameters.AddWithValue("@pathlogo", casaProduttrice.PathLogo);
                _cmd.Parameters.AddWithValue("@sito", casaProduttrice.Sito);

                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando è stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                comunicazione = "Casa produttrice inserita con successo nel DataBase";
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
        /// Update di un record di caseproduttrici
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="casaProduttrice">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateCasaProdruttrice(ref MySqlConnection connection, ClsCasaProduttrice casaProduttrice, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando dml
                string _dml =
                    "UPDATE caseproduttrici SET " +
                    "nome = @nome, " +
                    "email = @email, " +
                    "pathlogo = @pathlogo," +
                    "sito = @sito  " +
                    "WHERE ID = @ID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@nome", casaProduttrice.Nome);
                _cmd.Parameters.AddWithValue("@email", casaProduttrice.Email);
                _cmd.Parameters.AddWithValue("@pathlogo", casaProduttrice.PathLogo);
                _cmd.Parameters.AddWithValue("@ID", casaProduttrice.ID);
                _cmd.Parameters.AddWithValue("@sito", casaProduttrice.Sito);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Casa produttrice aggiornata correttamente nel DataBase";
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
        /// Eliminazione di un record da caseproduttrici
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="casaProduttrice">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void DeleteCasaproduttrice(ref MySqlConnection connection, ClsCasaProduttrice casaProduttrice, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml = "DELETE FROM caseproduttrici WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", casaProduttrice.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Casa Produttrice eliminata correttamente dal DataBase";
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
        /// Caricamento dei dati del DataReader ad un'istanza di ClsCasaProduttrice
        /// </summary>
        /// <param name="dataReader"></param>
        /// <returns></returns>
        private static ClsCasaProduttrice CaricaSingolaCasaProduttrice(ref MySqlDataReader dataReader)
        {
            ClsCasaProduttrice _casaProduttrice = new ClsCasaProduttrice();
            _casaProduttrice.ID = Convert.ToInt64(dataReader["ID"]);
            _casaProduttrice.Nome = dataReader["nome"].ToString();
            _casaProduttrice.Email = dataReader["email"].ToString();
            _casaProduttrice.PathLogo = dataReader["pathlogo"].ToString();
            _casaProduttrice.Sito = dataReader["sito"].ToString();

            return _casaProduttrice;
        }
        /// <summary>
        /// Caricamento di tutti i record di caseproduttrici
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="ordinaPerPiuRecente">Se true, ordina per ID in maniera decrescente. Se false ordina per ID in maniera crescente</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <param name="limiteRecord">Numero massimo di record da caricare. Accetta valori da 2 in su</param>
        /// <returns>La lista di tutti i record di caseproduttrici</returns>
        public static List<ClsCasaProduttrice> GetAllCaseProduttrici(ref MySqlConnection connection, bool ordinaPerPiuRecente, out string comunicazione, int limiteRecord = 0)
        {
            //VARIABILI
            List<ClsCasaProduttrice> _caseProduttrici = new List<ClsCasaProduttrice>();
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo la query
                string _query = "SELECT * FROM caseproduttrici ORDER BY ID ";

                if(ordinaPerPiuRecente)
                {
                    _query += "DESC";
                }
                else
                {
                    _query += "ASC";
                }

                //Metto limite se richiesto
                if(limiteRecord >= 2)
                {
                    _query += " LIMIT @limite";
                }

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, connection);

                //Inserisco il limite se richiesto
                if(limiteRecord >= 2)
                {
                    _cmd.Parameters.AddWithValue("@limite", limiteRecord);
                }

                //Eseguo il comando creando l'oggetto DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if (_dataReader.HasRows) //Controllo se la tabella contiene dei record
                {
                    while (_dataReader.Read()) //Se ce li ha li leggo tutti
                    {
                        //Carico i dati dal DB
                        _caseProduttrici.Add(CaricaSingolaCasaProduttrice(ref _dataReader));
                    }
                }

                _dataReader.Close();

                comunicazione = "Case produttrici caricate correttamente dal DataBase";
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

            return _caseProduttrici;
        }
        /// <summary>
        /// Prende un record da caseproduttrici in base alla chiave primaria ID
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="ID"></param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns></returns>
        public static ClsCasaProduttrice GetOneCasaProduttrice(ref MySqlConnection connection, long ID ,out string comunicazione)
        {
            //VARIABILI GLOBALI
            comunicazione = String.Empty;
            ClsCasaProduttrice _casaProduttrice = new ClsCasaProduttrice();

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo la query
                string _query = "SELECT * FROM caseproduttrici WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, connection);

                //Inserisco il valore
                _cmd.Parameters.AddWithValue("@ID", ID);

                //Eseguo il comando creando il DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if(_dataReader.HasRows) //Controllo se la tabella ha dei record
                {
                    while(_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        _casaProduttrice = CaricaSingolaCasaProduttrice(ref _dataReader);
                    }
                }

                _dataReader.Close();

                comunicazione = "Casa produttrice caricata correttamente dal DataBase";
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

            return _casaProduttrice;
        }
    }
}
