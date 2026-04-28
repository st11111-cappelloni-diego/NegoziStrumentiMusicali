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
    }
}
