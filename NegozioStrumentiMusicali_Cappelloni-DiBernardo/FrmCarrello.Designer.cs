namespace NegozioStrumentiMusicali
{
    partial class FrmCarrello
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
            this.chCasaProduttrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modello = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chColori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuantità = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrezzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRimossa = new System.Windows.Forms.Button();
            this.btnAggiunta = new System.Windows.Forms.Button();
            this.btnInfoNegozio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNegozio = new System.Windows.Forms.ComboBox();
            this.btnOdina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvStrumenti
            // 
            this.lvStrumenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvStrumenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCasaProduttrice,
            this.Modello,
            this.chColori,
            this.chQuantità,
            this.chPrezzo});
            this.lvStrumenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStrumenti.FullRowSelect = true;
            this.lvStrumenti.HideSelection = false;
            this.lvStrumenti.Location = new System.Drawing.Point(16, 63);
            this.lvStrumenti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvStrumenti.MultiSelect = false;
            this.lvStrumenti.Name = "lvStrumenti";
            this.lvStrumenti.Size = new System.Drawing.Size(1235, 589);
            this.lvStrumenti.TabIndex = 61;
            this.lvStrumenti.UseCompatibleStateImageBehavior = false;
            this.lvStrumenti.View = System.Windows.Forms.View.Details;
            this.lvStrumenti.SelectedIndexChanged += new System.EventHandler(this.lvStrumenti_SelectedIndexChanged);
            // 
            // chCasaProduttrice
            // 
            this.chCasaProduttrice.Text = "Casa produttrice";
            this.chCasaProduttrice.Width = 200;
            // 
            // Modello
            // 
            this.Modello.Text = "Modello";
            this.Modello.Width = 200;
            // 
            // chColori
            // 
            this.chColori.Text = "Colori";
            this.chColori.Width = 150;
            // 
            // chQuantità
            // 
            this.chQuantità.Text = "Quantità";
            this.chQuantità.Width = 110;
            // 
            // chPrezzo
            // 
            this.chPrezzo.Text = "Prezzo";
            this.chPrezzo.Width = 100;
            // 
            // btnRimossa
            // 
            this.btnRimossa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRimossa.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaMeno1_30x30;
            this.btnRimossa.Location = new System.Drawing.Point(1325, 185);
            this.btnRimossa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRimossa.Name = "btnRimossa";
            this.btnRimossa.Size = new System.Drawing.Size(53, 49);
            this.btnRimossa.TabIndex = 63;
            this.btnRimossa.UseVisualStyleBackColor = true;
            this.btnRimossa.Click += new System.EventHandler(this.btnRimossa_Click);
            // 
            // btnAggiunta
            // 
            this.btnAggiunta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiunta.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaNuovo1_30x30;
            this.btnAggiunta.Location = new System.Drawing.Point(1260, 185);
            this.btnAggiunta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAggiunta.Name = "btnAggiunta";
            this.btnAggiunta.Size = new System.Drawing.Size(53, 49);
            this.btnAggiunta.TabIndex = 62;
            this.btnAggiunta.UseVisualStyleBackColor = true;
            this.btnAggiunta.Click += new System.EventHandler(this.btnAggiunta_Click);
            // 
            // btnInfoNegozio
            // 
            this.btnInfoNegozio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoNegozio.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaInformazioni1_45x45;
            this.btnInfoNegozio.Location = new System.Drawing.Point(1196, 6);
            this.btnInfoNegozio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInfoNegozio.Name = "btnInfoNegozio";
            this.btnInfoNegozio.Size = new System.Drawing.Size(56, 49);
            this.btnInfoNegozio.TabIndex = 85;
            this.btnInfoNegozio.UseVisualStyleBackColor = true;
            this.btnInfoNegozio.Click += new System.EventHandler(this.btnInfoNegozio_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 34);
            this.label1.TabIndex = 84;
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
            this.cbNegozio.Location = new System.Drawing.Point(159, 14);
            this.cbNegozio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNegozio.Name = "cbNegozio";
            this.cbNegozio.Size = new System.Drawing.Size(1028, 33);
            this.cbNegozio.TabIndex = 83;
            this.cbNegozio.SelectedIndexChanged += new System.EventHandler(this.cbNegozio_SelectedIndexChanged);
            // 
            // btnOdina
            // 
            this.btnOdina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdina.Location = new System.Drawing.Point(1259, 582);
            this.btnOdina.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdina.Name = "btnOdina";
            this.btnOdina.Size = new System.Drawing.Size(119, 70);
            this.btnOdina.TabIndex = 86;
            this.btnOdina.Text = "CREA ORDINE NEGOZIO";
            this.btnOdina.UseVisualStyleBackColor = true;
            this.btnOdina.Click += new System.EventHandler(this.btnOdina_Click);
            // 
            // FrmCarrello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1391, 667);
            this.Controls.Add(this.btnOdina);
            this.Controls.Add(this.btnInfoNegozio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNegozio);
            this.Controls.Add(this.btnRimossa);
            this.Controls.Add(this.btnAggiunta);
            this.Controls.Add(this.lvStrumenti);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCarrello";
            this.Text = "FrmCarrello";
            this.Load += new System.EventHandler(this.FrmCarrello_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView lvStrumenti;
        private System.Windows.Forms.ColumnHeader chCasaProduttrice;
        private System.Windows.Forms.ColumnHeader Modello;
        private System.Windows.Forms.ColumnHeader chColori;
        private System.Windows.Forms.ColumnHeader chPrezzo;
        private System.Windows.Forms.ColumnHeader chQuantità;
        private System.Windows.Forms.Button btnAggiunta;
        private System.Windows.Forms.Button btnRimossa;
        private System.Windows.Forms.Button btnInfoNegozio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNegozio;
        private System.Windows.Forms.Button btnOdina;
    }
}