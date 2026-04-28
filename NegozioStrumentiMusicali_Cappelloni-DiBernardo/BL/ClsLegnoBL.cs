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
        /// Update di un record in legni + dettagli generali in strumentimusicali
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
    }
}
