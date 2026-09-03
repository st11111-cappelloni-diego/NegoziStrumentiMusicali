namespace NegozioStrumentiMusicali
{
    partial class FrmOrdine
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
            this.nudIDArticolo = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDataOrdine = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlIndirizzo = new System.Windows.Forms.Panel();
            this.nudCivico = new System.Windows.Forms.NumericUpDown();
            this.cbNazione = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbComune = new System.Windows.Forms.TextBox();
            this.tbVia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLetteraCivico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCodicePostale = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudQuantita = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudIDArticolo)).BeginInit();
            this.pnlIndirizzo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCivico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantita)).BeginInit();
            this.SuspendLayout();
            // 
            // nudIDArticolo
            // 
            this.nudIDArticolo.Enabled = false;
            this.nudIDArticolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIDArticolo.Location = new System.Drawing.Point(8, 129);
            this.nudIDArticolo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudIDArticolo.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudIDArticolo.Name = "nudIDArticolo";
            this.nudIDArticolo.ReadOnly = true;
            this.nudIDArticolo.Size = new System.Drawing.Size(729, 37);
            this.nudIDArticolo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(729, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "ID Articolo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDataOrdine
            // 
            this.dtpDataOrdine.Enabled = false;
            this.dtpDataOrdine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataOrdine.Location = new System.Drawing.Point(8, 43);
            this.dtpDataOrdine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDataOrdine.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataOrdine.Name = "dtpDataOrdine";
            this.dtpDataOrdine.Size = new System.Drawing.Size(729, 37);
            this.dtpDataOrdine.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(729, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data ordine";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(745, 548);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(181, 54);
            this.btnSalva.TabIndex = 19;
            this.btnSalva.Text = "Ordina";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaVisualizza1_23x16;
            this.button1.Location = new System.Drawing.Point(467, 182);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 39);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(692, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dettagli Negozio";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pnlIndirizzo
            // 
            this.pnlIndirizzo.Controls.Add(this.nudCivico);
            this.pnlIndirizzo.Controls.Add(this.cbNazione);
            this.pnlIndirizzo.Controls.Add(this.label1);
            this.pnlIndirizzo.Controls.Add(this.label2);
            this.pnlIndirizzo.Controls.Add(this.tbComune);
            this.pnlIndirizzo.Controls.Add(this.tbVia);
            this.pnlIndirizzo.Controls.Add(this.label4);
            this.pnlIndirizzo.Controls.Add(this.tbLetteraCivico);
            this.pnlIndirizzo.Controls.Add(this.label5);
            this.pnlIndirizzo.Controls.Add(this.tbCodicePostale);
            this.pnlIndirizzo.Controls.Add(this.label8);
            this.pnlIndirizzo.Location = new System.Drawing.Point(8, 229);
            this.pnlIndirizzo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlIndirizzo.Name = "pnlIndirizzo";
            this.pnlIndirizzo.Size = new System.Drawing.Size(729, 420);
            this.pnlIndirizzo.TabIndex = 94;
            // 
            // nudCivico
            // 
            this.nudCivico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCivico.Location = new System.Drawing.Point(11, 180);
            this.nudCivico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCivico.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudCivico.Name = "nudCivico";
            this.nudCivico.Size = new System.Drawing.Size(347, 37);
            this.nudCivico.TabIndex = 13;
            // 
            // cbNazione
            // 
            this.cbNazione.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNazione.FormattingEnabled = true;
            this.cbNazione.Location = new System.Drawing.Point(4, 325);
            this.cbNazione.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNazione.Name = "cbNazione";
            this.cbNazione.Size = new System.Drawing.Size(725, 38);
            this.cbNazione.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(727, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Comune";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(727, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Via";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbComune
            // 
            this.tbComune.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbComune.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComune.Location = new System.Drawing.Point(4, 31);
            this.tbComune.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbComune.Name = "tbComune";
            this.tbComune.Size = new System.Drawing.Size(724, 37);
            this.tbComune.TabIndex = 9;
            // 
            // tbVia
            // 
            this.tbVia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVia.Location = new System.Drawing.Point(4, 105);
            this.tbVia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbVia.Name = "tbVia";
            this.tbVia.Size = new System.Drawing.Size(725, 37);
            this.tbVia.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(727, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Numero civico e lettera";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLetteraCivico
            // 
            this.tbLetteraCivico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLetteraCivico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLetteraCivico.Location = new System.Drawing.Point(365, 178);
            this.tbLetteraCivico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLetteraCivico.Name = "tbLetteraCivico";
            this.tbLetteraCivico.Size = new System.Drawing.Size(364, 37);
            this.tbLetteraCivico.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(727, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nazione";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCodicePostale
            // 
            this.tbCodicePostale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodicePostale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodicePostale.Location = new System.Drawing.Point(4, 252);
            this.tbCodicePostale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCodicePostale.Name = "tbCodicePostale";
            this.tbCodicePostale.Size = new System.Drawing.Size(725, 37);
            this.tbCodicePostale.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 220);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(727, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Codice postale";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudQuantita
            // 
            this.nudQuantita.Enabled = false;
            this.nudQuantita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantita.Location = new System.Drawing.Point(776, 129);
            this.nudQuantita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudQuantita.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudQuantita.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantita.Name = "nudQuantita";
            this.nudQuantita.Size = new System.Drawing.Size(133, 37);
            this.nudQuantita.TabIndex = 5;
            this.nudQuantita.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(745, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 28);
            this.label9.TabIndex = 4;
            this.label9.Text = "Quantità";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmOrdine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 618);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudQuantita);
            this.Controls.Add(this.pnlIndirizzo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.nudIDArticolo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDataOrdine);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmOrdine";
            this.Text = "FrmOrdine";
            this.Load += new System.EventHandler(this.FrmOrdine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudIDArticolo)).EndInit();
            this.pnlIndirizzo.ResumeLayout(false);
            this.pnlIndirizzo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCivico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudIDArticolo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDataOrdine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlIndirizzo;
        private System.Windows.Forms.ComboBox cbNazione;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbComune;
        private System.Windows.Forms.TextBox tbVia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLetteraCivico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCodicePostale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudCivico;
        private System.Windows.Forms.NumericUpDown nudQuantita;
        private System.Windows.Forms.Label label9;
    }
}