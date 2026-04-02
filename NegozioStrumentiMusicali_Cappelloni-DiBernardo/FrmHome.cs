using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegozioStrumentiMusicali
{
    /// <summary>
    /// Sviluppo e GUI: Diego Cappelloni
    /// </summary>
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();

            #region Generazione della lista di note musicali 
            //Sviluppato da: Diego Cappelloni
            //Da implementare poi nella classe coi metodi (?)

            //Ricavo in primis le note naturali dell'ottava 0 inserendole nella lista globale di note musicali. Scorro tutti i valori dell'enum eNOTA_BASE
            //Enum.GetValues(typeof(ClsNotaMusicale.eNOTA_BASE)).Length = lunghezza della lista con tutti i valore dell'enum, ovvero il numero di valori disponibili
            for (int i = 0; i < Enum.GetValues(typeof(ClsNotaMusicale.eNOTA_BASE)).Length; i++) 
            {
                //(ClsNotaMusicale.eNOTA_BASE)i = associo il numero intero al valore dell'enum (il primo valore è di default 0, il secondo 1, ecc... infatti i inizia con valore 0)
                ClsArchivio.NoteMusicali.Add(new ClsNotaMusicale((ClsNotaMusicale.eNOTA_BASE)i, ClsNotaMusicale.eALTERAZIONE.Naturale, 0));
            }

            //Successivamente, aggiungo le note non naturali sempre dell'ottava 0. Scelgo come alterazione il diesis (#)
            for(int j = 0; j < ClsArchivio.NoteMusicali.Count(); j++) //Scorro la lista appena popolata con le note naturali
            {
                //Deve generare solo le alterazioni delle note naturali ad eccezione di MI e SI
                if (ClsArchivio.NoteMusicali[j].NotaBase != ClsNotaMusicale.eNOTA_BASE.Mi)  //MI# = FA Naturale
 
                {
                    if(ClsArchivio.NoteMusicali[j].NotaBase != ClsNotaMusicale.eNOTA_BASE.Si)
                    {
                        if (ClsArchivio.NoteMusicali[j].Alterazione == ClsNotaMusicale.eALTERAZIONE.Naturale)
                        {
                            //Aggiungo la nota attuale con alterazione diesis e non naturale alla lista
                            //Aggiungo la nota in coda alla lista
                            //Non gli dico di aggiungere alla lista ClsArchivio.NoteMusicali[j] sennò quello ed il nuovo oggetto hanno lo stesso puntatore in memoria
                            ClsArchivio.NoteMusicali.Add(new ClsNotaMusicale(
                                ClsArchivio.NoteMusicali[j].NotaBase,
                                ClsArchivio.NoteMusicali[j].Alterazione,
                                ClsArchivio.NoteMusicali[j].Ottava));
                            ClsArchivio.NoteMusicali[ClsArchivio.NoteMusicali.Count - 1].Alterazione = ClsNotaMusicale.eALTERAZIONE.Diesis; //Cambio l'alterazione in diesis

                            //Metto la nota alterata dopo la nota naturale indicata dall'indice j
                            //Metto la nota alterata in una variabile temporanea
                            ClsNotaMusicale _temp = ClsArchivio.NoteMusicali[ClsArchivio.NoteMusicali.Count - 1];
                            //Sposto in avanti tutte le note dopo la posizione j + 1
                            for (int k = ClsArchivio.NoteMusicali.Count - 1; k > j + 1; k--)
                            {
                                ClsArchivio.NoteMusicali[k] = ClsArchivio.NoteMusicali[k - 1];
                            }
                            //Aggiungo nella posizione j + 1 la nota alterata
                            ClsArchivio.NoteMusicali[j + 1] = _temp;
                        }
                    }
                }
            }

            //Ora che ho tutte le note dell'ottava 0, accodo la lista e addiziono all'ottava 1 fino ad ottenere 10 ottave

            #endregion
        }

        private void msHome_Load(object sender, EventArgs e)
        {

        }
    }
}
