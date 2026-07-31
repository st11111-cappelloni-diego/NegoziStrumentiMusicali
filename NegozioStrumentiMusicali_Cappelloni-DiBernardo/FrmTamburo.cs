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
    /// GUI e Sviluppo: Diego Cappelloni
    /// </summary>
    public partial class FrmTamburo : Form
    {
        #region Variabili globali
        public ClsTamburo _tamburo;
        public Program.eMODALITA_ENTRATA_DETAIL _modalitaEntrataDetail;
        public ClsBatteriaTamburo _batteriaTamburo;

        #endregion

        #region Metodi della form
        private void CaricaDati(ClsTamburo tamburo)
        {
            cbMateriale.SelectedIndex = Convert.ToInt32(tamburo.Materiale);
            nudDiametro.Value = Convert.ToDecimal(tamburo.DiametroIN);
            nudStrati.Value = Convert.ToDecimal(tamburo.Strati);
        }

        private void AbilitaControlliGraficiInput(bool controlliAbilitati)
        {
            cbMateriale.Enabled = controlliAbilitati;
            nudDiametro.Enabled = controlliAbilitati;
            nudStrati.Enabled = controlliAbilitati;
            btnSalva.Enabled = controlliAbilitati;
        }

        #endregion

        public FrmTamburo()
        {
            InitializeComponent();

            cbMateriale.DataSource = Enum.GetNames(typeof(ClsTamburo.eMATERIALE));
        }

        private void FrmTamburo_Load(object sender, EventArgs e)
        {
            if(_modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Modifica
                || _modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione)
            {
                CaricaDati(_tamburo);
            }

            if((_modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Inserimento
                || _modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Modifica))
            {
                AbilitaControlliGraficiInput(true);
                btnSalva.Visible = true;
            }
            else
            {
                AbilitaControlliGraficiInput(false);
                btnSalva.Visible = false;
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            DialogResult _drMessageBox =
                MessageBox.Show("Sei sicur* di voler salvare ed uscire?", "SALVA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(_drMessageBox == DialogResult.Yes)
            {
                try
                {
                    string _comunicazione = String.Empty;

                    _tamburo.DiametroIN = Convert.ToByte(nudDiametro.Value);
                    _tamburo.Materiale = (ClsTamburo.eMATERIALE)cbMateriale.SelectedIndex;
                    _tamburo.Strati = Convert.ToByte(nudStrati.Value);

                    if(_modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Inserimento)
                    {
                        _tamburo.ID = ClsTamburoBL.InsertTamburo(Program._connectionString, _tamburo, out _comunicazione);
                    }
                    else if(_modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Modifica)
                    {
                        ClsTamburoBL.UpdateTamburo(Program._connectionString, _tamburo, out _comunicazione);
                    }

                    MessageBox.Show(_comunicazione, "SALVATAGGIO DATI TAMBURO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Errore nel salvataggio del tamburo:\r\n" + ex, "SALVA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
