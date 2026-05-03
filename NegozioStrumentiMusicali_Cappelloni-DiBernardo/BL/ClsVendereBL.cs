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
    }
}
