using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySqlConnector;
using System.Threading.Tasks;

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
    }
}
