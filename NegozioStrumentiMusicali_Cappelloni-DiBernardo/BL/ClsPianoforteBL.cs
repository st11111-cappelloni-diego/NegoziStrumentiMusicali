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
        public static void DeleteStrumentoMusicale(ref MySqlConnection connection, ClsPianoforte pianoforte, out string comunicazione)
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
    }
}
