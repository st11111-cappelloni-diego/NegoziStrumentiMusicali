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
    public static class ClsVendereBL
    {
        /// <summary>
        /// Inserimento di un record in vendere
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="vendere">Record da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>L'ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertVendere(ref MySqlConnection connection, ClsVendere vendere, out string comunicazione)
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
                    "INSERT into vendere " +
                    "(quantita, prezzo, strumentoMusicaleID, negozioID) " +
                    "VALUES(@quantita, @prezzo, @strumentoMusicaleID, @negozioID)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@quantita", vendere.Quantita);
                _cmd.Parameters.AddWithValue("@prezzo", vendere.Prezzo);
                _cmd.Parameters.AddWithValue("@strumentoMusicaleID", vendere.StrumentoMusicaleID);
                _cmd.Parameters.AddWithValue("@negozioID", vendere.NegozioID);


                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando è stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                comunicazione = "Relazione di tipo vendere inserita con successo nel DataBase";

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
        /// Update di un record di vendere
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="vendere">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateVendere(ref MySqlConnection connection, ClsVendere vendere, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando dml
                string _dml =
                    "UPDATE vendere SET " +
                    "quantita = @quantita, " +
                    "prezzo = @prezzo, " +
                    "strumentoMusicaleID = @strumentoMusicaleID, " +
                    "negozioID = @negozioID " +
                    "WHERE ID = @ID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@quantita", vendere.Quantita);
                _cmd.Parameters.AddWithValue("@prezzo", vendere.Prezzo);
                _cmd.Parameters.AddWithValue("@strumentoMusicaleID", vendere.StrumentoMusicaleID);
                _cmd.Parameters.AddWithValue("@negozioID", vendere.NegozioID);
                _cmd.Parameters.AddWithValue("@ID", vendere.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Relazione di tipo vendere aggiornata correttamente nel DataBase";
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
        /// Carica i dati dal DataReader ad un'istanza di ClsVendere
        /// </summary>
        /// <param name="dataReader"></param>
        /// <returns></returns>
        private static ClsVendere CaricaSingolaVendere(ref MySqlDataReader dataReader)
        {
            ClsVendere _vendere = new ClsVendere();

            _vendere.ID = Convert.ToInt64(dataReader["ID"]);
            _vendere.NegozioID = Convert.ToInt64(dataReader["negozioID"]);
            _vendere.StrumentoMusicaleID = Convert.ToInt64(dataReader["strumentomusicaleID"]);

            return _vendere;
        }
        /// <summary>
        /// Caricamento di alcuni record di strumentimusicali in base a negozioID o strumentoMusicaleID.
        /// Escludi negozioID passando come valore -1, escludi strumentoMusicaleID passando come valore -1
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="negozioID"></param>
        /// <param name="strumentoMusicaleID"></param>
        /// <param name="comunicazione"></param>
        /// <returns></returns>
        public static List<ClsVendere> GetSomeVendere(ref MySqlConnection connection, long negozioID, long strumentoMusicaleID, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;
            List<ClsVendere> _listaVendere = new List<ClsVendere>();

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo la query
                string _query = "SELECT * FROM vendere WHERE ";
                //Posso cercare per un valore alla volta quindi controllo in questo ordine: negozioID, strumentoMusicaleID
                if(negozioID > -1)
                {
                    //Il campo per cui cercare è negozioID
                    _query += "negozioID = @negozioID";
                }
                else
                {
                    //Il campo per cui cercare è strumentoMusicaleID
                    _query += "strumentomusicaleID = @strumentomusicaleID";
                }

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, connection);

                //Inserisco i valori
                //Posso cercare per un valore alla volta quindi controllo in questo ordine: negozioID, strumentoMusicaleID
                if (negozioID > -1)
                {
                    //Il campo per cui cercare è negozioID                   
                    _cmd.Parameters.AddWithValue("@negozioID", negozioID);
                }
                else
                {
                    //Il campo per cui cercare è strumentoMusicaleID
                    _cmd.Parameters.AddWithValue("@strumentomusicaleID", strumentoMusicaleID);
                }

                //Eseguo il comando creando il DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if(_dataReader.HasRows) //Controllo se la tabella ha record
                {
                    while(_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        _listaVendere.Add(CaricaSingolaVendere(ref _dataReader));
                    }
                }

                _dataReader.Close();

                comunicazione = "Relazioni di tipo vendere caricate correttamente dal DataBase";
            }
            catch(Exception ex)
            {
                comunicazione = ex.Message;
                _listaVendere = null;
            }
            finally
            {
                //Chiudo la connessione
                connection.Close();
            }

            return _listaVendere;
        }
    }
}
