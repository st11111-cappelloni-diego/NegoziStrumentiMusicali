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
    public static class ClsGestireBL
    {
        /// <summary>
        /// Inserimento di un record in gestire
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="gestire">Record da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>L'ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertGestire(ref MySqlConnection connection, ClsGestire gestire, out string comunicazione)
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
                    "INSERT into gestire " +
                    "(negozioID, utenteUsername)" +
                    "VALUES(@negozioID, @utenteUsername)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@quantita", gestire.NegozioID);
                _cmd.Parameters.AddWithValue("@prezzo", gestire.UtenteUsername);

                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando è stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                comunicazione = "Relazione di tipo gestire inserita con successo nel DataBase";
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
        /// Update di un record di gestire
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="gestire">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateGestire(ref MySqlConnection connection, ClsGestire gestire, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando dml
                string _dml =
                   "UPDATE gestire SET " +
                    "negozioID = @negozioID, " +
                    "utenteUsername = @utenteUsername " +
                    "WHERE ID = @ID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@negozioID", gestire.NegozioID);
                _cmd.Parameters.AddWithValue("@utenteUsername", gestire.UtenteUsername);
                _cmd.Parameters.AddWithValue("@ID", gestire.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Relazione di tipo gestire aggiornata correttamente nel DataBase";
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
        /// Eliminazione di un record da gestire
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="gestire">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void DeleteGestire(ref MySqlConnection connection, ClsGestire gestire, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml = "DELETE FROM gestire WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", gestire.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Relazione eliminata correttamente dal DataBase";
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
        /// Caricamento di tutti i record di gestire
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>La lista di tutti i record di caseproduttrici</returns>
        public static List<ClsGestire> GetAllGestire(ref MySqlConnection connection, out string comunicazione)
        {
            //VARIABILI
            List<ClsGestire> _listaGestire = new List<ClsGestire>();
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo la query
                string _query = "SELECT * FROM gestire";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, connection);

                //Eseguo il comando creando l'oggetto DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if (_dataReader.HasRows) //Controllo se la tabella contiene dei record
                {
                    while (_dataReader.Read()) //Se ce li ha li leggo tutti
                    {
                        //Carico i dati dal DB
                        ClsGestire _gestire = new ClsGestire();
                        _gestire.ID = (long)_dataReader["ID"];
                        _gestire.NegozioID = (long)_dataReader["negozioID"];
                        _gestire.UtenteUsername = _dataReader["utenteusername"].ToString();

                        _listaGestire.Add(_gestire);
                    }
                }

                _dataReader.Close();

                comunicazione = "Relazioni di tipo gestire caricate correttamente dal DataBase";
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

            return _listaGestire;
        }

        public static List<ClsStrumentoMusicale> GetSomeGestire(ref MySqlConnection connection, out string comunicazione, string username)
        {
            //VARIABILI
            comunicazione = String.Empty;
            List<ClsGestire> _listGestire = new List<ClsGestire>();

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo la query
                string _query = "SELECT * from gestire WHERE usernameutente = @usernameutente";
                //Posso ricercare per un solo campo alla volta perciò li controllo nell'ordine: casaProduttriceID, modello, colori)

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@usernameutente", username);

                //Eseguo il comando creando il DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if (_dataReader.HasRows) //Controllo se la tabella ha dei record
                {
                    while (_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        //Carico i dati dal DB
                        _listGestire.Add(CaricaSingoloGestire(ref _dataReader));
                    }
                }

                _dataReader.Close();

                comunicazione = "Strumenti musicali caricati correttamente dal DataBase";
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

            return _listGestire;
        }

        public static ClsStrumentoMusicale CaricaSingoloGestire(ref MySqlDataReader dataReader)
        {
            ClsStrumentoMusicale _strumentoMusicale = new ClsStrumentoMusicale();

            _strumentoMusicale.ID = Convert.ToInt64(dataReader["ID"]);

            _strumentoMusicale.CasaProduttriceID = Convert.ToInt64(dataReader["casaproduttriceID"]);

            if (dataReader["colori"] == DBNull.Value)
            {
                _strumentoMusicale.Colori = null;
            }
            else
            {
                _strumentoMusicale.Colori = dataReader["colori"].ToString();
            }

            if (dataReader["pathimmagine"] == DBNull.Value)
            {
                _strumentoMusicale.Immagine = null;
            }
            else
            {
                _strumentoMusicale.Immagine = dataReader["pathimmagine"].ToString();
            }

            _strumentoMusicale.Modello = dataReader["modello"].ToString();

            if (dataReader["notamassimaID"] == DBNull.Value)
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
    }
}
