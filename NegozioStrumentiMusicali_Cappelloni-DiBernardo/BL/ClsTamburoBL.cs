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
    public static class ClsTamburoBL
    {
        /// <summary>
        /// Inserimento di un record in tamburi
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="tamburo">Oggetto da inserire</param>
        /// <param name="comunicazione">Stringa di comunicazione in uscita</param>
        /// <returns>ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertTamburo(ref MySqlConnection connection, ClsTamburo tamburo, out string comunicazione)
        {
            //VARIABILI
            long _ID = -1;
            comunicazione = string.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml =
                    "INSERT into tamburi (tipo, diametroin, materiale, strati) " +
                    "VALUES(@tipo, @diametroin, @materiale, @strati)";

                //Creo il command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@tipo", tamburo.Tipo.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@diametroin", tamburo.DiametroIN.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materiale", tamburo.Materiale.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@strati", tamburo.Strati);

                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando è stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                comunicazione = "Tamburo inserito con successo nel DataBase";

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
        /// Update di un record di tamburi
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="tamburo">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateTamburo(ref MySqlConnection connection, ClsTamburo tamburo, out string comunicazione)
        {
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml =
                    "UPDATE tamburi " +
                    "SET tipo = @tipo, " +
                    "diametroin = @diametroin, " +
                    "materiale = @materiale, " +
                    "strati = @strati " +
                    "WHERE ID = @ID";

                //Creo il command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", tamburo.ID);
                _cmd.Parameters.AddWithValue("@tipo", tamburo.Tipo.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@diametroin", tamburo.DiametroIN.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materiale", tamburo.Materiale.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@strati", tamburo.Strati);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Tamburo aggiornato correttamente nel DataBase";
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
        /// Eliminazione di un record da tamburi
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="tamburo">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void DeleteTamburo(ref MySqlConnection connection, ClsTamburo tamburo, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml = "DELETE FROM tamburi WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", tamburo.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Tamburo eliminato correttamente dal DataBase";
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
        private static ClsTamburo CaricaSingoloTamburo(ref MySqlDataReader dataReader)
        {
            ClsTamburo _tamburo = new ClsTamburo();

            _tamburo.ID = Convert.ToInt64(dataReader["ID"]);
            _tamburo.DiametroIN = Convert.ToByte(dataReader["diametroin"]);
            _tamburo.Strati = Convert.ToByte(dataReader["strati"]);
            _tamburo.Materiale = (ClsTamburo.eMATERIALE)Enum.Parse
            (
                typeof(ClsTamburo.eMATERIALE),
                dataReader["materiale"].ToString()
            );
            _tamburo.Tipo = (ClsTamburo.eTIPO)Enum.Parse
            (
                typeof(ClsTamburo.eTIPO),
                dataReader["tipo"].ToString()
            );

            return _tamburo;
        }
        /// <summary>
        /// Caricamento di tutti i record di tamburi
        /// </summary>
        /// <param name="stringaDiConnessione">Stringa per la connessione al DB</param>
        /// <param name="ordinaPerPiuRecente">Se true, ordina per ID in maniera decrescente. Se false ordina per ID in maniera crescente</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <param name="limiteRecord">Numero massimo di record da caricare. Accetta valori da 2 in su</param>
        /// <returns>La lista di tutti i record di tamburi</returns>
        public static List<ClsTamburo> GetAllTamburi(string stringaDiConnessione, bool ordinaPerPiuRecente, out string comunicazione, int limiteRecord = 0)
        {
            //VARIABILI
            List<ClsTamburo> _tamburi = new List<ClsTamburo>();
            comunicazione = String.Empty;
            MySqlConnection _connection = new MySqlConnection(stringaDiConnessione);

            try
            {
                //Apro la connessione                
                _connection.Open();

                //Compongo la query
                string _query = "SELECT * from tamburi ORDER BY ID ";

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
                        //Carico i dati sulla lista
                        _tamburi.Add(CaricaSingoloTamburo(ref _dataReader));
                    }

                    _dataReader.Close();

                    comunicazione = "Tamburi caricati correttamente dal DataBase";
                }
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

            return _tamburi;
        }
    }
}
