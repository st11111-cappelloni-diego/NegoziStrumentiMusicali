using MySqlConnector;
using System;
using System.Collections.Generic;

namespace NegozioStrumentiMusicali
{
    /// <summary>
    /// Sviluppata da Diego Cappelloni
    /// </summary>
    public static class ClsStrumentoMusicaleBL
    {
        /// <summary>
        /// Inserimento di un record in strumentimusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="strumentoMusicale">Oggetto da inserire</param>
        /// <param name="comunicazione">Stringa di comunicazione in uscita</param>
        /// <returns>ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertStrumentoMusicale(ref MySqlConnection connection, ClsStrumentoMusicale strumentoMusicale, out string comunicazione)
        {
            //VARIABILI LOCALI
            long _ID = -1;
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Creo il comando DML
                string _dml =
                    "INSERT into strumentimusicali " +
                    "(colori, pathimmagine, modello, pesokg, notaminimaID, notamassimaID) " +
                    "VALUES (@colori, @pathimmagine, @modello, @pesokg, @notaminimaID, @notamassimaID)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@colori", strumentoMusicale.Colori);
                _cmd.Parameters.AddWithValue("@pathimmagine", strumentoMusicale.Immagine);
                _cmd.Parameters.AddWithValue("@modello", strumentoMusicale.Modello);
                _cmd.Parameters.AddWithValue("@pesokg", strumentoMusicale.PesoKG);
                _cmd.Parameters.AddWithValue("@notaminimaID", strumentoMusicale.NotaMinimaID);
                _cmd.Parameters.AddWithValue("@notaMassimaID", strumentoMusicale.NotaMassimaID);

                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando è stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                comunicazione = "Strumento musicale inserito con successo nel DataBase";
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
        /// Update di un record di strumentimusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="strumentoMusicale">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateStrumentoMusicale(ref MySqlConnection connection, ClsStrumentoMusicale strumentoMusicale, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando dml
                string _dml =
                    "UPDATE strumentimusicali " +
                    "SET colori = @colori, " +
                    "pathimmagine = @pathimmagine, " +
                    "modello = @modello, " +
                    "notaminimaID = @notaminimaID, " +
                    "notamassimaID = @notamassimaID, " +
                    "pesokg = @pesokg " +
                    "WHERE ID = @ID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@colori", strumentoMusicale.Colori);
                _cmd.Parameters.AddWithValue("@pathimmagine", strumentoMusicale.Immagine);
                _cmd.Parameters.AddWithValue("@modello", strumentoMusicale.Modello);
                _cmd.Parameters.AddWithValue("@notaminimaID", strumentoMusicale.NotaMinimaID);
                _cmd.Parameters.AddWithValue("@notamassimaID", strumentoMusicale.NotaMassimaID);
                _cmd.Parameters.AddWithValue("@pesokg", strumentoMusicale.PesoKG);
                _cmd.Parameters.AddWithValue("@ID", strumentoMusicale.ID);

                comunicazione = "Strumento musicale aggiornato correttamente nel DataBase";
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
        /// <param name="strumentoMusicale">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void DeleteStrumentoMusicale(ref MySqlConnection connection, ClsStrumentoMusicale strumentoMusicale, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml = "DELETE FROM strumentimusicali WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", strumentoMusicale.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Strumento musicale eliminato correttamente dal DataBase";
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
        /// Caricamento dei dati dal DataReader ad un'istanza di ClsStrumentoMusicale
        /// </summary>
        /// <param name="dataReader"></param>
        /// <returns></returns>
        private static ClsStrumentoMusicale CaricaSingoloStrumento(ref MySqlDataReader dataReader)
        {
            ClsStrumentoMusicale _strumentoMusicale = new ClsStrumentoMusicale();
            _strumentoMusicale.ID = Convert.ToInt64(dataReader["ID"]);
            _strumentoMusicale.CasaProduttriceID = Convert.ToInt64(dataReader["casaproduttriceID"]);
            _strumentoMusicale.Colori = dataReader["colori"].ToString();
            _strumentoMusicale.Immagine = dataReader["pathimmagine"].ToString();
            _strumentoMusicale.Modello = dataReader["modello"].ToString();
            _strumentoMusicale.NotaMassimaID = Convert.ToInt64(dataReader["notamassimaID"]);
            _strumentoMusicale.NotaMinimaID = Convert.ToInt64(dataReader["notaminimaID"]);
            _strumentoMusicale.PesoKG = Convert.ToSingle(dataReader["pesokg"]);

            return _strumentoMusicale;
        }
        /// <summary>
        /// Caricamento di tutti i record di strumentimusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>La lista di tutti i record di strumentimusicali</returns>
        public static List<ClsStrumentoMusicale> GetAllStrumentiMusicali(ref MySqlConnection connection, out string comunicazione)
        {
            //VARIABILI
            List<ClsStrumentoMusicale> _strumentiMusicali = new List<ClsStrumentoMusicale>();
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo la query
                string _query = "SELECT * FROM strumentimusicali";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, connection);

                //Eseguo il comando creando l'oggetto DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if(_dataReader.HasRows) //Controllo se la tabella contiene dei record
                {
                    while(_dataReader.Read()) //Se ce li ha li leggo tutti
                    {
                        //Carico i dati dal DB
                        _strumentiMusicali.Add(CaricaSingoloStrumento(ref _dataReader));
                    }
                }

                _dataReader.Close();

                comunicazione = "Strumenti musicali caricati correttamente dal DataBase";
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

            return _strumentiMusicali;
        }
        /// <summary>
        /// Caricamento di alcuni record di strumentimusicali in base a casa produttrice, modello o colori.
        /// Escludi casaproduttrice mettendo come valore -1, escludi modello mettendo come valore null, escludi colori mettendo come valore null
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <param name="colori"></param>
        /// <param name="modello"></param>
        /// <param name="casaProduttriceID"></param>
        /// <returns></returns>
        public static List<ClsStrumentoMusicale> GetSomeStrumentiMusicali(ref MySqlConnection connection, out string comunicazione, string colori, string modello, long casaProduttriceID)
        {
            //VARIABILI
            comunicazione = String.Empty;
            List<ClsStrumentoMusicale> _strumentiMusicali = new List<ClsStrumentoMusicale>();

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo la query
                string _query = "SELECT * from strumentimusicali WHERE ";
                //Posso ricercare per un solo campo alla volta perciò li controllo nell'ordine: casaProduttriceID, modello, colori)
                if(casaProduttriceID > -1)
                {
                    //Casa produttrice è il campo di ricerca
                    _query += "casaproduttriceID = @casaproduttriceID";
                }
                else if(modello != null)
                {
                    //Modello è il campo di ricerca
                    _query += "modello LIKE '@modello%'";
                }
                else
                {
                    //Colori è il campo di ricerca
                    _query += "colori LIKE '@colori%'";
                }

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, connection);

                //Inserisco i valori in base al campo di ricerca
                //Posso ricercare per un solo campo alla volta perciò li controllo nell'ordine: casaProduttriceID, modello, colori)
                if (casaProduttriceID > -1)
                {
                    //Casa produttrice è il campo di ricerca
                    _cmd.Parameters.AddWithValue("@casaproduttriceID", casaProduttriceID);
                }
                else if (modello != null)
                {
                    //Modello è il campo di ricerca
                    _cmd.Parameters.AddWithValue("@modello", modello);
                }
                else
                {
                    //Colori è il campo di ricerca
                    _cmd.Parameters.AddWithValue("@colori", colori);
                }

                //Eseguo il comando creando il DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if(_dataReader.HasRows) //Controllo se la tabella ha dei record
                {
                    while(_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        //Carico i dati dal DB
                        _strumentiMusicali.Add(CaricaSingoloStrumento(ref _dataReader));
                    }
                }

                _dataReader.Close();

                comunicazione = "Strumenti musicali caricati correttamente dal DataBase";
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

            return _strumentiMusicali;
        }
    }


}
