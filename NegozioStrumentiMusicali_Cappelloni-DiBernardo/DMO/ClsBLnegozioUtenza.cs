using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioStrumentiMusicali
{
    public static class ClsBLnegozioUtenza
    {
        /// <summary>
        /// Sviluppata da: Leonardo Di Bernardo
        /// </summary>
       
        
        #region ClsNegozio
        /// <summary>
        /// Inserimento record in negozi
        /// </summary>
        /// <param name="connection">Stringa di connessione</param>
        /// <param name="negozio">Oggetto da inserire</param>
        /// <param name="errore"></param>
        /// <returns></returns>
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

        #region ClsUtente
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

        #region ClsOrdine
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

        #region ClsIndirizzo
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

        #region ClsCasaProdruttrice
        /// <summary>
        /// Inserimento record in negozi
        /// </summary>
        /// <param name="connection">Stringa di connessione</param>
        /// <param name="casaProdruttrice">Oggetto da inserire</param>
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

        #region ClsNegozio
        /// <summary>
        /// Inserimento record in negozi
        /// </summary>
        /// <param name="connection">Stringa di connessione</param>
        /// <param name="negozio">Oggetto da inserire</param>
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

    }
}
