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
    /// GUI: Diego Cappelloni
    /// </summary>
    public partial class FrmOrdini : Form
    {
        public enum ePARAMETRI_DI_ORDINAMENTO
        {
            Username_cliente,
            Data,
            ID_ordine,
            ID_articolo,
            Quantità
        }

        
        List<ClsNegozio> _negozi = new List<ClsNegozio>();  //creo la lista di negozio dove verranno inseriti tutti quelli correlati al username dell'utente che ha fatto l'accesso
        
        public FrmOrdini()
        {
            InitializeComponent();
            List<ClsGestire> _listGestire = new List<ClsGestire>(); //creo una lista di gestire dove metto tutti i gestire presi in base al userneme di chi ha fatto l'accesso
            string _comunicazione;
            _listGestire = ClsGestireBL.GetSomeGestire(ref Program._connessioneAlDB, out _comunicazione, ClsArchivio.UtenteAttuale.Username); //carico la lista di fgestire tramite il get sokme di gestire 
            string _comunicazioneNegozi;
            foreach (ClsGestire gestire in _listGestire)   //foreach per inseire con un get one i negozi chi dell'utente che ha fatto l'accesso 
            {
                
                _negozi.Add(ClsNegozioBL.GetOneNegozio(ref Program._connessioneAlDB, gestire.NegozioID, out _comunicazioneNegozi));
            }

            PopolaCombobox(cbNegozio, _negozi);

            List<ClsOrdine> _listOrdini = new List<ClsOrdine>();
        }

        void PopolaCombobox(ComboBox comboBox, List<ClsNegozio> listaNegozi)
        {
            //Rimuovo tutti gli elementi dalla combobox
            comboBox.Items.Clear();

            //Scorro tutti gli elementi della lista
            {
                for (int i = 0; i < listaNegozi.Count; i++)
                {
                    comboBox.Items.Add(listaNegozi[i].Nome);
                    comboBox.SelectedIndex = i;
                }
            }
        }


        private void FrmOrdini_Load(object sender, EventArgs e)
        {
            cbParametriDiOrdinamento.DataSource = Enum.GetNames(typeof(ePARAMETRI_DI_ORDINAMENTO));
        }
    }
}
