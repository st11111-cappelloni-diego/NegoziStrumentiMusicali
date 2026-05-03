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
    public static class ClsTamburoBL
    {
        /// <summary>
        /// Inserimento di un record in tamburi
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="tamburo">Oggetto da inserire</param>
        /// <param name="comunicazione">Stringa di comunicazione in uscita</param>
        /// <returns>ID del nuovo record. Se -1 insert non riuscito</returns>
        public static long InsertTamburo(ref MySqlConnection connection, ClsTamburo tamburo, out string comunicazione)
        {
            //VARIABILI
            long _ID = -1;
            comunicazione = string.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml =
                    "INSERT into tamburi (tipo, diametroin, materiale, strati) " +
                    "VALUES(@tipo, @diametroin, @materiale, @strati)";

                //Creo il command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@tipo", tamburo.Tipo.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@diametroin", tamburo.DiametroIN.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materiale", tamburo.Materiale.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@strati", tamburo.Strati);

                //Eseguo il comando
                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1) //1 significa che il comando è stato eseguito con successo
                    _ID = _cmd.LastInsertedId; //Ottengo l'ID generato in automatico dal DBMS

                comunicazione = "Tamburo inserito con successo nel DataBase";

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
        /// Update di un record di tamburi
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="tamburo">Dati record da aggiornare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void UpdateTamburo(ref MySqlConnection connection, ClsTamburo tamburo, out string comunicazione)
        {
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml =
                    "UPDATE tamburi " +
                    "SET tipo = @tipo, " +
                    "diametroin = @diametroin, " +
                    "materiale = @materiale, " +
                    "strati = @strati " +
                    "WHERE ID = @ID";

                //Creo il command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", tamburo.ID);
                _cmd.Parameters.AddWithValue("@tipo", tamburo.Tipo.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@diametroin", tamburo.DiametroIN.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@materiale", tamburo.Materiale.ToString().ToLower());
                _cmd.Parameters.AddWithValue("@strati", tamburo.Strati);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Tamburo aggiornato correttamente nel DataBase";
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
        /// Eliminazione di un record da tamburi
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="tamburo">Record da eliminare</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        public static void DeleteTamburo(ref MySqlConnection connection, ClsTamburo tamburo, out string comunicazione)
        {
            //VARIABILI LOCALI
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo il comando DML
                string _dml = "DELETE FROM tamburi WHERE ID = @ID";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_dml, connection);

                //Inserisco i valori
                _cmd.Parameters.AddWithValue("@ID", tamburo.ID);

                //Eseguo il comando
                _cmd.ExecuteNonQuery();

                comunicazione = "Tamburo eliminato correttamente dal DataBase";
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
        /// Caricamento di tutti i record di tamburi
        /// </summary>
        /// <param name="connection">Connessione al DB</param>
        /// <param name="comunicazione">Comunicazione in uscita</param>
        /// <returns>La lista di tutti i record di tamburi</returns>
        public static List<ClsTamburo> GetAllTamburi(ref MySqlConnection connection, out string comunicazione)
        {
            //VARIABILI
            List<ClsTamburo> _tamburi = new List<ClsTamburo>();
            comunicazione = String.Empty;

            try
            {
                //Apro la connessione
                connection.Open();

                //Compongo la query
                string _query = "SELECT * from tamburi";

                //Creo l'oggetto command
                MySqlCommand _cmd = new MySqlCommand(_query, connection);

                //Eseguo il comando creando il DataReader
                MySqlDataReader _dataReader = _cmd.ExecuteReader();

                if(_dataReader.HasRows) //Controllo se la tabella ha dei record
                {
                    while(_dataReader.Read()) //Se ne ha li leggo tutti
                    {
                        //Carico i dati sulla lista
                        ClsTamburo _tamburo = new ClsTamburo();

                        _tamburo.ID = (long)_dataReader["ID"];
                        _tamburo.DiametroIN = (ushort)_dataReader["diametroin"];
                        _tamburo.Strati = (ushort)_dataReader["strati"];
                        _tamburo.Materiale = (ClsTamburo.eMATERIALE)Enum.Parse
                        (
                            typeof(ClsTamburo.eMATERIALE),
                            _dataReader["materiale"].ToString()
                        );
                        _tamburo.Tipo = (ClsTamburo.eTIPO)Enum.Parse
                        (
                            typeof(ClsTamburo.eTIPO),
                            _dataReader["tipo"].ToString()
                        );

                        _tamburi.Add(_tamburo);
                    }

                    _dataReader.Close();

                    comunicazione = "Tamburi caricati correttamente dal DataBase";
                }
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

            return _tamburi;
        }
    }
}
