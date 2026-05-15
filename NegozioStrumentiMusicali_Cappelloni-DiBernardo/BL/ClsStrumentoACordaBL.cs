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
    public static class ClsStrumentoACordaBL
    {
        /// <summary>
        /// Inserimento di record in strumentiacorda + informazioni generali in strumentimusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="strumentoACorda">Oggetto da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertStrumentoACorda(ref MySqlConnection connection, ClsStrumentoACorda strumentoACorda, out string comunicazione)
        {
            //VARIABILI LOCALI
            long _ID = -1;
            comunicazione = String.Empty;

            try
            {
                //Inserisco le informazioni generali in strumentimusicali
                _ID = ClsStrumentoMusicaleBL.InsertStrumentoMusicale(ref connection, strumentoACorda, out comunicazione);

                //Riapro la connessione dopo che si è chiusa in InsertStrumentoMusicale
                connection.Open();

                //Creo il comando DML
                string _dml =
                    "INSERT into strumentiacorda " +
                    "(strumentomusicaleID, strumento, numerocorde, lunghezzamanicocm, ampiezzamanicocm, spessoremanicocm," +
                    "materialemanico, materialetastiera, lunghezzacorpocm, ampiezzacorpocm, spessorecorpocm, materialecorpo," +
                    "tasti, pickup1, pickup2, pickup3)" +
                    "VALUES (@strumentomusicaleID, @strumento, @numerocorde, @lunghezzamanicocm, @ampiezzamanicocm, @spessoremanicocm," +
                    "@materialemanico, @materialetastiera, @lunghezzacorpocm, @ampiezzacorpocm, @spessorecorpocm, @materialecorpo," +
                    "@tasti, @pickup1, @pickup2, @pickup3)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@strumentomusicaleID", _ID); //Prima di inserire lo strumento a corda bisogna inserire lo strumento musicale ad esso associato
                _cmd.Parameters.AddWithValue("@strumento", strumentoACorda.Strumento.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@numerocorde", strumentoACorda.NumeroCorde);
                _cmd.Parameters.AddWithValue("@lunghezzamanicocm", strumentoACorda.LunghezzaManicoCM);
                _cmd.Parameters.AddWithValue("@ampiezzamanicocm", strumentoACorda.AmpiezzaManicoCM);
                _cmd.Parameters.AddWithValue("@spessoremanicocm", strumentoACorda.SpessoreManicoCM);
                _cmd.Parameters.AddWithValue("@materialemanico", strumentoACorda.MaterialeManico.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materialetastiera", strumentoACorda.MaterialeTastiera.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@lunghezzacorpocm", strumentoACorda.LunghezzaCorpoCM);
                _cmd.Parameters.AddWithValue("@ampiezzacorpocm", strumentoACorda.AmpiezzaCorpoCM);
                _cmd.Parameters.AddWithValue("@spessorecorpocm", strumentoACorda.SpessoreCorpoCM);
                _cmd.Parameters.AddWithValue("@materialecorpo", strumentoACorda.MaterialeCorpo.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@tasti", strumentoACorda.Tasti);
                _cmd.Parameters.AddWithValue("@pickup1", strumentoACorda.Pickup1.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@pickup2", strumentoACorda.Pickup2.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@pickup3", strumentoACorda.Pickup3.ToString().ToLower());

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Strumento a corda inserito con successo nel DataBase";
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
        /// Update di un record in strumentiacorda + dettagli generali in strumentimusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="strumentoACorda">Oggetto da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateStrumentoACorda(ref MySqlConnection connection, ClsStrumentoACorda strumentoACorda, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Aggiorno le info generali in strumentimusicali
                ClsStrumentoMusicaleBL.UpdateStrumentoMusicale(ref connection, strumentoACorda, out comunicazione);

                //Riapro la connessione dopo che si è chiusa in UpdateStrumentoMusicale
                connection.Open();

                //Compongo il comando dml
                string _dml =
                    "UPDATE strumentiacorda " +
                    "SET strumento = @strumento, " +
                    "numerocorde = @numerocorde, " +
                    "lunghezzamanicocm = @lunghezzamanicocm, " +
                    "ampiezzamanicocm = @ampiezzamanicocm, " +
                    "spessoremanicocm = @spessoremanicocm, " +
                    "materialemanico = @materialemanico, " +
                    "materialetastiera = @materialetastiera, " +
                    "lunghezzacorpocm = @lunghezzacorpocm, " +
                    "ampiezzacorpocm = @ampiezzacorpocm, " +
                    "spessorecorpocm = @spessorecorpocm, " +
                    "materialecorpo = @materialecorpo, " +
                    "tasti = @tasti, " +
                    "pickup1 = @pickup1, " +
                    "pickup2 = @pickup2, " +
                    "pickup3 = @pickup3 " +
                    "WHERE strumentomusicaleID = @ID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@strumento", strumentoACorda.Strumento.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@numerocorde", strumentoACorda.NumeroCorde);
                _cmd.Parameters.AddWithValue("@lunghezzamanicocm", strumentoACorda.LunghezzaManicoCM);
                _cmd.Parameters.AddWithValue("@ampiezzamanicocm", strumentoACorda.AmpiezzaManicoCM);
                _cmd.Parameters.AddWithValue("@spessoremanicocm", strumentoACorda.SpessoreManicoCM);
                _cmd.Parameters.AddWithValue("@materialemanico", strumentoACorda.MaterialeManico.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materialetastiera", strumentoACorda.MaterialeTastiera.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@lunghezzacorpocm", strumentoACorda.LunghezzaCorpoCM);
                _cmd.Parameters.AddWithValue("@ampiezzacorpocm", strumentoACorda.AmpiezzaCorpoCM);
                _cmd.Parameters.AddWithValue("@spessorecorpocm", strumentoACorda.SpessoreCorpoCM);
                _cmd.Parameters.AddWithValue("@materialecorpo", strumentoACorda.MaterialeCorpo.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@tasti", strumentoACorda.Tasti);
                _cmd.Parameters.AddWithValue("@pickup1", strumentoACorda.Pickup1.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@pickup2", strumentoACorda.Pickup2.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@pickup3", strumentoACorda.Pickup3.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@ID", strumentoACorda.ID);


                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Pianoforte aggiornato correttamente nel DataBase";
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
        /// Eliminazione di un record da strumentiacorda
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="strumentoACorda">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void DeleteStrumentoACorda(ref MySqlConnection connection, ClsStrumentoACorda strumentoACorda, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml = "DELETE FROM strumentiacorda WHERE strumentomusicaleID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", strumentoACorda.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Strumento a corda eliminato correttamente dal DataBase";
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
        /// Caricamento dei dati dal DataReader (che legge record di strumentiacorda) ad un'istanza di ClsStrumentoACorda
        /// </summary>
        /// <param name="dataReader"></param>
        /// <param name="caricaStrumentoMusicaleID"></param>
        /// <returns></returns>
        private static ClsStrumentoACorda CaricaSingoloStrumentoACorda(ref MySqlDataReader dataReader, bool caricaStrumentoMusicaleID)
        {
            ClsStrumentoACorda _strumentoACorda = new ClsStrumentoACorda();

            if(caricaStrumentoMusicaleID)
            {
                _strumentoACorda.ID = Convert.ToInt64(dataReader["strumentomusicaleID"]);
            }

            _strumentoACorda.LunghezzaCorpoCM = Convert.ToSingle(dataReader["lunghezzacorpocm"]);

            _strumentoACorda.LunghezzaManicoCM = Convert.ToSingle(dataReader["lunghezzamanicocm"]);

            _strumentoACorda.SpessoreCorpoCM = Convert.ToSingle(dataReader["spessorecorpocm"]);

            _strumentoACorda.SpessoreManicoCM = Convert.ToSingle(dataReader["spessoremanicocm"]);

            if(dataReader["tasti"] == DBNull.Value)
            {
                _strumentoACorda.Tasti = -1;
            }
            else
            {
                _strumentoACorda.Tasti = Convert.ToSByte(dataReader["tasti"]);
            }

            _strumentoACorda.AmpiezzaCorpoCM = Convert.ToSingle(dataReader["ampiezzacorpocm"]);

            _strumentoACorda.AmpiezzaManicoCM = Convert.ToSingle(dataReader["ampiezzamanicocm"]);

            _strumentoACorda.Strumento = (ClsStrumentoACorda.eSTRUMENTI_A_CORDA)Enum.Parse
            (
                typeof(ClsStrumentoACorda.eSTRUMENTI_A_CORDA),
                dataReader["strumento"].ToString()
            );

            _strumentoACorda.MaterialeCorde = (ClsStrumentoACorda.eMATERIALE_CORDE)Enum.Parse
            (
                typeof(ClsStrumentoACorda.eMATERIALE_CORDE),
                dataReader["materialecorde"].ToString()
            );

            _strumentoACorda.MaterialeCorpo = (Program.eLEGNO)Enum.Parse
            (
                typeof(Program.eLEGNO),
                dataReader["materialecorpo"].ToString()
            );

            _strumentoACorda.MaterialeManico = (Program.eLEGNO)Enum.Parse
            (
                typeof(Program.eLEGNO),
                dataReader["materialemanico"].ToString()
            );

            _strumentoACorda.MaterialeTastiera = (Program.eLEGNO)Enum.Parse
            (
                typeof(Program.eLEGNO),
                dataReader["materialetastiera"].ToString()
            );

            _strumentoACorda.Pickup1 = (ClsStrumentoACorda.ePICKUP)Enum.Parse
            (
                typeof(ClsStrumentoACorda.ePICKUP),
                dataReader["pickup1"].ToString()
            );

            _strumentoACorda.Pickup2 = (ClsStrumentoACorda.ePICKUP)Enum.Parse
            (
                typeof(ClsStrumentoACorda.ePICKUP),
                dataReader["pickup2"].ToString()
            );

            _strumentoACorda.Pickup3 = (ClsStrumentoACorda.ePICKUP)Enum.Parse
            (
                typeof(ClsStrumentoACorda.ePICKUP),
                dataReader["pickup3"].ToString()
            );

            return _strumentoACorda;
        }        
	/// <summary>
        /// Caricamento dei dati dal DataReader (che legge join di strumentimusicali + strumentiacorda) ad un'istanza di ClsOttone
        /// </summary>
        /// <param name="dataReader"></param>
        /// <returns></returns>
        private static ClsStrumentoACorda CaricaSingoloStrumentoStrumentoACorda(ref MySqlDataReader dataReader, bool caricaStrumentoMusicaleID)
        {
            ClsStrumentoACorda _strumentoACorda = new ClsStrumentoACorda();
            ClsStrumentoMusicale _strumento = new ClsStrumentoMusicale();

            _strumentoACorda = CaricaSingoloStrumentoACorda(ref dataReader, caricaStrumentoMusicaleID);
            _strumento = ClsStrumentoMusicaleBL.CaricaSingoloStrumento(ref dataReader);

            _strumentoACorda = MergeStrumentoStrumentoACorda(_strumento, _strumentoACorda);
        
            return _strumentoACorda;
        }
        /// <summary>
        /// Mette in un istanza di ClsStrumentoACorda dati di generalizzazione da strumento e dati di specializzazione da strumento a corda
        /// </summary>
        /// <param name="strumento"></param>
        /// <param name="ottone"></param>
        /// <returns></returns>
        private static ClsStrumentoACorda MergeStrumentoStrumentoACorda(ClsStrumentoMusicale strumento, ClsStrumentoACorda strumentoACorda)
        {
            ClsStrumentoACorda _strumentoACordaFinale = strumentoACorda;

            _strumentoACordaFinale.Colori = strumento.Colori;
            _strumentoACordaFinale.CasaProduttriceID = strumento.CasaProduttriceID;
            _strumentoACordaFinale.Immagine = strumento.Immagine;
            _strumentoACordaFinale.PesoKG = strumento.PesoKG;
            _strumentoACordaFinale.NotaMassimaID = strumento.NotaMassimaID;
            _strumentoACordaFinale.NotaMinimaID = strumento.NotaMinimaID;
            _strumentoACordaFinale.Modello = strumento.Modello;

            return _strumentoACordaFinale;
        }
        /// <summary>
        /// Prende tutti i record di strumentiacorda con anche le informazione della generalizzazione da strumentimusicali
        /// </summary>
        /// <param name="_connection">Connessione al DB</param>
        /// <param name="ordinaPerPiuRecente">Se true, ordina per ID in maniera decrescente. Se false ordina per ID in maniera crescente</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <param name="limiteRecord">Numero massimo di record da caricare. Accetta valori da 2 in su</param>
        /// <returns>La lista con tutti i record. Se è nulla il caricamento non è andato a buon fine</returns>
        public static List<ClsStrumentoACorda> GetAllStrumentiACorda(string stringaDiConnessione, bool ordinaPerPiuRecente, out string comunicazione, int limiteRecord = 0)
        {
            //VARIABILI
            comunicazione = String.Empty;
            List<ClsStrumentoACorda> _strumentiACorda = new List<ClsStrumentoACorda>();
            MySqlConnection _connection = new MySqlConnection(stringaDiConnessione);

            try
            {
                //Apro la connessione
                _connection.Open();

                //Creo la query con la join tra strumentimusicali e strumentiacorda
                //Abbino le righe in base a ID <-> strumentomusicaleID
                string _query = "SELECT S.*, " +
                    "C.strumento, " +
                    "C.numerocorde, " +
                    "C.materialecorde, " +
                    "C.lunghezzamanicocm, " +
                    "C.ampiezzamanicocm, " +
                    "C.spessoremanicocm, " +
                    "C.materialemanico, " +
                    "C.materialetastiera, " +
                    "C.lunghezzacorpocm, " +
                    "C.ampiezzacorpocm, " +
                    "C.spessorecorpocm, " +
                    "C.materialecorpo, " +
                    "C.tasti, " +
                    "C.pickup1, " +
                    "C.pickup2, " +
                    "C.pickup3 " +
                    "FROM strumentimusicali AS S JOIN strumentiacorda AS C " +
                    "ON S.ID = C.strumentomusicaleID " +
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

                if(_dataReader.HasRows) //Controllo se la join ha dei record
                {
                    while(_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        _strumentiACorda.Add(CaricaSingoloStrumentoStrumentoACorda(ref _dataReader, false));
                    }
                }

                _dataReader.Close();

                comunicazione = "Strumenti a corda caricati correttamente dal DataBase";
            }
            catch(Exception ex)
            {
                comunicazione = ex.Message;
                _strumentiACorda = null;
            }
            finally
            {
                //Chiudo la connessione
                _connection.Close();
            }

            return _strumentiACorda;
        }
    }
}
