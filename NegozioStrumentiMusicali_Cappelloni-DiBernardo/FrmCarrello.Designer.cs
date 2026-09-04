namespace NegozioStrumentiMusicali_Cappelloni_DiBernardo
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
            this.chTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCasaProduttrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modello = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chColori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrezzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuantità = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNegozio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRimossa = new System.Windows.Forms.Button();
            this.btnAggiunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvStrumenti
            // 
            this.lvStrumenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvStrumenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNegozio,
            this.chTipo,
            this.chCasaProduttrice,
            this.Modello,
            this.chColori,
            this.chPrezzo,
            this.chQuantità});
            this.lvStrumenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStrumenti.FullRowSelect = true;
            this.lvStrumenti.HideSelection = false;
            this.lvStrumenti.Location = new System.Drawing.Point(12, 12);
            this.lvStrumenti.MultiSelect = false;
            this.lvStrumenti.Name = "lvStrumenti";
            this.lvStrumenti.Size = new System.Drawing.Size(1083, 388);
            this.lvStrumenti.TabIndex = 61;
            this.lvStrumenti.UseCompatibleStateImageBehavior = false;
            this.lvStrumenti.View = System.Windows.Forms.View.Details;
            this.lvStrumenti.SelectedIndexChanged += new System.EventHandler(this.lvStrumenti_SelectedIndexChanged);
            // 
            // chTipo
            // 
            this.chTipo.Text = "Tipo";
            this.chTipo.Width = 120;
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
            // chPrezzo
            // 
            this.chPrezzo.Text = "Prezzo";
            this.chPrezzo.Width = 100;
            // 
            // chQuantità
            // 
            this.chQuantità.Text = "Quantità";
            this.chQuantità.Width = 110;
            // 
            // chNegozio
            // 
            this.chNegozio.Text = "Negozio";
            this.chNegozio.Width = 197;
            // 
            // btnRimossa
            // 
            this.btnRimossa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRimossa.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaMeno1_30x30;
            this.btnRimossa.Location = new System.Drawing.Point(1147, 74);
            this.btnRimossa.Name = "btnRimossa";
            this.btnRimossa.Size = new System.Drawing.Size(40, 40);
            this.btnRimossa.TabIndex = 63;
            this.btnRimossa.UseVisualStyleBackColor = true;
            // 
            // btnAggiunta
            // 
            this.btnAggiunta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggiunta.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaNuovo1_30x30;
            this.btnAggiunta.Location = new System.Drawing.Point(1101, 74);
            this.btnAggiunta.Name = "btnAggiunta";
            this.btnAggiunta.Size = new System.Drawing.Size(40, 40);
            this.btnAggiunta.TabIndex = 62;
            this.btnAggiunta.UseVisualStyleBackColor = true;
            // 
            // FrmCarrello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 542);
            this.Controls.Add(this.btnRimossa);
            this.Controls.Add(this.btnAggiunta);
            this.Controls.Add(this.lvStrumenti);
            this.Name = "FrmCarrello";
            this.Text = "FrmCarrello";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView lvStrumenti;
        private System.Windows.Forms.ColumnHeader chTipo;
        private System.Windows.Forms.ColumnHeader chCasaProduttrice;
        private System.Windows.Forms.ColumnHeader Modello;
        private System.Windows.Forms.ColumnHeader chColori;
        private System.Windows.Forms.ColumnHeader chPrezzo;
        private System.Windows.Forms.ColumnHeader chQuantità;
        private System.Windows.Forms.Button btnAggiunta;
        private System.Windows.Forms.ColumnHeader chNegozio;
        private System.Windows.Forms.Button btnRimossa;
    }
}