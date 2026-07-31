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
    public partial class FrmPiatto : Form
    {
        #region Variabili Globali
        ClsPiatto _piatto;
        Program.eMODALITA_ENTRATA_DETAIL _modalitaEntrataDetail;

        #endregion

        #region Metodi della form
        private void CaricaDati(ClsPiatto piatto)
        {
            cbMateriale.SelectedIndex = Convert.ToInt32(piatto.Materiale);
            nudDiametro.Value = Convert.ToDecimal(piatto.DiametroIN);
        }

        private void AbilitaControlliGraficiInput(bool controlliAbilitati)
        {
            cbMateriale.Enabled = controlliAbilitati;
            nudDiametro.Enabled = controlliAbilitati;
            btnSalva.Enabled = controlliAbilitati;
        }

        #endregion

        public FrmPiatto()
        {
            InitializeComponent();

            cbMateriale.DataSource = Enum.GetNames(typeof(ClsPiatto.eMATERIALE));
        }

        private void FrmPiatto_Load(object sender, EventArgs e)
        {
            if(_modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Modifica
                || _modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Visualizzazione)
            {
                CaricaDati(_piatto);
            }

            if(_modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Inserimento
                || _modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Modifica)
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

                if (_drMessageBox == DialogResult.Yes)
                {
                    try
                    {
                        string _comunicazione = String.Empty;

                        _piatto.DiametroIN = Convert.ToByte(nudDiametro.Value);
                        _piatto.Materiale = (ClsPiatto.eMATERIALE)cbMateriale.SelectedIndex;

                        if (_modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Inserimento)
                        {
                            _piatto.ID = ClsPiattoBL.InsertPiatto(Program._connectionString, _piatto, out _comunicazione);
                        }
                        else if (_modalitaEntrataDetail == Program.eMODALITA_ENTRATA_DETAIL.Modifica)
                        {
                            ClsPiattoBL.UpdatePiatto(Program._connectionString, _piatto, out _comunicazione);
                        }

                        MessageBox.Show(_comunicazione, "SALVATAGGIO DATI PIATTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Errore nel salvataggio del piatto:\r\n" + ex, "SALVA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
    }
}
