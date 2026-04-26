using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioStrumentiMusicali
{
    /// <summary>
    /// Sviluppata da Leonardo di Bernardo
    /// </summary>
    public class ClsBLNegoziUtenza
    {
        #region ClsNegozio

        #region Insert

        /// <summary>
        /// Inserimento record in negozi
        /// </summary>
        /// <param name="connection">Stringa di connessione</param>
        /// <param name="negozio">Oggetto da inserire</param>
        /// <param name="errore"></param>
        /// <returns></returns>
        /// 
        public static long InsertNegozio(ref MySqlConnection connection, ClsNegozio negozio, out string errore)
        {
            //VARIABILI 
            long _ID = 0;
            errore = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Creo il comando DML
                string _dml =
                    "INSERT into negozi " +
                    "(nome, bandito, pathimmagine, indirizzoID)" +
                    "VALUES (@nome, @bandito, @pathimmagine, @indirizzoID)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@nome", negozio.Nome);
                _cmd.Parameters.AddWithValue("@bandito", negozio.Bandito);
                _cmd.Parameters.AddWithValue("@pathimmagine", negozio.PathImmagine);
                _cmd.Parameters.AddWithValue("@indirizzoID", negozio.IndirizzoID);


                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando Ã¨ stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                //Chiudo la connessione
                connection.Close();
            }
            catch (Exception ex)
            {

            }

            return _ID;
        }
        #endregion

        #region Update

        /// <summary>
        /// Update di record di negozi
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="negozio"></param>
        /// <param name="comunicazione"></param>
        ///
        public static void UpdateNegozio(ref MySqlConnection connection, ClsNegozio negozio, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando dml
                string _dml =
                    "UPDATE negozi " +
                    "SET nome = @nome, " +
                    "bandito = @bandito, " +
                    "pathimmagine = @pathimmagine, " +
                    "indirizzoID = @indirizzoID " +
                    "WHERE ID = @ID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@nome", negozio.Nome.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@bandito", negozio.Bandito);
                _cmd.Parameters.AddWithValue("@pathimmagine", negozio.PathImmagine);
                _cmd.Parameters.AddWithValue("@indirizzoID", negozio.IndirizzoID);

                _cmd.Parameters.AddWithValue("@ID", negozio.ID);


                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Negozio aggiornato correttamente nel DataBase";
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


        #endregion

        #region ClsUtente

        #region Insert
        /// <summary>
        /// Inserimento record in unetnti
        /// </summary>
        /// <param name="connection">Stringa di connessione</param>
        /// <param name="utente">Oggetto da inserire</param>
        /// <param name="errore"></param>
        /// <returns></returns>
        public static void InsertUtente(ref MySqlConnection connection, ClsUtente utente, out string errore)
        {
            //VARIABILI
            errore = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Creo il comando DML
                string _dml =
                    "INSERT into utenti " +
                    "(username, password, nome, cognome, email, dataDiNascita, genere, pathImmagine, adminSoftware, adminNegozio, bandito)" +
                    "VALUES (@username, @password, @nome, @cognome, @email, @dataDiNascita, @genere, @pathImmagine, @adminSoftware, @adminNegozio, @bandito)";

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
                _cmd.Parameters.AddWithValue("@pathimmagine", utente.PathImmagine);
                _cmd.Parameters.AddWithValue("@adminSoftware", utente.AdminSoftware);
                _cmd.Parameters.AddWithValue("@adminNegozio", utente.AdminNegozio);
                _cmd.Parameters.AddWithValue("@bandito", utente.Bandito);


                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();


                //Chiudo la connessione
                connection.Close();
            }
            catch (Exception ex)
            {

            }

        }
        #endregion

        #region Update

        /// <summary>
        /// Update di record di utenti
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="utente"></param>
        /// <param name="comunicazione"></param>
        ///
        public static void UpdateUtrnte(ref MySqlConnection connection, ClsUtente utente, out string comunicazione)
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
                    "username = @username, " +
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
                    "WHERE ID = @ID";


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
        #endregion

        #endregion

        #region ClsOrdine

        #region Insert
        /// <summary>
        /// Inserimento record in ordini
        /// </summary>
        /// <param name="connection">Stringa di connessione</param>
        /// <param name="ordine">Oggetto da inserire</param>
        /// <param name="errore"></param>
        /// <returns></returns>
        public static long InsertOrdine(ref MySqlConnection connection, ClsOrdine ordine, out string errore)
        {
            //VARIABILI 
            long _ID = 0;
            errore = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Creo il comando DML
                string _dml =
                    "INSERT into ordini " +
                    "(quantita, dataora, indirizzoID, negozioID, strumentoMusicaleID, utenteUsername)" +
                    "VALUES (@quantita, @dataora, @indirizzoID, @negozioID, @strumentoMusicaleID, @utenteUsername)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@quantita", ordine.Quantita);
                _cmd.Parameters.AddWithValue("@dataora", ordine.DataOra);
                _cmd.Parameters.AddWithValue("@indirizzoID", ordine.IndirizzoID);
                _cmd.Parameters.AddWithValue("@negozioID", ordine.NegozioID);
                _cmd.Parameters.AddWithValue("@strumentoMusicaleID", ordine.StrumentoMusicaleID);
                _cmd.Parameters.AddWithValue("@utenteUsername", ordine.UsernameCliente);


                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando Ã¨ stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                //Chiudo la connessione
                connection.Close();
            }
            catch (Exception ex)
            {

            }

            return _ID;
        }
        #endregion

        #region Update

        /// <summary>
        /// Update di record di ordini
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="utente"></param>
        /// <param name="comunicazione"></param>
        ///
        public static void UpdateOrdine(ref MySqlConnection connection, ClsOrdine ordine, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando dml
                string _dml =
                    "UPDATE ordini SET " +
                    "quantita = @quantita, " +
                    "dataora = @dataora, " +
                    "indirizzoID = @indirizzoID, " +
                    "negozioID = @negozioID, " +
                    "strumentoMusicaleID = @strumentoMusicaleID, " +
                    "utenteUsername = @utenteUsername " +
                    "WHERE ID = @ID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@quantita", ordine.Quantita);
                _cmd.Parameters.AddWithValue("@dataora", ordine.DataOra);
                _cmd.Parameters.AddWithValue("@indirizzoID", ordine.IndirizzoID);
                _cmd.Parameters.AddWithValue("@negozioID", ordine.NegozioID);
                _cmd.Parameters.AddWithValue("@strumentoMusicaleID", ordine.StrumentoMusicaleID);
                _cmd.Parameters.AddWithValue("@utenteUsername", ordine.UsernameCliente);

                _cmd.Parameters.AddWithValue("@ID", ordine.ID);

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
        #endregion


        #endregion

        #region ClsIndirizzo

        #region Insert
        /// <summary>
        /// Inserimento record in indirizzi
        /// </summary>
        /// <param name="connection">Stringa di connessione</param>
        /// <param name="indirizzo">Oggetto da inserire</param>
        /// <param name="errore"></param>
        /// <returns></returns>
        public static long InsertIndirizzo(ref MySqlConnection connection, ClsIndirizzo indirizzo, out string errore)
        {
            //VARIABILI 
            long _ID = 0;
            errore = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Creo il comando DML
                string _dml =
                    "INSERT into indirizzi " +
                    "(codicepostale, comune, via, nazione, essereSede, casaProdruttriceID)" +
                    "VALUES (@codicepostale, @comune, @via, @nazione, @essereSede, @casaProdruttriceID)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@codicepostale", indirizzo.CodicePostale);
                _cmd.Parameters.AddWithValue("@comune", indirizzo.Comune);
                _cmd.Parameters.AddWithValue("@via", indirizzo.Via);
                _cmd.Parameters.AddWithValue("@nazione", indirizzo.Nazione);
                _cmd.Parameters.AddWithValue("@essereSede", indirizzo.EssereSede);
                _cmd.Parameters.AddWithValue("@casaProdruttriceID", indirizzo.CasaProduttriceID);


                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando Ã¨ stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                //Chiudo la connessione
                connection.Close();
            }
            catch (Exception ex)
            {

            }

            return _ID;
        }
        #endregion

        #region Update

        /// <summary>
        /// Update di record di ordini
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="indirizzo"></param>
        /// <param name="comunicazione"></param>
        ///
        public static void UpdateIndirizzo(ref MySqlConnection connection, ClsIndirizzo indirizzo, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando dml
                string _dml =
                    "UPDATE indirizzi SET " +
                    "codicepostale = @codicepostale, " +
                    "comune = @comune, " +
                    "via = @via, " +
                    "nazione = @nazione, " +
                    "essereSede = @essereSede, " +
                    "casaProdruttriceID = @casaProdruttriceID " +
                    "WHERE ID = @ID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@codicepostale", indirizzo.CodicePostale);
                _cmd.Parameters.AddWithValue("@comune", indirizzo.Comune);
                _cmd.Parameters.AddWithValue("@via", indirizzo.Via);
                _cmd.Parameters.AddWithValue("@nazione", indirizzo.Nazione);
                _cmd.Parameters.AddWithValue("@essereSede", indirizzo.EssereSede);
                _cmd.Parameters.AddWithValue("@casaProdruttriceID", indirizzo.CasaProduttriceID);

                _cmd.Parameters.AddWithValue("@ID", indirizzo.ID);

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
        #endregion

        #endregion

        #region ClsCasaProdruttrice

        #region Insert
        /// <summary>
        /// Inserimento record in negozi
        /// </summary>
        /// <param name="connection">Stringa di connessione</param>
        /// <param name="casaprodruttrice">Oggetto da inserire</param>
        /// <param name="errore"></param>
        /// <returns></returns>
        public static long InsertCasaProdruttrice(ref MySqlConnection connection, ClsCasaProdruttrice casaProdruttrice, out string errore)
        {
            //VARIABILI 
            long _ID = 0;
            errore = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Creo il comando DML
                string _dml =
                    "INSERT into caseprodruttrici " +
                    "(nome, email, pathlogo)" +
                    "VALUES (@nome, @email, @pathlogo)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@nome", casaProdruttrice.Nome);
                _cmd.Parameters.AddWithValue("@email", casaProdruttrice.Email);
                _cmd.Parameters.AddWithValue("@pathlogo", casaProdruttrice.PathLogo);


                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando Ã¨ stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                //Chiudo la connessione
                connection.Close();
            }
            catch (Exception ex)
            {

            }

            return _ID;
        }
        #endregion

        #region Update

        /// <summary>
        /// Update di record di ordini
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="casaProdruttrice"></param>
        /// <param name="comunicazione"></param>
        ///
        public static void UpdateCasaProdruttrice(ref MySqlConnection connection, ClsCasaProdruttrice casaProdruttrice, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando dml
                string _dml =
                    "UPDATE caseprodruttrici SET " +
                    "nome = @nome, " +
                    "email = @email, " +
                    "pathlogo = @pathlogo " +
                    "WHERE ID = @ID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@nome", casaProdruttrice.Nome);
                _cmd.Parameters.AddWithValue("@email", casaProdruttrice.Email);
                _cmd.Parameters.AddWithValue("@pathlogo", casaProdruttrice.PathLogo);

                _cmd.Parameters.AddWithValue("@ID", casaProdruttrice.ID);

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

        #endregion

        #endregion

        #region ClsVendere

        #region Insert
        /// <summary>
        /// Inserimento record in negozi
        /// </summary>
        /// <param name="connection">Stringa di connessione</param>
        /// <param name="vendere">Oggetto da inserire</param>
        /// <param name="errore"></param>
        /// <returns></returns>
        public static long InsertVendere(ref MySqlConnection connection, ClsVendere vendere, out string errore)
        {
            //VARIABILI 
            long _ID = 0;
            errore = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Creo il comando DML
                string _dml =
                    "INSERT into negozi " +
                    "(quantita, prezzo, strumentoMusicaleID, negozioID)" +
                    "VALUES (@quantita, @prezzo, @strumentoMusicaleID, @negozioID)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@quantita", vendere.Quantita);
                _cmd.Parameters.AddWithValue("@prezzo", vendere.Prezzo);
                _cmd.Parameters.AddWithValue("@strumentoMusicaleID", vendere.StrumentoMusicaleID);
                _cmd.Parameters.AddWithValue("@negozioID", vendere.NegozioID);


                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando Ã¨ stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                //Chiudo la connessione
                connection.Close();
            }
            catch (Exception ex)
            {

            }

            return _ID;
        }
        #endregion

        #region Update

        /// <summary>
        /// Update di record di ordini
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="vendere"></param>
        /// <param name="comunicazione"></param>
        ///
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
        #endregion


        #endregion

        #region ClsGestire 

        #region Insert
        /// <summary>
        /// Inserimento record in negozi
        /// </summary>
        /// <param name="connection">Stringa di connessione</param>
        /// <param name="gestire">Oggetto da inserire</param>
        /// <param name="errore"></param>
        /// <returns></returns>

        public static long InsertVendere(ref MySqlConnection connection, ClsGestire gestire, out string errore)
        {
            //VARIABILI 
            long _ID = 0;
            errore = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Creo il comando DML
                string _dml =
                    "INSERT into negozi " +
                    "(negozioID, utenteUsername)" +
                    "VALUES (@negozioID, @utenteUsername)";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@quantita", gestire.NegozioID);
                _cmd.Parameters.AddWithValue("@prezzo", gestire.UtenteUsername);

                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando Ã¨ stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                //Chiudo la connessione
                connection.Close();
            }
            catch (Exception ex)
            {

            }

            return _ID;

        }
        #endregion

        #region Update

        /// <summary>
        /// Update di record di ordini
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="gestire"></param>
        /// <param name="comunicazione"></param>
        ///
        public static void UpdateGestire(ref MySqlConnection connection, ClsGestire gestire, out string comunicazione)
        {
            //VARIABILI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando dml
                string _dml =
                   "UPDATE gestire SET " +
                    "negozioID = @negozioID, " +
                    "utenteUsername = @utenteUsername " +
                    "WHERE ID = @ID";


                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@negozioID", gestire.NegozioID);
                _cmd.Parameters.AddWithValue("@utenteUsername", gestire.UtenteUsername);

                _cmd.Parameters.AddWithValue("@ID", gestire.ID);

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
        #endregion


        #endregion
    }
}
