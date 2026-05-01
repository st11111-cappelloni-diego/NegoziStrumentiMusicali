namespace NegozioStrumentiMusicali
{
    partial class FrmStrumentiMusicali
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
            this.lvStrumenti = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCasaProduttrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modello = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chColori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrezzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuantità = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbParametriDiOrdinamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltriRicerca = new System.Windows.Forms.Button();
            this.tbRicerca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNegozio = new System.Windows.Forms.ComboBox();
            this.btnInfoNegozio = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnOrdina = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnNuovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvStrumenti
            // 
            this.lvStrumenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvStrumenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chCasaProduttrice,
            this.Modello,
            this.chColori,
            this.chPrezzo,
            this.chQuantità});
            this.lvStrumenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStrumenti.FullRowSelect = true;
            this.lvStrumenti.HideSelection = false;
            this.lvStrumenti.Location = new System.Drawing.Point(14, 99);
            this.lvStrumenti.MultiSelect = false;
            this.lvStrumenti.Name = "lvStrumenti";
            this.lvStrumenti.Size = new System.Drawing.Size(997, 580);
            this.lvStrumenti.TabIndex = 60;
            this.lvStrumenti.UseCompatibleStateImageBehavior = false;
            this.lvStrumenti.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 125;
            // 
            // chCasaProduttrice
            // 
            this.chCasaProduttrice.Text = "Casa produttrice";
            this.chCasaProduttrice.Width = 225;
            // 
            // Modello
            // 
            this.Modello.Text = "Modello";
            this.Modello.Width = 225;
            // 
            // chColori
            // 
            this.chColori.Text = "Colori";
            this.chColori.Width = 150;
            // 
            // chPrezzo
            // 
            this.chPrezzo.Text = "Prezzo";
            this.chPrezzo.Width = 150;
            // 
            // chQuantità
            // 
            this.chQuantità.Text = "Quantità";
            this.chQuantità.Width = 115;
            // 
            // cbParametriDiOrdinamento
            // 
            this.cbParametriDiOrdinamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParametriDiOrdinamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParametriDiOrdinamento.FormattingEnabled = true;
            this.cbParametriDiOrdinamento.Location = new System.Drawing.Point(121, 64);
            this.cbParametriDiOrdinamento.Name = "cbParametriDiOrdinamento";
            this.cbParametriDiOrdinamento.Size = new System.Drawing.Size(260, 28);
            this.cbParametriDiOrdinamento.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 28);
            this.label2.TabIndex = 78;
            this.label2.Text = "Ordina per:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFiltriRicerca
            // 
            this.btnFiltriRicerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltriRicerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltriRicerca.Location = new System.Drawing.Point(927, 63);
            this.btnFiltriRicerca.Name = "btnFiltriRicerca";
            this.btnFiltriRicerca.Size = new System.Drawing.Size(75, 30);
            this.btnFiltriRicerca.TabIndex = 77;
            this.btnFiltriRicerca.Text = "Filtri...";
            this.btnFiltriRicerca.UseVisualStyleBackColor = true;
            // 
            // tbRicerca
            // 
            this.tbRicerca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRicerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRicerca.Location = new System.Drawing.Point(387, 66);
            this.tbRicerca.Name = "tbRicerca";
            this.tbRicerca.Size = new System.Drawing.Size(534, 26);
            this.tbRicerca.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 74;
            this.label1.Text = "Negozio:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbNegozio
            // 
            this.cbNegozio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNegozio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNegozio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNegozio.FormattingEnabled = true;
            this.cbNegozio.Location = new System.Drawing.Point(121, 9);
            this.cbNegozio.Name = "cbNegozio";
            this.cbNegozio.Size = new System.Drawing.Size(890, 28);
            this.cbNegozio.TabIndex = 73;
            this.cbNegozio.SelectedIndexChanged += new System.EventHandler(this.cbNegozio_SelectedIndexChanged);
            // 
            // btnInfoNegozio
            // 
            this.btnInfoNegozio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoNegozio.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaInformazioni1_45x45;
            this.btnInfoNegozio.Location = new System.Drawing.Point(1017, 3);
            this.btnInfoNegozio.Name = "btnInfoNegozio";
            this.btnInfoNegozio.Size = new System.Drawing.Size(40, 40);
            this.btnInfoNegozio.TabIndex = 82;
            this.btnInfoNegozio.UseVisualStyleBackColor = true;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizza.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaVisualizza1_30x21;
            this.btnVisualizza.Location = new System.Drawing.Point(1017, 501);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(40, 40);
            this.btnVisualizza.TabIndex = 81;
            this.btnVisualizza.UseVisualStyleBackColor = true;
            // 
            // btnOrdina
            // 
            this.btnOrdina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrdina.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaOrdina1_40x40;
            this.btnOrdina.Location = new System.Drawing.Point(1017, 89);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(40, 40);
            this.btnOrdina.TabIndex = 80;
            this.btnOrdina.UseVisualStyleBackColor = true;
            // 
            // btnCerca
            // 
            this.btnCerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerca.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaLenteRicerca1_28x28;
            this.btnCerca.Location = new System.Drawing.Point(1017, 49);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(40, 40);
            this.btnCerca.TabIndex = 76;
            this.btnCerca.UseVisualStyleBackColor = true;
            // 
            // btnElimina
            // 
            this.btnElimina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElimina.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaCestino1_35x35;
            this.btnElimina.Location = new System.Drawing.Point(1017, 547);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(40, 40);
            this.btnElimina.TabIndex = 59;
            this.btnElimina.UseVisualStyleBackColor = true;
            // 
            // btnModifica
            // 
            this.btnModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifica.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaModifica1_30x30;
            this.btnModifica.Location = new System.Drawing.Point(1017, 593);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(40, 40);
            this.btnModifica.TabIndex = 58;
            this.btnModifica.UseVisualStyleBackColor = true;
            // 
            // btnNuovo
            // 
            this.btnNuovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuovo.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaNuovo1_30x30;
            this.btnNuovo.Location = new System.Drawing.Point(1017, 639);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(40, 40);
            this.btnNuovo.TabIndex = 57;
            this.btnNuovo.UseVisualStyleBackColor = true;
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // FrmStrumentiMusicali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1155, 686);
            this.Controls.Add(this.btnInfoNegozio);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnOrdina);
            this.Controls.Add(this.cbParametriDiOrdinamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFiltriRicerca);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.tbRicerca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNegozio);
            this.Controls.Add(this.lvStrumenti);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnNuovo);
            this.Name = "FrmStrumentiMusicali";
            this.Text = "Strumenti";
            this.Load += new System.EventHandler(this.FrmStrumentiMusicali_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvStrumenti;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chCasaProduttrice;
        private System.Windows.Forms.ColumnHeader Modello;
        private System.Windows.Forms.ColumnHeader chColori;
        private System.Windows.Forms.ColumnHeader chPrezzo;
        private System.Windows.Forms.ColumnHeader chQuantità;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnNuovo;
        private System.Windows.Forms.Button btnOrdina;
        private System.Windows.Forms.ComboBox cbParametriDiOrdinamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiltriRicerca;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.TextBox tbRicerca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNegozio;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnInfoNegozio;
    }
}