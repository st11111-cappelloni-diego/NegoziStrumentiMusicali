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
    }
}
