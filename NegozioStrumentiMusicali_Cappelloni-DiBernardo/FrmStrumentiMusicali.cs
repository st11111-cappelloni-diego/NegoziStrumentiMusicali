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
    public partial class FrmStrumentiMusicali : Form
    {
        #region Enumeratori
        enum ePARAMETRO_DI_ORDINAMENTO
        {
            ID,
            Casa_produttrice,
            Modello,
            Prezzo,
            Quantita
        }

        #endregion

        #region Metodi della form
        void PopolaListView(ListView listView, List<ClsStrumentoMusicale> listaStrumenti)
        {
            //Rimuovo tutti gli elementi dalla listview
            listView.Clear();

            //Scorro tutti gli elementi della lista
            for(int i = 0; i < listaStrumenti.Count; i++)
            {
                //Creo il listViewItem

            }
        }
        void PopolaCombobox(ComboBox comboBox, List<ClsNegozio> listaNegozi)
        {
            //Rimuovo tutti gli elementi dalla combobox
            comboBox.Items.Clear();

            //Scorro tutti gli elementi della lista
            {
                for(int i = 0; i < listaNegozi.Count; i++)
                {
                    
                }
            }
        }

        #endregion

        #region Costruttore
        public FrmStrumentiMusicali()
        {
            InitializeComponent();

            //Popolo l'apposita combobox con i parametri di ricerca
            cbParametriDiOrdinamento.DataSource = Enum.GetNames(typeof(ePARAMETRO_DI_ORDINAMENTO));
        }

        #endregion

        #region Eventi
        private void FrmStrumentiMusicali_Load(object sender, EventArgs e)
        {
            //Popolo la combobox dei negozi 
            
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private void cbNegozio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
