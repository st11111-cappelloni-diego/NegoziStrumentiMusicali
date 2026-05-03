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
    public static class ClsCasaProduttriceBL
    {
        /// <summary>
        /// Inserimento di record in caseproduttrici
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="casaProduttrice">Record da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns></returns>
        public static long InsertCasaProduttrice(ref MySqlConnection connection, ClsCasaProduttrice casaProduttrice, out string comunicazione)
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
                    "INSERT into caseproduttrici " +
                    "(nome, email, pathlogo)" +
                    "VALUES(@nome, @email, @pathlogo)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@nome", casaProduttrice.Nome);
                _cmd.Parameters.AddWithValue("@email", casaProduttrice.Email);
                _cmd.Parameters.AddWithValue("@pathlogo", casaProduttrice.PathLogo);


                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando è stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                comunicazione = "Casa produttrice inserita con successo nel DataBase";
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
        /// Update di un record di caseproduttrici
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="casaProduttrice">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateCasaProdruttrice(ref MySqlConnection connection, ClsCasaProduttrice casaProduttrice, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando dml
                string _dml =
                    "UPDATE caseproduttrici SET " +
                    "nome = @nome, " +
                    "email = @email, " +
                    "pathlogo = @pathlogo " +
                    "WHERE ID = @ID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@nome", casaProduttrice.Nome);
                _cmd.Parameters.AddWithValue("@email", casaProduttrice.Email);
                _cmd.Parameters.AddWithValue("@pathlogo", casaProduttrice.PathLogo);
                _cmd.Parameters.AddWithValue("@ID", casaProduttrice.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Casa produttrice aggiornata correttamente nel DataBase";
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
