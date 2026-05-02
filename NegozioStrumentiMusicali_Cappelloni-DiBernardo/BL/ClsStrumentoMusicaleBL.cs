using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

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
        /// Caricamento di tutti i record di strumentimusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>La lista di tutti i record di strumentimusicali</returns>
        public static List<ClsStrumentoMusicale> SelectAllStrumentiMusicali(ref MySqlConnection connection, out string comunicazione)
        {
            //VARIABILI
            DataTable _dataTable = new DataTable();
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
                        ClsStrumentoMusicale _strumentoMusicale = new ClsStrumentoMusicale();
                        _strumentoMusicale.ID = (long)_dataReader["ID"];
                        _strumentoMusicale.CasaProduttriceID = (int)_dataReader["casaproduttriceID"];
                        _strumentoMusicale.Colori = _dataReader["colori"].ToString();
                        _strumentoMusicale.Immagine = _dataReader["pathimmagine"].ToString();
                        _strumentoMusicale.Modello = _dataReader["modello"].ToString();
                        _strumentoMusicale.NotaMassimaID = (long)_dataReader["notamassimaID"];
                        _strumentoMusicale.NotaMinimaID = (long)_dataReader["notaminimaID"];
                        _strumentoMusicale.PesoKG = (float)_dataReader["pesokg"];
                        _strumentiMusicali.Add(_strumentoMusicale);
                    }
                }

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
