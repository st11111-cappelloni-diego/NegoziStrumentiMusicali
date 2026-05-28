namespace NegozioStrumentiMusicali
{
    partial class FrmOrdini
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVisualizzaArticolo = new System.Windows.Forms.Button();
            this.btnVisualizzaUtente = new System.Windows.Forms.Button();
            this.nudIDArticolo = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudIDOrdine = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDataOrdine = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUsernameCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlMaster = new System.Windows.Forms.Panel();
            this.btnOrdina = new System.Windows.Forms.Button();
            this.cbParametriDiOrdinamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltriRicerca = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.tbRicerca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNegozio = new System.Windows.Forms.ComboBox();
            this.lvOrdini = new System.Windows.Forms.ListView();
            this.chUsernameCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIDOrdine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIDArticolo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuantità = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnElimina = new System.Windows.Forms.Button();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIDArticolo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIDOrdine)).BeginInit();
            this.pnlMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetail.BackColor = System.Drawing.Color.Transparent;
            this.pnlDetail.Controls.Add(this.label10);
            this.pnlDetail.Controls.Add(this.label9);
            this.pnlDetail.Controls.Add(this.button2);
            this.pnlDetail.Controls.Add(this.button1);
            this.pnlDetail.Controls.Add(this.label8);
            this.pnlDetail.Controls.Add(this.label3);
            this.pnlDetail.Controls.Add(this.btnVisualizzaArticolo);
            this.pnlDetail.Controls.Add(this.btnVisualizzaUtente);
            this.pnlDetail.Controls.Add(this.nudIDArticolo);
            this.pnlDetail.Controls.Add(this.label7);
            this.pnlDetail.Controls.Add(this.nudIDOrdine);
            this.pnlDetail.Controls.Add(this.label5);
            this.pnlDetail.Controls.Add(this.dtpDataOrdine);
            this.pnlDetail.Controls.Add(this.label6);
            this.pnlDetail.Controls.Add(this.tbUsernameCliente);
            this.pnlDetail.Controls.Add(this.label4);
            this.pnlDetail.Location = new System.Drawing.Point(628, 0);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(528, 686);
            this.pnlDetail.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(437, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 23);
            this.label10.TabIndex = 82;
            this.label10.Text = "visualizza dettagli";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(437, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 81;
            this.label9.Text = "visualizza dettagli";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaVisualizza1_23x16;
            this.button2.Location = new System.Drawing.Point(382, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 32);
            this.button2.TabIndex = 80;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaVisualizza1_23x16;
            this.button1.Location = new System.Drawing.Point(356, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 32);
            this.button1.TabIndex = 79;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(519, 28);
            this.label8.TabIndex = 78;
            this.label8.Text = "Dettagli Indirizzo odine ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(519, 28);
            this.label3.TabIndex = 77;
            this.label3.Text = "Dettagli Negozio";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVisualizzaArticolo
            // 
            this.btnVisualizzaArticolo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizzaArticolo.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaVisualizza1_23x16;
            this.btnVisualizzaArticolo.Location = new System.Drawing.Point(472, 217);
            this.btnVisualizzaArticolo.Name = "btnVisualizzaArticolo";
            this.btnVisualizzaArticolo.Size = new System.Drawing.Size(46, 32);
            this.btnVisualizzaArticolo.TabIndex = 76;
            this.btnVisualizzaArticolo.UseVisualStyleBackColor = true;
            // 
            // btnVisualizzaUtente
            // 
            this.btnVisualizzaUtente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizzaUtente.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaVisualizza1_23x16;
            this.btnVisualizzaUtente.Location = new System.Drawing.Point(473, 40);
            this.btnVisualizzaUtente.Name = "btnVisualizzaUtente";
            this.btnVisualizzaUtente.Size = new System.Drawing.Size(46, 32);
            this.btnVisualizzaUtente.TabIndex = 75;
            this.btnVisualizzaUtente.UseVisualStyleBackColor = true;
            // 
            // nudIDArticolo
            // 
            this.nudIDArticolo.Enabled = false;
            this.nudIDArticolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIDArticolo.Location = new System.Drawing.Point(5, 219);
            this.nudIDArticolo.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudIDArticolo.Name = "nudIDArticolo";
            this.nudIDArticolo.ReadOnly = true;
            this.nudIDArticolo.Size = new System.Drawing.Size(462, 31);
            this.nudIDArticolo.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(5, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(519, 23);
            this.label7.TabIndex = 43;
            this.label7.Text = "ID Articolo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudIDOrdine
            // 
            this.nudIDOrdine.Enabled = false;
            this.nudIDOrdine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIDOrdine.Location = new System.Drawing.Point(5, 159);
            this.nudIDOrdine.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudIDOrdine.Name = "nudIDOrdine";
            this.nudIDOrdine.ReadOnly = true;
            this.nudIDOrdine.Size = new System.Drawing.Size(519, 31);
            this.nudIDOrdine.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(519, 23);
            this.label5.TabIndex = 41;
            this.label5.Text = "ID Ordine";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDataOrdine
            // 
            this.dtpDataOrdine.Enabled = false;
            this.dtpDataOrdine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataOrdine.Location = new System.Drawing.Point(5, 99);
            this.dtpDataOrdine.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataOrdine.Name = "dtpDataOrdine";
            this.dtpDataOrdine.Size = new System.Drawing.Size(519, 31);
            this.dtpDataOrdine.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(519, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Data ordine";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUsernameCliente
            // 
            this.tbUsernameCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsernameCliente.Location = new System.Drawing.Point(6, 40);
            this.tbUsernameCliente.Name = "tbUsernameCliente";
            this.tbUsernameCliente.ReadOnly = true;
            this.tbUsernameCliente.Size = new System.Drawing.Size(461, 31);
            this.tbUsernameCliente.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(519, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = " Username cliente";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMaster
            // 
            this.pnlMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMaster.BackColor = System.Drawing.Color.Transparent;
            this.pnlMaster.Controls.Add(this.btnOrdina);
            this.pnlMaster.Controls.Add(this.cbParametriDiOrdinamento);
            this.pnlMaster.Controls.Add(this.label2);
            this.pnlMaster.Controls.Add(this.btnFiltriRicerca);
            this.pnlMaster.Controls.Add(this.btnCerca);
            this.pnlMaster.Controls.Add(this.tbRicerca);
            this.pnlMaster.Controls.Add(this.label1);
            this.pnlMaster.Controls.Add(this.cbNegozio);
            this.pnlMaster.Controls.Add(this.lvOrdini);
            this.pnlMaster.Controls.Add(this.btnElimina);
            this.pnlMaster.Location = new System.Drawing.Point(2, 0);
            this.pnlMaster.Name = "pnlMaster";
            this.pnlMaster.Size = new System.Drawing.Size(620, 686);
            this.pnlMaster.TabIndex = 45;
            // 
            // btnOrdina
            // 
            this.btnOrdina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrdina.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaOrdina1_40x40;
            this.btnOrdina.Location = new System.Drawing.Point(573, 89);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(40, 40);
            this.btnOrdina.TabIndex = 72;
            this.btnOrdina.UseVisualStyleBackColor = true;
            // 
            // cbParametriDiOrdinamento
            // 
            this.cbParametriDiOrdinamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParametriDiOrdinamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParametriDiOrdinamento.FormattingEnabled = true;
            this.cbParametriDiOrdinamento.Location = new System.Drawing.Point(107, 63);
            this.cbParametriDiOrdinamento.Name = "cbParametriDiOrdinamento";
            this.cbParametriDiOrdinamento.Size = new System.Drawing.Size(176, 28);
            this.cbParametriDiOrdinamento.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 70;
            this.label2.Text = "Ordina per:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFiltriRicerca
            // 
            this.btnFiltriRicerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltriRicerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltriRicerca.Location = new System.Drawing.Point(492, 61);
            this.btnFiltriRicerca.Name = "btnFiltriRicerca";
            this.btnFiltriRicerca.Size = new System.Drawing.Size(75, 30);
            this.btnFiltriRicerca.TabIndex = 69;
            this.btnFiltriRicerca.Text = "Filtri...";
            this.btnFiltriRicerca.UseVisualStyleBackColor = true;
            // 
            // btnCerca
            // 
            this.btnCerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerca.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaLenteRicerca1_28x28;
            this.btnCerca.Location = new System.Drawing.Point(573, 43);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(40, 40);
            this.btnCerca.TabIndex = 68;
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // tbRicerca
            // 
            this.tbRicerca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRicerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRicerca.Location = new System.Drawing.Point(289, 63);
            this.tbRicerca.Name = "tbRicerca";
            this.tbRicerca.Size = new System.Drawing.Size(197, 26);
            this.tbRicerca.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 66;
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
            this.cbNegozio.Location = new System.Drawing.Point(107, 9);
            this.cbNegozio.Name = "cbNegozio";
            this.cbNegozio.Size = new System.Drawing.Size(506, 28);
            this.cbNegozio.TabIndex = 65;
            this.cbNegozio.SelectedIndexChanged += new System.EventHandler(this.cbNegozio_SelectedIndexChanged);
            // 
            // lvOrdini
            // 
            this.lvOrdini.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvOrdini.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUsernameCliente,
            this.chData,
            this.chIDOrdine,
            this.chIDArticolo,
            this.chQuantità});
            this.lvOrdini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOrdini.FullRowSelect = true;
            this.lvOrdini.HideSelection = false;
            this.lvOrdini.Location = new System.Drawing.Point(8, 95);
            this.lvOrdini.MultiSelect = false;
            this.lvOrdini.Name = "lvOrdini";
            this.lvOrdini.Size = new System.Drawing.Size(559, 584);
            this.lvOrdini.TabIndex = 52;
            this.lvOrdini.UseCompatibleStateImageBehavior = false;
            this.lvOrdini.View = System.Windows.Forms.View.Details;
            this.lvOrdini.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvOrdini_ItemSelectionChanged);
            // 
            // chUsernameCliente
            // 
            this.chUsernameCliente.Text = "Cliente";
            this.chUsernameCliente.Width = 150;
            // 
            // chData
            // 
            this.chData.Text = "Data";
            this.chData.Width = 125;
            // 
            // chIDOrdine
            // 
            this.chIDOrdine.Text = "ID ordine";
            this.chIDOrdine.Width = 105;
            // 
            // chIDArticolo
            // 
            this.chIDArticolo.Text = "ID articolo";
            this.chIDArticolo.Width = 105;
            // 
            // chQuantità
            // 
            this.chQuantità.Text = "Quantità";
            this.chQuantità.Width = 90;
            // 
            // btnElimina
            // 
            this.btnElimina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElimina.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaCestino1_35x35;
            this.btnElimina.Location = new System.Drawing.Point(573, 639);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(40, 40);
            this.btnElimina.TabIndex = 51;
            this.btnElimina.UseVisualStyleBackColor = true;
            // 
            // FrmOrdini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1157, 686);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlMaster);
            this.Name = "FrmOrdini";
            this.Text = "Ordini";
            this.Load += new System.EventHandler(this.FrmOrdini_Load);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIDArticolo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIDOrdine)).EndInit();
            this.pnlMaster.ResumeLayout(false);
            this.pnlMaster.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Panel pnlMaster;
        private System.Windows.Forms.ListView lvOrdini;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNegozio;
        private System.Windows.Forms.TextBox tbRicerca;
        private System.Windows.Forms.Button btnFiltriRicerca;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Button btnOrdina;
        private System.Windows.Forms.ComboBox cbParametriDiOrdinamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader chUsernameCliente;
        private System.Windows.Forms.ColumnHeader chData;
        private System.Windows.Forms.ColumnHeader chIDOrdine;
        private System.Windows.Forms.ColumnHeader chIDArticolo;
        private System.Windows.Forms.ColumnHeader chQuantità;
        private System.Windows.Forms.TextBox tbUsernameCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataOrdine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudIDArticolo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudIDOrdine;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVisualizzaArticolo;
        private System.Windows.Forms.Button btnVisualizzaUtente;
        private System.Windows.Forms.Label label10;
    }
}