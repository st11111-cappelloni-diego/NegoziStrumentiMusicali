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
            this.label6 = new System.Windows.Forms.Label();
            this.nudPrezzo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQuantita = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.btnFiltriRicerca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvStrumentiMusicali = new System.Windows.Forms.ListView();
            this.chTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCasaProduttrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModello = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chColori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.pnlAggiungiStrumentoEsistente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantita)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(609, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 23);
            this.label3.TabIndex = 85;
            this.label3.Text = "Oppure creane uno nuovo\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNuovoStrumento
            // 
            this.btnNuovoStrumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuovoStrumento.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaNuovo1_30x30;
            this.btnNuovoStrumento.Location = new System.Drawing.Point(613, 256);
            this.btnNuovoStrumento.Name = "btnNuovoStrumento";
            this.btnNuovoStrumento.Size = new System.Drawing.Size(385, 40);
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
            this.pnlAggiungiStrumentoEsistente.Controls.Add(this.button1);
            this.pnlAggiungiStrumentoEsistente.Controls.Add(this.btnCerca);
            this.pnlAggiungiStrumentoEsistente.Controls.Add(this.btnFiltriRicerca);
            this.pnlAggiungiStrumentoEsistente.Controls.Add(this.label1);
            this.pnlAggiungiStrumentoEsistente.Controls.Add(this.lvStrumentiMusicali);
            this.pnlAggiungiStrumentoEsistente.Location = new System.Drawing.Point(12, 9);
            this.pnlAggiungiStrumentoEsistente.Name = "pnlAggiungiStrumentoEsistente";
            this.pnlAggiungiStrumentoEsistente.Size = new System.Drawing.Size(591, 552);
            this.pnlAggiungiStrumentoEsistente.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(367, 20);
            this.label6.TabIndex = 92;
            this.label6.Text = "Prezzo [euro]";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudPrezzo
            // 
            this.nudPrezzo.DecimalPlaces = 2;
            this.nudPrezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrezzo.Location = new System.Drawing.Point(0, 524);
            this.nudPrezzo.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudPrezzo.Name = "nudPrezzo";
            this.nudPrezzo.Size = new System.Drawing.Size(367, 26);
            this.nudPrezzo.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 20);
            this.label2.TabIndex = 90;
            this.label2.Text = "Quantità";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudQuantita
            // 
            this.nudQuantita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantita.Location = new System.Drawing.Point(0, 472);
            this.nudQuantita.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQuantita.Name = "nudQuantita";
            this.nudQuantita.Size = new System.Drawing.Size(367, 26);
            this.nudQuantita.TabIndex = 91;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(373, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 49);
            this.button1.TabIndex = 89;
            this.button1.Text = "AGGIUNGI AL NEGOZIO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCerca
            // 
            this.btnCerca.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaLenteRicerca1_28x28;
            this.btnCerca.Location = new System.Drawing.Point(551, 31);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(40, 40);
            this.btnCerca.TabIndex = 88;
            this.btnCerca.UseVisualStyleBackColor = true;
            // 
            // btnFiltriRicerca
            // 
            this.btnFiltriRicerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltriRicerca.Location = new System.Drawing.Point(0, 35);
            this.btnFiltriRicerca.Name = "btnFiltriRicerca";
            this.btnFiltriRicerca.Size = new System.Drawing.Size(545, 30);
            this.btnFiltriRicerca.TabIndex = 87;
            this.btnFiltriRicerca.Text = "Filtri di ricerca...";
            this.btnFiltriRicerca.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 23);
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
            this.lvStrumentiMusicali.Location = new System.Drawing.Point(0, 71);
            this.lvStrumentiMusicali.MultiSelect = false;
            this.lvStrumentiMusicali.Name = "lvStrumentiMusicali";
            this.lvStrumentiMusicali.Size = new System.Drawing.Size(591, 373);
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
            // btnVisualizza
            // 
            this.btnVisualizza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizza.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaVisualizza1_30x21;
            this.btnVisualizza.Location = new System.Drawing.Point(551, 447);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(40, 40);
            this.btnVisualizza.TabIndex = 94;
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // FrmSceltaInserimentoStrumentoMusicale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 573);
            this.Controls.Add(this.pnlAggiungiStrumentoEsistente);
            this.Controls.Add(this.btnNuovoStrumento);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSceltaInserimentoStrumentoMusicale";
            this.Text = "Inserimento di uno strumento musicale";
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
        private System.Windows.Forms.Button button1;
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