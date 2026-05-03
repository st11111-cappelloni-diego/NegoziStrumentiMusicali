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
    public static class ClsUtenteBL
    {
        /// <summary>
        /// Inserimento di record in utenti
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="utente">Record da inserire</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void InsertUtente(ref MySqlConnection connection, ClsUtente utente, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Creo il comando DML
                string _dml =
                    "INSERT into utenti " +
                    "(username, password, nome, cognome, email, datadinascita, genere, pathimmagine, adminsoftware, adminnegozio, bandito)" +
                    "VALUES(@username, @password, @nome, @cognome, @email, @datadinascita, @genere, @pathimmagine, @adminsoftware, @adminnegozio, @bandito)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@username", utente.Username);
                _cmd.Parameters.AddWithValue("@password", utente.Password);
                _cmd.Parameters.AddWithValue("@nome", utente.Nome);
                _cmd.Parameters.AddWithValue("@cognome", utente.Cognome);
                _cmd.Parameters.AddWithValue("@email", utente.Email);
                _cmd.Parameters.AddWithValue("@datadinascita", utente.DataDiNascita);
                _cmd.Parameters.AddWithValue("@genere", utente.Genere.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@pathimmagine", utente.PathImmagine);
                _cmd.Parameters.AddWithValue("@adminsoftware", utente.AdminSoftware);
                _cmd.Parameters.AddWithValue("@adminnegozio", utente.AdminNegozio);
                _cmd.Parameters.AddWithValue("@bandito", utente.Bandito);


                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Utente inserito con successo nel DataBase";
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
        /// Update di record in utenti
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="utente">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateUtente(ref MySqlConnection connection, ClsUtente utente, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando dml
                string _dml =
                    "UPDATE utenti SET " +
                    "password = @password, " +
                    "nome = @nome, " +
                    "cognome = @cognome, " +
                    "email = @email, " +
                    "dataDiNascita = @dataDiNascita, " +
                    "genere = @genere, " +
                    "pathImmagine = @pathImmagine, " +
                    "adminSoftware = @adminSoftware, " +
                    "adminNegozio = @adminNegozio, " +
                    "bandito = @bandito " +
                    "WHERE username = @username";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@username", utente.Username);
                _cmd.Parameters.AddWithValue("@password", utente.Password);
                _cmd.Parameters.AddWithValue("@nome", utente.Nome);
                _cmd.Parameters.AddWithValue("@cognome", utente.Cognome);
                _cmd.Parameters.AddWithValue("@email", utente.Email);
                _cmd.Parameters.AddWithValue("@dataDiNascita", utente.DataDiNascita);
                _cmd.Parameters.AddWithValue("@genere", utente.Genere);
                _cmd.Parameters.AddWithValue("@pathImmagine", utente.PathImmagine);
                _cmd.Parameters.AddWithValue("@adminSoftware", utente.AdminSoftware);
                _cmd.Parameters.AddWithValue("@adminNegozio", utente.AdminNegozio);
                _cmd.Parameters.AddWithValue("@bandito", utente.Bandito);


                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Utente aggiornato correttamente nel DataBase";
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
