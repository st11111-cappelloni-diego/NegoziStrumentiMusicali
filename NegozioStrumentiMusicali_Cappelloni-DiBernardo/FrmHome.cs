using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySqlConnector;
using System.Configuration;
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

            //string _comunicazione = String.Empty;
            /*
            ClsArchivio.Piatti = ClsPiattoBL.GetAllPiatti(ref Program._connessioneAlDB, out _comunicazione);
            MessageBox.Show(_comunicazione);
            ClsArchivio.Tamburi = ClsTamburoBL.GetAllTamburi(ref Program._connessioneAlDB, out _comunicazione);
            MessageBox.Show(_comunicazione);  
            ClsArchivio.NoteMusicali = ClsNotaMusicaleBL.GetAllNoteMusicali(ref Program._connessioneAlDB, out _comunicazione);
            MessageBox.Show(_comunicazione);
            ClsArchivio.CaseProduttrici = ClsCasaProduttriceBL.GetAllCaseProduttrici(ref Program._connessioneAlDB, out _comunicazione);
            MessageBox.Show(_comunicazione);
            List<ClsOttone> _ottoni = ClsOttoneBL.GetAllOttoni(ref Program._connessioneAlDB, out _comunicazione);
            MessageBox.Show(_comunicazione);
            */
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

        private void FrmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
