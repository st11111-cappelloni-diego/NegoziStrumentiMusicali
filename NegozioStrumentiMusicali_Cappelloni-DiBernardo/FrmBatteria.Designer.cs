namespace NegozioStrumentiMusicali
{
    partial class FrmBatteria
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
            this.pnlCassa = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cbMaterialeCassa = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nudStratiCassa = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.nudDiametroCassa = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlRullante = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMaterialeRullante = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudStratiRullante = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDiametroRullante = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCharleston = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMaterialeCharleston = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudDiametroCharleston = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlToms = new System.Windows.Forms.Panel();
            this.btnEliminaTom = new System.Windows.Forms.Button();
            this.lvToms = new System.Windows.Forms.ListView();
            this.chTipoTamburo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDiametroTamburo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStratiTamburo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMaterialeTamburo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnModificaTom = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btnNuovoTom = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.pnlAltriPiatti = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminaPiatto = new System.Windows.Forms.Button();
            this.btnModificaPiatto = new System.Windows.Forms.Button();
            this.lvAltriPiatti = new System.Windows.Forms.ListView();
            this.chTipoPiatto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDiametroPiatto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMaterialePiatto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNuovoPiatto = new System.Windows.Forms.Button();
            this.pnlCassa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStratiCassa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiametroCassa)).BeginInit();
            this.pnlRullante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStratiRullante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiametroRullante)).BeginInit();
            this.pnlCharleston.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiametroCharleston)).BeginInit();
            this.pnlToms.SuspendLayout();
            this.pnlAltriPiatti.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCassa
            // 
            this.pnlCassa.Controls.Add(this.label12);
            this.pnlCassa.Controls.Add(this.cbMaterialeCassa);
            this.pnlCassa.Controls.Add(this.label14);
            this.pnlCassa.Controls.Add(this.nudStratiCassa);
            this.pnlCassa.Controls.Add(this.label15);
            this.pnlCassa.Controls.Add(this.nudDiametroCassa);
            this.pnlCassa.Controls.Add(this.label16);
            this.pnlCassa.Location = new System.Drawing.Point(9, 15);
            this.pnlCassa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCassa.Name = "pnlCassa";
            this.pnlCassa.Size = new System.Drawing.Size(389, 276);
            this.pnlCassa.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 186);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(381, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "Materiale tamburo";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMaterialeCassa
            // 
            this.cbMaterialeCassa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterialeCassa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterialeCassa.FormattingEnabled = true;
            this.cbMaterialeCassa.Location = new System.Drawing.Point(4, 217);
            this.cbMaterialeCassa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaterialeCassa.Name = "cbMaterialeCassa";
            this.cbMaterialeCassa.Size = new System.Drawing.Size(380, 33);
            this.cbMaterialeCassa.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 122);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(381, 25);
            this.label14.TabIndex = 9;
            this.label14.Text = "Strati";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudStratiCassa
            // 
            this.nudStratiCassa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStratiCassa.Location = new System.Drawing.Point(4, 150);
            this.nudStratiCassa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudStratiCassa.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudStratiCassa.Name = "nudStratiCassa";
            this.nudStratiCassa.Size = new System.Drawing.Size(381, 30);
            this.nudStratiCassa.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 55);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(381, 25);
            this.label15.TabIndex = 7;
            this.label15.Text = "Diametro [in]";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudDiametroCassa
            // 
            this.nudDiametroCassa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiametroCassa.Location = new System.Drawing.Point(4, 86);
            this.nudDiametroCassa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudDiametroCassa.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDiametroCassa.Name = "nudDiametroCassa";
            this.nudDiametroCassa.Size = new System.Drawing.Size(381, 30);
            this.nudDiametroCassa.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 20);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(381, 36);
            this.label16.TabIndex = 7;
            this.label16.Text = "Cassa";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRullante
            // 
            this.pnlRullante.Controls.Add(this.label2);
            this.pnlRullante.Controls.Add(this.cbMaterialeRullante);
            this.pnlRullante.Controls.Add(this.label3);
            this.pnlRullante.Controls.Add(this.nudStratiRullante);
            this.pnlRullante.Controls.Add(this.label4);
            this.pnlRullante.Controls.Add(this.nudDiametroRullante);
            this.pnlRullante.Controls.Add(this.label5);
            this.pnlRullante.Location = new System.Drawing.Point(407, 15);
            this.pnlRullante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRullante.Name = "pnlRullante";
            this.pnlRullante.Size = new System.Drawing.Size(391, 276);
            this.pnlRullante.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Materiale tamburo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMaterialeRullante
            // 
            this.cbMaterialeRullante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterialeRullante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterialeRullante.FormattingEnabled = true;
            this.cbMaterialeRullante.Location = new System.Drawing.Point(4, 217);
            this.cbMaterialeRullante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaterialeRullante.Name = "cbMaterialeRullante";
            this.cbMaterialeRullante.Size = new System.Drawing.Size(381, 33);
            this.cbMaterialeRullante.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Strati";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudStratiRullante
            // 
            this.nudStratiRullante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStratiRullante.Location = new System.Drawing.Point(4, 150);
            this.nudStratiRullante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudStratiRullante.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudStratiRullante.Name = "nudStratiRullante";
            this.nudStratiRullante.Size = new System.Drawing.Size(383, 30);
            this.nudStratiRullante.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Diametro [in]";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudDiametroRullante
            // 
            this.nudDiametroRullante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiametroRullante.Location = new System.Drawing.Point(4, 86);
            this.nudDiametroRullante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudDiametroRullante.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDiametroRullante.Name = "nudDiametroRullante";
            this.nudDiametroRullante.Size = new System.Drawing.Size(383, 30);
            this.nudDiametroRullante.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rullante";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCharleston
            // 
            this.pnlCharleston.Controls.Add(this.label6);
            this.pnlCharleston.Controls.Add(this.cbMaterialeCharleston);
            this.pnlCharleston.Controls.Add(this.label8);
            this.pnlCharleston.Controls.Add(this.nudDiametroCharleston);
            this.pnlCharleston.Controls.Add(this.label9);
            this.pnlCharleston.Location = new System.Drawing.Point(805, 15);
            this.pnlCharleston.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCharleston.Name = "pnlCharleston";
            this.pnlCharleston.Size = new System.Drawing.Size(400, 276);
            this.pnlCharleston.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(392, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Materiale piatto";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMaterialeCharleston
            // 
            this.cbMaterialeCharleston.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterialeCharleston.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterialeCharleston.FormattingEnabled = true;
            this.cbMaterialeCharleston.Location = new System.Drawing.Point(4, 149);
            this.cbMaterialeCharleston.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaterialeCharleston.Name = "cbMaterialeCharleston";
            this.cbMaterialeCharleston.Size = new System.Drawing.Size(391, 33);
            this.cbMaterialeCharleston.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 55);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(392, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Diametro [in]";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudDiametroCharleston
            // 
            this.nudDiametroCharleston.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiametroCharleston.Location = new System.Drawing.Point(4, 86);
            this.nudDiametroCharleston.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudDiametroCharleston.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDiametroCharleston.Name = "nudDiametroCharleston";
            this.nudDiametroCharleston.Size = new System.Drawing.Size(392, 30);
            this.nudDiametroCharleston.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(392, 36);
            this.label9.TabIndex = 7;
            this.label9.Text = "Charleston";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlToms
            // 
            this.pnlToms.Controls.Add(this.btnEliminaTom);
            this.pnlToms.Controls.Add(this.lvToms);
            this.pnlToms.Controls.Add(this.btnModificaTom);
            this.pnlToms.Controls.Add(this.label20);
            this.pnlToms.Controls.Add(this.btnNuovoTom);
            this.pnlToms.Location = new System.Drawing.Point(9, 298);
            this.pnlToms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlToms.Name = "pnlToms";
            this.pnlToms.Size = new System.Drawing.Size(677, 417);
            this.pnlToms.TabIndex = 19;
            // 
            // btnEliminaTom
            // 
            this.btnEliminaTom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminaTom.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaCestino1_35x35;
            this.btnEliminaTom.Location = new System.Drawing.Point(617, 358);
            this.btnEliminaTom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminaTom.Name = "btnEliminaTom";
            this.btnEliminaTom.Size = new System.Drawing.Size(53, 49);
            this.btnEliminaTom.TabIndex = 54;
            this.btnEliminaTom.UseVisualStyleBackColor = true;
            // 
            // lvToms
            // 
            this.lvToms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTipoTamburo,
            this.chDiametroTamburo,
            this.chStratiTamburo,
            this.chMaterialeTamburo});
            this.lvToms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvToms.FullRowSelect = true;
            this.lvToms.HideSelection = false;
            this.lvToms.Location = new System.Drawing.Point(9, 63);
            this.lvToms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvToms.MultiSelect = false;
            this.lvToms.Name = "lvToms";
            this.lvToms.Size = new System.Drawing.Size(660, 287);
            this.lvToms.TabIndex = 8;
            this.lvToms.UseCompatibleStateImageBehavior = false;
            this.lvToms.View = System.Windows.Forms.View.Details;
            // 
            // chTipoTamburo
            // 
            this.chTipoTamburo.Text = "Tipo";
            this.chTipoTamburo.Width = 115;
            // 
            // chDiametroTamburo
            // 
            this.chDiametroTamburo.Text = "Diametro [in]";
            this.chDiametroTamburo.Width = 110;
            // 
            // chStratiTamburo
            // 
            this.chStratiTamburo.Text = "Strati";
            this.chStratiTamburo.Width = 80;
            // 
            // chMaterialeTamburo
            // 
            this.chMaterialeTamburo.Text = "Materiale";
            this.chMaterialeTamburo.Width = 180;
            // 
            // btnModificaTom
            // 
            this.btnModificaTom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificaTom.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaModifica1_30x30;
            this.btnModificaTom.Location = new System.Drawing.Point(556, 358);
            this.btnModificaTom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificaTom.Name = "btnModificaTom";
            this.btnModificaTom.Size = new System.Drawing.Size(53, 49);
            this.btnModificaTom.TabIndex = 53;
            this.btnModificaTom.UseVisualStyleBackColor = true;
            this.btnModificaTom.Click += new System.EventHandler(this.btnModificaTom_Click);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(9, 20);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(661, 36);
            this.label20.TabIndex = 7;
            this.label20.Text = "Toms e timpani";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNuovoTom
            // 
            this.btnNuovoTom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuovoTom.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaNuovo1_30x30;
            this.btnNuovoTom.Location = new System.Drawing.Point(495, 358);
            this.btnNuovoTom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuovoTom.Name = "btnNuovoTom";
            this.btnNuovoTom.Size = new System.Drawing.Size(53, 49);
            this.btnNuovoTom.TabIndex = 52;
            this.btnNuovoTom.UseVisualStyleBackColor = true;
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(1051, 722);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(155, 50);
            this.btnSalva.TabIndex = 20;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            // 
            // pnlAltriPiatti
            // 
            this.pnlAltriPiatti.Controls.Add(this.label1);
            this.pnlAltriPiatti.Controls.Add(this.btnEliminaPiatto);
            this.pnlAltriPiatti.Controls.Add(this.btnModificaPiatto);
            this.pnlAltriPiatti.Controls.Add(this.lvAltriPiatti);
            this.pnlAltriPiatti.Controls.Add(this.btnNuovoPiatto);
            this.pnlAltriPiatti.Location = new System.Drawing.Point(695, 298);
            this.pnlAltriPiatti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAltriPiatti.Name = "pnlAltriPiatti";
            this.pnlAltriPiatti.Size = new System.Drawing.Size(511, 417);
            this.pnlAltriPiatti.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 36);
            this.label1.TabIndex = 55;
            this.label1.Text = "Altri piatti";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminaPiatto
            // 
            this.btnEliminaPiatto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminaPiatto.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaCestino1_35x35;
            this.btnEliminaPiatto.Location = new System.Drawing.Point(453, 358);
            this.btnEliminaPiatto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminaPiatto.Name = "btnEliminaPiatto";
            this.btnEliminaPiatto.Size = new System.Drawing.Size(53, 49);
            this.btnEliminaPiatto.TabIndex = 57;
            this.btnEliminaPiatto.UseVisualStyleBackColor = true;
            // 
            // btnModificaPiatto
            // 
            this.btnModificaPiatto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificaPiatto.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaModifica1_30x30;
            this.btnModificaPiatto.Location = new System.Drawing.Point(392, 358);
            this.btnModificaPiatto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificaPiatto.Name = "btnModificaPiatto";
            this.btnModificaPiatto.Size = new System.Drawing.Size(53, 49);
            this.btnModificaPiatto.TabIndex = 56;
            this.btnModificaPiatto.UseVisualStyleBackColor = true;
            this.btnModificaPiatto.Click += new System.EventHandler(this.btnModificaPiatto_Click);
            // 
            // lvAltriPiatti
            // 
            this.lvAltriPiatti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTipoPiatto,
            this.chDiametroPiatto,
            this.chMaterialePiatto});
            this.lvAltriPiatti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAltriPiatti.FullRowSelect = true;
            this.lvAltriPiatti.HideSelection = false;
            this.lvAltriPiatti.Location = new System.Drawing.Point(9, 63);
            this.lvAltriPiatti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvAltriPiatti.MultiSelect = false;
            this.lvAltriPiatti.Name = "lvAltriPiatti";
            this.lvAltriPiatti.Size = new System.Drawing.Size(496, 287);
            this.lvAltriPiatti.TabIndex = 55;
            this.lvAltriPiatti.UseCompatibleStateImageBehavior = false;
            this.lvAltriPiatti.View = System.Windows.Forms.View.Details;
            // 
            // chTipoPiatto
            // 
            this.chTipoPiatto.Text = "Tipo";
            this.chTipoPiatto.Width = 110;
            // 
            // chDiametroPiatto
            // 
            this.chDiametroPiatto.Text = "Diametro [in]";
            this.chDiametroPiatto.Width = 110;
            // 
            // chMaterialePiatto
            // 
            this.chMaterialePiatto.Text = "Materiale";
            this.chMaterialePiatto.Width = 140;
            // 
            // btnNuovoPiatto
            // 
            this.btnNuovoPiatto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuovoPiatto.Image = global::NegozioStrumentiMusicali_Cappelloni_DiBernardo.Properties.Resources.iconaNuovo1_30x30;
            this.btnNuovoPiatto.Location = new System.Drawing.Point(331, 358);
            this.btnNuovoPiatto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuovoPiatto.Name = "btnNuovoPiatto";
            this.btnNuovoPiatto.Size = new System.Drawing.Size(53, 49);
            this.btnNuovoPiatto.TabIndex = 55;
            this.btnNuovoPiatto.UseVisualStyleBackColor = true;
            // 
            // FrmBatteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 788);
            this.Controls.Add(this.pnlAltriPiatti);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.pnlToms);
            this.Controls.Add(this.pnlCharleston);
            this.Controls.Add(this.pnlRullante);
            this.Controls.Add(this.pnlCassa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmBatteria";
            this.Text = "Batteria";
            this.Load += new System.EventHandler(this.FrmBatteria_Load);
            this.pnlCassa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudStratiCassa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiametroCassa)).EndInit();
            this.pnlRullante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudStratiRullante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiametroRullante)).EndInit();
            this.pnlCharleston.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDiametroCharleston)).EndInit();
            this.pnlToms.ResumeLayout(false);
            this.pnlAltriPiatti.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCassa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbMaterialeCassa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudStratiCassa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudDiametroCassa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlRullante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaterialeRullante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudStratiRullante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDiametroRullante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlCharleston;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMaterialeCharleston;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudDiametroCharleston;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlToms;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ListView lvToms;
        private System.Windows.Forms.ColumnHeader chDiametroTamburo;
        private System.Windows.Forms.ColumnHeader chStratiTamburo;
        private System.Windows.Forms.ColumnHeader chMaterialeTamburo;
        private System.Windows.Forms.Button btnEliminaTom;
        private System.Windows.Forms.Button btnModificaTom;
        private System.Windows.Forms.Button btnNuovoTom;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Panel pnlAltriPiatti;
        private System.Windows.Forms.ListView lvAltriPiatti;
        private System.Windows.Forms.ColumnHeader chTipoPiatto;
        private System.Windows.Forms.ColumnHeader chTipoTamburo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminaPiatto;
        private System.Windows.Forms.Button btnModificaPiatto;
        private System.Windows.Forms.ColumnHeader chDiametroPiatto;
        private System.Windows.Forms.ColumnHeader chMaterialePiatto;
        private System.Windows.Forms.Button btnNuovoPiatto;
    }
}