namespace NegozioStrumentiMusicali
{
    partial class FrmNegozi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNegozi));
            this.pnlMaster = new System.Windows.Forms.Panel();
            this.btnOrdina = new System.Windows.Forms.Button();
            this.cbParametriDiOrdinamento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCerca = new System.Windows.Forms.Button();
            this.tbRicerca = new System.Windows.Forms.TextBox();
            this.lvNegozi = new System.Windows.Forms.ListView();
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bandito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnNuovo = new System.Windows.Forms.Button();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.btnSalva = new System.Windows.Forms.Button();
            this.pbImmagine = new System.Windows.Forms.PictureBox();
            this.ckbBandito = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbComune = new System.Windows.Forms.TextBox();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.pnlMaster.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImmagine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            this.SuspendLayout();
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
            this.pnlMaster.Location = new System.Drawing.Point(0, 0);
            this.pnlMaster.Name = "pnlMaster";
            this.pnlMaster.Size = new System.Drawing.Size(642, 686);
            this.pnlMaster.TabIndex = 43;
            // 
            // btnOrdina
            // 
            this.btnOrdina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrdina.Location = new System.Drawing.Point(549, 4);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(40, 40);
            this.btnOrdina.TabIndex = 79;
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
            this.cbParametriDiOrdinamento.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 28);
            this.label8.TabIndex = 77;
            this.label8.Text = "Ordina per:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCerca
            // 
            this.btnCerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerca.Location = new System.Drawing.Point(549, 53);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(40, 40);
            this.btnCerca.TabIndex = 76;
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
            this.tbRicerca.TabIndex = 75;
            this.tbRicerca.Text = "Cerca per id o per nome...\r\n";
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
            this.chID,
            this.Bandito});
            this.lvNegozi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.chNome.Width = 250;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 200;
            // 
            // Bandito
            // 
            this.Bandito.Text = "Bandito";
            this.Bandito.Width = 125;
            // 
            // btnElimina
            // 
            this.btnElimina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElimina.Location = new System.Drawing.Point(595, 547);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(40, 40);
            this.btnElimina.TabIndex = 51;
            this.btnElimina.UseVisualStyleBackColor = true;
            // 
            // btnModifica
            // 
            this.btnModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifica.Location = new System.Drawing.Point(595, 593);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(40, 40);
            this.btnModifica.TabIndex = 50;
            this.btnModifica.UseVisualStyleBackColor = true;
            // 
            // btnNuovo
            // 
            this.btnNuovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuovo.Location = new System.Drawing.Point(595, 639);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(40, 40);
            this.btnNuovo.TabIndex = 49;
            this.btnNuovo.UseVisualStyleBackColor = true;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetail.BackColor = System.Drawing.Color.Transparent;
            this.pnlDetail.Controls.Add(this.btnSalva);
            this.pnlDetail.Controls.Add(this.pbImmagine);
            this.pnlDetail.Controls.Add(this.ckbBandito);
            this.pnlDetail.Controls.Add(this.numericUpDown1);
            this.pnlDetail.Controls.Add(this.label5);
            this.pnlDetail.Controls.Add(this.label4);
            this.pnlDetail.Controls.Add(this.tbVia);
            this.pnlDetail.Controls.Add(this.label3);
            this.pnlDetail.Controls.Add(this.tbComune);
            this.pnlDetail.Controls.Add(this.nudID);
            this.pnlDetail.Controls.Add(this.label2);
            this.pnlDetail.Controls.Add(this.label1);
            this.pnlDetail.Controls.Add(this.tbNome);
            this.pnlDetail.Location = new System.Drawing.Point(648, 0);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(533, 686);
            this.pnlDetail.TabIndex = 44;
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
            // pbImmagine
            // 
            this.pbImmagine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImmagine.BackColor = System.Drawing.Color.Transparent;
            this.pbImmagine.Image = ((System.Drawing.Image)(resources.GetObject("pbImmagine.Image")));
            this.pbImmagine.Location = new System.Drawing.Point(0, 351);
            this.pbImmagine.Name = "pbImmagine";
            this.pbImmagine.Size = new System.Drawing.Size(323, 323);
            this.pbImmagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImmagine.TabIndex = 13;
            this.pbImmagine.TabStop = false;
            // 
            // ckbBandito
            // 
            this.ckbBandito.AutoSize = true;
            this.ckbBandito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBandito.ForeColor = System.Drawing.Color.Yellow;
            this.ckbBandito.Location = new System.Drawing.Point(0, 12);
            this.ckbBandito.Name = "ckbBandito";
            this.ckbBandito.Size = new System.Drawing.Size(104, 29);
            this.ckbBandito.TabIndex = 12;
            this.ckbBandito.Text = "Bandito";
            this.ckbBandito.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(0, 314);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(524, 31);
            this.numericUpDown1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(0, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(524, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "CAP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(0, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(524, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Via";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbVia
            // 
            this.tbVia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVia.Location = new System.Drawing.Point(0, 254);
            this.tbVia.Name = "tbVia";
            this.tbVia.Size = new System.Drawing.Size(524, 31);
            this.tbVia.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(0, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(524, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Comune";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbComune
            // 
            this.tbComune.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComune.Location = new System.Drawing.Point(0, 194);
            this.tbComune.Name = "tbComune";
            this.tbComune.Size = new System.Drawing.Size(524, 31);
            this.tbComune.TabIndex = 6;
            // 
            // nudID
            // 
            this.nudID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudID.Location = new System.Drawing.Point(0, 134);
            this.nudID.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(524, 31);
            this.nudID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(0, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(524, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(0, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(0, 74);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(524, 31);
            this.tbNome.TabIndex = 1;
            // 
            // FrmNegozi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 686);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlMaster);
            this.Name = "FrmNegozi";
            this.Text = "Negozi";
            this.Load += new System.EventHandler(this.FrmNegozi_Load);
            this.pnlMaster.ResumeLayout(false);
            this.pnlMaster.PerformLayout();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImmagine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMaster;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.ListView lvNegozi;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader Bandito;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnNuovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbComune;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVia;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbBandito;
        private System.Windows.Forms.PictureBox pbImmagine;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnOrdina;
        private System.Windows.Forms.ComboBox cbParametriDiOrdinamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.TextBox tbRicerca;
    }
}