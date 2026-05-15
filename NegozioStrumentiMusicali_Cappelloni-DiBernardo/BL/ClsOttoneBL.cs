using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace NegozioStrumentiMusicali
{
    /// <summary>
    /// Sviluppata da Diego Cappelloni
    /// </summary>
    public static class ClsOttoneBL
    {
        /// <summary>
        /// Inserimento di record in ottoni + informazioni generali in strumentimusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="ottone">Oggetto da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertOttone(ref MySqlConnection connection, ClsOttone ottone, out string comunicazione)
        {
            //VARIABILI LOCALI
            long _ID = -1;
            comunicazione = String.Empty;

            try
            {
                //Inserisco le informazioni generali in strumentimusicali
                _ID = ClsStrumentoMusicaleBL.InsertStrumentoMusicale(ref connection, ottone, out comunicazione);

                //Riapro la connessione dopo che si è chiusa in InsertStrumentoMusicale
                connection.Open();

                //Creo il comando DML
                string _dml =
                    "INSERT into ottoni " +
                    "(strumentomusicaleID, strumento, materialecorpo, laccatura, placcatura, materialebocchino," +
                    "rivestimentobocchino, lunghezzacm, larghezzacm, altezzacm) " +
                    "VALUES(@strumentomusicaleID, @strumento, @materialecorpo, @laccatura, @placcatura, @materialebocchino," +
                    "@rivestimentobocchino, @lunghezzacm, @larghezzacm, @altezzacm";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@strumentomusicaleID", _ID); //Prima di inserire lo strumento a corda bisogna inserire lo strumento musicale ad esso associato
                _cmd.Parameters.AddWithValue("@strumento", ottone.Strumento.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materialecorpo", ottone.MaterialeCorpo.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@laccatura", ottone.Laccatura.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@placcatura", ottone.Placcatura.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materialebocchino", ottone.MaterialeBocchino.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@rivestimentobocchino", ottone.RivestimentoBocchino.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@lunghezzacm", ottone.LunghezzaCM);
                _cmd.Parameters.AddWithValue("@larghezzacm", ottone.LarghezzaCM);
                _cmd.Parameters.AddWithValue("@altezzacm", ottone.AltezzaCM);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Strumento della famiglia degli ottoni inserito con successo nel DataBase";
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
        /// Update di un record in ottoni + dettagli generali in strumentimusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="ottone">Dati record da aggiornare</param>
        /// <param name="comunicazione">Stringa di comunicazione in uscita</param>
        public static void UpdateOttone(ref MySqlConnection connection, ClsOttone ottone, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Aggiorno le info generali in strumentimusicali
                ClsStrumentoMusicaleBL.UpdateStrumentoMusicale(ref connection, ottone, out comunicazione);

                //Riapro la connessione dopo che si è chiusa in UpdateStrumentoMusicale
                connection.Open();

                //Compongo il comando dml
                string _dml =
                    "UPDATE ottoni " +
                    "SET strumento = @strumento, " +
                    "materialecorpo = @materialecorpo, " +
                    "laccatura = @laccatura, " +
                    "placcatura = @placcatura, " +
                    "materialebocchino = @materialebocchino, " +
                    "rivestimentobocchino = @rivestimentobocchino, " +
                    "lunghezzacm = @lunghezzacm, " +
                    "larghezzacm = @larghezzacm, " +
                    "altezzacm = @altezzacm " +
                    "WHERE strumentomusicaleID = @ID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@strumentomusicaleID", ottone.ID);
                _cmd.Parameters.AddWithValue("@strumento", ottone.Strumento.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materialecorpo", ottone.MaterialeCorpo.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@laccatura", ottone.Laccatura.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@placcatura", ottone.Placcatura.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materialebocchino", ottone.MaterialeBocchino.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@rivestimentobocchino", ottone.RivestimentoBocchino.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@lunghezzacm", ottone.LunghezzaCM);
                _cmd.Parameters.AddWithValue("@larghezzacm", ottone.LarghezzaCM);
                _cmd.Parameters.AddWithValue("@altezzacm", ottone.AltezzaCM);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Strumento della famiglia degli ottoni aggiornato correttamente nel DataBase";
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
        /// Eliminazione di un record da ottoni
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="ottone">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void DeleteOttone(ref MySqlConnection connection, ClsOttone ottone, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml = "DELETE FROM ottoni WHERE strumentomusicaleID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", ottone.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Strumento della famiglia degli ottoni eliminato correttamente dal DataBase";
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
        /// Caricamento dei dati dal DataReader (che legge record di ottoni) ad un'istanza di ClsOttone
        /// </summary>
        /// <param name="dataReader"></param>
        /// <returns></returns>
        private static ClsOttone CaricaSingoloOttone(ref MySqlDataReader dataReader, bool caricaStrumentoMusicaleID)
        {
            ClsOttone _ottone = new ClsOttone();


            if(caricaStrumentoMusicaleID)
            {
                _ottone.ID = Convert.ToInt64(dataReader["strumentomusicaleID"]);
            }

            _ottone.AltezzaCM = Convert.ToSingle(dataReader["altezzacm"]);

            _ottone.LunghezzaCM = Convert.ToSingle(dataReader["lunghezzacm"]);

            _ottone.LarghezzaCM = Convert.ToSingle(dataReader["larghezzacm"]);

            _ottone.Laccatura = (ClsOttone.eTIPO_LACCATURA)Enum.Parse
            (
                typeof(ClsOttone.eTIPO_LACCATURA),
                dataReader["laccatura"].ToString()
            );

            _ottone.Placcatura = (ClsOttone.eTIPO_PLACCATURA)Enum.Parse
            (
                typeof(ClsOttone.eTIPO_PLACCATURA),
                dataReader["placcatura"].ToString()
            );

            _ottone.MaterialeCorpo = (ClsOttone.eTIPO_OTTONE)Enum.Parse
            (
                typeof(ClsOttone.eTIPO_OTTONE),
                dataReader["materialecorpo"].ToString()
            );

            _ottone.Strumento = (ClsOttone.eOTTONI)Enum.Parse
            (
                typeof(ClsOttone.eOTTONI),
                dataReader["strumento"].ToString()
            );

            _ottone.MaterialeBocchino = (ClsOttone.eMATERIALE_BOCCHINO)Enum.Parse
            (
                typeof(ClsOttone.eMATERIALE_BOCCHINO),
                dataReader["materialebocchino"].ToString()
            );

            _ottone.RivestimentoBocchino = (ClsOttone.eRIVESTIMENTO_BOCCHINO)Enum.Parse
            (
                typeof(ClsOttone.eRIVESTIMENTO_BOCCHINO),
                dataReader["rivestimentobocchino"].ToString()
            );


            return _ottone;
        }
        /// <summary>
        /// Caricamento dei dati dal DataReader (che legge join di strumentimusicali + ottoni) ad un'istanza di ClsOttone
        /// </summary>
        /// <param name="dataReader"></param>
        /// <returns></returns>
        private static ClsOttone CaricaSingoloStrumentoOttone(ref MySqlDataReader dataReader, bool caricaStrumentoMusicaleID)
        {
            ClsOttone _ottone = new ClsOttone();
            ClsStrumentoMusicale _strumento = new ClsStrumentoMusicale();

            _ottone = CaricaSingoloOttone(ref dataReader, caricaStrumentoMusicaleID);
            _strumento = ClsStrumentoMusicaleBL.CaricaSingoloStrumento(ref dataReader);

            _ottone = MergeStrumentoOttone(_strumento, _ottone);
        
            return _ottone;
        }
        /// <summary>
        /// Mette in un istanza di ClsOttone dati di generalizzazione da strumento e dati di specializzazione da ottone
        /// </summary>
        /// <param name="strumento"></param>
        /// <param name="ottone"></param>
        /// <returns></returns>
        private static ClsOttone MergeStrumentoOttone(ClsStrumentoMusicale strumento, ClsOttone ottone)
        {
            ClsOttone _ottoneFinale = ottone;

            _ottoneFinale.Colori = strumento.Colori;
            _ottoneFinale.CasaProduttriceID = strumento.CasaProduttriceID;
            _ottoneFinale.Immagine = strumento.Immagine;
            _ottoneFinale.PesoKG = strumento.PesoKG;
            _ottoneFinale.NotaMassimaID = strumento.NotaMassimaID;
            _ottoneFinale.NotaMinimaID = strumento.NotaMinimaID;
            _ottoneFinale.Modello = strumento.Modello;

            return _ottoneFinale;
        }
        /// <summary>
        /// Prende tutti i record di ottoni con anche le informazione della generalizzazione da strumentimusicali
        /// </summary>
        /// <param name="stringaDiConnessione">Stringa per la connessione al DB</param>
        /// <param name="ordinaPerPiuRecente">Se true, ordina per ID in maniera decrescente. Se false ordina per ID in maniera crescente</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <param name="limiteRecord">Numero massimo di record da caricare. Accetta valori da 2 in su</param>
        /// <returns>La lista con tutti i record. Se è nulla il caricamento non è andato a buon fine</returns>
        public static List<ClsOttone> GetAllOttoni(string stringaDiConnessione, bool ordinaPerPiuRecente, out string comunicazione, int limiteRecord = 0)
        {
            //VARIABILI
            comunicazione = String.Empty;
            List<ClsOttone> _ottoni = new List<ClsOttone>();
            MySqlConnection _connection = new MySqlConnection(stringaDiConnessione);

            try
            {
                //Apro la connessione
                _connection.Open();

                //Creo la query con la join tra strumentimusicali e ottoni
                //Abbino le righe in base a ID <-> strumentomusicaleID
                string _query = "SELECT strumentimusicali.*, " +
                    "ottoni.strumento, " +
                    "ottoni.materialecorpo, " +
                    "ottoni.laccatura, " +
                    "ottoni.placcatura, " +
                    "ottoni.materialebocchino, " +
                    "ottoni.rivestimentobocchino, " +
                    "ottoni.lunghezzacm, " +
                    "ottoni.larghezzacm, " +
                    "ottoni.altezzacm " +
                    "FROM strumentimusicali AS S JOIN ottoni AS O " +
                    "ON S.ID = O.strumentomusicaleID " +
                    "ORDER BY S.ID ";

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

                if(_dataReader.HasRows) //Controllo se la view ha dei record
                {
                    while(_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        _ottoni.Add(CaricaSingoloStrumentoOttone(ref _dataReader, false));
                    }
                }

                _dataReader.Close();

                comunicazione = "Strumenti della famiglia degli ottoni caricati correttamente dal DataBase";
            }
            catch(Exception ex)
            {
                comunicazione = ex.Message;
                _ottoni = null;
            }
            finally
            {
                //Chiudo la connessione
                _connection.Close();
            }

            return _ottoni;
        }
    }
}
