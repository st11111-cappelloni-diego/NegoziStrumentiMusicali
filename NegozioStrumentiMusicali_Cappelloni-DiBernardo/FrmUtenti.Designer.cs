namespace NegozioStrumentiMusicali
{
    partial class FrmUtenti
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
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.btnVisualizzaPassword = new System.Windows.Forms.Button();
            this.pbImmagineProfilo = new System.Windows.Forms.PictureBox();
            this.cbGenere = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDataDiNascita = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCognome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.ckbBandito = new System.Windows.Forms.CheckBox();
            this.pnlMaster = new System.Windows.Forms.Panel();
            this.btnOrdina = new System.Windows.Forms.Button();
            this.cbParametriDiOrdinamento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCerca = new System.Windows.Forms.Button();
            this.tbRicerca = new System.Windows.Forms.TextBox();
            this.lvNegozi = new System.Windows.Forms.ListView();
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCognome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBandito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnNuovo = new System.Windows.Forms.Button();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImmagineProfilo)).BeginInit();
            this.pnlMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetail.BackColor = System.Drawing.Color.Transparent;
            this.pnlDetail.Controls.Add(this.btnVisualizzaPassword);
            this.pnlDetail.Controls.Add(this.pbImmagineProfilo);
            this.pnlDetail.Controls.Add(this.cbGenere);
            this.pnlDetail.Controls.Add(this.label7);
            this.pnlDetail.Controls.Add(this.dtpDataDiNascita);
            this.pnlDetail.Controls.Add(this.label6);
            this.pnlDetail.Controls.Add(this.tbCognome);
            this.pnlDetail.Controls.Add(this.label5);
            this.pnlDetail.Controls.Add(this.tbNome);
            this.pnlDetail.Controls.Add(this.label4);
            this.pnlDetail.Controls.Add(this.tbPassword);
            this.pnlDetail.Controls.Add(this.label3);
            this.pnlDetail.Controls.Add(this.tbEmail);
            this.pnlDetail.Controls.Add(this.label2);
            this.pnlDetail.Controls.Add(this.tbUsername);
            this.pnlDetail.Controls.Add(this.label1);
            this.pnlDetail.Controls.Add(this.btnSalva);
            this.pnlDetail.Controls.Add(this.ckbBandito);
            this.pnlDetail.Location = new System.Drawing.Point(650, 0);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(533, 686);
            this.pnlDetail.TabIndex = 46;
            // 
            // btnVisualizzaPassword
            // 
            this.btnVisualizzaPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizzaPassword.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaVisualizza1_23x16;
            this.btnVisualizzaPassword.Location = new System.Drawing.Point(476, 168);
            this.btnVisualizzaPassword.Name = "btnVisualizzaPassword";
            this.btnVisualizzaPassword.Size = new System.Drawing.Size(46, 29);
            this.btnVisualizzaPassword.TabIndex = 42;
            this.btnVisualizzaPassword.UseVisualStyleBackColor = true;
            // 
            // pbImmagineProfilo
            // 
            this.pbImmagineProfilo.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaUtente1_189x189;
            this.pbImmagineProfilo.Location = new System.Drawing.Point(8, 485);
            this.pbImmagineProfilo.Name = "pbImmagineProfilo";
            this.pbImmagineProfilo.Size = new System.Drawing.Size(189, 189);
            this.pbImmagineProfilo.TabIndex = 41;
            this.pbImmagineProfilo.TabStop = false;
            // 
            // cbGenere
            // 
            this.cbGenere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenere.FormattingEnabled = true;
            this.cbGenere.Location = new System.Drawing.Point(3, 443);
            this.cbGenere.Name = "cbGenere";
            this.cbGenere.Size = new System.Drawing.Size(519, 33);
            this.cbGenere.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(519, 23);
            this.label7.TabIndex = 39;
            this.label7.Text = "Genere";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDataDiNascita
            // 
            this.dtpDataDiNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDiNascita.Location = new System.Drawing.Point(3, 383);
            this.dtpDataDiNascita.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataDiNascita.Name = "dtpDataDiNascita";
            this.dtpDataDiNascita.Size = new System.Drawing.Size(519, 31);
            this.dtpDataDiNascita.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(519, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "Data di nascita";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCognome
            // 
            this.tbCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCognome.Location = new System.Drawing.Point(3, 323);
            this.tbCognome.Name = "tbCognome";
            this.tbCognome.Size = new System.Drawing.Size(519, 31);
            this.tbCognome.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(519, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Cognome";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(3, 263);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(519, 31);
            this.tbNome.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(519, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nome";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(3, 203);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(519, 31);
            this.tbPassword.TabIndex = 32;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(519, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(3, 134);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(519, 31);
            this.tbEmail.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(3, 74);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(519, 31);
            this.tbUsername.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Username\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(335, 630);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(195, 44);
            this.btnSalva.TabIndex = 14;
            this.btnSalva.Text = "Salva modifiche";
            this.btnSalva.UseVisualStyleBackColor = true;
            // 
            // ckbBandito
            // 
            this.ckbBandito.AutoSize = true;
            this.ckbBandito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBandito.ForeColor = System.Drawing.Color.Black;
            this.ckbBandito.Location = new System.Drawing.Point(6, 12);
            this.ckbBandito.Name = "ckbBandito";
            this.ckbBandito.Size = new System.Drawing.Size(104, 29);
            this.ckbBandito.TabIndex = 12;
            this.ckbBandito.Text = "Bandito";
            this.ckbBandito.UseVisualStyleBackColor = true;
            // 
            // pnlMaster
            // 
            this.pnlMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMaster.BackColor = System.Drawing.Color.Transparent;
            this.pnlMaster.Controls.Add(this.btnOrdina);
            this.pnlMaster.Controls.Add(this.cbParametriDiOrdinamento);
            this.pnlMaster.Controls.Add(this.label8);
            this.pnlMaster.Controls.Add(this.btnCerca);
            this.pnlMaster.Controls.Add(this.tbRicerca);
            this.pnlMaster.Controls.Add(this.lvNegozi);
            this.pnlMaster.Controls.Add(this.btnElimina);
            this.pnlMaster.Controls.Add(this.btnModifica);
            this.pnlMaster.Controls.Add(this.btnNuovo);
            this.pnlMaster.Location = new System.Drawing.Point(2, 0);
            this.pnlMaster.Name = "pnlMaster";
            this.pnlMaster.Size = new System.Drawing.Size(642, 686);
            this.pnlMaster.TabIndex = 45;
            // 
            // btnOrdina
            // 
            this.btnOrdina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrdina.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaOrdina1_40x40;
            this.btnOrdina.Location = new System.Drawing.Point(549, 4);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(40, 40);
            this.btnOrdina.TabIndex = 74;
            this.btnOrdina.UseVisualStyleBackColor = true;
            // 
            // cbParametriDiOrdinamento
            // 
            this.cbParametriDiOrdinamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbParametriDiOrdinamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParametriDiOrdinamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParametriDiOrdinamento.FormattingEnabled = true;
            this.cbParametriDiOrdinamento.Location = new System.Drawing.Point(117, 8);
            this.cbParametriDiOrdinamento.Name = "cbParametriDiOrdinamento";
            this.cbParametriDiOrdinamento.Size = new System.Drawing.Size(426, 28);
            this.cbParametriDiOrdinamento.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 28);
            this.label8.TabIndex = 72;
            this.label8.Text = "Ordina per:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCerca
            // 
            this.btnCerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerca.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaLenteRicerca1_28x28;
            this.btnCerca.Location = new System.Drawing.Point(549, 53);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(40, 40);
            this.btnCerca.TabIndex = 54;
            this.btnCerca.UseVisualStyleBackColor = true;
            // 
            // tbRicerca
            // 
            this.tbRicerca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRicerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRicerca.ForeColor = System.Drawing.Color.Gray;
            this.tbRicerca.Location = new System.Drawing.Point(8, 67);
            this.tbRicerca.Name = "tbRicerca";
            this.tbRicerca.Size = new System.Drawing.Size(535, 26);
            this.tbRicerca.TabIndex = 53;
            this.tbRicerca.Text = "Cerca per nome, cognome, username o email...";
            this.tbRicerca.Enter += new System.EventHandler(this.tbRicerca_Enter);
            this.tbRicerca.Leave += new System.EventHandler(this.tbRicerca_Leave);
            // 
            // lvNegozi
            // 
            this.lvNegozi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvNegozi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNome,
            this.chCognome,
            this.chUsername,
            this.chEmail,
            this.chBandito});
            this.lvNegozi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvNegozi.FullRowSelect = true;
            this.lvNegozi.HideSelection = false;
            this.lvNegozi.Location = new System.Drawing.Point(8, 99);
            this.lvNegozi.MultiSelect = false;
            this.lvNegozi.Name = "lvNegozi";
            this.lvNegozi.Size = new System.Drawing.Size(581, 580);
            this.lvNegozi.TabIndex = 52;
            this.lvNegozi.UseCompatibleStateImageBehavior = false;
            this.lvNegozi.View = System.Windows.Forms.View.Details;
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.Width = 120;
            // 
            // chCognome
            // 
            this.chCognome.Text = "Cognome";
            this.chCognome.Width = 120;
            // 
            // chUsername
            // 
            this.chUsername.Text = "Username";
            this.chUsername.Width = 125;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.Width = 125;
            // 
            // chBandito
            // 
            this.chBandito.Text = "Bandito";
            this.chBandito.Width = 80;
            // 
            // btnElimina
            // 
            this.btnElimina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElimina.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaCestino1_35x35;
            this.btnElimina.Location = new System.Drawing.Point(595, 547);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(40, 40);
            this.btnElimina.TabIndex = 51;
            this.btnElimina.UseVisualStyleBackColor = true;
            // 
            // btnModifica
            // 
            this.btnModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifica.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaModifica1_30x30;
            this.btnModifica.Location = new System.Drawing.Point(595, 593);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(40, 40);
            this.btnModifica.TabIndex = 50;
            this.btnModifica.UseVisualStyleBackColor = true;
            // 
            // btnNuovo
            // 
            this.btnNuovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuovo.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaNuovo1_30x30;
            this.btnNuovo.Location = new System.Drawing.Point(595, 639);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(40, 40);
            this.btnNuovo.TabIndex = 49;
            this.btnNuovo.UseVisualStyleBackColor = true;
            // 
            // FrmUtenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1184, 686);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlMaster);
            this.Name = "FrmUtenti";
            this.Text = "Utenti";
            this.Load += new System.EventHandler(this.FrmUtenti_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImmagineProfilo)).EndInit();
            this.pnlMaster.ResumeLayout(false);
            this.pnlMaster.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.CheckBox ckbBandito;
        private System.Windows.Forms.Panel pnlMaster;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.TextBox tbRicerca;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnNuovo;
        private System.Windows.Forms.ListView lvNegozi;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chCognome;
        private System.Windows.Forms.ComboBox cbGenere;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDataDiNascita;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCognome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader chUsername;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chBandito;
        private System.Windows.Forms.PictureBox pbImmagineProfilo;
        private System.Windows.Forms.Button btnVisualizzaPassword;
        private System.Windows.Forms.Button btnOrdina;
        private System.Windows.Forms.ComboBox cbParametriDiOrdinamento;
        private System.Windows.Forms.Label label8;
    }
}