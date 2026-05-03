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
        #region Altri metodi
        /// <summary>
        /// Copia gli oggetti di tipo ClsNotaMusicale da una lista1 ad una lista2 in modo che i puntatori alla memoria di ogni oggetto siano differenti
        /// </summary>
        /// <param name="lista1"></param>
        /// <returns></returns>
        //Da implementare poi nella classe coi metodi (?)
        public List<ClsNotaMusicale> CopiaListaClsNoteMusicali(List<ClsNotaMusicale> lista1)
        {
            List<ClsNotaMusicale> _lista2 = new List<ClsNotaMusicale>();

            for(int i = 0; i < lista1.Count; i++)
            {
                _lista2.Add(new ClsNotaMusicale(
                    lista1[i].NotaBase,
                    lista1[i].Alterazione,
                    lista1[i].Ottava));
            }

            return _lista2;
        }
        /// <summary>
        /// Accoda una lista di oggetti ClsNotaMusicale ad un'altra lista ClsNotaMusicale in modo che il puntatore alla memoria di ogni singolo oggetto sia differente
        /// </summary>
        /// <param name="listaMain"></param>
        /// <param name="listaDaAccodare"></param>
        /// <returns></returns>
        //Da implementare poi nella classe coi metodi (?)
        public List<ClsNotaMusicale> AccodaListaClsNoteMusicali(List<ClsNotaMusicale> listaMain, List<ClsNotaMusicale> listaDaAccodare)
        {
            List<ClsNotaMusicale> _nuovaLista = new List<ClsNotaMusicale>();
            for(int i = 0; i < listaMain.Count; i++)
            {
                _nuovaLista.Add(new ClsNotaMusicale(
                    listaMain[i].NotaBase,
                    listaMain[i].Alterazione,
                    listaMain[i].Ottava));
            }
            for (int j = 0; j < listaDaAccodare.Count; j++)
            {
                _nuovaLista.Add(new ClsNotaMusicale(
                    listaDaAccodare[j].NotaBase,
                    listaDaAccodare[j].Alterazione,
                    listaDaAccodare[j].Ottava));
            }

            return _nuovaLista;
        }

        #endregion

        #region Variabili globali
        FrmUtente _frmUtente;
        FrmUtenti _frmUtenti;
        FrmNegozi _frmNegozi;
        FrmOrdini _frmOrdini;
        FrmStrumentiMusicali _frmStrumentiMusicali;
        FrmCaseProduttrici _frmCaseProduttrici;

        #endregion

        #region Costruttore
        public FrmHome()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            #region Generazione della lista di note musicali 
            //Sviluppato da: Diego Cappelloni
            //Da implementare poi nella classe coi metodi (?)

            //Ricavo in primis le note naturali dell'ottava 0 inserendole nella lista globale di note musicali. Scorro tutti i valori dell'enum eNOTA_BASE
            //Enum.GetValues(typeof(ClsNotaMusicale.eNOTA_BASE)).Length = lunghezza della lista con tutti i valore dell'enum, ovvero il numero di valori disponibili
            for (int i = 0; i < Enum.GetValues(typeof(ClsNotaMusicale.eNOTA_BASE)).Length; i++) 
            {
                //(ClsNotaMusicale.eNOTA_BASE)i = associo il numero intero al valore dell'enum (il primo valore è di default 0, il secondo 1, ecc... infatti i inizia con valore 0)
                ClsArchivio.NoteMusicali.Add(new ClsNotaMusicale((ClsNotaMusicale.eNOTA_BASE)i, ClsNotaMusicale.eALTERAZIONE.naturale, 0));
            }

            //Successivamente, aggiungo le note non naturali sempre dell'ottava 0. Scelgo come alterazione il diesis (#)
            for(int j = 0; j < ClsArchivio.NoteMusicali.Count(); j++) //Scorro la lista appena popolata con le note naturali
            {
                //Deve generare solo le alterazioni delle note naturali ad eccezione di MI e SI
                if (ClsArchivio.NoteMusicali[j].NotaBase != ClsNotaMusicale.eNOTA_BASE.mi)  //MI# = FA Naturale
 
                {
                    if(ClsArchivio.NoteMusicali[j].NotaBase != ClsNotaMusicale.eNOTA_BASE.si)
                    {
                        if (ClsArchivio.NoteMusicali[j].Alterazione == ClsNotaMusicale.eALTERAZIONE.naturale)
                        {
                            //Aggiungo la nota attuale con alterazione diesis e non naturale alla lista
                            //Aggiungo la nota in coda alla lista
                            //Non gli dico di aggiungere alla lista ClsArchivio.NoteMusicali[j] sennò quello ed il nuovo oggetto hanno lo stesso puntatore in memoria
                            ClsArchivio.NoteMusicali.Add(new ClsNotaMusicale(
                                ClsArchivio.NoteMusicali[j].NotaBase,
                                ClsArchivio.NoteMusicali[j].Alterazione,
                                ClsArchivio.NoteMusicali[j].Ottava));
                            ClsArchivio.NoteMusicali[ClsArchivio.NoteMusicali.Count - 1].Alterazione = ClsNotaMusicale.eALTERAZIONE.diesis; //Cambio l'alterazione in diesis

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
            List<ClsNotaMusicale> _temp2 = CopiaListaClsNoteMusicali(ClsArchivio.NoteMusicali);           
            for(int l = 1; l <= 10; l++)
            {
                //L'ottava di ognuna delle 12 note è uguale a l
                for(int m = 0; m < _temp2.Count(); m++)
                {
                    _temp2[m].Ottava = l;
                }
                //Accodo temp alla lista con tutte le note
                ClsArchivio.NoteMusicali = AccodaListaClsNoteMusicali(ClsArchivio.NoteMusicali, _temp2);
            }

            #endregion
        }

        #endregion

        #region Metodi della form
        void MostraFormMDI(Form form)
        {
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.MdiParent = this;
            form.BringToFront();
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        #endregion

        #region Eventi
        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
        private void mioUtenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmUtente"] == null)
            {
                //Se la form non è già aperta la instanzio
                _frmUtente = new FrmUtente();
            }
            MostraFormMDI(_frmUtente);
        }
        private void utentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmUtenti"] == null)
            {
                //Se la form non è già aperta la instanzio
                _frmUtenti = new FrmUtenti();
            }
            MostraFormMDI(_frmUtenti);
        }
        private void negoziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmNegozi"] == null)
            {
                //Se la form non è già aperta la instanzio
                _frmNegozi = new FrmNegozi();
            }
            MostraFormMDI(_frmNegozi);
        }
        private void ordiniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmOrdini"] == null)
            {
                //Se la form non è già aperta la instanzio
                _frmOrdini = new FrmOrdini();
            }
            MostraFormMDI(_frmOrdini);
        }
        private void strumentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmStrumentiMusicali"] == null)
            {
                //Se la form non è già aperta la instanzio
                _frmStrumentiMusicali = new FrmStrumentiMusicali();
            }
            MostraFormMDI(_frmStrumentiMusicali);
        }
        private void caseProduttriciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmCaseProduttrici"] == null)
            {
                //Se la form non è già aperta la instanzio
                _frmCaseProduttrici = new FrmCaseProduttrici();
            }
            MostraFormMDI(_frmCaseProduttrici);
        }

        #endregion 


    }
}
