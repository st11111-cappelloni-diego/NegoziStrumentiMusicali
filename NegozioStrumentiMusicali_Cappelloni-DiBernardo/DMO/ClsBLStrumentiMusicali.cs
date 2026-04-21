using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioStrumentiMusicali
{
    /// <summary>
    /// Sviluppata da: Diego Cappelloni
    /// </summary>
    public static class ClsBLStrumentiMusicali
    {
        #region Insert
        /// <summary>
        /// Inserimento record in strumentimusicali
        /// </summary>
        /// <param name="connection">Stringa di connessione</param>
        /// <param name="pianforte">Oggetto da inserire</param>
        /// <param name="comunicazione"></param>
        /// <returns></returns>
        public static long InsertStrumentoMusicale(ref MySqlConnection connection, ClsStrumentoMusicale strumentoMusicale, out string comunicazione)
        {
            //VARIABILI 
            long _ID = 0;
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

                //Chiudo la connessione
                connection.Close();

                comunicazione = "Strumento musicale inserito con successo nel DataBase";
            }
            catch(Exception ex)
            {
                comunicazione = ex.Message;
            }

            return _ID;
        }
        /// <summary>
        /// Inserimento record in pianoforti
        /// </summary>
        /// <param name="connection">Stringa di connessione</param>
        /// <param name="pianforte">Oggetto da inserire</param>
        /// <param name="comunicazione"></param>
        /// <returns></returns>
        public static void InsertPianoforte(ref MySqlConnection connection, ClsPianoforte pianforte, out string comunicazione)
        {
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Creo il comando DML
                string _dml =
                    "INSERT into pianoforti " +
                    "(strumentomusicaleID, tipo, numerotasti, materialetastibianchi, materialetastineri, materialecorpopfacustico," +
                    "altezzacm, lunghezzacm, profonditacm, altezzaginocchiocm)" +
                    "VALUES (@strumentomusicaleID, @tipo, @numerotasti, @materialetastibianchi, @materialetastineri, @materialecorpopfacustico," +
                    "@altezzacm, @lunghezzacm, @profonditacm, @altezzaginocchiocm)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@strumentomusicaleID", pianforte.ID); //Prima di inserire il pianoforte bisogna inserire lo strumento musicale ad esso associato
                _cmd.Parameters.AddWithValue("@tipo", "'" + pianforte.Tipo.ToString().ToLower() + "'");
                _cmd.Parameters.AddWithValue("@numerotasti", pianforte.NumeroTasti);
                if (pianforte.Tipo == ClsPianoforte.eTIPO_PF.Acustico)
                {
                    _cmd.Parameters.AddWithValue("materialecorpopfacustico", pianforte.MaterialeCorpoPFAcustico.ToString().ToLower());
                }
                else
                {
                    //Null se il pianoforte è elettrico
                    _cmd.Parameters.AddWithValue("materialecorpopfacustico", null);
                }
                _cmd.Parameters.AddWithValue("@materialetastibianchi", pianforte.MaterialeTastiBianchi.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materialetastineri", pianforte.MaterialeTastiNeri.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@altezzacm", pianforte.AltezzaCM);
                _cmd.Parameters.AddWithValue("@lunghezzacm", pianforte.LunghezzaCM);
                _cmd.Parameters.AddWithValue("@profonditacm", pianforte.ProfonditaCM);
                _cmd.Parameters.AddWithValue("@altezzaginocchiocm", pianforte.AltezzaGinocchioCM);

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
        }
        /// <summary>
        /// Inserimento record in strumentiacorda
        /// </summary>
        /// <param name="connection">Stringa di connessione</param>
        /// <param name="strumentoACorda">Oggetto da inserire</param>
        /// <param name="comunicazione"></param>
        /// <returns></returns>
        public static void InsertStrumentoACorda(ref MySqlConnection connection, ClsStrumentoACorda strumentoACorda, out string comunicazione)
        {
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Creo il comando DML
                string _dml =
                    "INSERT into strumentimusicali " +
                    "(strumentomusicaleID, strumento, numerocorde, lunghezzamanicocm, ampiezzamanicocm, spessoremanicocm," +
                    "materialemanico, materialetastiera, lunghezzacorpocm, ampiezzacorpocm, spessorecorpocm, materialecorpo," +
                    "tasti, pickup1, pickup2, pickup3)" +
                    "VALUES (@strumentomusicaleID, @strumento, @numerocorde, @lunghezzamanicocm, @ampiezzamanicocm, @spessoremanicocm," +
                    "@materialemanico, @materialetastiera, @lunghezzacorpocm, @ampiezzacorpocm, @spessorecorpocm, @materialecorpo," +
                    "@tasti, @pickup1, @pickup2, @pickup3)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@strumentomusicaleID", strumentoACorda.ID); //Prima di inserire lo strumento a corda bisogna inserire lo strumento musicale ad esso associato
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
        }
        /// <summary>
        /// Inserimento record in ottoni
        /// </summary>
        /// <param name="connection">Stringa di connessione</param>
        /// <param name="strumentoACorda">Oggetto da inserire</param>
        /// <param name="comunicazione"></param>
        /// <returns></returns>
        public static void InsertOttoni(ref MySqlConnection connection, ClsOttone ottone, out string comunicazione)
        {
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Creo il comando DML
                string _dml =
                    "INSERT into strumentimusicali " +
                    "(strumentomusicaleID, strumento, materialecorpo, laccatura, placcatura, materialebocchino," +
                    "rivestimentobocchino, lunghezzacm, larghezzacm, altezzacm)" +
                    "VALUES(@strumentomusicaleID, @strumento, @materialecorpo, @laccatura, @placcatura, @materialebocchino," +
                    "@rivestimentobocchino, @lunghezzacm, @larghezzacm, @altezzacm";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@strumentomusicaleID", ottone.ID); //Prima di inserire lo strumento a corda bisogna inserire lo strumento musicale ad esso associato
                _cmd.Parameters.AddWithValue("@strumento", ottone.Strumento.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materialecorpo", ottone.MaterialeCorpo.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@laccatura", ottone.Laccatura);
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
        }

        #endregion

        #region Update
        /// <summary>
        /// Update di record di strumentimusicali
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="strumentoMusicale"></param>
        /// <param name="comunicazione"></param>
        public static void UpdateStrumentoMusicale(ref MySqlConnection connection, ClsStrumentoMusicale strumentoMusicale, out string comunicazione)
        {
            //VARIABILI
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
        /// Update di record di pianoforti
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="strumentoMusicale"></param>
        /// <param name="comunicazione"></param>
        public static void UpdatePianoforte(ref MySqlConnection connection, ClsPianoforte pianoforte, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando dml
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
        /// Update di record di strumentiacorda
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="strumentoMusicale"></param>
        /// <param name="comunicazione"></param>
        public static void UpdateStrumentoACorda(ref MySqlConnection connection, ClsStrumentoACorda strumentoACorda, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
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
        #endregion
    }
}
