using MySqlConnector;
using System;
using System.Collections.Generic;

namespace NegozioStrumentiMusicali
{
    /// <summary>
    /// Sviluppato da Diego Cappelloni
    /// </summary>
    public static class ClsBatteriaBL
    {
        /// <summary>
        /// Inserimento di record in batterie + informazioni generali in strumentimusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="batteria">Oggetto da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertBatteria(ref MySqlConnection connection, ClsBatteria batteria, out string comunicazione)
        {
            //VARIABILI GLOBALI
            comunicazione = String.Empty;
            long _ID = -1;

            try
            {
                //Inserisco le informazione generali in strumentimusicali
                _ID = ClsStrumentoMusicaleBL.InsertStrumentoMusicale(ref connection, batteria, out comunicazione);

                //Riapro la connessione dopo che si è chiusa in InsertStrumentoMusicale
                connection.Open();

                //Compongo il comando DML
                string _dml = "INSERT into batterie (strumentomusicaleID) VALUES (@strumentomusicaleID)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@strumentomusicaleID", batteria.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Batteria inserita con successo nel DataBase";
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

            return _ID;
        }
        /// <summary>
        /// Update di un record di batterie + dettagli generali in strumentimusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="batteria">Dati record da aggiornare</param>
        /// <param name="comunicazione">Stringa di comunicazione in uscita</param>
        public static void UpdateBatteria(ref MySqlConnection connection, ClsBatteria batteria, out string comunicazione)
        {
            //VARIABILI 
            comunicazione = String.Empty;

            try
            {
                //Aggiorno le informazioni generali in strumentimusicali
                ClsStrumentoMusicaleBL.UpdateStrumentoMusicale(ref connection, batteria, out comunicazione);
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
        /// Elimina un record da batterie
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="batteria">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void DeleteBatteria(ref MySqlConnection connection, ClsBatteria batteria, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml = "DELETE FROM batterie WHERE strumentomusicaleID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", batteria.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Batteria eliminata correttamente dal DataBase";
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
        /// Caricamento dei dati dal DataReader (che legge record di batterie) ad un'istanza di ClsBatteria
        /// </summary>
        /// <param name="dataReader"></param>
        /// <param name="caricaStrumentoMusicaleID"></param>
        /// <returns></returns>
        private static ClsBatteria CaricaSingolaBatteria(ref MySqlDataReader dataReader, bool caricaStrumentoMusicaleID)
        {
            ClsBatteria _batteria = new ClsBatteria();

            if (caricaStrumentoMusicaleID)
            {
                _batteria.ID = Convert.ToInt64(dataReader["strumentomusicaleID"]);
            }

            return _batteria;
        }
        /// <summary>
        /// Caricamento dei dati dal DataReader (che legge join di strumentimusicali + batterie) ad un'istanza di ClsBatteria
        /// </summary>
        /// <param name="dataReader"></param>
        /// <returns></returns>
        private static ClsBatteria CaricaSingoloStrumentoBatteria(ref MySqlDataReader dataReader, bool caricaStrumentoMusicaleID)
        {
            ClsBatteria _batteria = new ClsBatteria();
            ClsStrumentoMusicale _strumento = new ClsStrumentoMusicale();

            _batteria = CaricaSingolaBatteria(ref dataReader, caricaStrumentoMusicaleID);
            _strumento = ClsStrumentoMusicaleBL.CaricaSingoloStrumento(ref dataReader);

            _batteria = MergeStrumentoBatteria(_strumento, _batteria);

            return _batteria;
        }
        /// <summary>
        /// Mette in un istanza di ClSBatteria dati di generalizzazione da strumento e dati di specializzazione da batteria
        /// </summary>
        /// <param name="strumento"></param>
        /// <param name="ottone"></param>
        /// <returns></returns>
        private static ClsBatteria MergeStrumentoBatteria(ClsStrumentoMusicale strumento, ClsBatteria batteria)
        {
            ClsBatteria _batteria = batteria;

            _batteria.ID = strumento.ID;
            _batteria.Colori = strumento.Colori;
            _batteria.CasaProduttriceID = strumento.CasaProduttriceID;
            _batteria.Immagine = strumento.Immagine;
            _batteria.PesoKG = strumento.PesoKG;
            _batteria.NotaMassimaID = strumento.NotaMassimaID;
            _batteria.NotaMinimaID = strumento.NotaMinimaID;
            _batteria.Modello = strumento.Modello;

            return _batteria;
        }
        /// <summary>
        /// Prende tutti i record di batterie con anche le informazione della generalizzazione da strumentimusicali
        /// </summary>
        /// <param name="stringaDiConnessione">Connessione al DB</param>
        /// <param name="ordinaPerPiuRecente">Se true, ordina per ID in maniera decrescente. Se false ordina per ID in maniera crescente</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <param name="limiteRecord">Numero massimo di record da caricare. Accetta valori da 2 in su</param>
        /// <returns>La lista con tutti i record. Se è nulla il caricamento non è andato a buon fine</returns>
        public static List<ClsBatteria> GetAllBatterie(string stringaDiConnessione, bool ordinaPerPiuRecente, out string comunicazione, int limiteRecord = 0)
        {
            //VARIABILI
            comunicazione = String.Empty;
            List<ClsBatteria> _batterie = null;
            MySqlConnection _connection = new MySqlConnection(stringaDiConnessione);

            try
            {
                //Apro la connessione
                _connection.Open();

                //Compongo la query
                string _query = 
                    "SELECT S.* FROM strumentimusicali AS S JOIN " +
                    "batterie AS B ON S.ID = B.strumentomusicaleID " +
                    "ORDER BY ID ";

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

                if (_dataReader.HasRows) //Controllo se la join ha dei record
                {
                    _batterie = new List<ClsBatteria>();
                    while (_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        _batterie.Add(CaricaSingoloStrumentoBatteria(ref _dataReader, false));
                    }
                }

                _dataReader.Close();

                comunicazione = "Batterie caricate correttamente dal DataBase";
            }
            catch(Exception ex)
            {
                comunicazione = ex.Message;
                _batterie = null;
            }
            finally
            {
                //Chiudo la connessione
                _connection.Close();
            }

            return _batterie;
        }
    }
}
