namespace NegozioStrumentiMusicali
{
    partial class FrmSceltaInserimentoStrumentoMusicale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuovoStrumento = new System.Windows.Forms.Button();
            this.pnlAggiungiStrumentoEsistente = new System.Windows.Forms.Panel();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nudPrezzo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQuantita = new System.Windows.Forms.NumericUpDown();
            this.btnAggiungiAlNegozio = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.btnFiltriRicerca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvStrumentiMusicali = new System.Windows.Forms.ListView();
            this.chTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCasaProduttrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModello = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chColori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlAggiungiStrumentoEsistente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantita)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(812, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(519, 28);
            this.label3.TabIndex = 85;
            this.label3.Text = "Oppure creane uno nuovo\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNuovoStrumento
            // 
            this.btnNuovoStrumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuovoStrumento.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaNuovo1_30x30;
            this.btnNuovoStrumento.Location = new System.Drawing.Point(817, 315);
            this.btnNuovoStrumento.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuovoStrumento.Name = "btnNuovoStrumento";
            this.btnNuovoStrumento.Size = new System.Drawing.Size(513, 49);
            this.btnNuovoStrumento.TabIndex = 86;
            this.btnNuovoStrumento.UseVisualStyleBackColor = true;
            this.btnNuovoStrumento.Click += new System.EventHandler(this.btnNuovoStrumento_Click);
            // 
            // pnlAggiungiStrumentoEsistente
            // 
            this.pnlAggiungiStrumentoEsistente.Controls.Add(this.btnVisualizza);
            this.pnlAggiungiStrumentoEsistente.Controls.Add(this.label6);
            this.pnlAggiungiStrumentoEsistente.Controls.Add(this.nudPrezzo);
            this.pnlAggiungiStrumentoEsistente.Controls.Add(this.label2);
            this.pnlAggiungiStrumentoEsistente.Controls.Add(this.nudQuantita);
            this.pnlAggiungiStrumentoEsistente.Controls.Add(this.btnAggiungiAlNegozio);
            this.pnlAggiungiStrumentoEsistente.Controls.Add(this.btnCerca);
            this.pnlAggiungiStrumentoEsistente.Controls.Add(this.btnFiltriRicerca);
            this.pnlAggiungiStrumentoEsistente.Controls.Add(this.label1);
            this.pnlAggiungiStrumentoEsistente.Controls.Add(this.lvStrumentiMusicali);
            this.pnlAggiungiStrumentoEsistente.Location = new System.Drawing.Point(16, 11);
            this.pnlAggiungiStrumentoEsistente.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAggiungiStrumentoEsistente.Name = "pnlAggiungiStrumentoEsistente";
            this.pnlAggiungiStrumentoEsistente.Size = new System.Drawing.Size(788, 679);
            this.pnlAggiungiStrumentoEsistente.TabIndex = 87;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizza.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaVisualizza1_30x21;
            this.btnVisualizza.Location = new System.Drawing.Point(735, 550);
            this.btnVisualizza.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(53, 49);
            this.btnVisualizza.TabIndex = 94;
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 617);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(489, 25);
            this.label6.TabIndex = 92;
            this.label6.Text = "Prezzo [euro]";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudPrezzo
            // 
            this.nudPrezzo.DecimalPlaces = 2;
            this.nudPrezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrezzo.Location = new System.Drawing.Point(0, 645);
            this.nudPrezzo.Margin = new System.Windows.Forms.Padding(4);
            this.nudPrezzo.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudPrezzo.Name = "nudPrezzo";
            this.nudPrezzo.Size = new System.Drawing.Size(489, 30);
            this.nudPrezzo.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 550);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(489, 25);
            this.label2.TabIndex = 90;
            this.label2.Text = "Quantità";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudQuantita
            // 
            this.nudQuantita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantita.Location = new System.Drawing.Point(0, 581);
            this.nudQuantita.Margin = new System.Windows.Forms.Padding(4);
            this.nudQuantita.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQuantita.Name = "nudQuantita";
            this.nudQuantita.Size = new System.Drawing.Size(489, 30);
            this.nudQuantita.TabIndex = 91;
            // 
            // btnAggiungiAlNegozio
            // 
            this.btnAggiungiAlNegozio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiAlNegozio.Location = new System.Drawing.Point(497, 601);
            this.btnAggiungiAlNegozio.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggiungiAlNegozio.Name = "btnAggiungiAlNegozio";
            this.btnAggiungiAlNegozio.Size = new System.Drawing.Size(291, 60);
            this.btnAggiungiAlNegozio.TabIndex = 89;
            this.btnAggiungiAlNegozio.Text = "AGGIUNGI AL NEGOZIO";
            this.btnAggiungiAlNegozio.UseVisualStyleBackColor = true;
            this.btnAggiungiAlNegozio.Click += new System.EventHandler(this.btnAggiungiAlNegozio_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaLenteRicerca1_28x28;
            this.btnCerca.Location = new System.Drawing.Point(735, 38);
            this.btnCerca.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(53, 49);
            this.btnCerca.TabIndex = 88;
            this.btnCerca.UseVisualStyleBackColor = true;
            // 
            // btnFiltriRicerca
            // 
            this.btnFiltriRicerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltriRicerca.Location = new System.Drawing.Point(0, 43);
            this.btnFiltriRicerca.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltriRicerca.Name = "btnFiltriRicerca";
            this.btnFiltriRicerca.Size = new System.Drawing.Size(727, 37);
            this.btnFiltriRicerca.TabIndex = 87;
            this.btnFiltriRicerca.Text = "Filtri di ricerca...";
            this.btnFiltriRicerca.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 28);
            this.label1.TabIndex = 86;
            this.label1.Text = "Aggiungi al negozio uno strumento esistente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvStrumentiMusicali
            // 
            this.lvStrumentiMusicali.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTipo,
            this.chID,
            this.chCasaProduttrice,
            this.chModello,
            this.chColori});
            this.lvStrumentiMusicali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStrumentiMusicali.FullRowSelect = true;
            this.lvStrumentiMusicali.HideSelection = false;
            this.lvStrumentiMusicali.Location = new System.Drawing.Point(0, 87);
            this.lvStrumentiMusicali.Margin = new System.Windows.Forms.Padding(4);
            this.lvStrumentiMusicali.MultiSelect = false;
            this.lvStrumentiMusicali.Name = "lvStrumentiMusicali";
            this.lvStrumentiMusicali.Size = new System.Drawing.Size(787, 458);
            this.lvStrumentiMusicali.TabIndex = 85;
            this.lvStrumentiMusicali.UseCompatibleStateImageBehavior = false;
            this.lvStrumentiMusicali.View = System.Windows.Forms.View.Details;
            // 
            // chTipo
            // 
            this.chTipo.Text = "Tipo";
            this.chTipo.Width = 100;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            // 
            // chCasaProduttrice
            // 
            this.chCasaProduttrice.Text = "Casa produttrice";
            this.chCasaProduttrice.Width = 150;
            // 
            // chModello
            // 
            this.chModello.Text = "Modello";
            this.chModello.Width = 145;
            // 
            // chColori
            // 
            this.chColori.Text = "Colori";
            this.chColori.Width = 130;
            // 
            // FrmSceltaInserimentoStrumentoMusicale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 705);
            this.Controls.Add(this.pnlAggiungiStrumentoEsistente);
            this.Controls.Add(this.btnNuovoStrumento);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSceltaInserimentoStrumentoMusicale";
            this.Text = "Inserimento di uno strumento musicale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSceltaInserimentoStrumentoMusicale_FormClosing);
            this.Load += new System.EventHandler(this.FrmSceltaInserimentoStrumentoMusicale_Load);
            this.pnlAggiungiStrumentoEsistente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNuovoStrumento;
        private System.Windows.Forms.Panel pnlAggiungiStrumentoEsistente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudPrezzo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQuantita;
        private System.Windows.Forms.Button btnAggiungiAlNegozio;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Button btnFiltriRicerca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvStrumentiMusicali;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chCasaProduttrice;
        private System.Windows.Forms.ColumnHeader chModello;
        private System.Windows.Forms.ColumnHeader chColori;
        private System.Windows.Forms.ColumnHeader chTipo;
        private System.Windows.Forms.Button btnVisualizza;
    }
}