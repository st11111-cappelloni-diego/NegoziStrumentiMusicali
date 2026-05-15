namespace NegozioStrumentiMusicali
{
    partial class FrmStrumentoMusicale
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbStrumento = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQuantita = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbColori = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudPrezzo = new System.Windows.Forms.NumericUpDown();
            this.tbModello = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCasaProduttrice = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNotaMinima = new System.Windows.Forms.ComboBox();
            this.cbNotaMassima = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnInfoSpecifiche = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminaCaratteristica = new System.Windows.Forms.Button();
            this.btnModificaCaratteristica = new System.Windows.Forms.Button();
            this.btnNuovaCaratteristica = new System.Windows.Forms.Button();
            this.lvAltreCaratteristiche = new System.Windows.Forms.ListView();
            this.chTitolo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVisualizzaCaratteristica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Strumento:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbStrumento
            // 
            this.cbStrumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStrumento.FormattingEnabled = true;
            this.cbStrumento.Location = new System.Drawing.Point(108, 7);
            this.cbStrumento.Name = "cbStrumento";
            this.cbStrumento.Size = new System.Drawing.Size(680, 28);
            this.cbStrumento.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(258, 20);
            this.label15.TabIndex = 9;
            this.label15.Text = "ID";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudID
            // 
            this.nudID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudID.Location = new System.Drawing.Point(12, 93);
            this.nudID.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(258, 26);
            this.nudID.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quantità";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudQuantità
            // 
            this.nudQuantita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantita.Location = new System.Drawing.Point(12, 147);
            this.nudQuantita.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQuantita.Name = "nudQuantità";
            this.nudQuantita.Size = new System.Drawing.Size(258, 26);
            this.nudQuantita.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Colori";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbColori
            // 
            this.tbColori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColori.Location = new System.Drawing.Point(12, 251);
            this.tbColori.Name = "tbColori";
            this.tbColori.Size = new System.Drawing.Size(258, 26);
            this.tbColori.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Prezzo [euro]";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudPrezzo
            // 
            this.nudPrezzo.DecimalPlaces = 2;
            this.nudPrezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrezzo.Location = new System.Drawing.Point(12, 199);
            this.nudPrezzo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrezzo.Name = "nudPrezzo";
            this.nudPrezzo.Size = new System.Drawing.Size(258, 26);
            this.nudPrezzo.TabIndex = 16;
            // 
            // tbModello
            // 
            this.tbModello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModello.Location = new System.Drawing.Point(12, 357);
            this.tbModello.Name = "tbModello";
            this.tbModello.Size = new System.Drawing.Size(258, 26);
            this.tbModello.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Modello";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Casa produttrice";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCasaProduttrice
            // 
            this.cbCasaProduttrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCasaProduttrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCasaProduttrice.FormattingEnabled = true;
            this.cbCasaProduttrice.Location = new System.Drawing.Point(12, 303);
            this.cbCasaProduttrice.Name = "cbCasaProduttrice";
            this.cbCasaProduttrice.Size = new System.Drawing.Size(258, 28);
            this.cbCasaProduttrice.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(276, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nota minima";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbNotaMinima
            // 
            this.cbNotaMinima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNotaMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNotaMinima.FormattingEnabled = true;
            this.cbNotaMinima.Location = new System.Drawing.Point(276, 93);
            this.cbNotaMinima.Name = "cbNotaMinima";
            this.cbNotaMinima.Size = new System.Drawing.Size(258, 28);
            this.cbNotaMinima.TabIndex = 22;
            // 
            // cbNotaMassima
            // 
            this.cbNotaMassima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNotaMassima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNotaMassima.FormattingEnabled = true;
            this.cbNotaMassima.Location = new System.Drawing.Point(276, 145);
            this.cbNotaMassima.Name = "cbNotaMassima";
            this.cbNotaMassima.Size = new System.Drawing.Size(258, 28);
            this.cbNotaMassima.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Nota massima";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(276, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Peso [kg]";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudPeso
            // 
            this.nudPeso.DecimalPlaces = 2;
            this.nudPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPeso.Location = new System.Drawing.Point(276, 199);
            this.nudPeso.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(258, 26);
            this.nudPeso.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(276, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(512, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Altre caratteristiche";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(683, 409);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(105, 29);
            this.btnSalva.TabIndex = 30;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            // 
            // btnInfoSpecifiche
            // 
            this.btnInfoSpecifiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoSpecifiche.Location = new System.Drawing.Point(466, 409);
            this.btnInfoSpecifiche.Name = "btnInfoSpecifiche";
            this.btnInfoSpecifiche.Size = new System.Drawing.Size(211, 29);
            this.btnInfoSpecifiche.TabIndex = 31;
            this.btnInfoSpecifiche.Text = "Informazioni specifiche";
            this.btnInfoSpecifiche.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(540, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 157);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminaCaratteristica
            // 
            this.btnEliminaCaratteristica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminaCaratteristica.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaCestino1_35x35;
            this.btnEliminaCaratteristica.Location = new System.Drawing.Point(276, 386);
            this.btnEliminaCaratteristica.Name = "btnEliminaCaratteristica";
            this.btnEliminaCaratteristica.Size = new System.Drawing.Size(40, 40);
            this.btnEliminaCaratteristica.TabIndex = 54;
            this.btnEliminaCaratteristica.UseVisualStyleBackColor = true;
            // 
            // btnModificaCaratteristica
            // 
            this.btnModificaCaratteristica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificaCaratteristica.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaModifica1_30x30;
            this.btnModificaCaratteristica.Location = new System.Drawing.Point(322, 386);
            this.btnModificaCaratteristica.Name = "btnModificaCaratteristica";
            this.btnModificaCaratteristica.Size = new System.Drawing.Size(40, 40);
            this.btnModificaCaratteristica.TabIndex = 53;
            this.btnModificaCaratteristica.UseVisualStyleBackColor = true;
            // 
            // btnNuovaCaratteristica
            // 
            this.btnNuovaCaratteristica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuovaCaratteristica.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaNuovo1_30x30;
            this.btnNuovaCaratteristica.Location = new System.Drawing.Point(368, 386);
            this.btnNuovaCaratteristica.Name = "btnNuovaCaratteristica";
            this.btnNuovaCaratteristica.Size = new System.Drawing.Size(40, 40);
            this.btnNuovaCaratteristica.TabIndex = 52;
            this.btnNuovaCaratteristica.UseVisualStyleBackColor = true;
            // 
            // lvAltreCaratteristiche
            // 
            this.lvAltreCaratteristiche.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitolo,
            this.chTesto});
            this.lvAltreCaratteristiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAltreCaratteristiche.HideSelection = false;
            this.lvAltreCaratteristiche.Location = new System.Drawing.Point(276, 259);
            this.lvAltreCaratteristiche.Name = "lvAltreCaratteristiche";
            this.lvAltreCaratteristiche.Size = new System.Drawing.Size(512, 121);
            this.lvAltreCaratteristiche.TabIndex = 55;
            this.lvAltreCaratteristiche.UseCompatibleStateImageBehavior = false;
            this.lvAltreCaratteristiche.View = System.Windows.Forms.View.Details;
            // 
            // chTitolo
            // 
            this.chTitolo.Text = "Titolo";
            this.chTitolo.Width = 150;
            // 
            // chTesto
            // 
            this.chTesto.Text = "Testo";
            this.chTesto.Width = 350;
            // 
            // btnVisualizzaCaratteristica
            // 
            this.btnVisualizzaCaratteristica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizzaCaratteristica.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaVisualizza1_30x21;
            this.btnVisualizzaCaratteristica.Location = new System.Drawing.Point(414, 386);
            this.btnVisualizzaCaratteristica.Name = "btnVisualizzaCaratteristica";
            this.btnVisualizzaCaratteristica.Size = new System.Drawing.Size(40, 40);
            this.btnVisualizzaCaratteristica.TabIndex = 82;
            this.btnVisualizzaCaratteristica.UseVisualStyleBackColor = true;
            // 
            // FrmStrumentoMusicale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisualizzaCaratteristica);
            this.Controls.Add(this.lvAltreCaratteristiche);
            this.Controls.Add(this.btnEliminaCaratteristica);
            this.Controls.Add(this.btnModificaCaratteristica);
            this.Controls.Add(this.btnNuovaCaratteristica);
            this.Controls.Add(this.btnInfoSpecifiche);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudPeso);
            this.Controls.Add(this.cbNotaMassima);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbNotaMinima);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCasaProduttrice);
            this.Controls.Add(this.tbModello);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudPrezzo);
            this.Controls.Add(this.tbColori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudQuantita);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.nudID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStrumento);
            this.MaximizeBox = false;
            this.Name = "FrmStrumentoMusicale";
            this.Text = "FrmStrumentoMusicale";
            this.Load += new System.EventHandler(this.FrmStrumentoMusicale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStrumento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQuantita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbColori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudPrezzo;
        private System.Windows.Forms.TextBox tbModello;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCasaProduttrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbNotaMinima;
        private System.Windows.Forms.ComboBox cbNotaMassima;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnInfoSpecifiche;
        private System.Windows.Forms.Button btnEliminaCaratteristica;
        private System.Windows.Forms.Button btnModificaCaratteristica;
        private System.Windows.Forms.Button btnNuovaCaratteristica;
        private System.Windows.Forms.ListView lvAltreCaratteristiche;
        private System.Windows.Forms.ColumnHeader chTitolo;
        private System.Windows.Forms.ColumnHeader chTesto;
        private System.Windows.Forms.Button btnVisualizzaCaratteristica;
    }
}