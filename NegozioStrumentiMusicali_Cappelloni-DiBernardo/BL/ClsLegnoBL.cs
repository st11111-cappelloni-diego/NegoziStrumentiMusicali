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
    public static class ClsLegnoBL
    {
        /// <summary>
        /// Inserimento di record in legni + informazioni generali in strumentimusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="legno">Oggetto da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertLegno(ref MySqlConnection connection, ClsLegno legno, out string comunicazione)
        {
            //VARIABILI LOCALI
            long _ID = -1;
            comunicazione = String.Empty;

            try
            {
                //Inserisco le informazioni generali in strumentimusicali
                _ID = ClsStrumentoMusicaleBL.InsertStrumentoMusicale(ref connection, legno, out comunicazione);

                //Riapro la connessione dopo che si è chiusa in InsertStrumentoMusicale
                connection.Open();

                //Compongo il comando DML per info specifiche legno
                string _dml =
                    "INSERT into legni (strumentomusicaleID, strumento, materialecorpo, materialechiavi, lunghezzacm, larghezzacm, altezzacm) " +
                    "VALUES(@strumentomusicaleID, @strumento, @materialecorpo, @materialechiavi, @lunghezzacm, @larghezzacm, @altezzacm)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@strumentomusicaleID", legno.ID);
                _cmd.Parameters.AddWithValue("@strumento", legno.Strumento.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materialecorpo", legno.MaterialeCorpo.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materialechiavi", legno.MaterialeChiavi.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@lunghezzacm", legno.LunghezzaCM);
                _cmd.Parameters.AddWithValue("@larghezzacm", legno.LarghezzaCM);
                _cmd.Parameters.AddWithValue("@altezzacm", legno.AltezzaCM);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Strumento della famiglia dei legni inserito correttamente nel DataBase";
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
        /// Update di un record di legni + dettagli generali in strumentimusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="legno">Dati record da aggiornare</param>
        /// <param name="comunicazione">Stringa di comunicazione in uscita</param>
        public static void UpdateLegno(ref MySqlConnection connection, ClsLegno legno, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Aggiorno le info generali in strumentimusicali
                ClsStrumentoMusicaleBL.UpdateStrumentoMusicale(ref connection, legno, out comunicazione);

                //Riapro la connessione dopo che si è chiusa in UpdateStrumentoMusicale
                connection.Open();

                //Compongo il comando DML
                string _dml =
                    "UPDATE legni " +
                    "SET strumento = @strumento, " +
                    "materialecorpo = @materialecorpo, " +
                    "materialechiavi = @materialechiavi, " +
                    "lunghezzacm = @lunghezzacm, " +
                    "larghezzacm = @larghezzacm, " +
                    "altezzacm = @altezzacm " +
                    "WHERE strumentomusicaleID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@strumento", legno.Strumento.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materialecorpo", legno.MaterialeCorpo.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materialechiavi", legno.MaterialeChiavi.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@lunghezzacm", legno.LunghezzaCM);
                _cmd.Parameters.AddWithValue("@larghezzacm", legno.LarghezzaCM);
                _cmd.Parameters.AddWithValue("@altezzacm", legno.AltezzaCM);
                _cmd.Parameters.AddWithValue("@ID", legno.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Strumento della famiglia legni aggiornato correttamente nel DataBase";
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
        /// Eliminazione di un record da legni
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="legno">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void DeleteLegno(ref MySqlConnection connection, ClsLegno legno, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml = "DELETE FROM legni WHERE strumentomusicaleID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", legno.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Strumento della famiglia dei legni eliminato correttamente dal DataBase";
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
        /// Caricamento dei dati dal DataReader (che legge record di legni) ad un'istanza di Clslegno
        /// </summary>
        /// <param name="dataReader"></param>
        /// <param name="caricaStrumentoMusicaleID"></param>
        /// <returns></returns>
        private static ClsLegno CaricaSingoloLegno(ref MySqlDataReader dataReader, bool caricaStrumentoMusicaleID)
        {
            ClsLegno _legno = new ClsLegno();

            if (caricaStrumentoMusicaleID)
            {
                _legno.ID = Convert.ToInt64(dataReader["strumentomusicaleID"]);
            }

            _legno.Strumento = (ClsLegno.eLEGNI)Enum.Parse
            (
                typeof(ClsLegno.eLEGNI),
                dataReader["strumento"].ToString()
            );

            _legno.MaterialeCorpo = (ClsLegno.eMATERIALE_CORPO_LEGNI)Enum.Parse
            (
                typeof(ClsLegno.eMATERIALE_CORPO_LEGNI),
                dataReader["materialecorpo"].ToString()
            );

            _legno.MaterialeChiavi = (ClsLegno.eMATERIALE_CHIAVI)Enum.Parse
            (
                typeof(ClsLegno.eMATERIALE_CHIAVI),
                dataReader["materialechiavi"].ToString()
            );

            _legno.LunghezzaCM = Convert.ToSingle(dataReader["lunghezzacm"]);

            _legno.LarghezzaCM = Convert.ToSingle(dataReader["larghezzacm"]);

            _legno.AltezzaCM = Convert.ToSingle(dataReader["altezzacm"]);


            return _legno;
        }
        /// <summary>
        /// Caricamento dei dati dal DataReader (che legge join o view di strumentimusicali + strumentiacorda) ad un'istanza di ClsOttone
        /// </summary>
        /// <param name="dataReader"></param>
        /// <returns></returns>
        private static ClsLegno CaricaSingoloStrumentoLegno(ref MySqlDataReader dataReader, bool caricaCasaProduttriceID)
        {
            ClsLegno _legno = new ClsLegno();
            ClsStrumentoMusicale _strumento = new ClsStrumentoMusicale();

            _legno = CaricaSingoloLegno(ref dataReader, caricaCasaProduttriceID);
            _strumento = ClsStrumentoMusicaleBL.CaricaSingoloStrumento(ref dataReader);

            _legno = MergeStrumentoLegno(_strumento, _legno);

            return _legno;
        }
        /// <summary>
        /// Mette in un istanza di ClsLegno dati di generalizzazione da strumento e dati di specializzazione da legno
        /// </summary>
        /// <param name="strumento"></param>
        /// <param name="legno"></param>
        /// <returns></returns>
        private static ClsLegno MergeStrumentoLegno(ClsStrumentoMusicale strumento, ClsLegno legno)
        {
            ClsLegno _legnoFinale = legno;

            _legnoFinale.Colori = strumento.Colori;
            _legnoFinale.CasaProduttriceID = strumento.CasaProduttriceID;
            _legnoFinale.Immagine = strumento.Immagine;
            _legnoFinale.PesoKG = strumento.PesoKG;
            _legnoFinale.NotaMassimaID = strumento.NotaMassimaID;
            _legnoFinale.NotaMinimaID = strumento.NotaMinimaID;
            _legnoFinale.Modello = strumento.Modello;

            return _legnoFinale;
        }
        /// <summary>
        /// Prende tutti i record di pianoforti con anche le informazione della generalizzazione da strumentimusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="ordinaPerPiuRecente">Se true, ordina per ID in maniera decrescente. Se false ordina per ID in maniera crescente</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <param name="limiteRecord">Numero massimo di record da caricare. Accetta valori da 2 in su</param>
        /// <returns>La lista con tutti i record. Se è nulla il caricamento non è andato a buon fine</returns>
        public static List<ClsLegno> GetAllLegni(ref MySqlConnection connection, bool ordinaPerPiuRecente, out string comunicazione, int limiteRecord = 0)
        {
            //VARIABILI
            comunicazione = String.Empty;
            List<ClsLegno> _legni = new List<ClsLegno>();

            try
            {
                //Apro la connessione
                connection.Open();

                //Creo la query con la join tra strumentimusicali e legni
                //Abbino le righe in base a ID <-> strumentomusicaleID
                string _query = "SELECT strumentimusicali.*, " +
                    "legni.strumento, " +
                    "legni.materialecorpo, " +
                    "legni.materialechiavi, " +
                    "legni.lunghezzacm," +
                    "legni.larghezzacm," +
                    "legni.altezzacm " +
                    "FROM strumentimusicali AS S JOIN legni AS L " +
                    "ON S.ID = L.strumentomusicaleID " +
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
                MySqlCommand _cmd = new MySqlCommand(_query, connection);

                //Inserisco il limite se richiesto
                if (limiteRecord >= 2)
                {
                    _cmd.Parameters.AddWithValue("@limite", limiteRecord);
                }

                //Eseguo il comando creando il DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if (_dataReader.HasRows) //Controllo se la view ha dei record
                {
                    while (_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        _legni.Add(CaricaSingoloStrumentoLegno(ref _dataReader, false));
                    }
                }

                _dataReader.Close();

                comunicazione = "Strumenti della famiglia dei legni caricati correttamente dal DataBase";
            }
            catch (Exception ex)
            {
                comunicazione = ex.Message;
                _legni = null;
            }
            finally
            {
                //Chiudo la connessione
                connection.Close();
            }

            return _legni;
        }
    }
}
