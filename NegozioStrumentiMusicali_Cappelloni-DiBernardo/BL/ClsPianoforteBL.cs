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
    public static class ClsPianoforteBL
    {
        /// <summary>
        /// Inserimento di record in pianoforti + informazioni generali in strumentimusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="pianoforte">Oggetto da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertPianoforte(ref MySqlConnection connection, ClsPianoforte pianoforte, out string comunicazione)
        {
            //VARIABILI LOCALI
            long _ID = -1;
            comunicazione = String.Empty;

            try
            {
                //Inserisco le informazioni generali in strumentimusicali
                _ID = ClsStrumentoMusicaleBL.InsertStrumentoMusicale(ref connection, pianoforte, out comunicazione);

                //Riapro la connessione dopo che si è chiusa in InsertStrumentoMusicale
                connection.Open();

                //Creo il comando DML per info specifiche del pianoforte
                string _dml =
                    "INSERT into pianoforti " +
                    "(strumentomusicaleID, tipo, numerotasti, materialetastibianchi, materialetastineri, materialecorpopfacustico," +
                    "altezzacm, lunghezzacm, profonditacm, altezzaginocchiocm)" +
                    "VALUES (@strumentomusicaleID, @tipo, @numerotasti, @materialetastibianchi, @materialetastineri, @materialecorpopfacustico," +
                    "@altezzacm, @lunghezzacm, @profonditacm, @altezzaginocchiocm)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@strumentomusicaleID", _ID); //Prima di inserire il pianoforte bisogna inserire lo strumento musicale ad esso associato
                _cmd.Parameters.AddWithValue("@tipo", "'" + pianoforte.Tipo.ToString().ToLower() + "'");
                _cmd.Parameters.AddWithValue("@numerotasti", pianoforte.NumeroTasti);
                if (pianoforte.Tipo == ClsPianoforte.eTIPO_PF.acustico)
                {
                    _cmd.Parameters.AddWithValue("materialecorpopfacustico", pianoforte.MaterialeCorpoPFAcustico.ToString().ToLower());
                }
                else
                {
                    //Null se il pianoforte è elettrico
                    _cmd.Parameters.AddWithValue("materialecorpopfacustico", null);
                }
                _cmd.Parameters.AddWithValue("@materialetastibianchi", pianoforte.MaterialeTastiBianchi.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materialetastineri", pianoforte.MaterialeTastiNeri.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@altezzacm", pianoforte.AltezzaCM);
                _cmd.Parameters.AddWithValue("@lunghezzacm", pianoforte.LunghezzaCM);
                _cmd.Parameters.AddWithValue("@profonditacm", pianoforte.ProfonditaCM);
                _cmd.Parameters.AddWithValue("@altezzaginocchiocm", pianoforte.AltezzaGinocchioCM);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Pianoforte inserito con successo nel DataBase";
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
        /// Update di un record in pianoforti + dettagli generali in strumentimusicali
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="pianoforte">Dati record da aggiornare</param>
        /// <param name="comunicazione">Stringa di comunicazione in uscita</param>
        public static void UpdatePianoforte(ref MySqlConnection connection, ClsPianoforte pianoforte, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Aggiorno le info generali in strumentimusicali
                ClsStrumentoMusicaleBL.UpdateStrumentoMusicale(ref connection, pianoforte, out comunicazione);

                //Riapro la connessione dopo che si è chiusa in UpdateStrumentoMusicale
                connection.Open();

                //Compongo il comando dml per dettagli specifici pianoforte
                string _dml =
                    "UPDATE pianoforti " +
                    "SET tipo = @tipo, " +
                    "numerotasti = @numerotasti, " +
                    "materialetastibianchi = @materialetastibianchi, " +
                    "materialetastineri = @materialetastineri, " +
                    "materialecorpopfacustico = @materialecorpopfacustico, " +
                    "altezzacm = @altezzacm, " +
                    "lunghezzacm = @lunghezzacm, " +
                    "profonditacm = @profonditacm, " +
                    "altezzaginocchiocm = @altezzaginocchiocm " +
                    "WHERE strumentomusicaleID = @ID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@tipo", pianoforte.Tipo.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@numerotasti", pianoforte.NumeroTasti);
                _cmd.Parameters.AddWithValue("@materialetastibianchi", pianoforte.MaterialeTastiBianchi.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materialetastineri", pianoforte.MaterialeTastiNeri.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materialecorpopfacustico", pianoforte.MaterialeCorpoPFAcustico.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@altezzacm", pianoforte.AltezzaCM);
                _cmd.Parameters.AddWithValue("@lunghezzacm", pianoforte.LunghezzaCM);
                _cmd.Parameters.AddWithValue("@profonditacm", pianoforte.ProfonditaCM);
                _cmd.Parameters.AddWithValue("@altezzaginocchiocm", pianoforte.AltezzaGinocchioCM);
                _cmd.Parameters.AddWithValue("@ID", pianoforte.ID);

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
        /// Eliminazione di un record da pianoforti
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="pianoforte">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void DeletePianoforte(ref MySqlConnection connection, ClsPianoforte pianoforte, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml = "DELETE FROM pianoforti WHERE strumentomusicaleID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", pianoforte.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Pianoforte eliminato correttamente dal DataBase";
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
        /// Caricamento dei dati dal DataReader (che legge record di pianoforti) ad un'istanza di ClsPianoforte
        /// </summary>
        /// <param name="dataReader"></param>
        /// <param name="caricaStrumentoMusicaleID"></param>
        /// <returns></returns>
        private static ClsPianoforte CaricaSingoloPianoforte(ref MySqlDataReader dataReader, bool caricaStrumentoMusicaleID)
        {
            ClsPianoforte _pianoforte = new ClsPianoforte();

            if(caricaStrumentoMusicaleID)
            {
                _pianoforte.ID = Convert.ToInt64(dataReader["strumentomusicaleID"]);
            }

            _pianoforte.Tipo = (ClsPianoforte.eTIPO_PF)Enum.Parse 
            (
                typeof(ClsPianoforte.eTIPO_PF),
                dataReader["tipo"].ToString()
            );

            if(dataReader["materialecorpopfacustico"] == DBNull.Value)
            {
                _pianoforte.MaterialeCorpoPFAcustico = null;
            }
            else
            {
                _pianoforte.MaterialeCorpoPFAcustico = (Program.eLEGNO)Enum.Parse
                (
                    typeof(Program.eLEGNO),
                    dataReader["materialecorpopfacustico"].ToString()
                );
            }

            _pianoforte.MaterialeTastiBianchi = (ClsPianoforte.eMATERIALE_TASTI_PF)Enum.Parse
            (
                typeof(Program.eLEGNO),
                dataReader["materialetastibianchi"].ToString()
            );

            _pianoforte.MaterialeTastiNeri = (ClsPianoforte.eMATERIALE_TASTI_PF)Enum.Parse
            (
                typeof(Program.eLEGNO),
                dataReader["materialetastineri"].ToString()
            );

            _pianoforte.NumeroTasti = Convert.ToInt32(dataReader["numerotasti"]);

            _pianoforte.AltezzaCM = Convert.ToSingle(dataReader["altezzacm"]);

            _pianoforte.LunghezzaCM = Convert.ToSingle(dataReader["lunghezzacm"]);

            _pianoforte.ProfonditaCM = Convert.ToSingle(dataReader["profonditacm"]);

            _pianoforte.AltezzaGinocchioCM = Convert.ToSingle(dataReader["altezzaginocchiocm"]);
 

            return _pianoforte;
        }        
	    /// <summary>
        /// Caricamento dei dati dal DataReader (che legge join o view di strumentimusicali + strumentiacorda) ad un'istanza di ClsOttone
        /// </summary>
        /// <param name="dataReader"></param>
        /// <returns></returns>
        private static ClsPianoforte CaricaSingoloStrumentoPianoforte(ref MySqlDataReader dataReader, bool caricaCasaProduttriceID)
        {
            ClsPianoforte _pianoforte = new ClsPianoforte();
            ClsStrumentoMusicale _strumento = new ClsStrumentoMusicale();

            _pianoforte = CaricaSingoloPianoforte(ref dataReader, caricaCasaProduttriceID);
            _strumento = ClsStrumentoMusicaleBL.CaricaSingoloStrumento(ref dataReader);

            _pianoforte = MergeStrumentoPianoforte(_strumento, _pianoforte);
        
            return _pianoforte;
        }
        /// <summary>
        /// Mette in un istanza di ClsPianoforte dati di generalizzazione da strumento e dati di specializzazione da strumento a corda
        /// </summary>
        /// <param name="strumento"></param>
        /// <param name="ottone"></param>
        /// <returns></returns>
        private static ClsPianoforte MergeStrumentoPianoforte(ClsStrumentoMusicale strumento, ClsPianoforte pianoforte)
        {
            ClsPianoforte _pianoforteFinale = pianoforte;

            _pianoforteFinale.ID = strumento.ID;
            _pianoforteFinale.Colori = strumento.Colori;
            _pianoforteFinale.CasaProduttriceID = strumento.CasaProduttriceID;
            _pianoforteFinale.Immagine = strumento.Immagine;
            _pianoforteFinale.PesoKG = strumento.PesoKG;
            _pianoforteFinale.NotaMassimaID = strumento.NotaMassimaID;
            _pianoforteFinale.NotaMinimaID = strumento.NotaMinimaID;
            _pianoforteFinale.Modello = strumento.Modello;

            return _pianoforteFinale;
        }
        /// <summary>
        /// Prende tutti i record di pianoforti con anche le informazione della generalizzazione da strumentimusicali
        /// </summary>
        /// <param name="stringaDiConnessione">Stringa per la connessione al DB</param>
        /// <param name="ordinaPerPiuRecente">Se true, ordina per ID in maniera decrescente. Se false ordina per ID in maniera crescente</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <param name="limiteRecord">Massimo di record da caricare. Accetta valori da 2 in su</param>
        /// <returns>La lista con tutti i record. Se è nulla il caricamento non è andato a buon fine</returns>
        public static List<ClsPianoforte> GetAllPianoforti(string stringaDiConnessione, bool ordinaPerPiuRecente, out string comunicazione, int limiteRecord = 0)
        {
            //VARIABILI
            comunicazione = String.Empty;
            List<ClsPianoforte> _pianoforti = null;
            MySqlConnection _connection = new MySqlConnection(stringaDiConnessione);

            try
            {
                //Apro la connessione
                _connection.Open();

                //Creo la query con la join tra strumentimusicali e pianoforti
                //Abbino le righe in base a ID <-> strumentomusicaleID
                string _query = "SELECT S.*, " +
                    "P.tipo, " +
                    "P.numerotasti, " +
                    "P.materialetastibianchi, " +
                    "P.materialetastineri, " +
                    "P.materialecorpopfacustico, " +
                    "P.altezzacm, " +
                    "P.lunghezzacm, " +
                    "pP.profonditacm, " +
                    "P.altezzaginocchiocm " +
                    "FROM strumentimusicali AS S JOIN pianoforti AS P " +
                    "ON S.ID = P.strumentomusicaleID " +
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

                if(_dataReader.HasRows) //Controllo se la view ha dei record
                {
                    _pianoforti = new List<ClsPianoforte>();
                    while(_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        _pianoforti.Add(CaricaSingoloStrumentoPianoforte(ref _dataReader, false));
                    }
                }

                _dataReader.Close();

                comunicazione = "Pianoforti caricati correttamente dal DataBase";
            }
            catch(Exception ex)
            {
                comunicazione = ex.Message;
                _pianoforti = null;
            }
            finally
            {
                //Chiudo la connessione
                _connection.Close();
            }

            return _pianoforti;
        }
    }
}
