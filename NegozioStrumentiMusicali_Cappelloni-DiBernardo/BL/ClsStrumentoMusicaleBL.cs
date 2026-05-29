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
        /// <param name="stringaDiConnessione"
        /// <param name="strumentoMusicale">Oggetto da inserire</param>
        /// <param name="comunicazione">Stringa di comunicazione in uscita</param>
        /// <returns>ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertStrumentoMusicale(string stringaDiConnessione, ClsStrumentoMusicale strumentoMusicale, out string comunicazione)
        {
            //VARIABILI LOCALI
            long _ID = -1;
            comunicazione = String.Empty;
            MySqlConnection _connection = new MySqlConnection(stringaDiConnessione);

            try
            {
                //Apro la connessione
                _connection.Open();

                //Creo il comando DML
                string _dml =
                    "INSERT into strumentimusicali " +
                    "(colori, pathimmagine, modello, pesokg, notaminimaID, notamassimaID, casaproduttriceID) " +
                    "VALUES (@colori, @pathimmagine, @modello, @pesokg, @notaminimaID, @notamassimaID, @casaproduttriceID)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, _connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@colori", strumentoMusicale.Colori);

                _cmd.Parameters.AddWithValue("@pathimmagine", strumentoMusicale.Immagine);

                _cmd.Parameters.AddWithValue("@modello", strumentoMusicale.Modello);

                _cmd.Parameters.AddWithValue("@casaproduttriceID", strumentoMusicale.CasaProduttriceID);

                if (strumentoMusicale.NotaMinimaID <= -1)
                {
                    _cmd.Parameters.AddWithValue("@notaminimaID", null);
                }
                else
                {
                    _cmd.Parameters.AddWithValue("@notaminimaID", strumentoMusicale.NotaMinimaID);
                }

                if (strumentoMusicale.NotaMassimaID <= -1)
                {
                    _cmd.Parameters.AddWithValue("@notamassimaID", null);
                }
                else
                {
                    _cmd.Parameters.AddWithValue("@notamassimaID", strumentoMusicale.NotaMassimaID);
                }

                _cmd.Parameters.AddWithValue("@pesokg", strumentoMusicale.PesoKG);


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
                _connection.Close();
            }

            return _ID;
        }
        /// <summary>
        /// Update di un record di strumentimusicali
        /// </summary>
        /// <param name="stringaDiConnessione"></param>
        /// <param name="strumentoMusicale">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateStrumentoMusicale(string stringaDiConnessione, ClsStrumentoMusicale strumentoMusicale, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;
            MySqlConnection _connection = new MySqlConnection(stringaDiConnessione);

            try
            {
                //Apro la connessione
                _connection.Open();

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
                MySqlCommand _cmd = new MySqlCommand(_dml, _connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@colori", strumentoMusicale.Colori);

                _cmd.Parameters.AddWithValue("@pathimmagine", strumentoMusicale.Immagine);

                _cmd.Parameters.AddWithValue("@modello", strumentoMusicale.Modello);
                
                if(strumentoMusicale.NotaMinimaID <= -1)
                {
                    _cmd.Parameters.AddWithValue("@notaminimaID", null);
                }
                else
                {
                    _cmd.Parameters.AddWithValue("@notaminimaID", strumentoMusicale.NotaMinimaID);
                }

                if (strumentoMusicale.NotaMassimaID <= -1)
                {
                    _cmd.Parameters.AddWithValue("@notamassimaID", null);
                }
                else
                {
                    _cmd.Parameters.AddWithValue("@notamassimaID", strumentoMusicale.NotaMassimaID);
                }

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
                _connection.Close();
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
        public static ClsStrumentoMusicale CaricaSingoloStrumento(ref MySqlDataReader dataReader)
        {
            ClsStrumentoMusicale _strumentoMusicale = new ClsStrumentoMusicale();

            _strumentoMusicale.ID = Convert.ToInt64(dataReader["ID"]);

            _strumentoMusicale.CasaProduttriceID = Convert.ToInt64(dataReader["casaproduttriceID"]);

            if(dataReader["colori"] == DBNull.Value)
            {
                _strumentoMusicale.Colori = null;
            }
            else
            {
                _strumentoMusicale.Colori = dataReader["colori"].ToString();
            }

            if(dataReader["pathimmagine"] == DBNull.Value)
            {
                _strumentoMusicale.Immagine = null;
            }
            else
            {
                _strumentoMusicale.Immagine = dataReader["pathimmagine"].ToString();
            }

            _strumentoMusicale.Modello = dataReader["modello"].ToString();

            if(dataReader["notamassimaID"] == DBNull.Value)
            {
                _strumentoMusicale.NotaMassimaID = -1;
            }
            else
            {
                _strumentoMusicale.NotaMassimaID = Convert.ToInt64(dataReader["notamassimaID"]);
            }

            if (dataReader["notaminimaID"] == DBNull.Value)
            {
                _strumentoMusicale.NotaMinimaID = -1;
            }
            else
            {
                _strumentoMusicale.NotaMinimaID = Convert.ToInt64(dataReader["notaminimaID"]);
            }

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
        /// <summary>
        /// Prende un record da strumentimusicali in base alla chiave primaria ID
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="ID"></param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>Il record ottenuto. Se è null la query non è andata a buon fine</returns>
        public static ClsStrumentoMusicale GetOneStrumentoMusicale(ref MySqlConnection connection, long ID, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;
            ClsStrumentoMusicale _strumentoMusicale = new ClsStrumentoMusicale();

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo la query
                string _query = "SELECT * FROM strumentimusicali WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", ID);

                //Eseguo il comando creando il DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if(_dataReader.HasRows) //Controllo se la tabella ha dei record
                {
                    while(_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        _strumentoMusicale = CaricaSingoloStrumento(ref _dataReader);
                    }
                }

                _dataReader.Close();

                comunicazione = "Strumento musicale caricato correttamente dal DataBase";
            }
            catch(Exception ex)
            {
                comunicazione = ex.Message;
                _strumentoMusicale = null;
            }
            finally 
            {
                //Chiudo la connessione
                connection.Close();
            }

            return _strumentoMusicale;
        }
        /// <summary>
        /// Copia i dati da strumento1 a strumento2 senza mantenere gli stessi riferimenti in memoria. In caso di specializzazione, va a copiare solo i dati generali
        /// </summary>
        /// <param name="strumento1"></param>
        /// <param name="strumento2"
        /// <returns></returns>
        public static void Clona(ClsStrumentoMusicale strumento1, ref ClsStrumentoMusicale strumento2)
        {
            strumento2.ID = strumento1.ID;
            strumento2.Immagine = strumento1.Immagine;
            strumento2.Modello = strumento1.Modello;
            strumento2.NotaMassimaID = strumento1.NotaMassimaID;
            strumento2.NotaMinimaID = strumento1.NotaMinimaID;
            strumento2.CasaProduttriceID = strumento1.CasaProduttriceID;
            strumento2.Colori = strumento1.Colori;
            strumento2.PesoKG = strumento1.PesoKG;
        }
        /// <summary>
        /// Copia i dati da strumento1 a strumento2 (che è batteria) senza mantenere gli stessi riferimenti in memoria. In caso di specializzazione, va a copiare solo i dati generali
        /// </summary>
        /// <param name="strumento1"></param>
        /// <param name="strumento2"
        /// <returns></returns>
        public static void Clona(ClsStrumentoMusicale strumento1, ref ClsBatteria strumento2)
        {
            strumento2.ID = strumento1.ID;
            strumento2.Immagine = strumento1.Immagine;
            strumento2.Modello = strumento1.Modello;
            strumento2.NotaMassimaID = strumento1.NotaMassimaID;
            strumento2.NotaMinimaID = strumento1.NotaMinimaID;
            strumento2.CasaProduttriceID = strumento1.CasaProduttriceID;
            strumento2.Colori = strumento1.Colori;
            strumento2.PesoKG = strumento1.PesoKG;
        }
        /// <summary>
        /// Copia i dati da strumento1 a strumento2 (che è legno) senza mantenere gli stessi riferimenti in memoria. In caso di specializzazione, va a copiare solo i dati generali
        /// </summary>
        /// <param name="strumento1"></param>
        /// <param name="strumento2"
        /// <returns></returns>
        public static void Clona(ClsStrumentoMusicale strumento1, ref ClsLegno strumento2)
        {
            strumento2.ID = strumento1.ID;
            strumento2.Immagine = strumento1.Immagine;
            strumento2.Modello = strumento1.Modello;
            strumento2.NotaMassimaID = strumento1.NotaMassimaID;
            strumento2.NotaMinimaID = strumento1.NotaMinimaID;
            strumento2.CasaProduttriceID = strumento1.CasaProduttriceID;
            strumento2.Colori = strumento1.Colori;
            strumento2.PesoKG = strumento1.PesoKG;
        }
        /// <summary>
        /// Copia i dati da strumento1 a strumento2 (che è ottone) senza mantenere gli stessi riferimenti in memoria. In caso di specializzazione, va a copiare solo i dati generali
        /// </summary>
        /// <param name="strumento1"></param>
        /// <param name="strumento2"
        /// <returns></returns>
        public static void Clona(ClsStrumentoMusicale strumento1, ref ClsOttone strumento2)
        {
            strumento2.ID = strumento1.ID;
            strumento2.Immagine = strumento1.Immagine;
            strumento2.Modello = strumento1.Modello;
            strumento2.NotaMassimaID = strumento1.NotaMassimaID;
            strumento2.NotaMinimaID = strumento1.NotaMinimaID;
            strumento2.CasaProduttriceID = strumento1.CasaProduttriceID;
            strumento2.Colori = strumento1.Colori;
            strumento2.PesoKG = strumento1.PesoKG;
        }
        /// <summary>
        /// Copia i dati da strumento1 a strumento2 (che è pianoforte) senza mantenere gli stessi riferimenti in memoria. In caso di specializzazione, va a copiare solo i dati generali
        /// </summary>
        /// <param name="strumento1"></param>
        /// <param name="strumento2"
        /// <returns></returns>
        public static void Clona(ClsStrumentoMusicale strumento1, ref ClsPianoforte strumento2)
        {
            strumento2.ID = strumento1.ID;
            strumento2.Immagine = strumento1.Immagine;
            strumento2.Modello = strumento1.Modello;
            strumento2.NotaMassimaID = strumento1.NotaMassimaID;
            strumento2.NotaMinimaID = strumento1.NotaMinimaID;
            strumento2.CasaProduttriceID = strumento1.CasaProduttriceID;
            strumento2.Colori = strumento1.Colori;
            strumento2.PesoKG = strumento1.PesoKG;
        }
        /// <summary>
        /// Copia i dati da strumento1 a strumento2 (che è strumento a corda) senza mantenere gli stessi riferimenti in memoria. In caso di specializzazione, va a copiare solo i dati generali
        /// </summary>
        /// <param name="strumento1"></param>
        /// <param name="strumento2"
        /// <returns></returns>
        public static void Clona(ClsStrumentoMusicale strumento1, ref ClsStrumentoACorda strumento2)
        {
            strumento2.ID = strumento1.ID;
            strumento2.Immagine = strumento1.Immagine;
            strumento2.Modello = strumento1.Modello;
            strumento2.NotaMassimaID = strumento1.NotaMassimaID;
            strumento2.NotaMinimaID = strumento1.NotaMinimaID;
            strumento2.CasaProduttriceID = strumento1.CasaProduttriceID;
            strumento2.Colori = strumento1.Colori;
            strumento2.PesoKG = strumento1.PesoKG;
        }

    }


}
