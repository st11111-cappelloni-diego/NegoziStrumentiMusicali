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
    public static class ClsNotaMusicaleBL
    {
        /// <summary>
        /// Inserimento di un record in notemusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="notaMusicale">Oggetto da inserire</param>
        /// <param name="comunicazione">Stringa di comunicazione in uscita</param>
        /// <returns>ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertNotaMusicale(MySqlConnection connection, ClsNotaMusicale notaMusicale, out string comunicazione)
        {
            //VARIABILI
            long _ID = -1;
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando in DML
                string _dml =
                    "INSERT into notemusicali (notabase, alterazione, ottava) " +
                    "VALUES(@notabase, @alterazione, @ottava)";

                //Creo il command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@notabase", notaMusicale.NotaBase.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@alterazione", notaMusicale.Alterazione.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@ottava", notaMusicale.Ottava);

                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando è stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                comunicazione = "Nota musicale inserita con successo nel DataBase";
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
        /// Update di un record di notemusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="notaMusicale">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateNotaMusicale(ref MySqlConnection connection, ClsNotaMusicale notaMusicale, out string comunicazione)
        {
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml =
                    "UPDATE notemusicali " +
                    "SET notabase = @notabase, " +
                    "alterazione = @alterazione, " +
                    "ottava = @ottava, " +
                    "WHERE ID = @ID";

                //Creo il command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@notabase", notaMusicale.NotaBase.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@alterazione", notaMusicale.NotaBase.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@ottava", notaMusicale.Ottava);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Nota musicale aggiornata correttamente nel DataBase";
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
        /// Eliminazione di un record da notemusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="notamusicale">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void DeleteNotaMusicale(ref MySqlConnection connection, ClsNotaMusicale notamusicale, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml = "DELETE FROM notemusicali WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", notamusicale.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Nota musicale eliminata correttamente dal DataBase";
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
        /// Caricamento di tutti i record di notemusicali
        /// </summary>
        /// <param name="stringaDiConnessione">Stringa per connessione al DB</param>
        /// <param name="ordinaPerPiuRecente">Se true, ordina per altezza nota in maniera decrescente. Se false ordina per altezza nota in maniera crescente</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <param name="limiteRecord">Numero massimo di record da caricare. Accetta valori da 2 in su</param>
        /// <returns>La lista di tutti i record di notemusicali in base ai limiti stabiliti</returns>
        public static List<ClsNotaMusicale> GetAllNoteMusicali(string stringaDiConnessione, bool ordinaPerPiuRecente, out string comunicazione, int limiteRecord = 0)
        {
            //VARIABILI
            List<ClsNotaMusicale> _noteMusicali = new List<ClsNotaMusicale>();
            comunicazione = String.Empty;
            MySqlConnection _connection = new MySqlConnection(stringaDiConnessione);

            try
            {
                //Apro la connessione                
                _connection.Open();

                //Compongo la query
                string _query = "SELECT * FROM notemusicali ORDER BY ottava, notabase, alterazione ";

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

                if(_dataReader.HasRows) //Controllo se la tabella ha dei record
                {
                    while(_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        ClsNotaMusicale _notaMusicale = new ClsNotaMusicale();

                        _notaMusicale.ID = Convert.ToInt64(_dataReader["ID"]);
                        _notaMusicale.Alterazione = (ClsNotaMusicale.eALTERAZIONE)Enum.Parse
                        (
                            typeof(ClsNotaMusicale.eALTERAZIONE),
                            _dataReader["alterazione"].ToString()
                        );
                        _notaMusicale.NotaBase = (ClsNotaMusicale.eNOTA_BASE)Enum.Parse
                        (
                            typeof(ClsNotaMusicale.eNOTA_BASE),
                            _dataReader["notabase"].ToString()
                        );
                        _notaMusicale.Ottava = Convert.ToByte(_dataReader["ottava"]);

                        _noteMusicali.Add(_notaMusicale);
                    }
                }

                _dataReader.Close();

                comunicazione = "Note musicali caricate correttamente dal DataBase";
            }
            catch(Exception ex)
            {
                comunicazione = ex.Message;
            }
            finally
            {
                //Chiudo la connessione
                _connection.Close();
            }

            return _noteMusicali;
        }
    }
}
